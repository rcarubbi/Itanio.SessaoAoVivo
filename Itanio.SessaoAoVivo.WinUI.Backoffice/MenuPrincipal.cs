using System;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class MenuPrincipal : Carubbi.MetroLayoutEngine.MetroLayoutUserControl
    {
        FormMensagens mensagens = null;

        public MenuPrincipal()
        {
            InitializeComponent();
        
        }

        private void tileSessoes_TileClick(object sender, EventArgs e)
        {
            LoadPage(new SessoesForm(this.Parent.Parent as FormPrincipal));
        }

        private void tileMensagens_TileClick(object sender, EventArgs e)
        {
            if (mensagens == null || mensagens.IsDisposed)
            {
                mensagens = new FormMensagens(this.Parent.Parent as FormPrincipal);

            }

            if (!mensagens.Visible)
                mensagens.Show(this);

        }

        private void tileSorteios_TileClick(object sender, EventArgs e)
        {
            LoadPage(new SorteioForm(this.Parent.Parent as FormPrincipal));
        }
    }
}
