namespace TeknolojiMagazasi
{
    partial class KullaniciSatis
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
            dataGridViewSatis2 = new DataGridView();
            txtMusteriTC = new TextBox();
            txtUrunID = new TextBox();
            textBox3 = new TextBox();
            btnSatisYap2 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnIade2 = new Button();
            btnGeri3 = new Button();
            btnCikisYap3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSatis2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSatis2
            // 
            dataGridViewSatis2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSatis2.Location = new Point(14, 341);
            dataGridViewSatis2.Name = "dataGridViewSatis2";
            dataGridViewSatis2.RowHeadersWidth = 51;
            dataGridViewSatis2.RowTemplate.Height = 29;
            dataGridViewSatis2.Size = new Size(839, 416);
            dataGridViewSatis2.TabIndex = 0;
            // 
            // txtMusteriTC
            // 
            txtMusteriTC.Location = new Point(23, 111);
            txtMusteriTC.Name = "txtMusteriTC";
            txtMusteriTC.Size = new Size(114, 27);
            txtMusteriTC.TabIndex = 1;
            // 
            // txtUrunID
            // 
            txtUrunID.Location = new Point(166, 111);
            txtUrunID.Name = "txtUrunID";
            txtUrunID.Size = new Size(114, 27);
            txtUrunID.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 4;
            // 
            // btnSatisYap2
            // 
            btnSatisYap2.Location = new Point(297, 109);
            btnSatisYap2.Name = "btnSatisYap2";
            btnSatisYap2.Size = new Size(86, 31);
            btnSatisYap2.TabIndex = 5;
            btnSatisYap2.Text = "Satış Yap";
            btnSatisYap2.UseVisualStyleBackColor = true;
            btnSatisYap2.Click += btnSatisYap2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 144);
            button2.Name = "button2";
            button2.Size = new Size(114, 57);
            button2.TabIndex = 6;
            button2.Text = "Müşteri  Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(168, 144);
            button3.Name = "button3";
            button3.Size = new Size(114, 57);
            button3.TabIndex = 7;
            button3.Text = "Ürünleri Listele";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnIade2
            // 
            btnIade2.Location = new Point(404, 107);
            btnIade2.Name = "btnIade2";
            btnIade2.Size = new Size(85, 31);
            btnIade2.TabIndex = 8;
            btnIade2.Text = "İade Yap";
            btnIade2.UseVisualStyleBackColor = true;
            btnIade2.Click += btnIade2_Click;
            // 
            // btnGeri3
            // 
            btnGeri3.Location = new Point(1112, 12);
            btnGeri3.Name = "btnGeri3";
            btnGeri3.Size = new Size(86, 31);
            btnGeri3.TabIndex = 9;
            btnGeri3.Text = "Geri";
            btnGeri3.UseVisualStyleBackColor = true;
            btnGeri3.Click += btnGeri3_Click;
            // 
            // btnCikisYap3
            // 
            btnCikisYap3.Location = new Point(1223, 12);
            btnCikisYap3.Name = "btnCikisYap3";
            btnCikisYap3.Size = new Size(86, 31);
            btnCikisYap3.TabIndex = 10;
            btnCikisYap3.Text = "Çıkış Yap";
            btnCikisYap3.UseVisualStyleBackColor = true;
            btnCikisYap3.Click += btnCikisYap3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 80);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 11;
            label1.Text = "MüşteriTC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 12;
            label2.Text = "ÜrünID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 256);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 14;
            label4.Text = "Genel Toplam:";
            // 
            // KullaniciSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCikisYap3);
            Controls.Add(btnGeri3);
            Controls.Add(btnIade2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSatisYap2);
            Controls.Add(textBox3);
            Controls.Add(txtUrunID);
            Controls.Add(txtMusteriTC);
            Controls.Add(dataGridViewSatis2);
            Name = "KullaniciSatis";
            Text = "KullaniciSatis";
            Load += KullaniciSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSatis2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSatis2;
        private TextBox txtMusteriTC;
        private TextBox txtUrunID;
        private TextBox textBox3;
        private Button btnSatisYap2;
        private Button button2;
        private Button button3;
        private Button btnIade2;
        private Button btnGeri3;
        private Button btnCikisYap3;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}