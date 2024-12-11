using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petroluygulamsı_1
{
    public partial class Form1 : Form
    {//SQL BAGLANTISI
        public static string genel_bilgi = "";
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CN4K9TK;Initial Catalog=Petrol;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler.
        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre alanlarının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı Adınızı Girin");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Şifrenizi Girin");
                return;
            }

            string kul = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();
            // databaseden verileri  çekip ğiriş
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM giriş WHERE kullanıcıad=@kul AND Sifre=@sifre";
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader oku = command.ExecuteReader();

                if (oku.Read())
                {
                    genel_bilgi = "Merhaba, Hoş Geldiniz " + oku["kullanıcıad"].ToString();
                    MessageBox.Show(genel_bilgi);

                    // Yeni bir form başlat ve mevcut formu gizle
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Yapamadınız. Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Kontroller sadece "Giriş_Click" ile yapılır.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //"Giriş_Click" ile yapılır.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
