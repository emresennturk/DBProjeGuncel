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

namespace TeknolojiMagazasi
{
    public partial class Kampanya : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Kampanya()
        {
            InitializeComponent();
        }
        void KampanyaGetir()
        {
            conn = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Kampanya", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKampanya.DataSource = dt;
            conn.Close();
        }

        private void Kampanya_Load(object sender, EventArgs e)
        {
            KampanyaGetir();

        }

        private void dataGridViewKampanya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewKampanya.Rows[e.RowIndex];
            txtKampanyaAd.Text = dataGridViewKampanya.CurrentRow.Cells[1].Value.ToString();
            txtIndirimOran.Text = dataGridViewKampanya.CurrentRow.Cells[2].Value.ToString();
        }
        private void Temizle()
        {
            txtKampanyaID.Text = "";
            txtKampanyaAd.Text = "";
            txtIndirimOran.Text = "";
        }

        private void btnKampanyaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
                {
                    using (cmd = new SqlCommand("INSERT INTO tbl_Kampanya(KampyaAd,IndirimOran) VALUES (@KampyaAd,@IndirimOran)", conn))
                    {
                        cmd.Parameters.AddWithValue("@KampyaAd", txtKampanyaAd.Text);

                        cmd.Parameters.AddWithValue("@IndirimOran", Convert.ToDecimal(txtIndirimOran.Text));


                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                KampanyaGetir();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKampanyaSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_Kampanya WHERE KampanyaID=@KampanyaID";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@KampanyaID", Convert.ToInt32(txtKampanyaID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            KampanyaGetir();
            Temizle();
        }


    }
}
