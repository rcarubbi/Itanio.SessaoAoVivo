using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class MensagemControl : UserControl
    {
        private string _mensagem;
        private Usuario _usuario;

        public MensagemControl()
        {
            InitializeComponent();
            
        }

        public MensagemControl(string mensagem, Usuario usuario)
            : this()
        {
            _mensagem = mensagem;
            _usuario = usuario;

            lblCidade.Text = usuario?.Cidade;
            lblUF.Text = usuario?.UF;
            lblNome.Text = usuario?.Nome;
            lblEmail.Text = usuario?.Email;
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblMensagem.Text = mensagem;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            
        }
    }
}
