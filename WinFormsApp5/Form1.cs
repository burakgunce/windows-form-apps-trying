namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streader = new StreamReader(@"C:\\Users\\PC\\Desktop\\linkler2.txt");
            string icerik = streader.ReadToEnd();
            streader.Close();
            if (icerik.Contains(textBox1.Text))
            {
                richTextBox1.Text = "";

                int index = 0;
                while (index < icerik.Length)
                {
                    index = icerik.IndexOf(textBox1.Text, index);
                    if (index == -1) break; 

                    richTextBox1.AppendText(icerik.Substring(0, index)); 
                    richTextBox1.SelectionColor = System.Drawing.Color.Red; 
                    richTextBox1.AppendText(textBox1.Text); 
                    richTextBox1.SelectionColor = System.Drawing.Color.Black; 
                    icerik = icerik.Substring(index + textBox1.Text.Length); 
                    index = 0; 
                }

                richTextBox1.AppendText(icerik); 
            }
            else
            {
                richTextBox1.Text = "Ýçerik Bulunamadý";
            }
        }
    }
}