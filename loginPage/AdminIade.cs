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
    public partial class AdminIade : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public AdminIade()
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
            dataGridViewIade.DataSource = dt;
            con.Close();
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {

            string iadeSorgu = "INSERT INTO tbl_Iade(IadeTarih, SatisID) VALUES (@IadeTarih, @SatisID)";
            cmd = new SqlCommand(iadeSorgu, con);
            cmd.Parameters.AddWithValue("@IadeTarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@SatisID", Convert.ToString(txtSatisID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            IadeGetir();
        }
        private void AdminIade_Load(object sender, EventArgs e)
        {
            IadeGetir();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            new AdminSatis().Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }


    }
}
