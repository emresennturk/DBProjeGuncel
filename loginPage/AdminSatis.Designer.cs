namespace TeknolojiMagazasi
{
    partial class AdminSatis
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtMusteriTC = new TextBox();
            txtUrunID = new TextBox();
            btnSatisYap = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            btnUrunListele = new Button();
            dataGridViewSatis = new DataGridView();
            btnMusteriListele = new Button();
            btnIadeler = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSatis).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1223, 12);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Çıkış Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1112, 12);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 1;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtMusteriTC
            // 
            txtMusteriTC.Location = new Point(23, 111);
            txtMusteriTC.Margin = new Padding(3, 4, 3, 4);
            txtMusteriTC.Name = "txtMusteriTC";
            txtMusteriTC.Size = new Size(114, 27);
            txtMusteriTC.TabIndex = 7;
            // 
            // txtUrunID
            // 
            txtUrunID.Location = new Point(166, 111);
            txtUrunID.Margin = new Padding(3, 4, 3, 4);
            txtUrunID.Name = "txtUrunID";
            txtUrunID.Size = new Size(114, 27);
            txtUrunID.TabIndex = 8;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Location = new Point(305, 107);
            btnSatisYap.Margin = new Padding(3, 4, 3, 4);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(86, 31);
            btnSatisYap.TabIndex = 9;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 80);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 12;
            label1.Text = "MüşteriTC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 13;
            label2.Text = "ÜrünID:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(23, 279);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(114, 27);
            textBox7.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 255);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 18;
            label6.Text = "Genel Toplam:";
            // 
            // btnUrunListele
            // 
            btnUrunListele.Location = new Point(166, 146);
            btnUrunListele.Margin = new Padding(3, 4, 3, 4);
            btnUrunListele.Name = "btnUrunListele";
            btnUrunListele.Size = new Size(114, 57);
            btnUrunListele.TabIndex = 19;
            btnUrunListele.Text = "Ürünleri Listele";
            btnUrunListele.UseVisualStyleBackColor = true;
            btnUrunListele.Click += button4_Click;
            // 
            // dataGridViewSatis
            // 
            dataGridViewSatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSatis.Location = new Point(14, 341);
            dataGridViewSatis.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSatis.Name = "dataGridViewSatis";
            dataGridViewSatis.RowHeadersWidth = 51;
            dataGridViewSatis.RowTemplate.Height = 25;
            dataGridViewSatis.Size = new Size(839, 416);
            dataGridViewSatis.TabIndex = 20;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Location = new Point(23, 146);
            btnMusteriListele.Margin = new Padding(3, 4, 3, 4);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(114, 57);
            btnMusteriListele.TabIndex = 21;
            btnMusteriListele.Text = "Müşteri   Listele";
            btnMusteriListele.UseVisualStyleBackColor = true;
            btnMusteriListele.Click += button5_Click;
            // 
            // btnIadeler
            // 
            btnIadeler.Location = new Point(408, 107);
            btnIadeler.Name = "btnIadeler";
            btnIadeler.Size = new Size(86, 31);
            btnIadeler.TabIndex = 25;
            btnIadeler.Text = "İade Yap";
            btnIadeler.UseVisualStyleBackColor = true;
            btnIadeler.Click += btnIadeler_Click;
            // 
            // AdminSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(btnIadeler);
            Controls.Add(btnMusteriListele);
            Controls.Add(dataGridViewSatis);
            Controls.Add(btnUrunListele);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSatisYap);
            Controls.Add(txtUrunID);
            Controls.Add(txtMusteriTC);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminSatis";
            Text = "Satış";
            Load += AdminSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSatis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMusteriTC;
        private TextBox txtUrunID;
        private Button btnSatisYap;
        private Label label1;
        private Label label2;
        private TextBox textBox7;
        private Label label6;
        private Button btnUrunListele;
        private DataGridView dataGridViewSatis;
        private Button btnMusteriListele;
        private Button btnIadeler;
    }
}