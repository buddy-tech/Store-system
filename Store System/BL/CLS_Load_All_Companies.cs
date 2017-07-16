using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_Load_All_Companies
    {
        public DataTable LOAD_ALL_COM_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_COMtodgv", null);
            return dt;
        }
        //public DataTable SEARCH_CUT_NAME(string TMP)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@TMP", SqlDbType.VarChar, 50);
        //    param[0].Value = TMP;
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("SEARCH_COMNAME", param);
        //    return dt;
        //}
        public DataTable SEARCH_AllCUT_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TMP", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_COMNAME", param);
            return dt;
        }
        public void DELETE_COM(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_COM", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_COM", param);
            DAL.close();
        }

    }
}
