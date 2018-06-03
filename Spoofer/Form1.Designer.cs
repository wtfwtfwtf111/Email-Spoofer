namespace Spoofer
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
            this.sendButton = new System.Windows.Forms.Button();
            this.fromTXT = new System.Windows.Forms.TextBox();
            this.smtpTXT = new System.Windows.Forms.TextBox();
            this.toTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.bodyTXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.attachmentsTXT = new System.Windows.Forms.TextBox();
            this.subjectTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(281, 297);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(165, 31);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send e-mail(s)";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // fromTXT
            // 
            this.fromTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fromTXT.ForeColor = System.Drawing.Color.Gray;
            this.fromTXT.Location = new System.Drawing.Point(97, 72);
            this.fromTXT.Name = "fromTXT";
            this.fromTXT.Size = new System.Drawing.Size(349, 20);
            this.fromTXT.TabIndex = 1;
            this.fromTXT.Text = " email@example.com";
            this.fromTXT.Click += new System.EventHandler(this.fromTXT_Click);
            this.fromTXT.Leave += new System.EventHandler(this.fromTXT_Leave);
            // 
            // smtpTXT
            // 
            this.smtpTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.smtpTXT.ForeColor = System.Drawing.Color.Gray;
            this.smtpTXT.Location = new System.Drawing.Point(97, 176);
            this.smtpTXT.Name = "smtpTXT";
            this.smtpTXT.Size = new System.Drawing.Size(349, 20);
            this.smtpTXT.TabIndex = 2;
            this.smtpTXT.Text = " smtp.gmail.com";
            this.smtpTXT.Click += new System.EventHandler(this.smtpTXT_Click);
            this.smtpTXT.TextChanged += new System.EventHandler(this.displaynameTXT_TextChanged);
            this.smtpTXT.Leave += new System.EventHandler(this.smtpTXT_Leave);
            // 
            // toTXT
            // 
            this.toTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toTXT.ForeColor = System.Drawing.Color.Gray;
            this.toTXT.Location = new System.Drawing.Point(97, 150);
            this.toTXT.Name = "toTXT";
            this.toTXT.Size = new System.Drawing.Size(349, 20);
            this.toTXT.TabIndex = 4;
            this.toTXT.Text = " victim@example.com (seperate multiple e-mails using a comma)";
            this.toTXT.Click += new System.EventHandler(this.toTXT_Click);
            this.toTXT.Leave += new System.EventHandler(this.toTXT_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(67, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(16, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SMTP Server*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(34, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password*";
            // 
            // passwordTXT
            // 
            this.passwordTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.passwordTXT.Location = new System.Drawing.Point(97, 124);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.Size = new System.Drawing.Size(349, 20);
            this.passwordTXT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Displayed name";
            // 
            // nameTXT
            // 
            this.nameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.nameTXT.ForeColor = System.Drawing.Color.Gray;
            this.nameTXT.Location = new System.Drawing.Point(97, 98);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(349, 20);
            this.nameTXT.TabIndex = 10;
            this.nameTXT.Text = " John Doe";
            this.nameTXT.Click += new System.EventHandler(this.nameTXT_Click);
            this.nameTXT.Leave += new System.EventHandler(this.nameTXT_Leave);
            // 
            // bodyTXT
            // 
            this.bodyTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bodyTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyTXT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bodyTXT.Location = new System.Drawing.Point(458, 72);
            this.bodyTXT.Multiline = true;
            this.bodyTXT.Name = "bodyTXT";
            this.bodyTXT.Size = new System.Drawing.Size(421, 256);
            this.bodyTXT.TabIndex = 12;
            this.bodyTXT.Text = " E-mail body...";
            this.bodyTXT.Click += new System.EventHandler(this.bodyTXT_Click);
            this.bodyTXT.Leave += new System.EventHandler(this.bodyTXT_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add attachment(s)...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attachmentsTXT
            // 
            this.attachmentsTXT.AllowDrop = true;
            this.attachmentsTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.attachmentsTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.attachmentsTXT.Location = new System.Drawing.Point(12, 237);
            this.attachmentsTXT.Multiline = true;
            this.attachmentsTXT.Name = "attachmentsTXT";
            this.attachmentsTXT.Size = new System.Drawing.Size(434, 54);
            this.attachmentsTXT.TabIndex = 14;
            this.attachmentsTXT.Text = " Attachments...";
            this.attachmentsTXT.Click += new System.EventHandler(this.attachmentsTXT_Click);
            this.attachmentsTXT.TextChanged += new System.EventHandler(this.attachmentsTXT_TextChanged);
            this.attachmentsTXT.Leave += new System.EventHandler(this.attachmentsTXT_Leave);
            // 
            // subjectTXT
            // 
            this.subjectTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.subjectTXT.ForeColor = System.Drawing.Color.Gray;
            this.subjectTXT.Location = new System.Drawing.Point(97, 202);
            this.subjectTXT.Name = "subjectTXT";
            this.subjectTXT.Size = new System.Drawing.Size(349, 20);
            this.subjectTXT.TabIndex = 15;
            this.subjectTXT.Text = " subject";
            this.subjectTXT.Click += new System.EventHandler(this.subjectTXT_Click);
            this.subjectTXT.Leave += new System.EventHandler(this.subjectTXT_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(44, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Subject*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(107)))));
            this.panel2.Location = new System.Drawing.Point(-11, -73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 82);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(107)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(62)))));
            this.panel3.Location = new System.Drawing.Point(19, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 5);
            this.panel3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(337, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Austin\'s Email Spoofer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(904, 342);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectTXT);
            this.Controls.Add(this.attachmentsTXT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bodyTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toTXT);
            this.Controls.Add(this.smtpTXT);
            this.Controls.Add(this.fromTXT);
            this.Controls.Add(this.sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "E-mail Spoofer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox fromTXT;
        private System.Windows.Forms.TextBox smtpTXT;
        private System.Windows.Forms.TextBox toTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.TextBox bodyTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox attachmentsTXT;
        private System.Windows.Forms.TextBox subjectTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}
