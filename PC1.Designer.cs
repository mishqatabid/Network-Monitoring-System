namespace Network_Monitoring_Sytem
{
    partial class PC1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC1));
            this.donebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Label();
            this.smbox = new System.Windows.Forms.TextBox();
            this.dgbox = new System.Windows.Forms.TextBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.dglabel = new System.Windows.Forms.Label();
            this.subnetlabel = new System.Windows.Forms.Label();
            this.iplabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.donebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.donebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebutton.ForeColor = System.Drawing.Color.White;
            this.donebutton.Location = new System.Drawing.Point(227, 313);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(106, 37);
            this.donebutton.TabIndex = 29;
            this.donebutton.Text = "DONE";
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "You Can Configure It Once";
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(68, 24);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(235, 33);
            this.head.TabIndex = 26;
            this.head.Text = "CONFIGURATION";
            // 
            // smbox
            // 
            this.smbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smbox.Location = new System.Drawing.Point(188, 166);
            this.smbox.Name = "smbox";
            this.smbox.Size = new System.Drawing.Size(145, 30);
            this.smbox.TabIndex = 25;
            // 
            // dgbox
            // 
            this.dgbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgbox.Location = new System.Drawing.Point(188, 218);
            this.dgbox.Name = "dgbox";
            this.dgbox.Size = new System.Drawing.Size(145, 30);
            this.dgbox.TabIndex = 24;
            // 
            // ipbox
            // 
            this.ipbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipbox.Location = new System.Drawing.Point(188, 117);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(145, 30);
            this.ipbox.TabIndex = 23;
            // 
            // dglabel
            // 
            this.dglabel.AutoSize = true;
            this.dglabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dglabel.Location = new System.Drawing.Point(34, 218);
            this.dglabel.Name = "dglabel";
            this.dglabel.Size = new System.Drawing.Size(135, 23);
            this.dglabel.TabIndex = 22;
            this.dglabel.Text = "Default Gateway";
            // 
            // subnetlabel
            // 
            this.subnetlabel.AutoSize = true;
            this.subnetlabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetlabel.Location = new System.Drawing.Point(34, 169);
            this.subnetlabel.Name = "subnetlabel";
            this.subnetlabel.Size = new System.Drawing.Size(108, 23);
            this.subnetlabel.TabIndex = 21;
            this.subnetlabel.Text = "Subnet Mask";
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iplabel.Location = new System.Drawing.Point(34, 120);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(90, 23);
            this.iplabel.TabIndex = 20;
            this.iplabel.Text = "IP Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // PC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(352, 375);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.head);
            this.Controls.Add(this.smbox);
            this.Controls.Add(this.dgbox);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.dglabel);
            this.Controls.Add(this.subnetlabel);
            this.Controls.Add(this.iplabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PC1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button donebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.TextBox smbox;
        private System.Windows.Forms.TextBox dgbox;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Label dglabel;
        private System.Windows.Forms.Label subnetlabel;
        private System.Windows.Forms.Label iplabel;
    }
}