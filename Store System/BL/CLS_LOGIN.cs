using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_LOGIN
    {
        string ID;
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("load_userID", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }

        public DataTable LOGIN(string id, string PSW)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param =new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@PSW", SqlDbType.VarChar, 50);
            param[1].Value = PSW;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOGIN", param);
            return dt;

        }
        public DataTable ADD_users(string userName, string PSW, string user_type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@userName", SqlDbType.VarChar, 50);
            param[0].Value = userName;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = PSW;
            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = user_type;

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_Newusers", param);
            return dt;
        }
        public DataTable Update_users(int userID,string userName, string PSW, string user_type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@userName", SqlDbType.VarChar, 50);
            param[0].Value = userName;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = PSW;
            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = user_type;
            param[3] = new SqlParameter("@userID", SqlDbType.Int);
            param[3].Value = userID;

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Update_Existusers", param);
            return dt;
        }
        public void DELETE_user(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_user", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("DELETE_user", param);
            DAL.close();
        }

        public DataTable SEARCH_AllUSers_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Search_All_Users", param);
            return dt;
        }
        public DataTable LOAD_ALL_Users_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_Userstodgv", null);
            return dt;
        }
    

    }
}
