using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_allPayedmoney
    {

        public DataTable SEARCH_AllPayedmoney_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@payedmoney_NAME", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Search_All_payedmoney", param);
            return dt;
        }
        public DataTable LOAD_ALL_Payedmoney_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_Payedmoneytodgv", null);
            return dt;
        }
        public void DELETE_Payedmoney(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Payedmoney", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_Payedmoney", param);
            DAL.close();
        }




    }
}
