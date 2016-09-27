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
            ConectarIrc();
            txtNomeSessao.Text = sessao.Nome;
            txtDescricao.Text = sessao.Descricao;
            txtRodape.Text = sessao.Rodape;
            txtCodigoVideo.Text = sessao.CodigoYouTube;
            pnlCor.BackColor = ColorTranslator.FromHtml(sessao.Cor);
            dtpDataHoraInicio.Value = sessao.DataHoraInicio;
            lblCaminhoValor.Text = sessao.Id.ToString();
            lblLogotipoValor.Text = sessao.Logotipo.Nome;

            pbLogotipo.Image = Image.FromStream(new MemoryStream(sessao.Logotipo.Conteudo));
            btnDesligar.Enabled = true;
            btnLigar.Enabled = false;
        }

        private void ConectarIrc()
        {
            if (IrcClient == null)
                IrcClient = new IrcClient();

            IrcClient.ActiveChannelSyncing = true;
            IrcClient.OnConnected += C_OnConnected;

            if (!IrcClient.IsConnected)
                IrcClient.Connect("irc.BrasIRC.com.br", 6667);
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

            _nomeCanal = $"#sessaoAoVivo_{txtNomeSessao.Text}";
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

        private Sessao LerFormulario()
        {
            return new Sessao
            {
                Nome = txtNomeSessao.Text,
                Descricao = txtDescricao.Text,
                DataCriacao = DateTime.Now,
                DataHoraInicio = dtpDataHoraInicio.Value,
                Ativo = true,
                CodigoYouTube = txtCodigoVideo.Text,
                Cor = HexConverter(pnlCor.BackColor),
                Logotipo = new Arquivo { Nome = lblLogotipoValor.Text, Conteudo = imageToByteArray(pbLogotipo.Image, lblLogotipoValor.Text) },
                NomeCanal = _nomeCanal,
                Rodape = txtRodape.Text,
            };
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

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }


        private void C_OnConnected(object sender, EventArgs e)
        {
            if (IrcClient.GetIrcUser($"{ txtNomeSessao.Text}_operador") == null)
                IrcClient.Login($"{ txtNomeSessao.Text}_operador", $"{ txtNomeSessao.Text}_operador");

            if (!IrcClient.IsJoined(_nomeCanal))
                IrcClient.RfcJoin(new string[] { _nomeCanal }, new string[] { "+p" });

            IrcClient.OnChannelMessage += _principal.IrcClient_OnChannelMessage;

            if (_principal.MessageListener == null || !_principal.MessageListener.IsAlive)
                _principal.MessageListener = new Thread(new ThreadStart(Listen));

            if (!_principal.MessageListener.IsAlive)
                 _principal.MessageListener.Start();
        }

        private void Listen()
        {
            IrcClient.Listen(true);
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            _principal.MessageListener.Abort();
            IrcClient.RfcDie();
            IrcClient.RfcQuit();
            if (IrcClient.IsConnected)
             IrcClient.Disconnect();
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
