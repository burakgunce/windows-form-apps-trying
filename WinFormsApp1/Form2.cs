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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cikti = textBox1.Text + textBox2.Text;
            if (radioButton1.Checked)
            {
                cikti += radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                cikti += radioButton2.Text;
            }
            if (checkBox1.Checked)
            {
                cikti += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                cikti += checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                cikti += checkBox3.Text;
            }
            MessageBox.Show(cikti);

        }
    }
}
