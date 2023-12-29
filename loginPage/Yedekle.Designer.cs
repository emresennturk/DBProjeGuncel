namespace TeknolojiMagazasi
{
    partial class Yedekle
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
            txtServer = new TextBox();
            txtDatabase = new TextBox();
            txtPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnYedekle = new Button();
            btnSec = new Button();
            saveFileDialog1 = new SaveFileDialog();
            txtServer2 = new TextBox();
            txtDatabase2 = new TextBox();
            txtPath2 = new TextBox();
            btnSec2 = new Button();
            btnRestore = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // txtServer
            // 
            txtServer.Location = new Point(107, 69);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(284, 27);
            txtServer.TabIndex = 0;
            txtServer.Text = ".";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(107, 114);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(284, 27);
            txtDatabase.TabIndex = 1;
            txtDatabase.Text = "dbTeknolojiMagaza";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(107, 167);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(245, 27);
            txtPath.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 72);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Server:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Veritabanı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 170);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Path:";
            // 
            // btnYedekle
            // 
            btnYedekle.Location = new Point(107, 231);
            btnYedekle.Name = "btnYedekle";
            btnYedekle.Size = new Size(113, 29);
            btnYedekle.TabIndex = 6;
            btnYedekle.Text = "Yedekle";
            btnYedekle.UseVisualStyleBackColor = true;
            btnYedekle.Click += btnYedekle_Click;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(370, 165);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(62, 29);
            btnSec.TabIndex = 7;
            btnSec.Text = "...";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // txtServer2
            // 
            txtServer2.Location = new Point(107, 317);
            txtServer2.Name = "txtServer2";
            txtServer2.Size = new Size(284, 27);
            txtServer2.TabIndex = 8;
            // 
            // txtDatabase2
            // 
            txtDatabase2.Location = new Point(107, 367);
            txtDatabase2.Name = "txtDatabase2";
            txtDatabase2.Size = new Size(284, 27);
            txtDatabase2.TabIndex = 9;
            // 
            // txtPath2
            // 
            txtPath2.Location = new Point(107, 419);
            txtPath2.Name = "txtPath2";
            txtPath2.Size = new Size(245, 27);
            txtPath2.TabIndex = 10;
            // 
            // btnSec2
            // 
            btnSec2.Location = new Point(370, 419);
            btnSec2.Name = "btnSec2";
            btnSec2.Size = new Size(62, 29);
            btnSec2.TabIndex = 11;
            btnSec2.Text = "...";
            btnSec2.UseVisualStyleBackColor = true;
            btnSec2.Click += btnSec2_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(107, 481);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(113, 29);
            btnRestore.TabIndex = 12;
            btnRestore.Text = "Yedekten Dön";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 422);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 13;
            label4.Text = "Path:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 370);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 14;
            label5.Text = "Veritabanı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 320);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 15;
            label6.Text = "Server:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Yedekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(481, 568);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnRestore);
            Controls.Add(btnSec2);
            Controls.Add(txtPath2);
            Controls.Add(txtDatabase2);
            Controls.Add(txtServer2);
            Controls.Add(btnSec);
            Controls.Add(btnYedekle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Controls.Add(txtDatabase);
            Controls.Add(txtServer);
            Name = "Yedekle";
            Text = "Yedekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServer;
        private TextBox txtDatabase;
        private TextBox txtPath;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnYedekle;
        private Button btnSec;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtServer2;
        private TextBox txtDatabase2;
        private TextBox txtPath2;
        private Button btnSec2;
        private Button btnRestore;
        private Label label4;
        private Label label5;
        private Label label6;
        private OpenFileDialog openFileDialog1;
    }
}