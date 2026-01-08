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
    public partial class Form9 : Form
    {
        // Hardcoded admin bilgileri
        private string adminKullaniciAdi = "admin";
        private string adminSifre = "123";

        public Form9()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtAdminAdi.Text;
            string sifre = txtSifre.Text;


            if (kullaniciAdi == adminKullaniciAdi && sifre == adminSifre)
            {

                Form10 form10 = new Form10();
                form10.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Yanlış kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeriGel_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close(); // Form9'u kapat
        }
    }
}