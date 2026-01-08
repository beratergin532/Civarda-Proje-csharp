using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Civarda_Proje_2
{
    public partial class Form1 : Form
    {
        string baglantiCumlesi =
"Server=(localdb)\\MSSQLLocalDB;Database=MahalleYardimlasmaDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            // Designer'da Click eventi atanmadıysa burada bağlıyoruz.
            BtnKayitOl.Click += BtnKayitOl_Click;
            BtnSifremiUnuttum.Click += BtnSifremiUnuttum_Click;
            // Yeni: Admin giriş butonunu bağla
            BtnAdminGirisi.Click += BtnAdminGirisi_Click;
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            // Form1 arkada görünmesin diye önce gizliyoruz, Form2 modal açılıyor.
            this.Hide();
            try
            {
                using var form2 = new Form2();
                form2.ShowDialog(); // owner olarak this verilmediği için ana form görünmez
            }
            finally
            {
                // Form2 kapandığında Form1 tekrar görünür olacak
                this.Show();
            }
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            // Değişiklik: Form1'i kapatmak yerine gizliyoruz ve
            // Form3 kapandığında Form1'i tekrar gösteriyoruz.
            var form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show(); // this.Close() yerine this.Show()
            this.Hide();
            form3.Show();
        }

        private void BtnAdminGirisi_Click(object sender, EventArgs e)
        {
            // Form9'u aç ve Form1'i kapat.
            // Önce Form9 gösteriliyor, ardından Form1 kapatılıyor; uygulama Form9 açık kaldığı sürece çalışmaya devam eder.
            var frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new(baglantiCumlesi);

            try
            {
                baglanti.Open();

                string sorgu = @"SELECT COUNT(*) 
                         FROM Kullanicilar
                         WHERE KullaniciAdi = @kadi 
                         AND Sifre = @sifre";

                SqlCommand komut = new(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                int sonuc = (int)komut.ExecuteScalar();

                if (sonuc > 0)
                {
                    Form5 frm = new();
                    frm.Show();
                    this.Hide(); // Form1 gizlenir
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı ");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
