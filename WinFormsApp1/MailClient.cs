using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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
