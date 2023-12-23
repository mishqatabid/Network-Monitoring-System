using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Monitoring_Sytem
{
    public partial class ping : Form
    {
        string pinging { get; set; }
        Server serve = new Server("Server1");
        public ping()
        {
            InitializeComponent();
        }
        public ping(string ips)
        {
            InitializeComponent();
            pinging = ips;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            pingmessage.Text = serve.Ping(pinging);
        }

        private void exiting_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
