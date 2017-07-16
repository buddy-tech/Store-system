using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_notification
    {
        public DataTable SEARCH_AllPnotification_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@pnotification_NAME", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Search_All_Pnotification", param);
            return dt;
        }
        public DataTable LOAD_ALL_Pnotification_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_Pnotificationtodgv", null);
            return dt;
        }
    
    }
}
