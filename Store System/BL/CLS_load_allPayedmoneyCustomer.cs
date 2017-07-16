using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_load_allPayedmoneyCustomer
    {
        public DataTable LOAD_ALL_paytedmoneyCUSTOMER_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_paytedmoneyCUSTOMER_todgv", null);
            return dt;
        }
        public DataTable LOAD_ALL_paytedmoneyCOM_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_paytedmoneyCOM_todgv", null);
            return dt;
        }

        public DataTable SEARCH_AllCustomer_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@customer_name", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("search_payedmoney_customer", param);
            return dt;
        }
        public DataTable SEARCH_AllCOM_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@com_name", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("search_payedmoney_com", param);
            return dt;
        }

        public void Delete_Payedmoney_customer(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Payedmoney_Customer", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_Payedmoney_customer", param);
            DAL.close();
        }
        public void Delete_Payedmoney_com(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Payedmoney_COM", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_Payedmoney_com", param);
            DAL.close();
        }



    }
}
