using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;





namespace loginPage
{
    public partial class LoginPage : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public LoginPage()
        {
            InitializeComponent();

            AcceptButton = lgnBtn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUser.Text;
            string sifre = txtPass.Text;
            using (SqlConnection con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SistemeGirisYap", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciAd", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    // OUTPUT parametresini tan�mlanmas�
                    SqlParameter outputParam = new SqlParameter("@KullaniciAdOut", SqlDbType.VarChar, 20);
                    outputParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParam);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    // OUTPUT parametresinin de�erinin al�nmas�
                    string kullaniciAdiOut = cmd.Parameters["@KullaniciAdOut"].Value.ToString();

                    // Tam olarak ayn� harf b�y�kl��� ve k���kl���nde kontrol
                    if (string.Equals(kullaniciAdiOut, "Admin", StringComparison.Ordinal))
                    {
                        MessageBox.Show("Giri� Ba�ar�l�");
                        new AdminMenu().Show();
                        this.Hide();
                    }
                    else if (!string.IsNullOrEmpty(kullaniciAdiOut))
                    {
                        MessageBox.Show("Giri� Ba�ar�l�");
                        new KullaniciMain().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� ad�n� ve �ifrenizi kontrol ediniz.");
                    }
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}