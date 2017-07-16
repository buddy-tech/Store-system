using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Store_System.BL
{
    class CLS_ADD_CAT
    {
        string ID;
        public void update_DGV(string name)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("update_categore", param);
        }
        public void DELETE_CATEGORIE(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("DELETE_CATEGORIEs", param);
            DAL.close();

        }
        public DataTable verify_categorieName(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[0].Value = name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("verify_categorieName", param);
            DAL.close();
            return dt;
        }
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_MAXCAT", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
        #region currentID
    
        public string CurrentID(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            param[0].Value = name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetCatID", param);
            DAL.close();
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
    }
	#endregion   
}

