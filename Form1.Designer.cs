namespace Civarda_Proje_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnGirisYap = new Button();
            BtnSifremiUnuttum = new Button();
            BtnKayitOl = new Button();
            BtnAdminGirisi = new Button();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(328, 55);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 0;
            label1.Text = "Hesabınıza Giriş Yapın";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(258, 179);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(328, 261);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(258, 396);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 3;
            label4.Text = "Üye Değil Misiniz ?";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGirisYap.ForeColor = Color.White;
            BtnGirisYap.Image = (Image)resources.GetObject("BtnGirisYap.Image");
            BtnGirisYap.Location = new Point(479, 323);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(147, 45);
            BtnGirisYap.TabIndex = 4;
            BtnGirisYap.Text = "Giriş Yap ";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // BtnSifremiUnuttum
            // 
            BtnSifremiUnuttum.BackColor = Color.Transparent;
            BtnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            BtnSifremiUnuttum.FlatStyle = FlatStyle.Flat;
            BtnSifremiUnuttum.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            BtnSifremiUnuttum.ForeColor = Color.White;
            BtnSifremiUnuttum.Location = new Point(258, 329);
            BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            BtnSifremiUnuttum.Size = new Size(170, 35);
            BtnSifremiUnuttum.TabIndex = 5;
            BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            BtnSifremiUnuttum.UseVisualStyleBackColor = false;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKayitOl.ForeColor = Color.White;
            BtnKayitOl.Image = (Image)resources.GetObject("BtnKayitOl.Image");
            BtnKayitOl.Location = new Point(258, 446);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(134, 45);
            BtnKayitOl.TabIndex = 6;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = true;
            // 
            // BtnAdminGirisi
            // 
            BtnAdminGirisi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnAdminGirisi.ForeColor = Color.White;
            BtnAdminGirisi.Image = (Image)resources.GetObject("BtnAdminGirisi.Image");
            BtnAdminGirisi.Location = new Point(773, 12);
            BtnAdminGirisi.Name = "BtnAdminGirisi";
            BtnAdminGirisi.Size = new Size(157, 40);
            BtnAdminGirisi.TabIndex = 7;
            BtnAdminGirisi.Text = "Admin Girişi ";
            BtnAdminGirisi.UseVisualStyleBackColor = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.Silver;
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(395, 176);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(231, 34);
            txtKullaniciAdi.TabIndex = 9;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.Silver;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(395, 258);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(231, 34);
            txtSifre.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 548);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(BtnAdminGirisi);
            Controls.Add(BtnKayitOl);
            Controls.Add(BtnSifremiUnuttum);
            Controls.Add(BtnGirisYap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Civarda'ya Hoş Geldiniz ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnGirisYap;
        private Button BtnSifremiUnuttum;
        private Button BtnKayitOl;
        private Button BtnAdminGirisi;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
    }
}
