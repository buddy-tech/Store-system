using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Store_System.BL
{
    class CLS_LoadAll_customer
    {
        public DataTable LOAD_ALL_CUSTOMER_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_CUSTOMERtodgv", null);
            return dt;
        }
        //public DataTable SEARCH_CUT_NAME(string TMP)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@TMP", SqlDbType.VarChar, 50);
        //    param[0].Value = TMP;
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("SEARCH_CUT_NAME", param);
        //    return dt;
        //}
        public DataTable SEARCH_AllCUT_NAME(string TMP)
        {   
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CUT_NAME", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Search_All_Customer", param);
            return dt;
        }
        public void DELETE_Customer(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Customer", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_customer", param);
            DAL.close();
        }


    }
}
