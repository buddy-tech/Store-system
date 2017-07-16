using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Store_System.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconn;
        public DataAccessLayer()
        {
            sqlconn = new SqlConnection(@"Server=.\SQLEXPRESS; DataBase=Stroe_DB; Integrated Security=true");
        }
        //metheod to open the connection
        public void open()
        {
            if (sqlconn.State != ConnectionState.Open)
            {
                sqlconn.Open();
            }
        }
        public SqlConnection RetOpenConn()
        {
            sqlconn = new SqlConnection(@"Server=.\SQLEXPRESS; DataBase=Stroe_DB; Integrated Security=true");
            sqlconn.Open();
            return sqlconn;
        }

        //method to close the connection
        public void close()
        {
            if (sqlconn.State != ConnectionState.Closed)
            {
                sqlconn.Close();
            }
        }
        #region MyRegion
        //}
        //object temp;
        //public object Simple_select(string Query)
        //{
        //    using (SqlConnection conn = RetOpenConn())
        //    {
        //        int i = 0;
        //        SqlCommand cmd = new SqlCommand(Query, conn);
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            temp = rdr[i];
        //            i++;
        //        }
        //        return temp;
        //    }
 
        //}
        //method to read data from DataBase
        #endregion
        public DataTable SelectData(string StoredProcedure,SqlParameter[] param)
        {
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType=CommandType.StoredProcedure;
            sqlcommand.CommandText = StoredProcedure;
            sqlcommand.Connection = sqlconn;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcommand.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       

        //method to add,update,delete to database
        public void Excutecommand(string StoredProcedure, SqlParameter[] param)
        {
            open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = StoredProcedure;
            sqlcommand.Connection = sqlconn;

            if (param != null)
            {
                sqlcommand.Parameters.AddRange(param);
                
            }
            sqlcommand.ExecuteNonQuery();
        }

    }
}
