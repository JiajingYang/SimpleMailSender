namespace SimpleMailSender
{
    partial class FrmDashboard
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassw0rd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.cbSsl = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.加载配置 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(403, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 35);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "发送 Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(85, 154);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(178, 21);
            this.tbDisplayName.TabIndex = 1;
            this.tbDisplayName.Text = "BPM";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "显示名 Display";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号 Account";
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(85, 42);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(178, 21);
            this.tbAccount.TabIndex = 3;
            this.tbAccount.Text = "123456@qq.com";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码 Password";
            // 
            // tbPassw0rd
            // 
            this.tbPassw0rd.Location = new System.Drawing.Point(85, 80);
            this.tbPassw0rd.Name = "tbPassw0rd";
            this.tbPassw0rd.Size = new System.Drawing.Size(178, 21);
            this.tbPassw0rd.TabIndex = 5;
            this.tbPassw0rd.Text = "123456";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "端口 Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(313, 9);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(42, 21);
            this.tbPort.TabIndex = 2;
            this.tbPort.Text = "587";
            // 
            // cbSsl
            // 
            this.cbSsl.AutoSize = true;
            this.cbSsl.Checked = true;
            this.cbSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSsl.Location = new System.Drawing.Point(274, 50);
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.Size = new System.Drawing.Size(42, 16);
            this.cbSsl.TabIndex = 4;
            this.cbSsl.Text = "SSL";
            this.cbSsl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "主题 Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(85, 194);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(178, 21);
            this.tbSubject.TabIndex = 6;
            this.tbSubject.Text = "Test";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "内容 Content";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(81, 270);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(379, 102);
            this.tbContent.TabIndex = 8;
            this.tbContent.Text = "Test";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "收件人 Receiver";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(85, 231);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(178, 21);
            this.tbTo.TabIndex = 7;
            this.tbTo.Text = "119139463@qq.com";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(85, 116);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(178, 21);
            this.tbEmailAddress.TabIndex = 1;
            this.tbEmailAddress.Text = "rbp@qq.com";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "发送者 Sender";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(85, 9);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(178, 21);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "mail.qq.com";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "服务器 Host";
            // 
            // 加载配置
            // 
            this.加载配置.Location = new System.Drawing.Point(375, 57);
            this.加载配置.Name = "加载配置";
            this.加载配置.Size = new System.Drawing.Size(87, 51);
            this.加载配置.TabIndex = 13;
            this.加载配置.Text = "加载配置 Init Config";
            this.加载配置.UseVisualStyleBackColor = true;
            this.加载配置.Click += new System.EventHandler(this.加载配置_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 384);
            this.Controls.Add(this.加载配置);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSsl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassw0rd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.btnSend);
            this.Name = "FrmDashboard";
            this.Text = "简单邮件发送器 / Simple Email Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassw0rd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.CheckBox cbSsl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button 加载配置;
    }
}

