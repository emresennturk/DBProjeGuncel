namespace TeknolojiMagazasi
{
    partial class SilinenUrunler
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
            dataGridView6 = new DataGridView();
            btnGeri = new Button();
            btnCıkısYap = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(6, 222);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.RowTemplate.Height = 29;
            dataGridView6.Size = new Size(930, 440);
            dataGridView6.TabIndex = 0;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(835, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnCıkısYap
            // 
            btnCıkısYap.Location = new Point(935, 12);
            btnCıkısYap.Name = "btnCıkısYap";
            btnCıkısYap.Size = new Size(94, 29);
            btnCıkısYap.TabIndex = 2;
            btnCıkısYap.Text = "Çıkış Yap";
            btnCıkısYap.UseVisualStyleBackColor = true;
            btnCıkısYap.Click += btnCıkısYap_Click;
            // 
            // SilinenUrunler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1108, 773);
            Controls.Add(btnCıkısYap);
            Controls.Add(btnGeri);
            Controls.Add(dataGridView6);
            Name = "SilinenUrunler";
            Text = "Silinen Ürünler";
            Load += SilinenUrunler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView6;
        private Button btnGeri;
        private Button btnCıkısYap;
    }
}