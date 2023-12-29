using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknolojiMagazasi
{
    public partial class Yedekle : Form
    {
        public Yedekle()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedeklenecek Yolu Belirtiniz";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)(*.*) |*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            Server dbServer = new Server(new ServerConnection(txtServer.Text));
            Backup dbBackup = new Backup();
            dbBackup.Action = BackupActionType.Database;
            dbBackup.Database = txtDatabase.Text;
            dbBackup.Devices.AddDevice(txtPath.Text, DeviceType.File);
            dbBackup.Initialize = false;
            dbBackup.Complete += DbBackup_Complete;
            dbBackup.SqlBackup(dbServer);
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Yedekleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSec2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Geri Yüklemek İstediğiniz Dosyayı Seçiniz";
            openFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)(*.*) |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath2.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                Server dbServer = new Server(new ServerConnection(txtServer2.Text));
                Restore dbRestore = new Restore();

                // Belirtilen .bak dosyasından geri yükleme yapılacak
                dbRestore.Devices.AddDevice(txtPath2.Text, DeviceType.File);

                dbRestore.Database = txtDatabase2.Text;
                dbRestore.Action = RestoreActionType.Database;
                dbServer.KillAllProcesses(txtDatabase2.Text);

                // Veritabanını offline duruma getir
                dbServer.Databases[txtDatabase2.Text].SetOffline();
                // Veritabanını kullanılamaz durumda (offline) bırak
                dbRestore.ReplaceDatabase = true;

                // Geri yükleme işlemi tamamlandığında bir olay ekleyin
                dbRestore.Complete += DbRestore_Complete;

                // Geri yükleme işlemi başlat
                Task.Run(() =>
                {
                    dbRestore.SqlRestore(dbServer);

                    // Tamamlanıncaya kadar bekleyin (isteğe bağlı)
                    dbRestore.Wait();

                    // Veritabanını online duruma getir
                    dbServer.Databases[txtDatabase2.Text].SetOnline();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geri yükleme işlemi başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Geri yükleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
