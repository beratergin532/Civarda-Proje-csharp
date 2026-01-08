using System;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Civarda_Proje_2
{
    public partial class Form2 : Form
    {
        string baglantiCumlesi =
 "Server=(localdb)\\MSSQLLocalDB;Database=MahalleYardimlasmaDB;Trusted_Connection=True;";


        public Form2()
        {
            InitializeComponent();
            // Geri dön butonunu doğru isimle bağlıyoruz.
            btnGeriDön.Click += btnGeriDön_Click;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Gerekirse şifre alanı değişikliklerinde yapılacak işler buraya
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacaklar buraya
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Basit doğrulama
            if (string.IsNullOrWhiteSpace(txtKullanici.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtTcKimlikNo.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtEposta.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi girin.", "Geçersiz E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına ekleme
            try
            {
                using (var baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    string sorgu = @"INSERT INTO Kullanicilar
                                     (KullaniciAdi, Sifre, TcKimlikNo, Eposta)
                                     VALUES
                                     (@kadi, @sifre, @tc, @eposta)";

                    using (var komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kadi", txtKullanici.Text.Trim());
                        komut.Parameters.AddWithValue("@sifre", txtSifre.Text); // İsteğe göre hash'leyin
                        komut.Parameters.AddWithValue("@tc", txtTcKimlikNo.Text.Trim());
                        komut.Parameters.AddWithValue("@eposta", txtEposta.Text.Trim());

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarıyla oluşturuldu 🎉", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            // Form2'yi kapat; Form1 (AnaGiris) zaten önceki kodda gizlendiyse ShowDialog sonrası görünür olur.
            this.Close();
        }
    }
}
