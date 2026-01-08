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

namespace Civarda_Proje_2
{
    public partial class Form8 : Form
    {
        
        string baglantiCumlesi = "Server=(localdb)\\MSSQLLocalDB;Database=MahalleYardimlasmaDB;Trusted_Connection=True;";


        public Form8()
        {
            InitializeComponent();
        }


        void TaleplerimiGetir()
        {
            
            SqlConnection baglanti = new(baglantiCumlesi);

           
            string sorgu = "SELECT Id, TalepAciklamasi, Adres, TalepTuru, TalepTarihi, Durum FROM dbo.YardimTalepleri WHERE KullaniciAdi = @kullaniciAdi";

            
            SqlCommand komut = new(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullaniciAdi", "testKullanici"); 

            SqlDataAdapter da = new(komut);
            DataTable dt = new();

            try
            {
                // Veriyi çekiyoruz
                da.Fill(dt);

                // Eğer veri yoksa, hata mesajı gösterelim
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Veri bulunamadı.");
                }
                else
                {
                    MessageBox.Show($"Veri çekildi. {dt.Rows.Count} adet talep var.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message); 
                return;
            }

           
            dgvTaleplerim.DataSource = dt;

           
            MessageBox.Show($"DataGridView'e veri bağlandı. Toplam satır sayısı: {dt.Rows.Count}");

            
            dgvTaleplerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  
            dgvTaleplerim.ReadOnly = true; 
            dgvTaleplerim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  

           
            dgvTaleplerim.Columns["TalepAciklamasi"].Width = 300; 
            dgvTaleplerim.Columns["Adres"].Width = 200;           
            dgvTaleplerim.Columns["Durum"].Width = 150;          

            
            dgvTaleplerim.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGeriDön_Click(object sender, EventArgs e)
        {
            Form5 ana = new();
            ana.Show();
            this.Close();
        }
    }
}
