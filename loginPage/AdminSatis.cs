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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknolojiMagazasi
{
    public partial class AdminSatis : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public AdminSatis()
        {
            InitializeComponent();
        }



        void SatisGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Satis", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSatis.DataSource = dt;
            con.Close();
        }



        private void AdminSatis_Load(object sender, EventArgs e)
        {
            SatisGetir();

        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {

            string sorgu = "INSERT INTO tbl_Satis(MusteriTC,UrunID) VALUES (@MusteriTC,@UrunId)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@MusteriTc", txtMusteriTC.Text);
            cmd.Parameters.AddWithValue("@UrunID", txtUrunID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            SatisGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new UrunListele().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MusteriListele().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }


        private void btnIadeler_Click(object sender, EventArgs e)
        {
            new AdminIade().Show();
            this.Hide();
        }
    }
}
