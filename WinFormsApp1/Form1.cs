namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ho� Geldiniz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "erdinc@erdinc" && textBox2.Text == "123")
            {
                MessageBox.Show("Giri� Ba�ar�l�");
            }
            else
            {
                MessageBox.Show("Giri� Ba�ar�s�z");
            }
        }
    }
}