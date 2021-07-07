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
    public partial class AddressesForm : Form
    {
        public AddressesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            checkedListBox1.Items.Add(text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Редактирование_списка redspiska = new Редактирование_списка();
            redspiska.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
