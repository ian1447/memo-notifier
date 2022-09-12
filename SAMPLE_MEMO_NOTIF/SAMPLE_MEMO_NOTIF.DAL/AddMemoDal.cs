using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

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
    }
}
