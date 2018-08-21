using System.Windows.Forms;

namespace Client
{
    partial class TcpServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TcpServer));
            this.txtport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtms = new System.Windows.Forms.TextBox();
            this.bsend = new System.Windows.Forms.Button();
            this.bconnect = new System.Windows.Forms.Button();
            this.lstatus = new System.Windows.Forms.ListBox();
            this.ltest = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(305, 23);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(66, 20);
            this.txtport.TabIndex = 9;
            this.txtport.Text = "80";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(266, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(50, 23);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(200, 20);
            this.txthost.TabIndex = 7;
            this.txthost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host:";
            // 
            // txtms
            // 
            this.txtms.AcceptsReturn = true;
            this.txtms.AllowDrop = true;
            this.txtms.BackColor = System.Drawing.Color.White;
            this.txtms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtms.Location = new System.Drawing.Point(12, 294);
            this.txtms.Name = "txtms";
            this.txtms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtms.Size = new System.Drawing.Size(553, 20);
            this.txtms.TabIndex = 12;
            this.txtms.TextChanged += new System.EventHandler(this.txtms_TextChanged);
            // 
            // bsend
            // 
            this.bsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.bsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsend.ForeColor = System.Drawing.Color.White;
            this.bsend.Location = new System.Drawing.Point(490, 320);
            this.bsend.Name = "bsend";
            this.bsend.Size = new System.Drawing.Size(75, 23);
            this.bsend.TabIndex = 13;
            this.bsend.Text = "SEND";
            this.bsend.UseVisualStyleBackColor = false;
            this.bsend.Click += new System.EventHandler(this.bsend_Click);
            // 
            // bconnect
            // 
            this.bconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.bconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bconnect.ForeColor = System.Drawing.Color.White;
            this.bconnect.Location = new System.Drawing.Point(391, 22);
            this.bconnect.Name = "bconnect";
            this.bconnect.Size = new System.Drawing.Size(82, 23);
            this.bconnect.TabIndex = 15;
            this.bconnect.Text = "Connect";
            this.bconnect.UseVisualStyleBackColor = false;
            this.bconnect.Click += new System.EventHandler(this.bconnect_Click);
            // 
            // lstatus
            // 
            this.lstatus.BackColor = System.Drawing.Color.White;
            this.lstatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstatus.ForeColor = System.Drawing.Color.DimGray;
            this.lstatus.FormattingEnabled = true;
            this.lstatus.IntegralHeight = false;
            this.lstatus.ItemHeight = 15;
            this.lstatus.Location = new System.Drawing.Point(12, 89);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(553, 191);
            this.lstatus.TabIndex = 16;
            this.lstatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstatus_DrawItem);
            // 
            // ltest
            // 
            this.ltest.AutoSize = true;
            this.ltest.Font = new System.Drawing.Font("Cordia New", 12.25F, System.Drawing.FontStyle.Bold);
            this.ltest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.ltest.Location = new System.Drawing.Point(12, 66);
            this.ltest.Name = "ltest";
            this.ltest.Size = new System.Drawing.Size(69, 21);
            this.ltest.TabIndex = 17;
            this.ltest.Text = "User online:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(305, 50);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(66, 20);
            this.txtname.TabIndex = 18;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Location = new System.Drawing.Point(391, 48);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(82, 23);
            this.bSave.TabIndex = 19;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(255, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Whisper by type @<name>: some text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "all users online: cmd:online";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(479, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TcpServer
            // 
            this.AcceptButton = this.bsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(579, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.ltest);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.bconnect);
            this.Controls.Add(this.bsend);
            this.Controls.Add(this.txtms);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TcpServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TcpChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Button bsend;
        private System.Windows.Forms.Button bconnect;
        private System.Windows.Forms.ListBox lstatus;
        private System.Windows.Forms.Label ltest;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}

