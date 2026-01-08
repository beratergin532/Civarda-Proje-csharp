namespace Civarda_Proje_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTcKimlikNo = new TextBox();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            txtEposta = new TextBox();
            btnKayitOl = new Button();
            btnGeriDön = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(362, 57);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 0;
            label1.Text = "Civarda'ya Kayıt Olun ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(284, 241);
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
            label3.Location = new Point(354, 295);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(269, 184);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 3;
            label4.Text = "T.C. Kimlik No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(327, 347);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 4;
            label5.Text = "E-posta :";
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.BackColor = Color.Silver;
            txtTcKimlikNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTcKimlikNo.Location = new Point(424, 181);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(245, 34);
            txtTcKimlikNo.TabIndex = 5;
            // 
            // txtKullanici
            // 
            txtKullanici.BackColor = Color.Silver;
            txtKullanici.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullanici.Location = new Point(424, 238);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(245, 34);
            txtKullanici.TabIndex = 6;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.Silver;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(424, 292);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(245, 34);
            txtSifre.TabIndex = 7;
            txtSifre.TextChanged += textBox3_TextChanged;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.Silver;
            txtEposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEposta.Location = new Point(424, 344);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(245, 34);
            txtEposta.TabIndex = 8;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Image = (Image)resources.GetObject("btnKayitOl.Image");
            btnKayitOl.Location = new Point(546, 403);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(123, 43);
            btnKayitOl.TabIndex = 9;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGeriDön
            // 
            btnGeriDön.BackColor = Color.FromArgb(192, 64, 0);
            btnGeriDön.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDön.ForeColor = Color.White;
            btnGeriDön.Location = new Point(12, 498);
            btnGeriDön.Name = "btnGeriDön";
            btnGeriDön.Size = new Size(140, 38);
            btnGeriDön.TabIndex = 10;
            btnGeriDön.Text = "Geri Gel";
            btnGeriDön.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 548);
            Controls.Add(btnGeriDön);
            Controls.Add(btnKayitOl);
            Controls.Add(txtEposta);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(txtTcKimlikNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Kayıt Ekranı";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTcKimlikNo;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private TextBox txtEposta;
        private Button btnKayitOl;
        private Button btnGeriDön;
    }
}