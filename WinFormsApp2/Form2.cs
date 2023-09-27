using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] sehirler = { "trabzon", "izmir", "rize", "elazığ" };
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count> 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBox1.Items);
                listBox2.Items.Clear();
            }
            
        }
    }
}
