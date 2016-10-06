using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using Itanio.SessaoAoVivo.ServicosAplicacao;
using Meebey.SmartIrc4net;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class SessoesForm : Carubbi.MetroLayoutEngine.MetroLayoutUserControl
    {
        private Sessao sessao;
        private FormPrincipal _principal;

        public SessoesForm(FormPrincipal principal)
            : this()
        {
            _principal = principal;
        }

        protected override void OnLoad(EventArgs e)
        {
            IContexto contexto = new Contexto();
            SessaoRepository repo = new SessaoRepository(contexto, new GravadorArquivo());
            sessao = repo.ObterUltimaAtiva();
            if (sessao != null)
            {
                PreencherFormulario(sessao);
            }
        }

        private void PreencherFormulario(Sessao sessao)
        {
            _nomeCanal = sessao.NomeCanal;

            txtNomeSessao.Text = sessao.Nome;
            txtDescricao.Text = sessao.Descricao;
            txtRodape.Text = sessao.Rodape;
            txtCodigoVideo.Text = sessao.CodigoYouTube;
            pnlCor.BackColor = ColorTranslator.FromHtml(sessao.Cor);
            dtpDataHoraInicio.Value = sessao.DataHoraInicio;
            lblCaminhoValor.Text = sessao.Id.ToString();
            lblLogotipoValor.Text = sessao.Logotipo.Nome;
            if (sessao.Logotipo.Conteudo != null)
                pbLogotipo.Image = Image.FromStream(new MemoryStream(sessao.Logotipo.Conteudo));
            pbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogotipo.BackgroundImageLayout = ImageLayout.Stretch;
            ConectarIrc();
            btnDesligar.Enabled = true;
            btnLigar.Enabled = false;
        }

        private void ConectarIrc()
        {
            QuitIrc();
            IrcClient = new IrcClient();
            IrcClient.OnConnected -= C_OnConnected;
            IrcClient.OnConnected += C_OnConnected;
            IrcClient.Connect(Parametro.SERVIDOR_IRC, 6667);
        }

        private void QuitIrc()
        {
            if (IrcClient != null && IrcClient.IsConnected)
            {
                IrcClient.RfcQuit(Priority.Critical);
                IrcClient.Disconnect();
            }
        }

        private string _nomeCanal;

        public IrcClient IrcClient
        {
            get
            {
                return _principal.IrcClient;
            }
            set
            {
                _principal.IrcClient = value;
            }
        }

        public SessoesForm()
        {
            InitializeComponent();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            _principal.UsuariosTodos.Clear();
            _principal.UsuariosOnLine.Clear();
            if (string.IsNullOrWhiteSpace(txtNomeSessao.Text))
            {
                MessageBox.Show(this, "Digite o nome da sessão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeSessao.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoVideo.Text))
            {
                MessageBox.Show(this, "Digite o código do video", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoVideo.Focus();
                return;
            }

            _nomeCanal = $"#sessaoAoVivo_{txtNomeSessao.Text.Replace(" ", "")}";

            try
            {
                ConectarIrc();


                IContexto contexto = new Contexto();

                sessao = LerFormulario();
                SessaoRepository repo = new SessaoRepository(contexto, new GravadorArquivo());
                repo.Add(sessao);
                contexto.Salvar();
                contexto = null;

                lblCaminhoValor.Text = sessao.Id.ToString();
                
                btnDesligar.Enabled = true;
                btnLigar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Sessao LerFormulario()
        {
            var sessao = new Sessao
            {
                Nome = txtNomeSessao.Text,
                Descricao = txtDescricao.Text,
                DataCriacao = DateTime.Now,
                DataHoraInicio = dtpDataHoraInicio.Value,
                Ativo = true,
                CodigoYouTube = txtCodigoVideo.Text,
                Cor = HexConverter(pnlCor.BackColor),
                NomeCanal = _nomeCanal,
                Rodape = txtRodape.Text,
            };
            if (!string.IsNullOrWhiteSpace(lblLogotipoValor.Text))
                sessao.Logotipo = new Arquivo { Nome = Path.GetFileName(lblLogotipoValor.Text), Conteudo = imageToByteArray(pbLogotipo.Image, lblLogotipoValor.Text) };
            return sessao;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn, string nome)
        {
            ImageFormat format = null;
            if (Path.GetExtension(nome) == ".png")
                format = ImageFormat.Png;
            else
                format = ImageFormat.Jpeg;

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, format);
                return ms.ToArray();
            }
        }

        private static string HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }


        private void C_OnConnected(object sender, EventArgs e)
        {
            var tempNick = "operador" + DateTime.Now.ToString("ssfff");

            IrcClient.Login(tempNick, "operador", 0);
            Thread.Sleep(2000);
            if (!IrcClient.IsJoined(_nomeCanal))
            {
                Thread.Sleep(2000);
                IrcClient.RfcJoin(_nomeCanal, Parametro.SENHA_SALAS, Priority.Critical);
                Thread.Sleep(2000);
            }


            IrcClient.OnChannelMessage -= _principal.IrcClient_OnChannelMessage;
            IrcClient.OnChannelMessage += _principal.IrcClient_OnChannelMessage;

            IrcClient.OnJoin -= _principal.IrcClient_OnJoin; ;
            IrcClient.OnQuit -= _principal.IrcClient_OnQuit; ;
            IrcClient.OnJoin += _principal.IrcClient_OnJoin; ;
            IrcClient.OnQuit += _principal.IrcClient_OnQuit; ;


            if (_principal.MessageListener == null || !_principal.MessageListener.IsAlive)
                _principal.MessageListener = new Thread(new ThreadStart(Listen));

            if (!_principal.MessageListener.IsAlive)
                _principal.MessageListener.Start();

            var t = new Thread(new ThreadStart(Modify));
            t.Start();

        }

     

        private void Listen()
        {
            IrcClient.Listen(true);
        }

        private void Modify()
        {
            IrcClient.RfcMode(_nomeCanal, "ps");
            IrcClient.RfcMode(_nomeCanal, "k " + Parametro.SENHA_SALAS);
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            _principal.UsuariosTodos.Clear();
            _principal.UsuariosOnLine.Clear();
            _principal.MessageListener.Abort();
            QuitIrc();
            btnLigar.Enabled = true;
            btnDesligar.Enabled = false;

            IContexto contexto = new Contexto();
            var sessaoRepository = new SessaoRepository(contexto, new GravadorArquivo());
            sessao.Ativo = false;
            sessaoRepository.Atualizar(sessao);
            contexto.Salvar();

        }

        private void btnSelecionarLogotipo_Click(object sender, EventArgs e)
        {
            if (selecionarLogotipoDialog.ShowDialog() == DialogResult.OK)
            {
                lblLogotipoValor.Text = selecionarLogotipoDialog.FileName;
                pbLogotipo.Image = Image.FromFile(selecionarLogotipoDialog.FileName);
                pbLogotipo.BackgroundImageLayout = ImageLayout.Stretch;
                pbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pnlCor_DoubleClick(object sender, EventArgs e)
        {
            if (corDialog.ShowDialog() == DialogResult.OK)
            {
                pnlCor.BackColor = corDialog.Color;
            }
        }
    }
}
