using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace SAMPLE_MEMO_NOTIF.DAL
{
    public class AddMemoDal
    {
        public static string ErrorMessage = string.Empty;
        public static DataTable fillMemoTable()
        {
            using (LoginDal.Connection())
            {
                try
                {
                    LoginDal.conn.Open();

                    MySqlDataAdapter sqldata = new MySqlDataAdapter("sp_view_memos", LoginDal.conn);
                    DataTable dtbl = new DataTable();
                    sqldata.Fill(dtbl);
                    return dtbl;

                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.ToString() + "\n Function: View Memo";
                    return null;
                }
            }
        }

        public static string id_no= "1"; 
        public static bool isAddingSuccessful = false;
        public static void add_memo (string idno, string title, string particular, string addedby)
        {
            Thread.Sleep(2000);
            using (LoginDal.Connection())
            {
                try{
                    LoginDal.conn.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_memo_add",LoginDal.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_id", idno));
                    cmd.Parameters.Add(new MySqlParameter("_name", title));
                    cmd.Parameters.Add(new MySqlParameter("_description", particular));
                    cmd.Parameters.Add(new MySqlParameter("_user_id", addedby));
                    cmd.ExecuteNonQuery();
                    LoginDal.conn.Close();
                    isAddingSuccessful = true;
                }
                catch (Exception ex) {
                    ErrorMessage = ex.Message +"\nFunction: add_memo";
                }
            }
        }

        public static string GetUserDataError = string.Empty;
        public static DataTable CheckEdit(string idno)
        {
            //Thread.Sleep(2000);
            DataSet dt = new DataSet();
            try
            {
                using (LoginDal.Connection())
                {
                    LoginDal.conn.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_check_edit", LoginDal.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_idno", idno));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    LoginDal.conn.Close();
                    LoginDal.GetUserDataSuccessful = true;
                    if (dt.Tables[0].Rows.Count > 0)
                        return dt.Tables[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                GetUserDataError = ex.Message + "\n Function:  GetUsersData";
                return null;
            }
        }
    }
}
