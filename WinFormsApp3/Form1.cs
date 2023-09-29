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

                //this.Close();//bunu dersen uygulama kapanýr cunku uygulamanýn ana formu
                //baslangýc formudur yaný programcs de yazanform1 dir.
                this.Hide(); //çalýþmayý yaptýgýn formu gizler yani form1 i
                frm.KullaniciAdiYaz(kullaniciAdi);
            }
            else
            {
                DialogResult result = MessageBox.Show("kullancý adý veya parola hatalý");
                if (result == DialogResult.OK)
                {
                    textBox1.Text = "";// bunlar þifre ve paroladaki yazýlarý silmek için 
                    textBox2.Text = "";
                    textBox1.Focus();//tekrardan kullanýcý adýný girmene yarýyor.
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