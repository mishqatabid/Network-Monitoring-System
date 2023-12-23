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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.BackColor = Color.White;
            loginpanel.BackColor = Color.White;
            pwdpanel.BackColor = SystemColors.Control;
            pass.BackColor = SystemColors.Control;
        }

        private void pass_Click(object sender, EventArgs e)
        {
            pass.BackColor = Color.White;
            pwdpanel.BackColor = Color.White;
            username.BackColor = SystemColors.Control;
            loginpanel.BackColor = SystemColors.Control;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string id = username.Text;
            string password = pass.Text;

            if(id == "Dr.Naveed" &&  password == "admin123")
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR!!! \n Incorrect Username or Password ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
        }

        private void showpwdButton_CheckedChanged(object sender, EventArgs e)
        {
            if (showpwdButton.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }
    }
}
