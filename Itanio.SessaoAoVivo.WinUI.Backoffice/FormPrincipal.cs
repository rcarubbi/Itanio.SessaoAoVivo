using Meebey.SmartIrc4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Itanio.SessaoAoVivo.Dominio;
using Itanio.SessaoAoVivo.DAL;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class FormPrincipal : Carubbi.MetroLayoutEngine.MetroLayoutForm
    {
        public List<string> UsuariosOnLine { get; set; }
        public List<string> UsuariosTodos { get; set; }



        public event EventHandler<IrcEventArgs> MensagemRecebida;
        public event EventHandler<JoinEventArgs> UsuarioEntrou;
        public event EventHandler<QuitEventArgs> UsuarioSaiu;

        public FormPrincipal()
        {
            InitializeComponent();
            LoadPage(new MenuPrincipal());
            UsuariosOnLine = new List<string>();
            UsuariosTodos = new List<string>();
        }

        public IrcClient IrcClient { get; set; }
        public Thread MessageListener { get; internal set; }

        public void IrcClient_OnChannelMessage(object sender, IrcEventArgs e)
        {
            MensagemRecebida?.Invoke(sender, e);
        }

        public void IrcClient_OnQuit(object sender, QuitEventArgs e)
        {
            if (e.Data.Nick.LastIndexOf("-") < 0)
                return;

            var nick = e.Data.Nick.Substring(0, e.Data.Nick.LastIndexOf("-"));
            IContexto ctx = new Contexto();
            UsuarioRepository repo = new UsuarioRepository(ctx);
            var usuario = repo.ObterPorNick(nick);
            var item = usuario.Nome + " - " + usuario.Email;

            UsuariosOnLine.Remove(item);
            UsuarioSaiu?.Invoke(this, e);
        }

        public void IrcClient_OnJoin(object sender, JoinEventArgs e)
        {
            if (e.Data.Nick.LastIndexOf("-") < 0)
                return;

            var nick = e.Data.Nick.Substring(0, e.Data.Nick.LastIndexOf("-"));
            IContexto ctx = new Contexto();
            UsuarioRepository repo = new UsuarioRepository(ctx);
            var usuario = repo.ObterPorNick(nick);
            var item = usuario.Nome + " - " + usuario.Email;
            if (!UsuariosOnLine.Contains(item))
                UsuariosOnLine.Add(item);

            if (!UsuariosTodos.Contains(item))
                UsuariosTodos.Add(item);

            UsuarioEntrou?.Invoke(this, e);
        }


      
    }


   
}
