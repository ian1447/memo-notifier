using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SAMPLE_MEMO_NOTIF.DAL
{
    public class ShowOfficesDal
    {
        public static DataTable showoffice()
        {
            using (LoginDal.Connection())
            {
                try
                {
                    LoginDal.conn.Open();
                    string query = "SELECT * FROM offices;";
                    MySqlDataAdapter data = new MySqlDataAdapter(query, LoginDal.conn);
                    DataTable db = new DataTable();
                    data.Fill(db);
                    LoginDal.conn.Close();
                    return db;
                }
                catch {
                    return null;
                }
            }

        }
    }
}
