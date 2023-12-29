namespace TeknolojiMagazasi
{
    partial class SilinenUrulerKullanici
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
            dataGridView7 = new DataGridView();
            btnGeri2 = new Button();
            btnCikisYap2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(6, 222);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.RowTemplate.Height = 29;
            dataGridView7.Size = new Size(930, 440);
            dataGridView7.TabIndex = 0;
            // 
            // btnGeri2
            // 
            btnGeri2.Location = new Point(835, 12);
            btnGeri2.Name = "btnGeri2";
            btnGeri2.Size = new Size(94, 29);
            btnGeri2.TabIndex = 1;
            btnGeri2.Text = "Geri";
            btnGeri2.UseVisualStyleBackColor = true;
            btnGeri2.Click += btnGeri2_Click;
            // 
            // btnCikisYap2
            // 
            btnCikisYap2.Location = new Point(935, 12);
            btnCikisYap2.Name = "btnCikisYap2";
            btnCikisYap2.Size = new Size(94, 29);
            btnCikisYap2.TabIndex = 2;
            btnCikisYap2.Text = "Çıkış Yap";
            btnCikisYap2.UseVisualStyleBackColor = true;
            btnCikisYap2.Click += btnCikisYap2_Click;
            // 
            // SilinenUrulerKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1108, 773);
            Controls.Add(btnCikisYap2);
            Controls.Add(btnGeri2);
            Controls.Add(dataGridView7);
            Name = "SilinenUrulerKullanici";
            Text = "Form8";
            Load += SilinenUrulerKullanici_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView7;
        private Button btnGeri2;
        private Button btnCikisYap2;
    }
}