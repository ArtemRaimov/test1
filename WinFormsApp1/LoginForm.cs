using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        const string pathTextLogPass = @"C:\Users\raimo\source\repos\pass.txt";
        public string login;
        public string pasword;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathTextLogPass))
            {
                string[] lines = File.ReadAllLines(pathTextLogPass, Encoding.Default);
                foreach (string line in lines)
                {
                    string[] linesDec = Decryption(line).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    login = linesDec[0];
                    pasword = linesDec[1];

                    if (login.ToLower() == LoginTextBox.Text.ToLower() && pasword == PasswordTexBox.Text)
                    {
                        MainForm f = new MainForm(this);
                        this.Visible = false;
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
            MessageBox.Show("Такого логина или пароля не существует. \n Повторите ввод или зарегистрируйтесь!");
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form3 = new RegistrationForm(pathTextLogPass);
            form3.ShowDialog();
            if (form3.DialogResult == DialogResult.OK) Start();
        }
        void Start()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        string Decryption(string str)
        {
            StringBuilder strB = new StringBuilder(str);
            for (int i = 0; i < strB.Length; i++)
                strB[i] = (char)(strB[i] - 2);

            return strB.ToString();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTexBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTexBox.PasswordChar = '*';
        }
    }
}
