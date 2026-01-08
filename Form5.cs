using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Civarda_Proje_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            YuvarlakButonYap(BtnYardimEt, 150);
            YuvarlakButonYap(BtnYardimIste, 150);
        }

        private void YuvarlakButonYap(Button btn, int yaricap)
        {
            GraphicsPath yol = new GraphicsPath();
            yol.StartFigure();

            yol.AddArc(0, 0, yaricap, yaricap, 180, 90);
            yol.AddArc(btn.Width - yaricap, 0, yaricap, yaricap, 270, 90);
            yol.AddArc(btn.Width - yaricap, btn.Height - yaricap, yaricap, yaricap, 0, 90);
            yol.AddArc(0, btn.Height - yaricap, yaricap, yaricap, 90, 90);

            yol.CloseFigure();
            btn.Region = new Region(yol);
        }

        private void btnYardimEt_Click(object sender, EventArgs e)
        {
            // Form6'yı aç ve Form5'i kapat
            var f6 = new Form6();
            f6.Show();
            this.Close();
        }

        private void btnYardimIste_Click(object sender, EventArgs e)
        {
            var f7 = new Form7();
            f7.Show();
            this.Close();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            // Tüm açık formları kapatıp uygulamadan çıkış yapar.
            // Application.Exit() tüm formların FormClosing/FormClosed olaylarını tetikler ve uygulamayı sonlandırır.
            Application.Exit();
        }

        private void BtnYardimEt_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnYardimTaleplerim_Click(object sender, EventArgs e)
        {
            var f8 = new Form8();
            f8.Show();
            this.Close();
        }
    }
}