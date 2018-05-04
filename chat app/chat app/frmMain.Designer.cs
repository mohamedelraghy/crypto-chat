namespace chat_app
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.BackColor = System.Drawing.SystemColors.Menu;
            this.textLocalPort.Location = new System.Drawing.Point(69, 59);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(119, 20);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIp
            // 
            this.textLocalIp.BackColor = System.Drawing.SystemColors.Menu;
            this.textLocalIp.Location = new System.Drawing.Point(69, 30);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(119, 20);
            this.textLocalIp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFriendsPort);
            this.groupBox2.Controls.Add(this.textFriendsIp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(248, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.BackColor = System.Drawing.SystemColors.Menu;
            this.textFriendsPort.Location = new System.Drawing.Point(65, 59);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(119, 20);
            this.textFriendsPort.TabIndex = 4;
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.BackColor = System.Drawing.SystemColors.Menu;
            this.textFriendsIp.Location = new System.Drawing.Point(65, 30);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(119, 20);
            this.textFriendsIp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(475, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.Menu;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(33, 151);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(543, 173);
            this.listMessage.TabIndex = 3;
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Menu;
            this.textMessage.Location = new System.Drawing.Point(33, 339);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(543, 20);
            this.textMessage.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(475, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(33, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Decryption";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(606, 405);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Let\'s Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

