using Carubbi.Utils.UIControls;
using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using Meebey.SmartIrc4net;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class FormMensagens : Form
    {
        FormPrincipal _owner;
        public FormMensagens(FormPrincipal owner)
            : this()
        {
            _owner = owner;
            if (IrcClient != null && IrcClient.IsConnected)
                IrcClient.OnChannelMessage += IrcClient_OnChannelMessage;
            else
            {
                MessageBox.Show(this, "Nenhuma sessão esta dispónível", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        Dictionary<string, Usuario> _usuarios = new Dictionary<string, Usuario>();

        public IrcClient IrcClient
        {
            get
            {
                return _owner.IrcClient;
            }

        }

        public FormMensagens()
        {
            InitializeComponent();

        }

        private void IrcClient_OnChannelMessage(object sender, IrcEventArgs e)
        {
            if (e.Data.Nick.LastIndexOf("-") < 0)
                return;
            var nick = e.Data.Nick.Substring(0, e.Data.Nick.LastIndexOf("-"));


            if (!_usuarios.ContainsKey(nick))
            {
                IContexto contexto = new Contexto();
                UsuarioRepository repo = new UsuarioRepository(contexto);
                _usuarios.Add(nick, repo.ObterPorNick(nick));
            }

            flowLayoutPanelMensagens.InvokeIfRequired(x =>
            {
                var linha = new MensagemControl(e.Data.Message, _usuarios[nick]);
          
                x.Controls.Add(linha);
               
                if (chkRolagem.Checked)
                {
                    (x as ScrollableControl).ScrollControlIntoView(linha);
                }
            });
        
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
