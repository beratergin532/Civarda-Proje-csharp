namespace Civarda_Proje_2
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbTalepTürü = new ComboBox();
            txtTalepAciklamasi = new TextBox();
            txtAdres = new TextBox();
            BtnTalepOlustur = new Button();
            BtnGeriGel = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 166);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Talep Türü :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 258);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 1;
            label2.Text = "Talep Açıklaması : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(551, 166);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "Adres :";
            // 
            // cmbTalepTürü
            // 
            cmbTalepTürü.BackColor = Color.White;
            cmbTalepTürü.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbTalepTürü.ForeColor = Color.Black;
            cmbTalepTürü.FormattingEnabled = true;
            cmbTalepTürü.Items.AddRange(new object[] { "Alışveriş yardımı", "Basit ev tamiratı", "Çocuk bakıcılığı", "Evcil hayvan gezdirme" });
            cmbTalepTürü.Location = new Point(238, 163);
            cmbTalepTürü.Name = "cmbTalepTürü";
            cmbTalepTürü.Size = new Size(194, 36);
            cmbTalepTürü.TabIndex = 3;
            // 
            // txtTalepAciklamasi
            // 
            txtTalepAciklamasi.BackColor = Color.Silver;
            txtTalepAciklamasi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTalepAciklamasi.Location = new Point(238, 255);
            txtTalepAciklamasi.Name = "txtTalepAciklamasi";
            txtTalepAciklamasi.Size = new Size(194, 34);
            txtTalepAciklamasi.TabIndex = 4;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.White;
            txtAdres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdres.ForeColor = Color.Black;
            txtAdres.Location = new Point(642, 163);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(270, 34);
            txtAdres.TabIndex = 5;
            // 
            // BtnTalepOlustur
            // 
            BtnTalepOlustur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnTalepOlustur.ForeColor = Color.White;
            BtnTalepOlustur.Image = (Image)resources.GetObject("BtnTalepOlustur.Image");
            BtnTalepOlustur.Location = new Point(737, 258);
            BtnTalepOlustur.Name = "BtnTalepOlustur";
            BtnTalepOlustur.Size = new Size(175, 49);
            BtnTalepOlustur.TabIndex = 6;
            BtnTalepOlustur.Text = "Talep Oluştur ";
            BtnTalepOlustur.UseVisualStyleBackColor = true;
            BtnTalepOlustur.Click += BtnTalepOlustur_Click;
            // 
            // BtnGeriGel
            // 
            BtnGeriGel.BackColor = Color.Crimson;
            BtnGeriGel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGeriGel.ForeColor = Color.White;
            BtnGeriGel.Location = new Point(12, 498);
            BtnGeriGel.Name = "BtnGeriGel";
            BtnGeriGel.Size = new Size(120, 38);
            BtnGeriGel.TabIndex = 7;
            BtnGeriGel.Text = "Geri Gel";
            BtnGeriGel.UseVisualStyleBackColor = false;
            BtnGeriGel.Click += BtnGeriGel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(389, 61);
            label4.Name = "label4";
            label4.Size = new Size(304, 35);
            label4.TabIndex = 8;
            label4.Text = "Yardım Talebi Oluşturun ";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 548);
            Controls.Add(label4);
            Controls.Add(BtnGeriGel);
            Controls.Add(BtnTalepOlustur);
            Controls.Add(txtAdres);
            Controls.Add(txtTalepAciklamasi);
            Controls.Add(cmbTalepTürü);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Yardım Talebi Oluşturun";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTalepTürü;
        private TextBox txtTalepAciklamasi;
        private TextBox txtAdres;
        private Button BtnTalepOlustur;
        private Button BtnGeriGel;
        private Label label4;
    }
}