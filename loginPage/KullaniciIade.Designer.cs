namespace TeknolojiMagazasi
{
    partial class KullaniciIade
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
            dataGridViewIade2 = new DataGridView();
            txtSatisID2 = new TextBox();
            label1 = new Label();
            btnIadeEt2 = new Button();
            btnGeri4 = new Button();
            btnCikisYap4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIade2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIade2
            // 
            dataGridViewIade2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIade2.Location = new Point(12, 231);
            dataGridViewIade2.Name = "dataGridViewIade2";
            dataGridViewIade2.RowHeadersWidth = 51;
            dataGridViewIade2.RowTemplate.Height = 29;
            dataGridViewIade2.Size = new Size(839, 416);
            dataGridViewIade2.TabIndex = 0;
            // 
            // txtSatisID2
            // 
            txtSatisID2.Location = new Point(45, 99);
            txtSatisID2.Name = "txtSatisID2";
            txtSatisID2.Size = new Size(125, 27);
            txtSatisID2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 67);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "SatışID:";
            // 
            // btnIadeEt2
            // 
            btnIadeEt2.Location = new Point(207, 97);
            btnIadeEt2.Name = "btnIadeEt2";
            btnIadeEt2.Size = new Size(94, 29);
            btnIadeEt2.TabIndex = 3;
            btnIadeEt2.Text = "İade Et";
            btnIadeEt2.UseVisualStyleBackColor = true;
            btnIadeEt2.Click += btnIadeEt2_Click;
            // 
            // btnGeri4
            // 
            btnGeri4.Location = new Point(1112, 12);
            btnGeri4.Name = "btnGeri4";
            btnGeri4.Size = new Size(94, 29);
            btnGeri4.TabIndex = 4;
            btnGeri4.Text = "Geri";
            btnGeri4.UseVisualStyleBackColor = true;
            btnGeri4.Click += btnGeri4_Click;
            // 
            // btnCikisYap4
            // 
            btnCikisYap4.Location = new Point(1223, 12);
            btnCikisYap4.Name = "btnCikisYap4";
            btnCikisYap4.Size = new Size(94, 29);
            btnCikisYap4.TabIndex = 5;
            btnCikisYap4.Text = "Çıkış Yap";
            btnCikisYap4.UseVisualStyleBackColor = true;
            btnCikisYap4.Click += btnCikisYap4_Click;
            // 
            // KullaniciIade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(btnCikisYap4);
            Controls.Add(btnGeri4);
            Controls.Add(btnIadeEt2);
            Controls.Add(label1);
            Controls.Add(txtSatisID2);
            Controls.Add(dataGridViewIade2);
            Name = "KullaniciIade";
            Text = "KullaniciIade";
            Load += KullaniciIade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIade2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewIade2;
        private TextBox txtSatisID2;
        private Label label1;
        private Button btnIadeEt2;
        private Button btnGeri4;
        private Button btnCikisYap4;
    }
}