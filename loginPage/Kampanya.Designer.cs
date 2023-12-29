namespace TeknolojiMagazasi
{
    partial class Kampanya
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
            txtKampanyaID = new TextBox();
            txtKampanyaAd = new TextBox();
            txtIndirimOran = new TextBox();
            btnKampanyaEkle = new Button();
            btnKampanyaSil = new Button();
            dataGridViewKampanya = new DataGridView();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKampanya).BeginInit();
            SuspendLayout();
            // 
            // txtKampanyaID
            // 
            txtKampanyaID.Location = new Point(123, 284);
            txtKampanyaID.Name = "txtKampanyaID";
            txtKampanyaID.Size = new Size(125, 27);
            txtKampanyaID.TabIndex = 0;
            // 
            // txtKampanyaAd
            // 
            txtKampanyaAd.Location = new Point(132, 77);
            txtKampanyaAd.Name = "txtKampanyaAd";
            txtKampanyaAd.Size = new Size(125, 27);
            txtKampanyaAd.TabIndex = 1;
            // 
            // txtIndirimOran
            // 
            txtIndirimOran.Location = new Point(132, 126);
            txtIndirimOran.Name = "txtIndirimOran";
            txtIndirimOran.Size = new Size(125, 27);
            txtIndirimOran.TabIndex = 5;
            // 
            // btnKampanyaEkle
            // 
            btnKampanyaEkle.Location = new Point(144, 175);
            btnKampanyaEkle.Name = "btnKampanyaEkle";
            btnKampanyaEkle.Size = new Size(94, 29);
            btnKampanyaEkle.TabIndex = 6;
            btnKampanyaEkle.Text = "Ekle";
            btnKampanyaEkle.UseVisualStyleBackColor = true;
            btnKampanyaEkle.Click += btnKampanyaEkle_Click;
            // 
            // btnKampanyaSil
            // 
            btnKampanyaSil.Location = new Point(144, 330);
            btnKampanyaSil.Name = "btnKampanyaSil";
            btnKampanyaSil.Size = new Size(94, 29);
            btnKampanyaSil.TabIndex = 7;
            btnKampanyaSil.Text = "Sil";
            btnKampanyaSil.UseVisualStyleBackColor = true;
            btnKampanyaSil.Click += btnKampanyaSil_Click;
            // 
            // dataGridViewKampanya
            // 
            dataGridViewKampanya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKampanya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKampanya.Location = new Point(394, 45);
            dataGridViewKampanya.Name = "dataGridViewKampanya";
            dataGridViewKampanya.RowHeadersWidth = 51;
            dataGridViewKampanya.RowTemplate.Height = 29;
            dataGridViewKampanya.Size = new Size(637, 347);
            dataGridViewKampanya.TabIndex = 8;
            dataGridViewKampanya.CellContentClick += dataGridViewKampanya_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 77);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 9;
            label1.Text = "Ad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 126);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 13;
            label5.Text = "İndirim Oranı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 287);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 14;
            label2.Text = "KampanyaID:";
            // 
            // Kampanya
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1102, 450);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dataGridViewKampanya);
            Controls.Add(btnKampanyaSil);
            Controls.Add(btnKampanyaEkle);
            Controls.Add(txtIndirimOran);
            Controls.Add(txtKampanyaAd);
            Controls.Add(txtKampanyaID);
            Name = "Kampanya";
            Text = "Kampanya";
            Load += Kampanya_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKampanya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKampanyaID;
        private TextBox txtKampanyaAd;
        private TextBox txtIndirimOran;
        private Button btnKampanyaEkle;
        private Button btnKampanyaSil;
        private DataGridView dataGridViewKampanya;
        private Label label1;
        private Label label5;
        private Label label2;
    }
}