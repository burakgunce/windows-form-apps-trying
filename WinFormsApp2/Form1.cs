namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //dialog form olarak a��lan formlar kapat�lmadan arkadaki formlara ula��lamaz
        string[] dizi = { "bmw", "mercedes", "audi", "tesla" };

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        int index = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (index < dizi.Length)
            {
                listBox1.Items.Add(dizi[index]);
                index++;
            }
            else
            {
                MessageBox.Show("t�m elemanlar eklendi");
            }
        }
    }
}