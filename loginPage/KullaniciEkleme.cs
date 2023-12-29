using loginPage;
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
    public partial class KullaniciAyar : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public KullaniciAyar()
        {
            InitializeComponent();
        }
        void KullaniciGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Kullanici ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();

        }

        private void KullaniciAyar_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void BtnEkle3_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tbl_Kullanici(KullaniciAd,Sifre) VALUES(@KullaniciAd,@Sifre)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@KullaniciAd", txtKullanici.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            KullaniciGetir();
        }

        private void btnSil3_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_Kullanici WHERE KullaniciID=@KullaniciID";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@KullaniciID", Convert.ToInt32(txtKullaniciID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            KullaniciGetir();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
            txtKullaniciID.Text = selectedRow.Cells["KullaniciID"].Value.ToString();
            txtKullanici.Text = selectedRow.Cells["KullaniciAd"].Value.ToString();
            txtSifre.Text = selectedRow.Cells["Sifre"].Value.ToString();



        }

        private void BtnGeri1_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Hide();
        }

        private void BtnCikis3_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }


    }
}