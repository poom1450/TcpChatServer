namespace TcpServertest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lname = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.lport = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.bstart = new System.Windows.Forms.Button();
            this.bstop = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.lname.Location = new System.Drawing.Point(12, 25);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(32, 13);
            this.lname.TabIndex = 0;
            this.lname.Text = "Host:";
            // 
            // txthost
            // 
            this.txthost.BackColor = System.Drawing.SystemColors.Window;
            this.txthost.Location = new System.Drawing.Point(50, 22);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(200, 20);
            this.txthost.TabIndex = 1;
            this.txthost.Text = "127.0.0.1";
            // 
            // lport
            // 
            this.lport.AutoSize = true;
            this.lport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.lport.Location = new System.Drawing.Point(270, 25);
            this.lport.Name = "lport";
            this.lport.Size = new System.Drawing.Size(29, 13);
            this.lport.TabIndex = 2;
            this.lport.Text = "Port:";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(305, 22);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(100, 20);
            this.txtport.TabIndex = 3;
            this.txtport.Text = "80";
            // 
            // bstart
            // 
            this.bstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.bstart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bstart.ForeColor = System.Drawing.Color.White;
            this.bstart.Location = new System.Drawing.Point(425, 22);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(75, 23);
            this.bstart.TabIndex = 4;
            this.bstart.Text = "Start";
            this.bstart.UseVisualStyleBackColor = false;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // bstop
            // 
            this.bstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bstop.ForeColor = System.Drawing.Color.White;
            this.bstop.Location = new System.Drawing.Point(506, 22);
            this.bstop.Name = "bstop";
            this.bstop.Size = new System.Drawing.Size(75, 23);
            this.bstop.TabIndex = 5;
            this.bstop.Text = "Stop";
            this.bstop.UseVisualStyleBackColor = false;
            this.bstop.Click += new System.EventHandler(this.bstop_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Century Gothic", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtstatus.Location = new System.Drawing.Point(50, 63);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtstatus.Size = new System.Drawing.Size(531, 291);
            this.txtstatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 426);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.bstop);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.lport);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.lname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TcpServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label lport;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Button bstop;
        private System.Windows.Forms.TextBox txtstatus;
    }
}

