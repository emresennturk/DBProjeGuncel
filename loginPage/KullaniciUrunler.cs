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
    public partial class UrunlerKullanici : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public UrunlerKullanici()
        {
            InitializeComponent();
        }
        void UrunGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Urun", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            con.Close();

        }
        void KategoriGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT KategoriID,KategoriAd FROM tbl_Kategori", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "KategoriAd";
            comboBox2.ValueMember = "KategoriID";
            con.Close();
        }
        void KampanyaGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT KampanyaID,KampyaAd FROM tbl_Kampanya", con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "KampyaAd";
            comboBox1.ValueMember = "KampanyaID";
            con.Close();
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            int secilenKampanyaID = (int)comboBox1.SelectedValue;
            int secilenKategoriID = (int)comboBox2.SelectedValue;
            string sorgu = "INSERT INTO tbl_Urun(UrunAd,Stok,UrunFiyat,Marka,Aciklama,KategoriID,Renk,KampanyaID) VALUES (@UrunAd,@Stok,@UrunFiyat,@Marka,@Aciklama,@KategoriID,@Renk,@KampanyaID)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@UrunAd", txtUrunAd2.Text);
            cmd.Parameters.AddWithValue("@Stok", txtStok2.Text);
            cmd.Parameters.AddWithValue("@UrunFiyat", txtFiyat2.Text);
            cmd.Parameters.AddWithValue("@Renk", txtRenk2.Text);
            cmd.Parameters.AddWithValue("@Marka", txtMarka2.Text);
            cmd.Parameters.AddWithValue("@Aciklama", txtAciklama2.Text);
            cmd.Parameters.AddWithValue("@KategoriID", secilenKategoriID);
            cmd.Parameters.AddWithValue("@KampanyaID", secilenKampanyaID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            UrunGetir();
        }
        private void btnSil2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_Urun WHERE UrunID=@UrunID";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@UrunID", Convert.ToInt32(txtSilmeID2.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            UrunGetir();
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tbl_Urun SET Stok=@Stok WHERE UrunID=@UrunID";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@Stok", txtStokGuncelle2.Text);
            cmd.Parameters.AddWithValue("@UrunID", txtID2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            UrunGetir();
        }
        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID2.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            txtStokGuncelle2.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string UrunAd = txtArama2.Text.Trim();

            using (SqlConnection con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UrunArama", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreyi ekleyin
                    cmd.Parameters.AddWithValue("@UrunAd", UrunAd);

                    // DataTable oluşturun ve SqlDataAdapter kullanarak verileri doldurun
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // DataGridView'a DataTable'ı bağlayın
                    dataGridView5.DataSource = dt;
                }
            }

            // Eğer arama yapılmışsa DataGridView'ı sırala
            if (!string.IsNullOrEmpty(UrunAd))
            {
                SortDataGridView();
            }
        }
        private void KategorileriComboBoxaEkle2()
        {
            con.Open();

            // Kategorileri çekmek için SQL sorgusu
            string sorgu = "SELECT KategoriID, KategoriAd FROM tbl_Kategori";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            // ComboBox'a verileri yükle
            cmbKategori2.DataSource = dt;
            cmbKategori2.DisplayMember = "KategoriAd";
            cmbKategori2.ValueMember = "KategoriID";


            con.Close();

        }
        private void cmbKategori2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded && cmbKategori2.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbKategori2.SelectedItem;
                int secilenKategoriID = Convert.ToInt32(drv["KategoriID"]);

                // DataGridView'ı güncellemek için stored procedure'ü çağır
                DataGridViewiGuncelle(secilenKategoriID);
            }
        }
        private void DataGridViewiGuncelle(int kategoriID)
        {

            try
            {

                // Stored procedure'ü çağırmak için SqlCommand kullanıyoruz
                SqlCommand komut = new SqlCommand("sp_KategoriyeGoreListeleme", con);
                komut.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz
                komut.Parameters.AddWithValue("@SecilenKategoriID", kategoriID);

                // Verileri çekmek için SqlDataAdapter kullanıyoruz
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // DataGridView'a verileri yüklüyoruz
                dataGridView5.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void SortDataGridView()
        {
            string selectedOption = cmbSiralamaOptions2.SelectedItem.ToString();

            if (dataGridView5.DataSource != null && dataGridView5.Rows.Count > 0)
            {
                DataView dv = new DataView((DataTable)dataGridView5.DataSource);

                // Seçeneklere göre uygun sıralamayı yap
                switch (selectedOption)
                {
                    case "Stok Bilgisi Çoktan Aza":
                        dv.Sort = "Stok ASC";
                        break;
                    case "Ürün Fiyatı Yüksekten Düşüğe":
                        dv.Sort = "UrunFiyat DESC";
                        break;
                    case "Ürün Fiyatı Düşükten Yükseğe":
                        dv.Sort = "UrunFiyat ASC";
                        break;
                }

                // Sıralama sonuçlarını DataGridView'a yükle
                dataGridView5.DataSource = dv.ToTable();
            }
        }
        private void FillComboBoxOptions2()
        {
            // ComboBox'a stored procedure isimlerini ekle
            cmbSiralamaOptions2.Items.Add("Stok Bilgisi Çoktan Aza");
            cmbSiralamaOptions2.Items.Add("Ürün Fiyatı Yüksekten Düşüğe");
            cmbSiralamaOptions2.Items.Add("Ürün Fiyatı Düşükten Yükseğe");


            // ComboBox'ın ilk seçeneğini belirle
            cmbSiralamaOptions2.SelectedIndex = 0;
            cmbSiralamaOptions2.SelectedIndexChanged += new System.EventHandler(this.cmbSiralamaOptions2_SelectedIndexChanged);

        }
        private void cmbSiralamaOptions2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            string selectedOption = cmbSiralamaOptions2.SelectedItem.ToString();

            string connectionString = "server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("", connection))
                {
                    // Seçeneklere göre uygun stored procedure'ı belirle
                    switch (selectedOption)
                    {
                        case "Stok Bilgisi Çoktan Aza":
                            command.CommandText = "sp_StokBilgisiniYuksektenAzSirala";
                            break;
                        case "Ürün Fiyatı Yüksekten Düşüğe":
                            command.CommandText = "sp_YuksektenDusuge";
                            break;
                        case "Ürün Fiyatı Düşükten Yükseğe":
                            command.CommandText = "DusuktenYuksege";
                            break;
                    }

                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView5.DataSource = dataTable;
                }
            }
        }
        private bool formLoaded = false;
        private void UrunlerKullanici_Load(object sender, EventArgs e)
        {
            UrunGetir();
            KategoriGetir();
            KampanyaGetir();
            FillComboBoxOptions2();
            KategorileriComboBoxaEkle2();
            formLoaded = true;
        }





        private void btnGeri_Click(object sender, EventArgs e)
        {
            new KullaniciMain().Show();
            this.Close();
        }

        private void btnCikis2_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SilinenUrulerKullanici().Show();
            this.Hide();
        }


    }
}
