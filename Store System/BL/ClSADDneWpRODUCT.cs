using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Store_System.BL
{
    class ClSADDneWpRODUCT
    {
        string ID;
        int SG_ID;
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GETMAXPRODUCT", null);
            foreach (DataRow row in dt.Rows)
                 ID=row[0].ToString();
            return ID;    
        }
        public int get_SGID(string storedproc, string value)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[0].Value = value;
            dt = DAL.SelectData(storedproc, param);
            foreach (DataRow row in dt.Rows)
                SG_ID = Convert.ToInt32(row[0].ToString());
            return SG_ID;
        }

        public void ADD_product(int store_ID, string PRODUCT_NAME, int categore_ID,int Ptype_ID,  decimal buy_price, decimal sellS_price, decimal sellP_price, decimal min_price, int min_qty, int qty)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@PRODUCT_NAME", SqlDbType.VarChar, 50);
            param[0].Value = PRODUCT_NAME;
            param[1] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            param[1].Value = qty;
            param[2] = new SqlParameter("@buy_PRICE", SqlDbType.Money);
            param[2].Value = buy_price;
            param[3] = new SqlParameter("@SARALABIE_SECTORS", SqlDbType.Money);
            param[3].Value = sellP_price;
            param[4] = new SqlParameter("@SARALABIE_SENTENCE", SqlDbType.Money);
            param[4].Value = sellS_price;
            param[5] = new SqlParameter("@MINI_PRICE_TO_BUY", SqlDbType.Money);
            param[5].Value = min_qty;
            param[6] = new SqlParameter("@MINI_QTY", SqlDbType.Int);
            param[6].Value = min_qty;
            param[7] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[7].Value = categore_ID;
            param[8] = new SqlParameter("@STORE_ID", SqlDbType.Int);
            param[8].Value = store_ID;
            param[9] = new SqlParameter("@Ptype_ID", SqlDbType.Int);
            param[9].Value = Ptype_ID;

            DAL.Excutecommand("NInsertNewProduct", param);
            DAL.close();
        }
        public void update_product_INFO(int ID_PORDUCT, int store_ID, string PRODUCT_NAME, int categore_ID,int Ptype_ID, decimal buy_price, decimal sellS_price, decimal sellP_price, decimal min_price, int min_qty, int qty)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@PRODUCT_NAME", SqlDbType.VarChar, 50);
            param[0].Value = PRODUCT_NAME;
            param[1] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            param[1].Value = qty;
            param[2] = new SqlParameter("@buy_PRICE", SqlDbType.Money);
            param[2].Value = buy_price;
            param[3] = new SqlParameter("@SARALABIE_SECTORS", SqlDbType.Money);
            param[3].Value = sellP_price;
            param[4] = new SqlParameter("@SARALABIE_SENTENCE", SqlDbType.Money);
            param[4].Value = sellS_price;
            param[5] = new SqlParameter("@MINI_PRICE_TO_BUY", SqlDbType.Money);
            param[5].Value = min_qty;
            param[6] = new SqlParameter("@MINI_QTY", SqlDbType.Int);
            param[6].Value = min_qty;
            param[7] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[7].Value = categore_ID;
            param[8] = new SqlParameter("@STORE_ID", SqlDbType.Int);
            param[8].Value = store_ID;

            param[9] = new SqlParameter("@ID_PORDUCT", SqlDbType.Int);
            param[9].Value = ID_PORDUCT;
            param[10] = new SqlParameter("@Ptype_ID", SqlDbType.Int);
            param[10].Value = Ptype_ID;



            DAL.Excutecommand("update_product_INFO", param);
            DAL.close();
        }
        public DataTable SEARCH_CATEGORIES(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TMP", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_CAT", param);
            return dt;
        }   
       
    }
}
