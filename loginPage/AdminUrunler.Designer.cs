namespace TeknolojiMagazasi
{
    partial class Urunler
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
            dataGridView4 = new DataGridView();
            btnCikis2 = new Button();
            txtUrunAd = new TextBox();
            txtStok = new TextBox();
            txtFiyat = new TextBox();
            txtMarka = new TextBox();
            txtAciklama = new TextBox();
            btnGeri = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            btnEkle3 = new Button();
            btnSil2 = new Button();
            txtSilmeID = new TextBox();
            txtID = new TextBox();
            btnStokGuncelle = new Button();
            txtStokGuncelle = new TextBox();
            label8 = new Label();
            btnSilinenUrunler = new Button();
            txtUrunAdi = new TextBox();
            btnAra = new Button();
            label9 = new Label();
            cmbSiralamaOptions = new ComboBox();
            label10 = new Label();
            cmbKategori = new ComboBox();
            label11 = new Label();
            button1 = new Button();
            btnExport = new Button();
            btnImport = new Button();
            comboBox2 = new ComboBox();
            txtRenk = new TextBox();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 221);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(930, 440);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellEnter += dataGridView4_CellEnter;
            // 
            // btnCikis2
            // 
            btnCikis2.Location = new Point(1223, 12);
            btnCikis2.Name = "btnCikis2";
            btnCikis2.Size = new Size(94, 29);
            btnCikis2.TabIndex = 42;
            btnCikis2.Text = "Çıkış Yap";
            btnCikis2.UseVisualStyleBackColor = true;
            btnCikis2.Click += btnCikis2_Click;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(1291, 323);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(151, 27);
            txtUrunAd.TabIndex = 44;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(1291, 367);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(151, 27);
            txtStok.TabIndex = 45;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(1291, 411);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(151, 27);
            txtFiyat.TabIndex = 46;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(1291, 455);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(151, 27);
            txtMarka.TabIndex = 47;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(1291, 500);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(151, 27);
            txtAciklama.TabIndex = 48;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(1112, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 51;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1168, 125);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 52;
            label1.Text = "ÜrünID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1200, 325);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 53;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1200, 367);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 54;
            label3.Text = "Stok:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1200, 413);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 55;
            label4.Text = "Ürün Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1200, 459);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 56;
            label5.Text = "Marka:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1200, 500);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 57;
            label6.Text = "Açıklama:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1200, 593);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 58;
            label7.Text = "Kategori:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1291, 593);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 59;
            // 
            // btnEkle3
            // 
            btnEkle3.Location = new Point(1315, 694);
            btnEkle3.Margin = new Padding(3, 4, 3, 4);
            btnEkle3.Name = "btnEkle3";
            btnEkle3.Size = new Size(86, 31);
            btnEkle3.TabIndex = 61;
            btnEkle3.Text = "EKLE";
            btnEkle3.UseVisualStyleBackColor = true;
            btnEkle3.Click += btnEkle3_Click;
            // 
            // btnSil2
            // 
            btnSil2.Location = new Point(1389, 119);
            btnSil2.Name = "btnSil2";
            btnSil2.Size = new Size(101, 33);
            btnSil2.TabIndex = 60;
            btnSil2.Text = "SİL";
            btnSil2.UseVisualStyleBackColor = true;
            btnSil2.Click += btnSil2_Click;
            // 
            // txtSilmeID
            // 
            txtSilmeID.Location = new Point(1232, 123);
            txtSilmeID.Name = "txtSilmeID";
            txtSilmeID.Size = new Size(151, 27);
            txtSilmeID.TabIndex = 62;
            // 
            // txtID
            // 
            txtID.Location = new Point(1291, 279);
            txtID.Name = "txtID";
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 82;
            txtID.Visible = false;
            // 
            // btnStokGuncelle
            // 
            btnStokGuncelle.Location = new Point(1397, 203);
            btnStokGuncelle.Name = "btnStokGuncelle";
            btnStokGuncelle.Size = new Size(94, 29);
            btnStokGuncelle.TabIndex = 83;
            btnStokGuncelle.Text = "Güncelle";
            btnStokGuncelle.UseVisualStyleBackColor = true;
            btnStokGuncelle.Click += btnStokGuncelle_Click_1;
            // 
            // txtStokGuncelle
            // 
            txtStokGuncelle.Location = new Point(1258, 203);
            txtStokGuncelle.Name = "txtStokGuncelle";
            txtStokGuncelle.Size = new Size(125, 27);
            txtStokGuncelle.TabIndex = 84;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1129, 207);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 85;
            label8.Text = "Stok Güncelleme:";
            // 
            // btnSilinenUrunler
            // 
            btnSilinenUrunler.Location = new Point(981, 593);
            btnSilinenUrunler.Name = "btnSilinenUrunler";
            btnSilinenUrunler.Size = new Size(125, 69);
            btnSilinenUrunler.TabIndex = 86;
            btnSilinenUrunler.Text = "Silinen Ürünler";
            btnSilinenUrunler.UseVisualStyleBackColor = true;
            btnSilinenUrunler.Click += btnSilinenUrunler_Click;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(69, 168);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(190, 27);
            txtUrunAdi.TabIndex = 88;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(274, 168);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(59, 27);
            btnAra.TabIndex = 89;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 172);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 90;
            label9.Text = "Arama:";
            // 
            // cmbSiralamaOptions
            // 
            cmbSiralamaOptions.FormattingEnabled = true;
            cmbSiralamaOptions.Location = new Point(738, 172);
            cmbSiralamaOptions.Name = "cmbSiralamaOptions";
            cmbSiralamaOptions.Size = new Size(198, 28);
            cmbSiralamaOptions.TabIndex = 91;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(810, 149);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 92;
            label10.Text = "Sırala:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(515, 172);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(198, 28);
            cmbKategori.TabIndex = 93;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(576, 149);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 94;
            label11.Text = "Kategori:";
            // 
            // button1
            // 
            button1.Location = new Point(883, 33);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 95;
            button1.Text = "PDF Olarak Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(552, 33);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(127, 50);
            btnExport.TabIndex = 96;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(717, 33);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(127, 50);
            btnImport.TabIndex = 97;
            btnImport.Text = "İmport";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1291, 634);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 98;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(1291, 549);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(151, 27);
            txtRenk.TabIndex = 99;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1200, 549);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 100;
            label12.Text = "Renk:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1200, 634);
            label13.Name = "label13";
            label13.Size = new Size(82, 20);
            label13.TabIndex = 101;
            label13.Text = "Kampanya:";
            // 
            // Urunler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtRenk);
            Controls.Add(comboBox2);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(cmbKategori);
            Controls.Add(label10);
            Controls.Add(cmbSiralamaOptions);
            Controls.Add(label9);
            Controls.Add(btnAra);
            Controls.Add(txtUrunAdi);
            Controls.Add(btnSilinenUrunler);
            Controls.Add(label8);
            Controls.Add(txtStokGuncelle);
            Controls.Add(btnStokGuncelle);
            Controls.Add(txtID);
            Controls.Add(txtSilmeID);
            Controls.Add(btnEkle3);
            Controls.Add(btnSil2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Controls.Add(txtAciklama);
            Controls.Add(txtMarka);
            Controls.Add(txtFiyat);
            Controls.Add(txtStok);
            Controls.Add(txtUrunAd);
            Controls.Add(btnCikis2);
            Controls.Add(dataGridView4);
            Name = "Urunler";
            Text = "Ürünler";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView4;
        private Button btnCikis2;
        private TextBox txtUrunAd;
        private TextBox txtStok;
        private TextBox txtFiyat;
        private TextBox txtMarka;
        private TextBox txtAciklama;
        private Button btnGeri;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Button btnEkle3;
        private Button btnSil2;
        private TextBox txtSilmeID;
        private TextBox txtID;
        private Button btnStokGuncelle;
        private TextBox txtStokGuncelle;
        private Label label8;
        private Button btnSilinenUrunler;
        private TextBox txtUrunAdi;
        private Button btnAra;
        private Label label9;
        private ComboBox cmbSiralamaOptions;
        private Label label10;
        private ComboBox cmbKategori;
        private Label label11;
        private Button button1;
        private Button btnExport;
        private Button btnImport;
        private ComboBox comboBox2;
        private TextBox txtRenk;
        private Label label12;
        private Label label13;
    }
}