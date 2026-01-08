namespace Civarda_Proje_2
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAdminAdi = new TextBox();
            txtSifre = new TextBox();
            BtnGiris = new Button();
            BtnGeriGel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(394, 60);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "Admin Girişi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 205);
            label2.Name = "label2";
            label2.Size = new Size(200, 28);
            label2.TabIndex = 1;
            label2.Text = "Admin Kullanıcı Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(319, 273);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre :";
            // 
            // txtAdminAdi
            // 
            txtAdminAdi.BackColor = Color.Silver;
            txtAdminAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdminAdi.Location = new Point(389, 202);
            txtAdminAdi.Name = "txtAdminAdi";
            txtAdminAdi.Size = new Size(193, 34);
            txtAdminAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.Silver;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(389, 270);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(193, 34);
            txtSifre.TabIndex = 4;
            // 
            // BtnGiris
            // 
            BtnGiris.BackgroundImage = (Image)resources.GetObject("BtnGiris.BackgroundImage");
            BtnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGiris.ForeColor = Color.White;
            BtnGiris.Location = new Point(460, 333);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(122, 44);
            BtnGiris.TabIndex = 5;
            BtnGiris.Text = "Giriş Yap";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // BtnGeriGel
            // 
            BtnGeriGel.BackColor = Color.FromArgb(192, 0, 0);
            BtnGeriGel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGeriGel.ForeColor = Color.White;
            BtnGeriGel.Location = new Point(12, 495);
            BtnGeriGel.Name = "BtnGeriGel";
            BtnGeriGel.Size = new Size(117, 41);
            BtnGeriGel.TabIndex = 6;
            BtnGeriGel.Text = "Geri Gel";
            BtnGeriGel.UseVisualStyleBackColor = false;
            BtnGeriGel.Click += BtnGeriGel_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 548);
            Controls.Add(BtnGeriGel);
            Controls.Add(BtnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtAdminAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Admin Girişi ";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAdminAdi;
        private TextBox txtSifre;
        private Button BtnGiris;
        private Button BtnGeriGel;
    }
}