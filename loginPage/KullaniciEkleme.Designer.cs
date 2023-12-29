namespace TeknolojiMagazasi
{
    partial class KullaniciAyar
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
            dataGridView3 = new DataGridView();
            BtnGeri1 = new Button();
            BtnCikis3 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            BtnEkle3 = new Button();
            btnSil3 = new Button();
            txtKullaniciID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 21);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(406, 405);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // BtnGeri1
            // 
            BtnGeri1.Location = new Point(571, -1);
            BtnGeri1.Name = "BtnGeri1";
            BtnGeri1.Size = new Size(94, 29);
            BtnGeri1.TabIndex = 1;
            BtnGeri1.Text = "Geri";
            BtnGeri1.UseVisualStyleBackColor = true;
            BtnGeri1.Click += BtnGeri1_Click;
            // 
            // BtnCikis3
            // 
            BtnCikis3.Location = new Point(671, -1);
            BtnCikis3.Name = "BtnCikis3";
            BtnCikis3.Size = new Size(94, 29);
            BtnCikis3.TabIndex = 2;
            BtnCikis3.Text = "Çıkış Yap";
            BtnCikis3.UseVisualStyleBackColor = true;
            BtnCikis3.Click += BtnCikis3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 142);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 187);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(612, 139);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(125, 27);
            txtKullanici.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(612, 184);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 6;
            // 
            // BtnEkle3
            // 
            BtnEkle3.Location = new Point(571, 257);
            BtnEkle3.Name = "BtnEkle3";
            BtnEkle3.Size = new Size(94, 29);
            BtnEkle3.TabIndex = 7;
            BtnEkle3.Text = "Ekle";
            BtnEkle3.UseVisualStyleBackColor = true;
            BtnEkle3.Click += BtnEkle3_Click;
            // 
            // btnSil3
            // 
            btnSil3.Location = new Point(671, 257);
            btnSil3.Name = "btnSil3";
            btnSil3.Size = new Size(94, 29);
            btnSil3.TabIndex = 8;
            btnSil3.Text = "Sil";
            btnSil3.UseVisualStyleBackColor = true;
            btnSil3.Click += btnSil3_Click;
            // 
            // txtKullaniciID
            // 
            txtKullaniciID.BackColor = SystemColors.ActiveCaption;
            txtKullaniciID.Location = new Point(612, 97);
            txtKullaniciID.Name = "txtKullaniciID";
            txtKullaniciID.Size = new Size(125, 27);
            txtKullaniciID.TabIndex = 9;
            txtKullaniciID.Visible = false;
            // 
            // KullaniciAyar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKullaniciID);
            Controls.Add(btnSil3);
            Controls.Add(BtnEkle3);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCikis3);
            Controls.Add(BtnGeri1);
            Controls.Add(dataGridView3);
            Name = "KullaniciAyar";
            Text = "Kullanıcı İşlemleri";
            Load += KullaniciAyar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView3;
        private Button BtnGeri1;
        private Button BtnCikis3;
        private Label label1;
        private Label label2;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Button BtnEkle3;
        private Button btnSil3;
        private TextBox txtKullaniciID;
    }
}