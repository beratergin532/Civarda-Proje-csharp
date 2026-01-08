namespace Civarda_Proje_2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            BtnYardimEt = new Button();
            BtnYardimIste = new Button();
            BtnYardimTaleplerim = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnCikisYap = new Button();
            SuspendLayout();
            // 
            // BtnYardimEt
            // 
            BtnYardimEt.BackgroundImage = (Image)resources.GetObject("BtnYardimEt.BackgroundImage");
            BtnYardimEt.BackgroundImageLayout = ImageLayout.Center;
            BtnYardimEt.Location = new Point(145, 186);
            BtnYardimEt.Name = "BtnYardimEt";
            BtnYardimEt.Size = new Size(150, 150);
            BtnYardimEt.TabIndex = 0;
            BtnYardimEt.UseVisualStyleBackColor = true;
            BtnYardimEt.Click += BtnYardimEt_Click_1;
            // 
            // BtnYardimIste
            // 
            BtnYardimIste.BackgroundImage = (Image)resources.GetObject("BtnYardimIste.BackgroundImage");
            BtnYardimIste.BackgroundImageLayout = ImageLayout.Stretch;
            BtnYardimIste.Location = new Point(672, 186);
            BtnYardimIste.Name = "BtnYardimIste";
            BtnYardimIste.Size = new Size(150, 150);
            BtnYardimIste.TabIndex = 1;
            BtnYardimIste.UseVisualStyleBackColor = true;
            BtnYardimIste.Click += btnYardimIste_Click;
            // 
            // BtnYardimTaleplerim
            // 
            BtnYardimTaleplerim.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnYardimTaleplerim.ForeColor = Color.White;
            BtnYardimTaleplerim.Image = (Image)resources.GetObject("BtnYardimTaleplerim.Image");
            BtnYardimTaleplerim.Location = new Point(589, 411);
            BtnYardimTaleplerim.Name = "BtnYardimTaleplerim";
            BtnYardimTaleplerim.Size = new Size(294, 49);
            BtnYardimTaleplerim.TabIndex = 2;
            BtnYardimTaleplerim.Text = "Yardım Taleplerim ";
            BtnYardimTaleplerim.UseVisualStyleBackColor = true;
            BtnYardimTaleplerim.Click += BtnYardimTaleplerim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(151, 138);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 3;
            label1.Text = "YARDIM ET";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(668, 138);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 4;
            label2.Text = "YARDIM İSTE";
            // 
            // BtnCikisYap
            // 
            BtnCikisYap.BackColor = Color.FromArgb(192, 0, 0);
            BtnCikisYap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCikisYap.ForeColor = Color.White;
            BtnCikisYap.Location = new Point(12, 495);
            BtnCikisYap.Name = "BtnCikisYap";
            BtnCikisYap.Size = new Size(137, 41);
            BtnCikisYap.TabIndex = 5;
            BtnCikisYap.Text = "Çıkış Yap";
            BtnCikisYap.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 548);
            Controls.Add(BtnCikisYap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnYardimTaleplerim);
            Controls.Add(BtnYardimIste);
            Controls.Add(BtnYardimEt);
            Name = "Form5";
            Text = "Kullanıcı Ana Sayfası";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnYardimEt;
        private Button BtnYardimIste;
        private Button BtnYardimTaleplerim;
        private Label label1;
        private Label label2;
        private Button BtnCikisYap;
    }
}