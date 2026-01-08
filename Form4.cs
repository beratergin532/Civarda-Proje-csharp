using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;




namespace Civarda_Proje_2
{
    public partial class Form4 : Form
    {
        string baglantiCumlesi =
"Server=(localdb)\\MSSQLLocalDB;Database=MahalleYardimlasmaDB;Trusted_Connection=True;";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new(baglantiCumlesi);

            try
            {
                baglanti.Open();

                string sorgu = @"UPDATE Kullanicilar 
                         SET Sifre = @yeniSifre 
                         WHERE KullaniciAdi = @kullaniciAdi";

                SqlCommand komut = new(sorgu, baglanti);
                komut.Parameters.AddWithValue("@yeniSifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);

                int etkilenenSatir = komut.ExecuteNonQuery();

                if (etkilenenSatir > 0)
                {
                    MessageBox.Show(
                        "Şifre başarıyla güncellendi ✅",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // İstersen Form1'e dön
                    Form1 frm1 = new();
                    frm1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Kullanıcı adı bulunamadı ❌",
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
    }
}
