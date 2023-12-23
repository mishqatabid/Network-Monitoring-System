namespace Network_Monitoring_Sytem
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.header = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Label();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.PictureBox();
            this.pwdpanel = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginpic = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.showpwdButton = new System.Windows.Forms.CheckBox();
            this.header.SuspendLayout();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            this.pwdpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginpic.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.header.Controls.Add(this.heading);
            this.header.Location = new System.Drawing.Point(0, -1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(420, 104);
            this.header.TabIndex = 1;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.White;
            this.heading.Location = new System.Drawing.Point(132, 26);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(132, 57);
            this.heading.TabIndex = 0;
            this.heading.Text = "NMS";
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.Controls.Add(this.username);
            this.loginpanel.Controls.Add(this.log);
            this.loginpanel.Location = new System.Drawing.Point(0, 289);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(420, 58);
            this.loginpanel.TabIndex = 3;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.username.Location = new System.Drawing.Point(85, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(320, 30);
            this.username.TabIndex = 6;
            // 
            // log
            // 
            this.log.Image = ((System.Drawing.Image)(resources.GetObject("log.Image")));
            this.log.Location = new System.Drawing.Point(34, 3);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(45, 55);
            this.log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.log.TabIndex = 5;
            this.log.TabStop = false;
            // 
            // pwdpanel
            // 
            this.pwdpanel.BackColor = System.Drawing.SystemColors.Control;
            this.pwdpanel.Controls.Add(this.pass);
            this.pwdpanel.Controls.Add(this.pwd);
            this.pwdpanel.Location = new System.Drawing.Point(0, 353);
            this.pwdpanel.Name = "pwdpanel";
            this.pwdpanel.Size = new System.Drawing.Size(420, 58);
            this.pwdpanel.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.Control;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.pass.Location = new System.Drawing.Point(85, 13);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(320, 27);
            this.pass.TabIndex = 7;
            this.pass.UseSystemPasswordChar = true;
            // 
            // pwd
            // 
            this.pwd.Image = ((System.Drawing.Image)(resources.GetObject("pwd.Image")));
            this.pwd.Location = new System.Drawing.Point(34, 3);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(45, 55);
            this.pwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pwd.TabIndex = 3;
            this.pwd.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loginpic
            // 
            this.loginpic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginpic.BackgroundImage")));
            this.loginpic.Controls.Add(this.exit);
            this.loginpic.Location = new System.Drawing.Point(420, -1);
            this.loginpic.Name = "loginpic";
            this.loginpic.Size = new System.Drawing.Size(380, 606);
            this.loginpic.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(321, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(59, 46);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.loginbutton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(21, 430);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(384, 58);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Azure;
            this.clearbutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.clearbutton.Location = new System.Drawing.Point(62, 509);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(103, 41);
            this.clearbutton.TabIndex = 7;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.info.Location = new System.Drawing.Point(16, 239);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(229, 28);
            this.info.TabIndex = 8;
            this.info.Text = "Login Information:";
            // 
            // showpwdButton
            // 
            this.showpwdButton.AutoSize = true;
            this.showpwdButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpwdButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.showpwdButton.Location = new System.Drawing.Point(229, 522);
            this.showpwdButton.Name = "showpwdButton";
            this.showpwdButton.Size = new System.Drawing.Size(149, 22);
            this.showpwdButton.TabIndex = 9;
            this.showpwdButton.Text = "Show Password";
            this.showpwdButton.UseVisualStyleBackColor = true;
            this.showpwdButton.CheckedChanged += new System.EventHandler(this.showpwdButton_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.showpwdButton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.pwdpanel);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.loginpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            this.pwdpanel.ResumeLayout(false);
            this.pwdpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginpic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginpic;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel pwdpanel;
        private System.Windows.Forms.PictureBox log;
        private System.Windows.Forms.PictureBox pwd;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.CheckBox showpwdButton;
    }
}