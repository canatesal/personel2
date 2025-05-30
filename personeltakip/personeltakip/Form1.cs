namespace personeltakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtId.Text;
            string sifre = txtPw.Text;


            if (kullaniciAdi == "can" && sifre == "2121")
            {
                Form2 yeniForm = new Form2();
                yeniForm.Show();
                this.Hide(); // Giri? formunu gizlemek istersen
            }
            else
            {
                MessageBox.Show("Kullan?c? ad? veya ?ifre yanl??!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            txtPw.PasswordChar = '*';
        }
    }
}
