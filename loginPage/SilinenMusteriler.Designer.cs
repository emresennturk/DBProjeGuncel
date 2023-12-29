namespace TeknolojiMagazasi
{
    partial class SilinenMusteriler
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
            dataGridViewSilinenMusteri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSilinenMusteri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSilinenMusteri
            // 
            dataGridViewSilinenMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSilinenMusteri.Location = new Point(51, 59);
            dataGridViewSilinenMusteri.Name = "dataGridViewSilinenMusteri";
            dataGridViewSilinenMusteri.RowHeadersWidth = 51;
            dataGridViewSilinenMusteri.RowTemplate.Height = 29;
            dataGridViewSilinenMusteri.Size = new Size(879, 341);
            dataGridViewSilinenMusteri.TabIndex = 0;
            // 
            // SilinenMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1138, 469);
            Controls.Add(dataGridViewSilinenMusteri);
            Name = "SilinenMusteriler";
            Text = "SilinenMusteriler";
            Load += SilinenMusteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSilinenMusteri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSilinenMusteri;
    }
}