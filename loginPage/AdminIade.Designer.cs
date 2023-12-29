namespace TeknolojiMagazasi
{
    partial class AdminIade
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
            btnGeri = new Button();
            btnCikis = new Button();
            dataGridViewIade = new DataGridView();
            txtSatisID = new TextBox();
            btnIadeEt = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIade).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(1112, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 0;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(1223, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // dataGridViewIade
            // 
            dataGridViewIade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIade.Location = new Point(12, 231);
            dataGridViewIade.Name = "dataGridViewIade";
            dataGridViewIade.RowHeadersWidth = 51;
            dataGridViewIade.RowTemplate.Height = 29;
            dataGridViewIade.Size = new Size(839, 416);
            dataGridViewIade.TabIndex = 2;
            // 
            // txtSatisID
            // 
            txtSatisID.Location = new Point(45, 99);
            txtSatisID.Name = "txtSatisID";
            txtSatisID.Size = new Size(125, 27);
            txtSatisID.TabIndex = 3;
            // 
            // btnIadeEt
            // 
            btnIadeEt.Location = new Point(207, 97);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(94, 29);
            btnIadeEt.TabIndex = 5;
            btnIadeEt.Text = "İade Et";
            btnIadeEt.UseVisualStyleBackColor = true;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "SatışID:";
            // 
            // AdminIade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1505, 773);
            Controls.Add(label2);
            Controls.Add(btnIadeEt);
            Controls.Add(txtSatisID);
            Controls.Add(dataGridViewIade);
            Controls.Add(btnCikis);
            Controls.Add(btnGeri);
            Name = "AdminIade";
            Text = "AdminIade";
            Load += AdminIade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeri;
        private Button btnCikis;
        private DataGridView dataGridViewIade;
        private TextBox txtSatisID;
        private Button btnIadeEt;
        private Label label2;
    }
}