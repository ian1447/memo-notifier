using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace SAMPLE_MEMO_NOTIF.DAL
{
    class DataBaseLogin
    {
        public static MySqlConnection conn = null;

        public MySqlConnection Connection()
        {
            conn = new MySqlConnection("datasource=localhost;database=memo_notif;port=3306;password=password");
            return conn;
        }

        public bool isConnection
        {
            get
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
