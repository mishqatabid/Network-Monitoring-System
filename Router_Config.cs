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
    public partial class Router_Config : Form
    {
        public static string ipadd {  get; set; }
        public static string sn { get; set; }
        public Router_Config()
        {
            InitializeComponent();
            ipbox.Text = ipadd;
            smbox.Text = sn;

        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            ipadd = ipbox.Text;
            sn = smbox.Text;

            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
