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

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    public partial class FormPrincipal : Carubbi.MetroLayoutEngine.MetroLayoutForm
    {
        public event EventHandler<IrcEventArgs> MensagemRecebida;

        public FormPrincipal()
        {
            InitializeComponent();
            LoadPage(new MenuPrincipal());
        }

        public IrcClient IrcClient { get; set; }
        public Thread MessageListener { get; internal set; }

        public void IrcClient_OnChannelMessage(object sender, IrcEventArgs e)
        {
            MensagemRecebida?.Invoke(sender, e);
        }
    }


   
}
