using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Carubbi.MetroLayoutEngine;
using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using Meebey.SmartIrc4net;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class FormPrincipal : MetroLayoutForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
            LoadPage(new MenuPrincipal());
            UsuariosOnLine = new List<string>();
            UsuariosTodos = new List<string>();
        }

        public List<string> UsuariosOnLine { get; set; }
        public List<string> UsuariosTodos { get; set; }

        public IrcClient IrcClient { get; set; }
        public Thread MessageListener { get; internal set; }


        public event EventHandler<IrcEventArgs> MensagemRecebida;
        public event EventHandler<JoinEventArgs> UsuarioEntrou;
        public event EventHandler<QuitEventArgs> UsuarioSaiu;

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
            var repo = new UsuarioRepository(ctx);
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
            var repo = new UsuarioRepository(ctx);
            var usuario = repo.ObterPorNick(nick);
            var item = usuario.Nome + " - " + usuario.Email;
            if (!UsuariosOnLine.Contains(item))
                UsuariosOnLine.Add(item);

            if (!UsuariosTodos.Contains(item))
                UsuariosTodos.Add(item);

            UsuarioEntrou?.Invoke(this, e);
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageListener != null && MessageListener.IsAlive) MessageListener.Abort();
        }
    }
}