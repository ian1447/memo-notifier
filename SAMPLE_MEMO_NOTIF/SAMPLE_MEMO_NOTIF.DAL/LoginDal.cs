using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using System.Threading;

namespace SAMPLE_MEMO_NOTIF.DAL
{
    public class LoginDal
    {
        public static MySqlConnection conn = null;
        public static string errormessage = string.Empty;
        public static MySqlConnection Connection()
        {
            conn = new MySqlConnection("datasource=192.168.13.44;database=memo_notif;port=3306;user=user101;password=user101");
            return conn;
        }

        public static bool isConnection = false;

        public static void TryConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    isConnection = true;
                }
            }
            catch (Exception ex)
            {
                errormessage = ex.Message;
            }
        }

        public static string GetUserDataError = string.Empty;
        public static bool GetUserDataSuccessful = false;
        public static bool isadmin = false;
        public static int n;
        public static DataTable GetUserData(string Username, string Password)
        {
            Thread.Sleep(2000);
            DataSet dt = new DataSet();
            try {
                using (Connection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_login",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_username", Username));
                    cmd.Parameters.Add(new MySqlParameter("_password", Password));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    conn.Close();
                    GetUserDataSuccessful=true;
                    //errormessage = dt.Tables[0].Rows[0][3].ToString();
                    if (dt.Tables[0].Rows[0][3].ToString() == "Y")
                        isadmin = true;
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        return dt.Tables[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            } catch (Exception ex)
            {
                GetUserDataError = ex.Message + "\n Function:  GetUsersData";
                return null;
            }

        }

    }
}
