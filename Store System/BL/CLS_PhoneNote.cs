using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.BL
{
    class CLS_PhoneNote
    {
        string ID;
        public string fillID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GETMAXPhoneNoteID", null);
            foreach (DataRow row in dt.Rows)
                ID = row[0].ToString();
            return ID;
        }
        public void ADD_PhoneNote(string NAME,string Phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = NAME;
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = Phone;
            DAL.Excutecommand("NInsertNewPhonenote", param);
            DAL.close();
        }
        public void update_Phonenote_INFO(int ID, string NAME, string Phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[1].Value = NAME;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = Phone;

            DAL.Excutecommand("update_PhoneNote_INFO", param);
            DAL.close();
        }

        public DataTable SEARCH_Allphonenote_NAME(string TMP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@phonenote_NAME", SqlDbType.VarChar, 50);
            param[0].Value = TMP;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Search_All_phonenote", param);
            return dt;
        }
        public DataTable LOAD_ALL_Phonenote_todgv()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOAD_ALL_Phonenotetodgv", null);
            return dt;
        }
        public void DELETE_Phonenote(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Phonenote", SqlDbType.Int);
            param[0].Value = ID;
            DAL.Excutecommand("Delete_Phonenote", param);
            DAL.close();
        }



    }
}
