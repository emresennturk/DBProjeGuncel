namespace TeknolojiMagazasi
{
    partial class MusteriListele
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
            dataGridView11 = new DataGridView();
            txtArama = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).BeginInit();
            SuspendLayout();
            // 
            // dataGridView11
            // 
            dataGridView11.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView11.GridColor = SystemColors.ButtonFace;
            dataGridView11.Location = new Point(29, 71);
            dataGridView11.Margin = new Padding(3, 4, 3, 4);
            dataGridView11.Name = "dataGridView11";
            dataGridView11.RowHeadersWidth = 51;
            dataGridView11.RowTemplate.Height = 25;
            dataGridView11.Size = new Size(396, 527);
            dataGridView11.TabIndex = 0;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(57, 32);
            txtArama.Margin = new Padding(3, 4, 3, 4);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(114, 27);
            txtArama.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(178, 32);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 31);
            button1.TabIndex = 2;
            button1.Text = "ARA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MusteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(589, 600);
            Controls.Add(button1);
            Controls.Add(txtArama);
            Controls.Add(dataGridView11);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MusteriListele";
            Text = "MusteriListele";
            Load += MusteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView11;
        private TextBox txtArama;
        private Button button1;
    }
}