using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader strRdr = new StreamReader(@"C:\\Users\\PC\\Desktop\\linkler2.txt");
            string içerik = strRdr.ReadToEnd();
            label1.Text = içerik;
            strRdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter strWrtr = new StreamWriter(@"C:\\Users\\PC\\Desktop\\linkler2.txt",true);
            //sonuna true yazarsan dosyanın üzerine ekler defalut hali false o zaman sürekli
            //sıfırlar ve sadece son yazdığını dosyaya kaydeder.
            strWrtr.Write(richTextBox1.Text);
            strWrtr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
