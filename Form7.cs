using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Civarda_Proje_2
{
    public partial class Form7 : Form
    {
        string baglantiCumlesi =
"Server=(localdb)\\MSSQLLocalDB;Database=MahalleYardimlasmaDB;Trusted_Connection=True;";

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void BtnTalepOlustur_Click(object sender, EventArgs e)
        {
            if (txtTalepAciklamasi.Text == "" || txtAdres.Text == "" || cmbTalepTürü.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Lütfen tüm alanları doldurun!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            try
            {
                baglanti.Open();

                string sorgu = @"
INSERT INTO YardimTalepleri
(KullaniciAdi, TalepAciklamasi, Adres, TalepTuru, TalepTarihi, Durum)
VALUES
(@kullaniciAdi, @aciklama, @adres, @tur, @tarih, @durum)";


                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", "testKullanici"); // şimdilik
                komut.Parameters.AddWithValue("@aciklama", txtTalepAciklamasi.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@tur", cmbTalepTürü.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.Parameters.AddWithValue("@durum", "Beklemede");

                komut.ExecuteNonQuery();

                MessageBox.Show(
                    "Yardım talebi başarıyla oluşturuldu.\nAdmin onayı bekleniyor.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Formu temizlemek istersen
                txtTalepAciklamasi.Clear();
                txtAdres.Clear();
                cmbTalepTürü.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void BtnGeriGel_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Close();
        }
    }
}
