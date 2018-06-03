using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

/// <summary>
/// Enjoy.
/// </summary>


namespace Spoofer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void sendButton_Click(object sender, EventArgs e)
        {

            string[] receivers = toTXT.Text.Split(Convert.ToChar(","));

            MailAddress fromAddress = null;
            if (nameTXT.Text == "")
            {
                fromAddress = new MailAddress(fromTXT.Text, fromTXT.Text);
            }
            else
            {
                fromAddress = new MailAddress(fromTXT.Text, nameTXT.Text);
            }

            int count = 0;
            foreach(string receiver in receivers)
            {
                MailAddress toAddress = new MailAddress(receiver);
                string fromPassword = passwordTXT.Text;
                string subject = subjectTXT.Text;

                var smtp = new SmtpClient
                {
                    Host = smtpTXT.Text,
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                var message = new MailMessage(fromAddress, toAddress);
                message.Subject = subject;
                message.Body = bodyTXT.Text;

                if (attachmentsTXT.Text != "Attachments...")
                {
                    message.Attachments.Add(new System.Net.Mail.Attachment(attachmentsTXT.Text));
                }

                try
                {
                    smtp.Send(message);
                    count++;
                }
                catch
                {
                }
            }
            MessageBox.Show(String.Format("Amount of e-mails sent: {0}", count));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bodyTXT_Click(object sender, EventArgs e)
        {
            if (bodyTXT.Text == "E-mail body...")
            {
                bodyTXT.Text = "";
                bodyTXT.ForeColor = Color.Black;
            }
        }

        bool failsafe = true;

        private void button1_Click(object sender, EventArgs e)
        {
            attachmentsTXT.Text = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (failsafe == true)
                    {
                        attachmentsTXT.Text = "";
                        failsafe = false;
                    }
                    attachmentsTXT.AppendText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void attachmentsTXT_TextChanged(object sender, EventArgs e)
        {
            if(attachmentsTXT.Text != "Attachments...")
            {
                attachmentsTXT.ForeColor = Color.Black;
            }
        }

        private void attachmentsTXT_Click(object sender, EventArgs e)
        {
            if(attachmentsTXT.Text == "Attachments...")
            {
                attachmentsTXT.Text = "";
            }
        }

        private void attachmentsTXT_Leave(object sender, EventArgs e)
        {
            if(attachmentsTXT.Text == "")
            {
                attachmentsTXT.Text = "Attachments...";
                attachmentsTXT.ForeColor = Color.Gray;
            }
        }

        private void bodyTXT_Leave(object sender, EventArgs e)
        {
            if (bodyTXT.Text == "")
            {
                bodyTXT.Text = "E-mail body...";
                bodyTXT.ForeColor = Color.Gray;
            }
        }

        private void displaynameTXT_TextChanged(object sender, EventArgs e)
        {
        }

        private void subjectTXT_Click(object sender, EventArgs e)
        {
            if(subjectTXT.Text == "How are you doing?")
            {
                subjectTXT.Text = "";
                subjectTXT.ForeColor = Color.Black;
            }
        }

        private void nameTXT_Click(object sender, EventArgs e)
        {
            if (nameTXT.Text == "John Doe")
            {
                nameTXT.Text = "";
                nameTXT.ForeColor = Color.Black;
            }
        }

        private void fromTXT_Click(object sender, EventArgs e)
        {
            if (fromTXT.Text == "email@example.com")
            {
                fromTXT.Text = "";
                fromTXT.ForeColor = Color.Black;
            }
        }

        private void toTXT_Click(object sender, EventArgs e)
        {
            if (toTXT.Text == "victim@example.com (seperate multiple e-mails using a comma)")
            {
                toTXT.Text = "";
                toTXT.ForeColor = Color.Black;
            }
        }

        private void smtpTXT_Click(object sender, EventArgs e)
        {
            if (smtpTXT.Text == "smtp.gmail.com")
            {
                smtpTXT.Text = "";
                smtpTXT.ForeColor = Color.Black;
            }
        }

        private void fromTXT_Leave(object sender, EventArgs e)
        {
            if(fromTXT.Text == "")
            {
                fromTXT.Text = "email@example.com";
                fromTXT.ForeColor = Color.Gray;
            }
        }

        private void nameTXT_Leave(object sender, EventArgs e)
        {
            if (nameTXT.Text == "")
            {
                nameTXT.Text = "John Doe";
                nameTXT.ForeColor = Color.Gray;
            }
        }

        private void toTXT_Leave(object sender, EventArgs e)
        {
            if (toTXT.Text == "")
            {
                toTXT.Text = "victim@example.com (seperate multiple e-mails using a comma)";
                toTXT.ForeColor = Color.Gray;
            }
        }

        private void smtpTXT_Leave(object sender, EventArgs e)
        {
            if (smtpTXT.Text == "")
            {
                smtpTXT.Text = "smtp.gmail.com";
                smtpTXT.ForeColor = Color.Gray;
            }
        }

        private void subjectTXT_Leave(object sender, EventArgs e)
        {
            if (subjectTXT.Text == "")
            {
                subjectTXT.Text = "How are you doing?";
                subjectTXT.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
