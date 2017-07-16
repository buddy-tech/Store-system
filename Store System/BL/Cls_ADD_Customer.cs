using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class Cls_ADD_Customer
    {
        string ID;
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GETMAXCustomerID", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
        public void ADD_Customer(string Customer_NAME, string Address, string Phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Customer_NAME", SqlDbType.VarChar, 50);
            param[0].Value = Customer_NAME;
            param[1] = new SqlParameter("@Customer_Address", SqlDbType.VarChar,50);
            param[1].Value = Address;
            param[2] = new SqlParameter("@Customer_Phone", SqlDbType.VarChar,50);
            param[2].Value = Phone;
            DAL.Excutecommand("NInsertNewCustomer", param);
            DAL.close();
        }
        public void update_Customer_INFO(int ID_Customer, string Customer_NAME, string Address, string Phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID_Customer", SqlDbType.Int);
            param[0].Value = ID_Customer;
            param[1] = new SqlParameter("@Customer_NAME", SqlDbType.VarChar, 50);
            param[1].Value = Customer_NAME;
            param[2] = new SqlParameter("@Address", SqlDbType.VarChar, 50);
            param[2].Value = Address;
            param[3] = new SqlParameter("@Phone", SqlDbType.VarChar, 50);
            param[3].Value = Phone;

            DAL.Excutecommand("update_Customer_INFO", param);
            DAL.close();
        }


    }
}
