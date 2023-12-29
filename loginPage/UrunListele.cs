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
    public partial class UrunListele : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public UrunListele()
        {
            InitializeComponent();
        }
        void UrunGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT UrunID,UrunAd FROM tbl_Urun", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView10.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UrunListele_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            string UrunAd = txtUrunAra.Text.Trim();

            using (SqlConnection con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("UrunArama", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreyi ekleyin
                    cmd.Parameters.AddWithValue("@UrunAd", UrunAd);

                    // DataTable oluşturun ve SqlDataAdapter kullanarak verileri doldurun
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // DataGridView'a DataTable'ı bağlayın
                    dataGridView10.DataSource = dt;
                }
            }
        }
    }
}
