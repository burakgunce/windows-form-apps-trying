namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> kullaniciAdlari = new List<string>();
        string parola = "1234";
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            kullaniciAdlari.Add("admin");
            kullaniciAdlari.Add("moderator");
            kullaniciAdlari.Add("yonetici");
            kullaniciAdlari.Add("kullanici");
            kullaniciAdlari.Add("sistem kullanicisi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (kullaniciAdlari.Contains(kullaniciAdi) && parola == password)
            {
                Form2 frm = new Form2();
                frm.Show();

                //this.Close();//bunu dersen uygulama kapan�r cunku uygulaman�n ana formu
                //baslang�c formudur yan� programcs de yazanform1 dir.
                this.Hide(); //�al��may� yapt�g�n formu gizler yani form1 i
                frm.KullaniciAdiYaz(kullaniciAdi);
            }
            else
            {
                DialogResult result = MessageBox.Show("kullanc� ad� veya parola hatal�");
                if (result == DialogResult.OK)
                {
                    textBox1.Text = "";// bunlar �ifre ve paroladaki yaz�lar� silmek i�in 
                    textBox2.Text = "";
                    textBox1.Focus();//tekrardan kullan�c� ad�n� girmene yar�yor.
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = default;
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}