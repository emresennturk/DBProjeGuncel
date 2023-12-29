using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TeknolojiMagazasi;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.VisualBasic;

namespace loginPage
{
    public partial class AdminMenu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public AdminMenu()
        {
            InitializeComponent();
        }
        //Bu metod ile DataGridView'a veri çekiyoruz
        void MusteriGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Musteri", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            MusteriGetir();

        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            new Urunler().Show();
            this.Hide();
        }
        //Gridviewdaki herhangi bir hücreye tıkladığımızda textboxları o satırdaki bilgiler ile doldurur.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
        }
        private void Temizle()
        {
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtAdres.Text = "";
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
                {
                    using (cmd = new SqlCommand("INSERT INTO tbl_Musteri(MusteriTc,MusteriAd,MusteriSoyad,Email,TelefonNo,Adres) VALUES (@MusteriTc,@MusteriAd,@MusteriSoyad,@Email,@TelefonNo,@Adres)", con))
                    {
                        cmd.Parameters.AddWithValue("@MusteriTc", txtTc.Text);
                        cmd.Parameters.AddWithValue("@MusteriAd", txtAd.Text);
                        cmd.Parameters.AddWithValue("@MusteriSoyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@TelefonNo", txtTel.Text);
                        cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MusteriGetir();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
                {
                    using (cmd = new SqlCommand("DELETE FROM tbl_Musteri WHERE MusteriTc=@MusteriTc", con))
                    {
                        cmd.Parameters.AddWithValue("@MusteriTc", Convert.ToString(txtTc.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MusteriGetir();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
                {
                    using (cmd = new SqlCommand("UPDATE tbl_Musteri SET MusteriTc=@MusteriTc,MusteriAd=@MusteriAd,MusteriSoyad=@MusteriSoyad,Email=@Email,TelefonNo=@TelefonNo,Adres=@Adres WHERE MusteriTc=@MusteriTc", con))
                    {
                        cmd.Parameters.AddWithValue("@MusteriTc", txtTc.Text);
                        cmd.Parameters.AddWithValue("@MusteriAd", txtAd.Text);
                        cmd.Parameters.AddWithValue("@MusteriSoyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@TelefonNo", txtTel.Text);
                        cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MusteriGetir();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string isimSoyad = txtIsimSoyad.Text.Trim();

            using (SqlConnection con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_MusteriArama", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreyi ekleyin
                    cmd.Parameters.AddWithValue("@isimSoyad", isimSoyad);

                    // DataTable oluşturun ve SqlDataAdapter kullanarak verileri doldurun
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // DataGridView'a DataTable'ı bağlayın
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan dosyaya bir isim vermesini isteyen kod
            string fileName = Interaction.InputBox("PDF dosyasının adını girin:", "Dosya Adı", "DataGridViewReport");

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Geçerli bir dosya adı girmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PDF dosyasını oluşturma
            using (FileStream fs = new FileStream($"C:\\Rapor\\{fileName}.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();

                // Başlık ekleme
                pdfDoc.Add(new Paragraph("DataGridView Report"));

                // DataGridView içeriği eklenmesi
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfDoc.Add(new Paragraph(cell.Value.ToString()));
                    }
                }

                pdfDoc.Close();
                fs.Close();
            }

            MessageBox.Show("PDF dosyası oluşturuldu.");
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
            new KullaniciAyar().Show();
            this.Hide();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            new AdminSatis().Show();
            this.Hide();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            new Yedekle().Show();

        }

        private void btnSilinenMusteri_Click(object sender, EventArgs e)
        {
            new SilinenMusteriler().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Kampanya().Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

    }


}
