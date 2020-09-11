using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using System.Configuration;

namespace JualBeli_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        #endregion

        #region Constructors
        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();

            //set connection string sesuai yang ada di App.Config
            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ConnectionString;

            //panggil method Connect
            Connect();
        }
        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "Server=" + pServer + ";Database=" + pDatabase + ";Uid=" + pUsername +
                               ";Pwd=" + pPassword + ";charset=utf8";

            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            //panggil method Connect
            Connect();

            UpdateAppConfig(strCon);
        }
        #endregion

        #region Methods
        public void Connect() {
            //jika connection sedang terbuka maka tutup dahulu
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public void UpdateAppConfig(string connString)
        {
            //Buka konfigurasi App.Config
            Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Set App.Config pada section yang telah dibuat sebelumnya
            myConfig.ConnectionStrings.ConnectionStrings["koneksiku"].ConnectionString = connString;

            //Simpan App.Config yang telah diupdate
            myConfig.Save(ConfigurationSaveMode.Modified, true);

            //Reload App.Config dengan pengaturan yang baru
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            c.ExecuteNonQuery();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();

            return hasil;
        }

        #endregion
    }
}
