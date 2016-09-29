using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using Carubbi.Utils.UIControls;
using System.Windows.Forms;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class SorteioForm : Carubbi.MetroLayoutEngine.MetroLayoutUserControl
    {

        protected List<string> UsuariosSorteados { get; set; }


        private FormPrincipal formPrincipal;

        public SorteioForm()
        {
            InitializeComponent();

            UsuariosSorteados = new List<string>();
        }

        public SorteioForm(FormPrincipal formPrincipal)
            : this()
        {
            this.formPrincipal = formPrincipal;
        }

        private void SorteioForm_Load(object sender, EventArgs e)
        {
            RefreshTodos();
            RefreshOnline();
            formPrincipal.UsuarioEntrou += FormPrincipal_UsuarioEntrou;
            formPrincipal.UsuarioSaiu += FormPrincipal_UsuarioSaiu;
        }

        private void FormPrincipal_UsuarioSaiu(object sender, Meebey.SmartIrc4net.QuitEventArgs e)
        {
            RefreshOnline();
        }

        private void RefreshOnline()
        {

            lstOnline.InvokeIfRequired(x =>
            {
                (x as ListBox).DataSource = null;
                (x as ListBox).DataSource = formPrincipal.UsuariosOnLine;
                x.Refresh();
            });
        }

        private void FormPrincipal_UsuarioEntrou(object sender, Meebey.SmartIrc4net.JoinEventArgs e)
        {
            RefreshOnline();
            RefreshTodos();
        }

        private void RefreshTodos()
        {
            lstTodos.InvokeIfRequired(x =>
            {
                (x as ListBox).DataSource = null;
                (x as ListBox).DataSource = formPrincipal.UsuariosTodos;
                x.Refresh();
            });
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            if (chkOnline.Checked)
            {
                Sortear(formPrincipal.UsuariosOnLine);
            }
            else
            {
                Sortear(formPrincipal.UsuariosTodos);
            }
        }

        private void Sortear(List<string> listaOrigem)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            var usuariosASortear = listaOrigem.Except(UsuariosSorteados).ToList();

            var qtd = usuariosASortear.Count();
            if (qtd == 0)
                return;

            var indiceSorteado = 0;

            indiceSorteado = rnd.Next(0, qtd - 1);

            IContexto ctx = new Contexto();
            UsuarioRepository repo = new UsuarioRepository(ctx);
            var usuario = repo.ObterPorEmail(usuariosASortear[indiceSorteado].Split('-')[1].Trim());
            ExibirSorteado(usuario);
            UsuariosSorteados.Add(usuario.Nome + " - " + usuario.Email);
            RefreshSorteados();
        }

        private void ExibirSorteado(Usuario usuario)
        {
            lblNomeValor.Text = usuario.Nome;
            lblEmailValor.Text = usuario.Email;
            lblEstadoValor.Text = usuario.Email;
            lblCidadeValor.Text = usuario.Cidade;
            gbPremiado.Visible = true;
        }

        private void RefreshSorteados()
        {
            lstSorteados.InvokeIfRequired(x =>
            {
                (x as ListBox).DataSource = null;
                (x as ListBox).DataSource = UsuariosSorteados;
                x.Refresh();
            });
        }


    }
}
