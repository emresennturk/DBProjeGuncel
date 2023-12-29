namespace loginPage
{
    partial class KullaniciMain
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
            button2 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            btnAra2 = new Button();
            label1 = new Label();
            txtIsimSoyad2 = new TextBox();
            btnGuncelle2 = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEkle2 = new Button();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            txtTc = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTel = new TextBox();
            btnSil2 = new Button();
            btnCikis2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(31, 31);
            button2.Name = "button2";
            button2.Size = new Size(123, 52);
            button2.TabIndex = 5;
            button2.Text = "Ürünler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 31);
            button3.Name = "button3";
            button3.Size = new Size(123, 52);
            button3.TabIndex = 6;
            button3.Text = "Satışlar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 222);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(930, 440);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnAra2
            // 
            btnAra2.Location = new Point(278, 173);
            btnAra2.Name = "btnAra2";
            btnAra2.Size = new Size(59, 27);
            btnAra2.TabIndex = 12;
            btnAra2.Text = "ARA";
            btnAra2.UseVisualStyleBackColor = true;
            btnAra2.Click += btnAra2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 177);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 11;
            label1.Text = "ARAMA:";
            // 
            // txtIsimSoyad2
            // 
            txtIsimSoyad2.Location = new Point(73, 173);
            txtIsimSoyad2.Name = "txtIsimSoyad2";
            txtIsimSoyad2.Size = new Size(190, 27);
            txtIsimSoyad2.TabIndex = 10;
            // 
            // btnGuncelle2
            // 
            btnGuncelle2.Location = new Point(1399, 525);
            btnGuncelle2.Name = "btnGuncelle2";
            btnGuncelle2.Size = new Size(94, 29);
            btnGuncelle2.TabIndex = 40;
            btnGuncelle2.Text = "GÜNCELLE";
            btnGuncelle2.UseVisualStyleBackColor = true;
            btnGuncelle2.Click += btnGuncelle2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1165, 458);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 39;
            label8.Text = "ADRES:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1165, 412);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 38;
            label6.Text = "EMAİL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1165, 368);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 37;
            label5.Text = "TEL.NO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1165, 323);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 36;
            label4.Text = "SOYADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1165, 275);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 35;
            label3.Text = "ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1165, 223);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 34;
            label2.Text = "T.C. NO:";
            // 
            // btnEkle2
            // 
            btnEkle2.Location = new Point(1292, 525);
            btnEkle2.Margin = new Padding(3, 4, 3, 4);
            btnEkle2.Name = "btnEkle2";
            btnEkle2.Size = new Size(86, 31);
            btnEkle2.TabIndex = 33;
            btnEkle2.Text = "EKLE";
            btnEkle2.UseVisualStyleBackColor = true;
            btnEkle2.Click += btnEkle2_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(1239, 458);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(190, 27);
            txtAdres.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1239, 412);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 27);
            txtEmail.TabIndex = 31;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(1239, 216);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(190, 27);
            txtTc.TabIndex = 30;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(1239, 268);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(190, 27);
            txtAd.TabIndex = 29;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(1239, 316);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(190, 27);
            txtSoyad.TabIndex = 28;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(1239, 365);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(190, 27);
            txtTel.TabIndex = 27;
            // 
            // btnSil2
            // 
            btnSil2.Location = new Point(1174, 525);
            btnSil2.Name = "btnSil2";
            btnSil2.Size = new Size(101, 33);
            btnSil2.TabIndex = 26;
            btnSil2.Text = "SİL";
            btnSil2.UseVisualStyleBackColor = true;
            btnSil2.Click += btnSil2_Click;
            // 
            // btnCikis2
            // 
            btnCikis2.Location = new Point(1223, 12);
            btnCikis2.Name = "btnCikis2";
            btnCikis2.Size = new Size(94, 29);
            btnCikis2.TabIndex = 41;
            btnCikis2.Text = "Çıkış Yap";
            btnCikis2.UseVisualStyleBackColor = true;
            btnCikis2.Click += btnCikis2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(971, 600);
            button4.Name = "button4";
            button4.Size = new Size(128, 56);
            button4.TabIndex = 42;
            button4.Text = "Silinen Müşteriler";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // KullaniciMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(button4);
            Controls.Add(btnCikis2);
            Controls.Add(btnGuncelle2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEkle2);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(txtTc);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtTel);
            Controls.Add(btnSil2);
            Controls.Add(btnAra2);
            Controls.Add(label1);
            Controls.Add(txtIsimSoyad2);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "KullaniciMain";
            Text = "MainMenu";
            Load += KullaniciMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
        private Button btnAra2;
        private Label label1;
        private TextBox txtIsimSoyad2;
        private Button btnGuncelle2;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEkle2;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private TextBox txtTc;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTel;
        private Button btnSil2;
        private Button btnCikis2;
        private Button button4;
    }
}