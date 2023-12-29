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
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using Microsoft.SqlServer.Management.Smo;

namespace TeknolojiMagazasi
{
    public partial class Urunler : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Urunler()
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
            dataGridView4.DataSource = dt;
            con.Close();

        }
        void KategoriGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT KategoriID,KategoriAd FROM tbl_Kategori", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "KategoriAd";
            comboBox1.ValueMember = "KategoriID";
            con.Close();
        }
        void KampanyaGetir()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT KampanyaID,KampyaAd FROM tbl_Kampanya", con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "KampyaAd";
            comboBox2.ValueMember = "KampanyaID";
            con.Close();
        }

        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtStokGuncelle.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();

        }
        private void btnEkle3_Click(object sender, EventArgs e)
        {
            int secilenKampanyaID = (int)comboBox2.SelectedValue;
            int secilenKategoriID = (int)comboBox1.SelectedValue;
            string sorgu = "INSERT INTO tbl_Urun(UrunAd,Stok,UrunFiyat,Marka,Aciklama,KategoriID,Renk,KampanyaID) VALUES (@UrunAd,@Stok,@UrunFiyat,@Marka,@Aciklama,@KategoriID,@Renk,@KampanyaID)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text);
            cmd.Parameters.AddWithValue("@Stok", txtStok.Text);
            cmd.Parameters.AddWithValue("@UrunFiyat", txtFiyat.Text);
            cmd.Parameters.AddWithValue("@Marka", txtMarka.Text);
            cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@Renk", txtRenk.Text);
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
            cmd.Parameters.AddWithValue("@UrunID", Convert.ToInt32(txtSilmeID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            UrunGetir();
        }

        private void btnStokGuncelle_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tbl_Urun SET Stok=@Stok WHERE UrunID=@UrunID";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@Stok", txtStokGuncelle.Text);
            cmd.Parameters.AddWithValue("@UrunID", txtID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            UrunGetir();

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string UrunAd = txtUrunAdi.Text.Trim();

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
                    dataGridView4.DataSource = dt;
                }
            }

            // Eğer arama yapılmışsa DataGridView'ı sırala
            if (!string.IsNullOrEmpty(UrunAd))
            {
                SortDataGridView();
            }
        }
        private void KategorileriComboBoxaEkle()
        {
            con.Open();

            // Kategorileri çekmek için SQL sorgusu
            string sorgu = "SELECT KategoriID, KategoriAd FROM tbl_Kategori";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            // ComboBox'a verileri yükle
            cmbKategori.DataSource = dt;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriID";


            con.Close();

        }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded && cmbKategori.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbKategori.SelectedItem;
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
                dataGridView4.DataSource = dt;
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
            string selectedOption = cmbSiralamaOptions.SelectedItem.ToString();

            if (dataGridView4.DataSource != null && dataGridView4.Rows.Count > 0)
            {
                DataView dv = new DataView((DataTable)dataGridView4.DataSource);

                // Seçeneklere göre uygun sıralamayı yapıyoruz
                switch (selectedOption)
                {
                    case "Stok Bilgisi Azdan Çoğa":
                        dv.Sort = "Stok ASC";
                        break;
                    case "Ürün Fiyatı Yüksekten Düşüğe":
                        dv.Sort = "UrunFiyat DESC";
                        break;
                    case "Ürün Fiyatı Düşükten Yükseğe":
                        dv.Sort = "UrunFiyat ASC";
                        break;
                }

                // Sıralama sonuçlarını DataGridView'a yüklüyoruz
                dataGridView4.DataSource = dv.ToTable();
            }
        }
        private void FillComboBoxOptions()
        {
            // ComboBox'a stored procedure isimlerini eklemeye yarayan kodlar
            cmbSiralamaOptions.Items.Add("Stok Bilgisi Azdan Çoğa");
            cmbSiralamaOptions.Items.Add("Ürün Fiyatı Yüksekten Düşüğe");
            cmbSiralamaOptions.Items.Add("Ürün Fiyatı Düşükten Yükseğe");


            // ComboBox'ın ilk seçeneğini belirleme
            cmbSiralamaOptions.SelectedIndex = 0;
            cmbSiralamaOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSiralamaOptions_SelectedIndexChanged);

        }

        private void cmbSiralamaOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            string selectedOption = cmbSiralamaOptions.SelectedItem.ToString();

            string connectionString = "server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("", connection))
                {
                    // Seçeneklere göre uygun stored procedure'ı belirle
                    switch (selectedOption)
                    {
                        case "Stok Bilgisi Azdan Çoğa":
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

                    dataGridView4.DataSource = dataTable;
                }
            }
        }
        //Raporu PDF olarak kaydetme
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("PDF dosyasının adını girin:", "Dosya Adı", "DataGridViewReport");

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Geçerli bir dosya adı girmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PDF dosyasını oluştur
            using (FileStream fs = new FileStream($"C:\\Rapor\\{fileName}.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();

                // Başlık ekle
                pdfDoc.Add(new Paragraph("DataGridView Report"));

                // DataGridView içeriği ekle
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Hücre değeri null değilse ekle
                        if (cell.Value != null)
                        {
                            pdfDoc.Add(new Paragraph(cell.Value.ToString()));
                        }
                        else
                        {
                            pdfDoc.Add(new Paragraph("")); // Hücre değeri null ise boş bir değer ekleyebilirsiniz.
                        }
                    }
                }

                pdfDoc.Close();
                fs.Close();
            }

            MessageBox.Show("PDF dosyası oluşturuldu.");
        }
        private bool formLoaded = false;
        private void Form5_Load(object sender, EventArgs e)
        {
            UrunGetir();
            KategoriGetir();
            KampanyaGetir();
            FillComboBoxOptions();
            KategorileriComboBoxaEkle();
            formLoaded = true;
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }

        private void btnCikis2_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        private void btnSilinenUrunler_Click(object sender, EventArgs e)
        {
            new SilinenUrunler().Show();
            this.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save As";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToTxtFile(dataGridView4, saveFileDialog.FileName);
                MessageBox.Show("Veriler başarıyla dosyaya yazıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToTxtFile(DataGridView dataGridView, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            sw.Write(dataGridView.Rows[i].Cells[j].Value);
                            if (j < dataGridView.Columns.Count - 1)
                                sw.Write("\t");
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //OpenFileDialog 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Text File";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportDataToDatabase(openFileDialog.FileName);
                MessageBox.Show("Veriler başarıyla veritabanına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ImportDataToDatabase(string filePath)
        {
            try
            {

                using (StreamReader sr = new StreamReader(filePath))
                {
                    //Daha sonra veritabanına bağlanması için gereken bilgileri giriyoruz.
                    using (SqlConnection connection = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
                    {
                        //Bağlantımızı sağlıyoruz.
                        connection.Open();

                        // Tabloya verileri eklemek için gerekli olan SQL komutunı burada giriyoruz.
                        string insertQuery = "INSERT INTO tbl_Urun(UrunAd,Stok,UrunFiyat,Marka,Aciklama,KategoriID,Renk,KampanyaID) VALUES (@UrunAd,@Stok,@UrunFiyat,@Marka,@Aciklama,@KategoriID,@Renk,@KampanyaID)"; // Sütun adlarını ve veri tiplerini güncelleyin

                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                string[] values = line.Split('\t');

                                // Parametreleri ayarlama işlemi yapıyoruz bu sayede verileri hangi coloumna kaydetmesi gerektiğini bilecek.
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@UrunAd", values[1]);
                                cmd.Parameters.AddWithValue("@Stok", values[2]);
                                cmd.Parameters.AddWithValue("@UrunFiyat", values[3]);
                                cmd.Parameters.AddWithValue("@Renk", values[4]);
                                cmd.Parameters.AddWithValue("@Marka", values[5]);
                                cmd.Parameters.AddWithValue("@Aciklama", values[6]);
                                cmd.Parameters.AddWithValue("@KategoriID", values[7]);
                                cmd.Parameters.AddWithValue("@KampanyaID", values[8]);

                                // Komutu çalıştır
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }



}
