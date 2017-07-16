using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CSL_load_allORERS
    {
        public DataTable LOAD_ALL_Orders_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Load_allORDERS", null);
            return dt;
        }
        public DataTable LOAD_ALL_OrdersCOM_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Load_allORDERSCOM", null);
            return dt;
        }
        public DataTable LOAD_ALL_Ordersnotyetpayed_cusotmer_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Load_allOrdersNotyetpayed_customer", null);
            return dt;
        }
        public DataTable LOAD_ALL_Ordersnotyetpayed_COM_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Load_allOrdersNotyetpayed_COM", null);
            return dt;
        }


        public DataTable SEARCH_AllORDERS(string customer_Name, DateTime begin_date, DateTime end_date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@customer_Name", SqlDbType.VarChar, 50);
            param[0].Value = customer_Name;
            param[1] = new SqlParameter("@begin_date", SqlDbType.DateTime);
            param[1].Value = begin_date;
            param[2] = new SqlParameter("@end_date", SqlDbType.DateTime);
            param[2].Value = end_date;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("search_ALLorders", param);
            return dt;
        }
        public DataTable SEARCH_AllORDERSnotyetpayed_cusotmer(string customer_Name, DateTime begin_date, DateTime end_date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@customer_Name", SqlDbType.VarChar, 50);
            param[0].Value = customer_Name;
            param[1] = new SqlParameter("@begin_date", SqlDbType.DateTime);
            param[1].Value = begin_date;
            param[2] = new SqlParameter("@end_date", SqlDbType.DateTime);
            param[2].Value = end_date;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("search_ALLordersnotyetpayed_cusotmer", param);
            return dt;
        }
        public DataTable SEARCH_AllORDERSnotyetpayed_COM(string customer_Name, DateTime begin_date, DateTime end_date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@com_Name", SqlDbType.VarChar, 50);
            param[0].Value = customer_Name;
            param[1] = new SqlParameter("@begin_date", SqlDbType.DateTime);
            param[1].Value = begin_date;
            param[2] = new SqlParameter("@end_date", SqlDbType.DateTime);
            param[2].Value = end_date;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("search_ALLordersnotyetpayed_COM", param);
            return dt;
        }

        public DataTable SEARCH_AllORDERS_COM(string customer_Name,  DateTime begin_date,DateTime end_date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@com_Name", SqlDbType.VarChar, 50);
            param[0].Value = customer_Name;
            param[1] = new SqlParameter("@begin_date", SqlDbType.DateTime);
            param[1].Value = begin_date;
            param[2] = new SqlParameter("@end_date", SqlDbType.DateTime);
            param[2].Value = end_date;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("search_ALLorders_COM", param);
            return dt;
        }



    }
}
