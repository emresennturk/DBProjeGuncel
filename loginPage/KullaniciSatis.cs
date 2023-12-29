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
    public partial class KullaniciSatis : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        public KullaniciSatis()
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
            dataGridViewSatis2.DataSource = dt;
            con.Close();
        }
        
        private void KullaniciSatis_Load(object sender, EventArgs e)
        {
            SatisGetir();
            
        }
        private void btnSatisYap2_Click(object sender, EventArgs e)
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


        private void button2_Click(object sender, EventArgs e)
        {
            new MusteriListele().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new UrunListele().Show();
        }

        private void btnGeri3_Click(object sender, EventArgs e)
        {
            new KullaniciMain().Show();
            this.Close();
        }

        private void btnCikisYap3_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        private void btnIade2_Click(object sender, EventArgs e)
        {
            new KullaniciIade().Show();
            this.Hide();
        }
    }
}
