using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace eksiParser
{
    class sqlite_baglanti
    {
        private SQLiteConnection sqlite;

        public sqlite_baglanti()
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            string dosyaYolu = System.IO.Path.GetDirectoryName(ass.Location);
            dosyaYolu.Replace("\\", "/");

            sqlite = new SQLiteConnection("Data Source="+dosyaYolu+"/EksiDB.db");

        }

        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata " + ex.ToString());
            }
            sqlite.Close();
            return dt;
        }

        public void sorguFonk(string sorgu)
        {
            SQLiteCommand cmd;
            sqlite.Open();  //Initiate connection to the db
            cmd = sqlite.CreateCommand();
            cmd.CommandText = sorgu;  //set the passed query
            cmd.ExecuteNonQuery();
            sqlite.Close();
            return;
        }
    }
}
