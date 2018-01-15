using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace utility_workbench
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            try
            {
                string smtpServer = smtpServerTextBox.Text;
                string port = portTextBox.Text;
                string from = fromTextBox.Text;
                string to = ToTextBox4.Text;
                string subject = subjectTextBox.Text;
                string body = bodyRichTextBox.Text;

                MailMessage mail = new MailMessage();
                
                SmtpClient smtpClient = new SmtpClient(smtpServer, Int16.Parse(port));

                string[] toListArray = File.ReadAllLines("tolist.txt");
                var splitListArray = toListArray.Select(str => str.Split(';'));
                foreach(var thisStr in splitListArray)
                {
                   foreach(var thisAddress in thisStr)
                    {
                        mail.To.Add(thisAddress);
                    }
                }

                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                //smtpServer.Port = 587;
                //smtpServer.Credentials = new System.Net.NetworkCredential("dhiraj.suvarna@gmail.com", "Raghu*123");
                //smtpServer.EnableSsl = true;

                smtpClient.Send(mail);
                MessageBox.Show("Mail Sent!!!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
