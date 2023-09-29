using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form10 : Form
    {
        Form9 form9;
        public Form10(Form9 form)
        {
            InitializeComponent();
            form9 = form;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Color.Red);
            comboBox1.Items.Add(Color.Black);
            comboBox1.Items.Add(Color.Yellow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form9.BackColor = (Color)comboBox1.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form9.BackColor = (Color)Color.WhiteSmoke;
            this.Close();
        }
    }
}
