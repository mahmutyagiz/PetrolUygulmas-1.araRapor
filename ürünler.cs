using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Petroluygulamsı_1
{


    public partial class ürünler : Form
    {
        public ürünler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CN4K9TK;Initial Catalog=Petrol;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ürünler_Load(object sender, EventArgs e)
        {
            this.urunTableAdapter.Fill(this.petrolDataSet.urun);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //EKLE
            String t1 = textBox1.Text; //Malzeme kodu
            String t2 = textBox2.Text; //malzeme adı
            String t3 = textBox3.Text; //yıllık satıs
            String t4 = textBox4.Text; // birim fiyat
            String t5 = textBox5.Text; // min stok
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO urun (UrunADI, UrunMARKA, Urunfiyat, UrunTip, Stokm) VALUES ('" + t1 + "' , '+" + t2 + "' , '+" + t3 + "' , '+" + t4 + "' , '+" + t5 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün eklendi");


        }

        private void button2_Click(object sender, EventArgs e)
        {//Silme kısmı
            string t1 = textBox1.Text; //seçilen satırın malzeme kodun alma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM urun WHERE UrunADI=('" + t1 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {// güncelleme
            String t1 = textBox1.Text; //Malzeme kodu
            String t2 = textBox2.Text; //malzeme adı
            String t3 = textBox3.Text; //yıllık satıs
            String t4 = textBox4.Text; // birim fiyat
            String t5 = textBox5.Text; // min stok

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE urun SET UrunADI='" + t1 + "', UrunMARKA='" + t2 + "', Urunfiyat= '" + t3 + "', UrunTip='" + t4 + "' , Stokm= '+" + t5 + "' WEHERE MalzemeKodu='" + t1 + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Güncellendi");
        }
    }
}


