using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_STORE
    {
        string ID;
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_MAXID_STORE", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
       public DataTable get_all_store()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_dSTORE", null);
            DAL.close();
            return dt;
        }
       public void ADD_INFO_store(string name)
       {

           DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
           param[0].Value = name;
           DataTable dt = new DataTable();
           dt = DAL.SelectData("insert_NewSTORE", param);
       }
       public void DELETE_INFO_store(int ID)
       {
           DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@ID", SqlDbType.Int);
           param[0].Value = ID;
           DataTable dt = new DataTable();
           dt = DAL.SelectData("DELETE_storeINFO", param);
           DAL.close();
       }
       public void update_INFO_store(int ID,string NAME)
       {

           DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[1].Value = NAME;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("update_storeInfo", param);
       }
       
    }
}
