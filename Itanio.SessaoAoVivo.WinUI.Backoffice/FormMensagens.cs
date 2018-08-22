using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Carubbi.WindowsAppHelper;
using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using Meebey.SmartIrc4net;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class FormMensagens : Form
    {
        private readonly FormPrincipal _owner;

        private readonly Dictionary<string, Usuario> _usuarios = new Dictionary<string, Usuario>();

        public FormMensagens(FormPrincipal owner)
            : this()
        {
            _owner = owner;
            if (IrcClient != null && IrcClient.IsConnected)
                IrcClient.OnChannelMessage += IrcClient_OnChannelMessage;
            else
                MessageBox.Show(this, "Nenhuma sessão esta dispónível", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        public FormMensagens()
        {
            InitializeComponent();
        }

        public IrcClient IrcClient => _owner.IrcClient;

        private void IrcClient_OnChannelMessage(object sender, IrcEventArgs e)
        {
            if (e.Data.Nick.LastIndexOf("-") < 0)
                return;
            var nick = e.Data.Nick.Substring(0, e.Data.Nick.LastIndexOf("-"));


            if (!_usuarios.ContainsKey(nick))
            {
                IContexto contexto = new Contexto();
                var repo = new UsuarioRepository(contexto);
                _usuarios.Add(nick, repo.ObterPorNick(nick));
            }

            flowLayoutPanelMensagens.InvokeIfRequired(x =>
            {
                var linha = new MensagemControl(e.Data.Message, _usuarios[nick]);

                x.Controls.Add(linha);

                if (chkRolagem.Checked) (x as ScrollableControl).ScrollControlIntoView(linha);
            });
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}