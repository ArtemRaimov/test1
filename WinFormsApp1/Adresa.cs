using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_course
{
    public partial class Adresa : Form
    {
        public Adresa()
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
