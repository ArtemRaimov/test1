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
    public partial class RegistrationForm : Form
    {
        string pathTextLogPass;
        public RegistrationForm(string pathTextLogPass)
        {
            InitializeComponent();
            this.pathTextLogPass = pathTextLogPass;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (!(File.Exists(pathTextLogPass)))
                using (FileStream fs = new FileStream(pathTextLogPass, FileMode.CreateNew));
            label3.Hide(); Pass2TB.Hide();
        }
    bool NotHaveLogin(string pathTextLogPass)
    {
        string[] lines = File.ReadAllLines(pathTextLogPass, Encoding.Default);
        foreach (string line in lines)
        {
            if (Decryption(line).Split('|')[0].ToLower() == LoginTB.Text.ToLower())
            {
                MessageBox.Show("Такой логин уже существует");
                return false;
            }
        }
        return true;
    }

    bool Save(string login, string pasword)
    {
        try
        {
            if (NotHaveLogin(pathTextLogPass))
            {
                File.AppendAllLines(pathTextLogPass, new[] { Encryption(login + "|" + pasword) }, Encoding.Default);
                return true;
            }
            else
                return false;
        }
        catch (Exception err)
        {
            MessageBox.Show(err.Message);
            return false;
        }
    }

    string Encryption(string str)
    {
        StringBuilder strB = new StringBuilder(str);
        for (int i = 0; i < strB.Length; i++)
            strB[i] = (char)(strB[i] + 2); 

        return strB.ToString();
    }

    string Decryption(string str)
    {
        StringBuilder strB = new StringBuilder(str);
        for (int i = 0; i < strB.Length; i++)
            strB[i] = (char)(strB[i] - 2);

        return strB.ToString();
    }

    private void PassTB_TextChanged(object sender, EventArgs e)
    {
            if (PassTB.Text == string.Empty) { label3.Hide(); Pass2TB.Hide(); }
            else { label3.Show(); Pass2TB.Show(); }
        }

    private void RegButton_Click(object sender, EventArgs e)
    {
        if (LoginTB.Text == string.Empty)
        {
            MessageBox.Show("Создайте логин");
            return;
        }

        if (PassTB.Text == string.Empty || Pass2TB.Text == string.Empty)
        {
            MessageBox.Show("Поле с паролем не заполнено");
            return;
        }
        if (PassTB.Text != Pass2TB.Text)
        {
            MessageBox.Show("Пароли не совпадают");
            return;
        }

        if (Save(LoginTB.Text, PassTB.Text) == true)
        {
            DialogResult = DialogResult.OK;
            LoginForm f = new LoginForm();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
        else
            return;
        }
    }
}
