using System;
using Carubbi.MetroLayoutEngine;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class MenuPrincipal : MetroLayoutUserControl
    {
        private FormMensagens mensagens;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void tileSessoes_TileClick(object sender, EventArgs e)
        {
            LoadPage(new SessoesForm(Parent.Parent as FormPrincipal));
        }

        private void tileMensagens_TileClick(object sender, EventArgs e)
        {
            if (mensagens == null || mensagens.IsDisposed)
                mensagens = new FormMensagens(Parent.Parent as FormPrincipal);

            if (!mensagens.Visible)
                mensagens.Show(this);
        }

        private void tileSorteios_TileClick(object sender, EventArgs e)
        {
            LoadPage(new SorteioForm(Parent.Parent as FormPrincipal));
        }
    }
}