namespace Civarda_Proje_2
{
    partial class Form8
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
            dgvTaleplerim = new DataGridView();
            BtnGeriDön = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTaleplerim).BeginInit();
            SuspendLayout();
            // 
            // dgvTaleplerim
            // 
            dgvTaleplerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaleplerim.BackgroundColor = Color.White;
            dgvTaleplerim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaleplerim.Dock = DockStyle.Fill;
            dgvTaleplerim.Location = new Point(0, 0);
            dgvTaleplerim.Name = "dgvTaleplerim";
            dgvTaleplerim.ReadOnly = true;
            dgvTaleplerim.RowHeadersWidth = 51;
            dgvTaleplerim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaleplerim.Size = new Size(942, 548);
            dgvTaleplerim.TabIndex = 0;
            dgvTaleplerim.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnGeriDön
            // 
            BtnGeriDön.Dock = DockStyle.Bottom;
            BtnGeriDön.Location = new Point(0, 503);
            BtnGeriDön.Name = "BtnGeriDön";
            BtnGeriDön.Size = new Size(942, 45);
            BtnGeriDön.TabIndex = 1;
            BtnGeriDön.Text = "Geri Gel";
            BtnGeriDön.UseVisualStyleBackColor = true;
            BtnGeriDön.Click += BtnGeriDön_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 548);
            Controls.Add(BtnGeriDön);
            Controls.Add(dgvTaleplerim);
            Name = "Form8";
            Text = "Yardım Talepleriniz";
            ((System.ComponentModel.ISupportInitialize)dgvTaleplerim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTaleplerim;
        private Button BtnGeriDön;
    }
}