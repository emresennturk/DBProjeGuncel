using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknolojiMagazasi;

namespace loginPage
{
    public partial class KullaniciMain : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public KullaniciMain()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Musteri", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }

        private void KullaniciMain_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                txtTc.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                txtAdres.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

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
        private void btnEkle2_Click(object sender, EventArgs e)
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

        private void btnSil2_Click(object sender, EventArgs e)
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

        private void btnGuncelle2_Click(object sender, EventArgs e)
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
        private void btnAra2_Click(object sender, EventArgs e)
        {
            string isimSoyad = txtIsimSoyad2.Text.Trim();

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
                    dataGridView2.DataSource = dt;
                }
            }
        }
        private void btnCikis2_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UrunlerKullanici().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SilinenMusteriler().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new KullaniciSatis().Show();
            this.Hide();
        }
    }
}
