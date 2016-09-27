using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
