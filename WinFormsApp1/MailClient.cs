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

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm(LoginForm f)
        {
            InitializeComponent();
            this.f = f;
            
        }

        LoginForm f;

        private void TemplateButton_Click(object sender, EventArgs e)
        {

        }

        private void DraftButton_Click(object sender, EventArgs e)
        {

        }

        private void PostponeButton_Click(object sender, EventArgs e)
        {
            PostponeForm f = new PostponeForm();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
        
        private void SendButton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress(f.login, SenderTextBox.Text);
            MailAddress to = new MailAddress(RecipientTextBox.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = ThemeTextBox.Text;
            m.Body = TextBox.Text;
            m.IsBodyHtml = true;
            int n = Convert.ToInt32(PortTextBox.Text);
            SmtpClient smtp = new SmtpClient(SMTPTextBox.Text, n);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(f.login, f.pasword);
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void ListsButton_Click(object sender, EventArgs e)
        {
            AddressesForm f = new AddressesForm();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
    }
}
