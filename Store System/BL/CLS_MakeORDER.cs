using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_MakeORDER
    {
        DataTable dt;
        string SID;
        string ID;  
        public string GETID(string storedproc,string value)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[0].Value = value; 
            dt = DAL.SelectData(storedproc, param);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GETMAXORDERID", null);
            foreach (DataRow row in dt.Rows)
                SID = row[0].ToString();

            return SID;
        }
        public string fillIDOrderForPrint()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_lastorderForPrint", null);
            foreach (DataRow row in dt.Rows)
                SID = row[0].ToString();

            return SID;
        }
        public DataTable Load_Order_ForPrint(int Order_ID)
        {
            DataTable dt2;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = Order_ID;
            dt = DAL.SelectData("Load_OrderForPrint", param);
            dt2 = Load_OrderDetailsForPrint(Order_ID);
            dt.Merge(dt2);
            return dt;
        }


        public DataTable Load_OrderDetailsForPrint(int Order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = Order_ID;
            dt = DAL.SelectData("orderDetails_ForPrint", param);
            return dt;
        }


         public string fillCOMID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_MaxORDERCOM_ID", null);
            foreach (DataRow row in dt.Rows)
                SID = row[0].ToString();

            return SID;
        }
        
        public void save_OverAlltotalORDER(int ORDER_ID, decimal OverAlltotalORDER) 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ORDER_ID", SqlDbType.Int);
            param[0].Value = ORDER_ID;
            param[1] = new SqlParameter("@OverAlltotalORDER", SqlDbType.Money);
            param[1].Value = OverAlltotalORDER;
            DAL.Excutecommand("save_OverAlltotalORDER", param);
        }
        public void save_OverAlltotalORDERCOM(int ORDER_ID, decimal OverAlltotalORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ORDER_ID", SqlDbType.Int);
            param[0].Value = ORDER_ID;
            param[1] = new SqlParameter("@OverAlltotalORDER", SqlDbType.Money);
            param[1].Value = OverAlltotalORDER;
            DAL.Excutecommand("save_OverAlltotalORDERCOM", param);
        }



        public void ADD_Order(DateTime Date_Order, int Customer_ID, int  Order_Type,int User_typeID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            param[0].Value = Date_Order;
            param[1] = new SqlParameter("@Customer_ID ", SqlDbType.Int);
            param[1].Value = Customer_ID;
            param[2] = new SqlParameter("@Order_Type", SqlDbType.Int);
            param[2].Value = Order_Type;
            param[3] = new SqlParameter("@user_TypeID", SqlDbType.Int);
            param[3].Value = User_typeID;

            DAL.Excutecommand("insert_Order", param);
            DAL.close();
        }
        public void ADD_COM_Order(DateTime Date_Order, int Customer_ID, int Order_Type,int user_typeID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            param[0].Value = Date_Order;
            param[1] = new SqlParameter("@Customer_ID ", SqlDbType.Int);
            param[1].Value = Customer_ID;
            param[2] = new SqlParameter("@Order_Type", SqlDbType.Int);
            param[2].Value = Order_Type;
            param[3] = new SqlParameter("@user_TypeID", SqlDbType.Int);
            param[3].Value = user_typeID;
            DAL.Excutecommand("insert_COM_Order", param);
            DAL.close();
        }

        public void ADD_OrderDetails( int Order_type, int Product_ID,int ORDER_ID,int product_QTY ,decimal total_PProduct)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Order_type", SqlDbType.Int );
            param[0].Value = Order_type;
            param[1] = new SqlParameter("@Product_ID", SqlDbType.Int);
            param[1].Value = Product_ID;
            param[2] = new SqlParameter("@ORDER_ID", SqlDbType.Int);
            param[2].Value = ORDER_ID;
            param[3] = new SqlParameter("@product_QTY", SqlDbType.Int);
            param[3].Value = product_QTY;
            param[4] = new SqlParameter("@total_PProduct", SqlDbType.Decimal);
            param[4].Value = total_PProduct;

            DAL.Excutecommand("NInsertNewOrder_details", param);
            DAL.close();
        }
        public void ADD_COM_OrderDetails(int Order_type, int Product_ID, int ORDER_ID, int product_QTY, decimal total_PProduct)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Order_type", SqlDbType.Int);
            param[0].Value = Order_type;
            param[1] = new SqlParameter("@Product_ID", SqlDbType.Int);
            param[1].Value = Product_ID;
            param[2] = new SqlParameter("@ORDER_ID", SqlDbType.Int);
            param[2].Value = ORDER_ID;
            param[3] = new SqlParameter("@product_QTY", SqlDbType.Int);
            param[3].Value = product_QTY;
            param[4] = new SqlParameter("@total_PProduct", SqlDbType.Decimal);
            param[4].Value = total_PProduct;

            DAL.Excutecommand("ADD_COM_OrderDetails", param);
            DAL.close();
        }

        public void Update_MProduct_QTY(int Product_ID, int product_QTY,int type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Product_ID", SqlDbType.Int);
            param[0].Value = Product_ID;
            param[1] = new SqlParameter("@Old_QTY", SqlDbType.Int);
            param[1].Value = product_QTY;
            param[2] = new SqlParameter("@type", SqlDbType.Int);
            param[2].Value = type;
            DAL.Excutecommand("update_QTY", param);
            DAL.close();

        }
        public void Update_BProduct_QTY(int Product_ID, int Oldproduct_QTY, int Newproduct_QTY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Product_ID", SqlDbType.Int);
            param[0].Value = Product_ID;
            param[1] = new SqlParameter("@Old_QTY", SqlDbType.Int);
            param[1].Value = Oldproduct_QTY;
            param[2] = new SqlParameter("@New_QTY", SqlDbType.Int);
            param[2].Value = Newproduct_QTY;
            DAL.Excutecommand("updateQTY", param);
            DAL.close();

        }

        public void Update_OrderDetails(int Order_type, int Product_ID, int ORDER_ID, int product_QTY, decimal total_PProduct)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Order_type", SqlDbType.Int);
            param[0].Value = Order_type;
            param[1] = new SqlParameter("@Product_ID", SqlDbType.Int);
            param[1].Value = Product_ID;
            param[2] = new SqlParameter("@ORDER_ID", SqlDbType.Int);
            param[2].Value = ORDER_ID;
            param[3] = new SqlParameter("@product_QTY", SqlDbType.Int);
            param[3].Value = product_QTY;
            param[4] = new SqlParameter("@total_PProduct", SqlDbType.Decimal);
            param[4].Value = total_PProduct;

            DAL.Excutecommand("NupdateExistingOrder_details", param);
            DAL.close();
        }
        public void Update_COM_OrderDetails(int Order_type, int Product_ID, int ORDER_COM_ID, int product_QTY, decimal total_PProduct)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Order_type", SqlDbType.Int);
            param[0].Value = Order_type;
            param[1] = new SqlParameter("@Product_ID", SqlDbType.Int);
            param[1].Value = Product_ID;
            param[2] = new SqlParameter("@ORDER_COM_ID", SqlDbType.Int);
            param[2].Value = ORDER_COM_ID;
            param[3] = new SqlParameter("@product_QTY", SqlDbType.Int);
            param[3].Value = product_QTY;
            param[4] = new SqlParameter("@total_PProduct", SqlDbType.Decimal);
            param[4].Value = total_PProduct;

            DAL.Excutecommand("Update_COMOrderDetail", param);
            DAL.close();
        }

        public void DELETE_PinOrderDetails(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_PinOrderDetails", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_PinOrderDetails", param);
            DAL.close();
        }
        public void DELETE_PinCOM_OrderDetails(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_PinCOM_OrderDetails", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_PinCOM_OrderDetails", param);
            DAL.close();
        }

        public DataTable Load_AllOrderDetails_SOrderID(int Order_ID  )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = Order_ID;
            dt = DAL.SelectData("Load_AllOrderDetails_SOrderID", param);
            return dt;
        }
        public DataTable Load_AllOrderDetailsCOM_SOrderID(int Order_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = Order_ID;
            dt = DAL.SelectData("Load_AllOrderDetailsCOM_SOrderID", param);
            return dt;
        }

        public string  Load_ProductQTY( int product_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_ID", SqlDbType.Int);
            param[0].Value = product_ID;
            dt = DAL.SelectData("Load_ProductQTY", param);
            foreach (DataRow row in dt.Rows)
                SID = row[0].ToString();
            return SID;
        }

    }
}
