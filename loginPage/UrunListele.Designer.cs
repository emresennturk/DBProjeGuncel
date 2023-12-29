namespace TeknolojiMagazasi
{
    partial class UrunListele
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
            dataGridView10 = new DataGridView();
            btnUrunAra = new Button();
            txtUrunAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView10).BeginInit();
            SuspendLayout();
            // 
            // dataGridView10
            // 
            dataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView10.Location = new Point(14, 48);
            dataGridView10.Margin = new Padding(3, 4, 3, 4);
            dataGridView10.Name = "dataGridView10";
            dataGridView10.RowHeadersWidth = 51;
            dataGridView10.RowTemplate.Height = 25;
            dataGridView10.Size = new Size(301, 536);
            dataGridView10.TabIndex = 0;
            dataGridView10.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnUrunAra
            // 
            btnUrunAra.Location = new Point(178, 9);
            btnUrunAra.Margin = new Padding(3, 4, 3, 4);
            btnUrunAra.Name = "btnUrunAra";
            btnUrunAra.Size = new Size(61, 31);
            btnUrunAra.TabIndex = 4;
            btnUrunAra.Text = "ARA";
            btnUrunAra.UseVisualStyleBackColor = true;
            btnUrunAra.Click += btnUrunAra_Click;
            // 
            // txtUrunAra
            // 
            txtUrunAra.Location = new Point(57, 9);
            txtUrunAra.Margin = new Padding(3, 4, 3, 4);
            txtUrunAra.Name = "txtUrunAra";
            txtUrunAra.Size = new Size(114, 27);
            txtUrunAra.TabIndex = 3;
            // 
            // UrunListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(btnUrunAra);
            Controls.Add(txtUrunAra);
            Controls.Add(dataGridView10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UrunListele";
            Text = "UrunListele";
            Load += UrunListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView10;
        private Button btnUrunAra;
        private TextBox txtUrunAra;
    }
}