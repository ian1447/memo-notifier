using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace SAMPLE_MEMO_NOTIF.DAL
{
    public class GetMemo
    {
        public static string ErrorMessage = string.Empty;

        public static DataTable fillTable()
        {
            using (LoginDal.Connection())
            {
                try
                {
                    LoginDal.conn.Open();

                    MySqlDataAdapter sqldata = new MySqlDataAdapter("sp_get_student_list",LoginDal.conn);
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
    }
}
