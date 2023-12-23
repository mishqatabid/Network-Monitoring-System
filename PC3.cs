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
    public partial class PC3 : Form
    {
        public static string ipadd { get; set; }
        public static string sn { get; set; }
        public static string dg { get; set; }
        public PC3()
        {
            InitializeComponent();
            ipbox.Text = ipadd;
            smbox.Text = sn;
            dgbox.Text = dg;
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            ipadd = ipbox.Text;
            sn = smbox.Text;
            dg = dgbox.Text;

            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
