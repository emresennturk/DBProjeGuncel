namespace loginPage
{
    partial class AdminMenu
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
            dataGridView1 = new DataGridView();
            txtIsimSoyad = new TextBox();
            label1 = new Label();
            btnAra = new Button();
            btnUrunler = new Button();
            btnSatis = new Button();
            button6 = new Button();
            btnSil = new Button();
            txtTel = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtTc = new TextBox();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            btnEkle = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnGuncelle = new Button();
            btnCikis = new Button();
            btnKullanıcı = new Button();
            btnYedekle = new Button();
            btnSilinenMusteri = new Button();
            btnKapat = new Button();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(930, 440);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtIsimSoyad
            // 
            txtIsimSoyad.Location = new Point(69, 168);
            txtIsimSoyad.Name = "txtIsimSoyad";
            txtIsimSoyad.Size = new Size(190, 27);
            txtIsimSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 172);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Arama:";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(274, 168);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(59, 27);
            btnAra.TabIndex = 3;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += button1_Click;
            // 
            // btnUrunler
            // 
            btnUrunler.Location = new Point(19, 36);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(123, 52);
            btnUrunler.TabIndex = 4;
            btnUrunler.Text = "Ürünler";
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnSatis
            // 
            btnSatis.Location = new Point(149, 36);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(123, 52);
            btnSatis.TabIndex = 5;
            btnSatis.Text = "Satışlar";
            btnSatis.UseVisualStyleBackColor = true;
            btnSatis.Click += btnSatis_Click;
            // 
            // button6
            // 
            button6.Location = new Point(280, 36);
            button6.Name = "button6";
            button6.Size = new Size(123, 52);
            button6.TabIndex = 8;
            button6.Text = "Kampanyalar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1173, 530);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 33);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(1239, 360);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(190, 27);
            txtTel.TabIndex = 10;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(1239, 313);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(190, 27);
            txtSoyad.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(1239, 265);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(190, 27);
            txtAd.TabIndex = 12;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(1239, 216);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(190, 27);
            txtTc.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1239, 411);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(1239, 461);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(190, 27);
            txtAdres.TabIndex = 16;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(1292, 530);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 31);
            btnEkle.TabIndex = 17;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1169, 220);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 18;
            label2.Text = "T.C. NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1169, 269);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 19;
            label3.Text = "ADI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1169, 317);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 20;
            label4.Text = "SOYADI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1169, 363);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 21;
            label5.Text = "TEL.NO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1169, 413);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 22;
            label6.Text = "EMAİL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1171, 464);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 24;
            label8.Text = "ADRES:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(1399, 530);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 25;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(1223, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 27;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnKullanıcı
            // 
            btnKullanıcı.Location = new Point(409, 36);
            btnKullanıcı.Name = "btnKullanıcı";
            btnKullanıcı.Size = new Size(130, 52);
            btnKullanıcı.TabIndex = 28;
            btnKullanıcı.Text = "Kullanıcı Ekle";
            btnKullanıcı.UseVisualStyleBackColor = true;
            btnKullanıcı.Click += btnKullanıcı_Click;
            // 
            // btnYedekle
            // 
            btnYedekle.Location = new Point(545, 36);
            btnYedekle.Name = "btnYedekle";
            btnYedekle.Size = new Size(140, 52);
            btnYedekle.TabIndex = 29;
            btnYedekle.Text = "Yedekle";
            btnYedekle.UseVisualStyleBackColor = true;
            btnYedekle.Click += btnYedekle_Click;
            // 
            // btnSilinenMusteri
            // 
            btnSilinenMusteri.Location = new Point(971, 600);
            btnSilinenMusteri.Name = "btnSilinenMusteri";
            btnSilinenMusteri.Size = new Size(128, 56);
            btnSilinenMusteri.TabIndex = 30;
            btnSilinenMusteri.Text = "Silinen Müşteriler";
            btnSilinenMusteri.UseVisualStyleBackColor = true;
            btnSilinenMusteri.Click += btnSilinenMusteri_Click;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(1112, 12);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(94, 29);
            btnKapat.TabIndex = 31;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(855, 36);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(126, 52);
            btnKaydet.TabIndex = 32;
            btnKaydet.Text = "PDF Olarak Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(btnKaydet);
            Controls.Add(btnKapat);
            Controls.Add(btnSilinenMusteri);
            Controls.Add(btnYedekle);
            Controls.Add(btnKullanıcı);
            Controls.Add(btnCikis);
            Controls.Add(btnGuncelle);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEkle);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(txtTc);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtTel);
            Controls.Add(btnSil);
            Controls.Add(button6);
            Controls.Add(btnSatis);
            Controls.Add(btnUrunler);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(txtIsimSoyad);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMenu";
            Text = "MainMenu";
            Load += AdminMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private TextBox txtIsimSoyad;
        private Label label1;
        private Button btnAra;
        private Button btnUrunler;
        private Button btnSatis;
        private Button button6;
        private Button btnSil;
        private TextBox txtTel;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtTc;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private Button btnEkle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btnGuncelle;
        private Button button10;
        private Button btnCikis;
        private Button btnGeri;
        private Button btnKullanıcı;
        private Button btnYedekle;
        private Button btnSilinenMusteri;
        private Button btnKapat;
        private Button btnKaydet;
    }
}