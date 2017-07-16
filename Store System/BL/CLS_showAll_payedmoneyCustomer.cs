using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_showAll_payedmoneyCustomer
    {
        public DataTable SEARCH_ALLCustomerOrders_todgv(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CUT_ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALLCustomerOrders_todgv", param);
            return dt;
        }
        public DataTable SEARCH_ALLpaymentmoneyFor_CustomerOrders_todgv(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CUT_ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALLpaymentmoneyFor_CustomerOrders_todgv", param);
            return dt;
        }

        public DataTable SEARCH_ALLCOMOrders_todgv(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CUT_ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALLCOMOrders_todgv", param);
            return dt;
        }
        public DataTable SEARCH_ALLpaymentmoneyFor_COMOrders_todgv(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CUT_ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALLpaymentmoneyFor_COMOrders_todgv", param);
            return dt;
        }

    }
}
