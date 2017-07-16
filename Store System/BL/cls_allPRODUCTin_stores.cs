using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class cls_allPRODUCTin_stores
    {
        public DataTable SEARCH_CATEGORIES(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TMP", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_CATNAME", param);
            return dt;
        
        }
        public DataTable SEARCH_storeNAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TMP", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_storeNAME", param);
            return dt;
        }
        public DataTable SEARCH_ALL_PRODUCTtodgv(string STORE_name, string CAT_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@CAT_NAME", SqlDbType.VarChar, 50);
            param[0].Value = CAT_name;
            param[1] = new SqlParameter("@STORE_NAME", SqlDbType.VarChar, 50);
            param[1].Value = STORE_name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALL_PRODUCTtodgv", param);
            return dt;
        }
        public DataTable LOAD_ALL_PRODUCTtodgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_PRODUCTtodgv", null);
            return dt;
        }
        public void DELETE_products(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("DELETE_products", param);
            DAL.close();
        }


        public DataTable SEARCH_PRODUCTtodgv(string Product_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Product_NAME", SqlDbType.VarChar, 50);
            param[0].Value = Product_name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCHPRODUCTtodgv", param);
            return dt;
        }

    }
}
