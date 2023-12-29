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
    public partial class SilinenMusteriler : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public SilinenMusteriler()
        {
            InitializeComponent();
        }

        void SilinenMusteriGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_SilinenMusteriKayitlari", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSilinenMusteri.DataSource = dt;
            con.Close();
        }

        private void SilinenMusteriler_Load(object sender, EventArgs e)
        {
            SilinenMusteriGetir();
        }
    }
}
