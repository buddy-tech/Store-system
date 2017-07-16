using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_Addpayedmoney_customer
    {
        string ID;
        string gcID;
        decimal remainMoney;
        string tOrder;
        decimal ROrder;
        public string GETID(string storedproc,string value)
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
        public string GETORDERID(string storedproc, decimal remainMoney)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@remainMoney", SqlDbType.Decimal);
            param[0].Value = remainMoney;
            dt = DAL.SelectData(storedproc, param);
            foreach (DataRow row in dt.Rows)
                gcID = row[0].ToString();
            return gcID;
        }
        public string fillIDCustomer()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_MAXID_payedmoney_Customer", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
        public string fillRemainMoneyCustomer(int customer_ID,int order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@customer_ID", SqlDbType.Int);
            param[0].Value = customer_ID;
            param[1] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[1].Value = order_ID;
            dt = DAL.SelectData("load_customerRemainmoney", param);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            if (ID == "")
            {
                param[0] = new SqlParameter("@customer_ID", SqlDbType.Int);
                param[0].Value = @customer_ID;
                param[1] = new SqlParameter("@order_ID", SqlDbType.Int);
                param[1].Value = order_ID;
                dt = DAL.SelectData("Load_totalmoneyCustomer", param);
                foreach (DataRow row in dt.Rows)
                    tOrder = row[0].ToString();
                return tOrder;
            }
            else
                return ID;
        }
        public string fillRemainMoneyCOM(int customer_ID,int order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@COM_ID", SqlDbType.Int);
            param[0].Value = @customer_ID;
            param[1] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[1].Value = order_ID;
            dt = DAL.SelectData("load_COMRemainmoney", param);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            if (ID == "")
            {
                param[0] = new SqlParameter("@customer_ID", SqlDbType.Int);
                param[0].Value = @customer_ID;
                param[1] = new SqlParameter("@order_ID", SqlDbType.Int);
                param[1].Value = order_ID;
                dt = DAL.SelectData("Load_totalmoneyCOM", param);
                foreach (DataRow row in dt.Rows)
                    tOrder = row[0].ToString();
                return tOrder;
            }
            else
                return ID;
        }


        public void ADD_Payedmoney_Customer(int Customer_ID,decimal Customer_payedmoney, DateTime date,int order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Customer_ID", SqlDbType.Int);
            param[0].Value = Customer_ID;
            param[1] = new SqlParameter("@Customer_payedmoney", SqlDbType.Decimal);
            param[1].Value = Customer_payedmoney;
            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[3].Value = order_ID;

            DAL.Excutecommand("NInsertNew_Payedmoney_Customer", param);
            DAL.close();
        }
        public void update_Payedmoney_Customer_INFO(int ID, int Customer_ID, decimal payedmoney, DateTime date, int order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@customer_ID", SqlDbType.Int);
            param[1].Value = Customer_ID;
            param[2] = new SqlParameter("@payed_money", SqlDbType.Decimal);
            param[2].Value = payedmoney;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[4].Value = order_ID;

            DAL.Excutecommand("update_payedmoneyCustomer_INFO", param);
            DAL.close();
        }
        public void update_RemainMoney_Customer_INFO(int Customer_ID,int order_ID, decimal Remain_money)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Customer_ID", SqlDbType.Int);
            param[0].Value = Customer_ID;
            param[1] = new SqlParameter("@Remain_money", SqlDbType.Decimal);
            param[1].Value = Remain_money;
            param[2] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[2].Value = order_ID;

            DAL.Excutecommand("Update_RemainmoneyCustomer", param);
            DAL.close();
        }
        //public void update_RemainMoney_COM_INFO(int Customer_ID, int order_ID, decimal Remain_money)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[3];
        //    param[0] = new SqlParameter("@Customer_ID", SqlDbType.Int);
        //    param[0].Value = Customer_ID;
        //    param[1] = new SqlParameter("@Remain_money", SqlDbType.Decimal);
        //    param[1].Value = Remain_money;
        //    param[2] = new SqlParameter("@orderCOM_ID", SqlDbType.Decimal);
        //    param[2].Value = order_ID;

        //    DAL.Excutecommand("Update_RemainmoneyCustomer", param);
        //    DAL.close();
        //}


        public string fillIDCOM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_MAXID_payedmoney_COM", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
        public void ADD_Payedmoney_COM(int COM_ID, decimal COM_payedmoney, DateTime date, int order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@COM_ID", SqlDbType.Int);
            param[0].Value = COM_ID;
            param[1] = new SqlParameter("@COM_payedmoney", SqlDbType.Decimal);
            param[1].Value = COM_payedmoney;
            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[3].Value = order_ID;

            DAL.Excutecommand("NInsertNew_Payedmoney_COM", param);
            DAL.close();
        }
        public void update_Payedmoney_COM_INFO(int ID, int Customer_ID, decimal payedmoney, DateTime date, int order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@com_ID", SqlDbType.Int);
            param[1].Value = Customer_ID;
            param[2] = new SqlParameter("@payed_money", SqlDbType.Decimal);
            param[2].Value = payedmoney;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@order_ID", SqlDbType.Int);
            param[4].Value = order_ID;

            DAL.Excutecommand("update_payedmoneyCOM_INFO", param);
            DAL.close();
        }



    }
}
