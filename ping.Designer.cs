namespace Network_Monitoring_Sytem
{
    partial class ping
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
            this.pingmessage = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.exiting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pingmessage
            // 
            this.pingmessage.AutoSize = true;
            this.pingmessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingmessage.Location = new System.Drawing.Point(66, 87);
            this.pingmessage.Name = "pingmessage";
            this.pingmessage.Size = new System.Drawing.Size(102, 23);
            this.pingmessage.TabIndex = 0;
            this.pingmessage.Text = "Starting....";
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(12, 12);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(121, 52);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // exiting
            // 
            this.exiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.exiting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.exiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exiting.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exiting.Location = new System.Drawing.Point(932, 1);
            this.exiting.Name = "exiting";
            this.exiting.Size = new System.Drawing.Size(50, 50);
            this.exiting.TabIndex = 2;
            this.exiting.Text = "X";
            this.exiting.UseVisualStyleBackColor = false;
            this.exiting.Click += new System.EventHandler(this.exiting_Click);
            // 
            // ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 550);
            this.Controls.Add(this.exiting);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.pingmessage);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinging....";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pingmessage;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button exiting;
    }
}