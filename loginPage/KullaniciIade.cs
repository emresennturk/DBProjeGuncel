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
    public partial class KullaniciIade : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public KullaniciIade()
        {
            InitializeComponent();
        }
        void IadeGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Iade", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewIade2.DataSource = dt;
            con.Close();
        }
        private void KullaniciIade_Load(object sender, EventArgs e)
        {
            IadeGetir();
        }
        private void btnIadeEt2_Click(object sender, EventArgs e)
        {
            string iadeSorgu = "INSERT INTO tbl_Iade(IadeTarih, SatisID) VALUES (@IadeTarih, @SatisID)";
            cmd = new SqlCommand(iadeSorgu, con);
            cmd.Parameters.AddWithValue("@IadeTarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@SatisID", Convert.ToString(txtSatisID2.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            IadeGetir();
        }
        private void btnGeri4_Click(object sender, EventArgs e)
        {
            new KullaniciSatis().Show();
            this.Close();
        }

        private void btnCikisYap4_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }


    }
}
