using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Zadanie6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passBox.PasswordChar = '*';
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            String to = toText.Text;
            String from = fromText.Text;
            String subject = subjectText.Text;
            String body = contentText.Text;
            String server = "";
            
            
            MailMessage message = new MailMessage(from, to, subject, body);
            var smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            
            smtp.Credentials=new System.Net.NetworkCredential(loginBox.Text,passBox.Text);
            smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.Send(message);


            try
            {
                foreach (string recipment in toText.Text.Split(';'))
                {
                    message.To.Add(to);

                    message.Attachments.Add(new Attachment(attachmentText.Text));
                }
                smtp.Send(message);
                MessageBox.Show("Message sent successfully", "Success!", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string picPath = ofd.FileName.ToString();
                attachmentText.Text = picPath;
            }
        }
    }
}
