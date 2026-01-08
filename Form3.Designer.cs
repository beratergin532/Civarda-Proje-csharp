namespace Civarda_Proje_2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtKullaniciAdi = new TextBox();
            txtEposta = new TextBox();
            txtTcKimlikNo = new TextBox();
            btnOnayla = new Button();
            btnGeriGel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(402, 64);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 0;
            label1.Text = "Şifre Değiştir ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(212, 188);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adınız :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(152, 258);
            label3.Name = "label3";
            label3.Size = new Size(220, 28);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik Numaranız :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(255, 325);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 3;
            label4.Text = "E-postanız :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.Silver;
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(378, 185);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(222, 34);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.Silver;
            txtEposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEposta.Location = new Point(378, 322);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(222, 34);
            txtEposta.TabIndex = 6;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.BackColor = Color.Silver;
            txtTcKimlikNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTcKimlikNo.Location = new Point(378, 255);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(222, 34);
            txtTcKimlikNo.TabIndex = 7;
            // 
            // btnOnayla
            // 
            btnOnayla.Font = new Font("Segoe UI", 12.2000008F, FontStyle.Bold);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Image = (Image)resources.GetObject("btnOnayla.Image");
            btnOnayla.Location = new Point(484, 382);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(116, 39);
            btnOnayla.TabIndex = 9;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnGeriGel
            // 
            btnGeriGel.BackColor = Color.FromArgb(192, 64, 0);
            btnGeriGel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriGel.ForeColor = Color.White;
            btnGeriGel.Location = new Point(12, 498);
            btnGeriGel.Name = "btnGeriGel";
            btnGeriGel.Size = new Size(127, 38);
            btnGeriGel.TabIndex = 10;
            btnGeriGel.Text = "Geri Gel";
            btnGeriGel.UseVisualStyleBackColor = false;
            btnGeriGel.Click += btnGeriGel_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 548);
            Controls.Add(btnGeriGel);
            Controls.Add(btnOnayla);
            Controls.Add(txtTcKimlikNo);
            Controls.Add(txtEposta);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKullaniciAdi;
        private TextBox txtEposta;
        private TextBox txtTcKimlikNo;
        private Button btnOnayla;
        private Button btnGeriGel;
    }
}