using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

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
        public static int n;
        public static DataTable GetUserData(string Username, string Password)
        {
            DataSet dt = new DataSet();
            try {
                using (Connection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_login",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_Username", Username));
                    cmd.Parameters.Add(new MySqlParameter("_Password", Password));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    conn.Close();
                    GetUserDataSuccessful=true;
                    if (dt.Tables.Count > 0)
                    {
                        errormessage = Password;
                        return dt.Tables[0];
                    }
                    else
                        return null;
                }
            } catch (Exception ex)
            {
                GetUserDataError = ex.Message + "\n Function:  GetUsersData";
                return null;
            }

        }

    }
}
