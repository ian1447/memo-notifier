using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace SAMPLE_MEMO_NOTIF.DAL
{
    public class AddUserDal
    {
        public static bool isAddingSuccessful = false;
        public static string ErrorMessage = string.Empty;
        public static void AddingUsers(string username, string password)
        {
            try
            {
                DataSet dt = new DataSet();
                using (LoginDal.Connection())
                {
                    LoginDal.conn.Open();
                    MySqlCommand cmd_check = new MySqlCommand("sp_login", LoginDal.conn);
                    cmd_check.CommandType = CommandType.StoredProcedure;
                    cmd_check.Parameters.Add(new MySqlParameter("_username", username));
                    cmd_check.Parameters.Add(new MySqlParameter("_password", password));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd_check);
                    adp.Fill(dt);
                    if (dt.Tables[0].Rows.Count == 0)
                    {
                        MySqlCommand cmd = new MySqlCommand("sp_add_user", LoginDal.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("_username", username));
                        cmd.Parameters.Add(new MySqlParameter("_password", password));
                        cmd.ExecuteNonQuery();
                        LoginDal.conn.Close();
                        isAddingSuccessful = true;
                    }
                    else
                    {
                        ErrorMessage = "Username and Password already exists!!";
                        LoginDal.conn.Close();
                    }
                }
            } catch (Exception ex){
                LoginDal.conn.Close();
                ErrorMessage = ex.Message + "/n AddingUsers Function!";
            }
        }

        private static void Thread(int p)
        {
            throw new NotImplementedException();
        }
    }
}
