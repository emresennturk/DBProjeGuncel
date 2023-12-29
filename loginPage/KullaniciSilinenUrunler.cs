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
    public partial class SilinenUrulerKullanici : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public SilinenUrulerKullanici()
        {
            InitializeComponent();
        }
        void SilinenUrunGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_SilinenUrunKayitlari", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView7.DataSource = dt;
            con.Close();
        }
        private void SilinenUrulerKullanici_Load(object sender, EventArgs e)
        {
            SilinenUrunGetir();
        }

        private void btnGeri2_Click(object sender, EventArgs e)
        {
            new UrunlerKullanici().Show();
            this.Close();
        }

        private void btnCikisYap2_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        
    }
}
