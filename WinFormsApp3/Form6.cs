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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            this.BackColor = Color.White;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(0, 10).ToString();
            label2.Text = rnd.Next(0, 10).ToString();
            label3.Text = rnd.Next(0, 10).ToString();
            

            if (counter == 10)
            {
                timer1.Stop();
                if (label1.Text == label2.Text && label1.Text == label3.Text)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
            counter++;
        }
    }
}
