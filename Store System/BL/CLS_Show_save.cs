using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_Show_save
    {
        string gcID;
        int ROrder;
        string ID;
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("PayMoney_ID", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }

        public string GETID(string storedproc, string value)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[0].Value = value;
            dt = DAL.SelectData(storedproc, param);
            foreach (DataRow row in dt.Rows)
                gcID = row[0].ToString();
            return gcID;
        }
        public int remainmoney_orderID(string storedproc, int value)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[0].Value = value;
            dt = DAL.SelectData(storedproc, param);
            foreach (DataRow row in dt.Rows)
                ROrder = Convert.ToInt32(row[0]);
            return ROrder;
        }

        public DataTable SEARCH_SaveIN_SpaceficDate(string storedproc,DateTime begin_date, DateTime end_date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@begin_date", SqlDbType.DateTime);
            param[0].Value = begin_date;
            param[1] = new SqlParameter("@end_date", SqlDbType.DateTime);
            param[1].Value = end_date;
            DataTable dt = new DataTable();
            dt = DAL.SelectData(storedproc, param);
            return dt;
        }
        public void Add_moneySaver_COM_INFO(int payedMoney_COM, int savemoneytype_ID, int usertyep_ID,DateTime date,int order_ID,int ordersavemoney_ID,decimal amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@payedMoney_COM", SqlDbType.Int);
            param[0].Value = payedMoney_COM;
            param[1] = new SqlParameter("@savemoneytype_ID", SqlDbType.Int);
            param[1].Value = savemoneytype_ID;
            param[2] = new SqlParameter("@usertyep_ID", SqlDbType.Int);
            param[2].Value = usertyep_ID;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[4].Value = order_ID;
            param[5] = new SqlParameter("@ordersavemoney_ID", SqlDbType.Int);
            param[5].Value = order_ID;
            param[6] = new SqlParameter("@amount", SqlDbType.Int);
            param[6].Value = amount;


            DAL.Excutecommand("NInsertNewMoney_COM_saver", param);
            DAL.close();
        }
        public void Add_moneySaver_Customer_INFO(int payedMoney_customer, int savemoneytype_ID, int usertyep_ID, DateTime date, int order_ID, int ordersavemoney_ID,decimal amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@payedMoney_customer", SqlDbType.Int);
            param[0].Value = payedMoney_customer;
            param[1] = new SqlParameter("@savemoneytype_ID", SqlDbType.Int);
            param[1].Value = savemoneytype_ID;
            param[2] = new SqlParameter("@usertyep_ID", SqlDbType.Int);
            param[2].Value = usertyep_ID;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@order_ID", SqlDbType.Int);  
            param[4].Value = order_ID;
            param[5] = new SqlParameter("@Ordersavemony_type_ID", SqlDbType.Int);
            param[5].Value = ordersavemoney_ID;
            param[6] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[6].Value = amount;

            DAL.Excutecommand("NInsertNewMoney_CUSTOMER_saver", param);
            DAL.close();
        }
        public void Add_moneySaver_Payed_INFO(int payedMoney_ID, int savemoneytype_ID, int usertyep_ID, DateTime date, int ordersavemoney_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@savemoneytype_ID", SqlDbType.Int);
            param[0].Value = savemoneytype_ID;
            param[1] = new SqlParameter("@usertyep_ID", SqlDbType.Int);
            param[1].Value = usertyep_ID;
            param[2] = new SqlParameter("@payedMoney_ID", SqlDbType.Int);
            param[2].Value = payedMoney_ID;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@ordersavemoney_type", SqlDbType.Int);
            param[4].Value =ordersavemoney_ID;

            DAL.Excutecommand("NInsertNewMoney_Payed_saver", param);
            DAL.close();
        }



        public void Add_Paymoney_INFO(string name,string pay_discription,decimal amount,DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar,50);
            param[0].Value = name;
            param[1] = new SqlParameter("@pay_discription", SqlDbType.VarChar, 50);
            param[1].Value = pay_discription;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            DAL.Excutecommand("NInsertPayMoney_INFO", param);
            DAL.close();
        }
        public void update_payedmoney_INFO(int payedmoney_ID,string name, string pay_discription, decimal amount, DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@pay_discription", SqlDbType.VarChar, 50);
            param[1].Value = pay_discription;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@payedmoney_ID", SqlDbType.DateTime);
            param[4].Value = payedmoney_ID;


            DAL.Excutecommand("UpdatePayMoney_INFO", param);
            DAL.close();
        }




    }
}
