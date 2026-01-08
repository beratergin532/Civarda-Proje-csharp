using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Civarda_Proje_2
{
    public partial class Form3 : Form
    {
        string baglantiCumlesi =
"Server=(localdb)\\MSSQLLocalDB;Database=MahalleYardimlasmaDB;Trusted_Connection=True;";

        public Form3()
        {
            InitializeComponent();
            // Geri gel butonunu bağladık
            btnGeriGel.Click += btnGeriGel_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new(baglantiCumlesi);

            try
            {
                baglanti.Open();

                string sorgu = @"SELECT COUNT(*) 
                         FROM Kullanicilar 
                         WHERE KullaniciAdi = @kullaniciAdi
                         AND TcKimlikNo = @tc
                         AND Eposta = @eposta";

                SqlCommand komut = new(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@tc", txtTcKimlikNo.Text);
                komut.Parameters.AddWithValue("@eposta", txtEposta.Text);

                int sonuc = (int)komut.ExecuteScalar();

                if (sonuc > 0)
                {
                    //  Bilgiler doğru → Form4 aç
                    Form4 frm4 = new();
                    frm4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Bilgiler eşleşmiyor!",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
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

        private void btnGeriGel_Click(object sender, EventArgs e)
        {
            // Zaten açık bir AnaGiris (Form1) varsa onu göster, yoksa yeni örnek oluşturup göster.
            var ana = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (ana != null)
            {
                ana.Show();
                ana.BringToFront();
            }
            else
            {
                var yeniAna = new Form1();
                yeniAna.Show();
            }

            // Form3'ü kapat
            this.Close();
        }

        private void btnGeriGel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
