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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Top = button5.Top -5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Left = button5.Left+5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Top = button5.Top+5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Left = button5.Left-5;
        }
    }
}
