using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace ClientInformationDL
{
    public class Utils
    {                

        public DataSet ExecuteDataSet(string cmdText, string sqlConString) {
            DataSet ds = new DataSet();
            SqlConnection sqlCon = new SqlConnection(sqlConString);

            try
            {                
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlCon);
                sqlCommand.CommandType = CommandType.Text;
                SqlDataAdapter sqlAdap = new SqlDataAdapter(sqlCommand);
                sqlAdap.Fill(ds);
            }
            catch (Exception ex)
            {
                return ds;
            }
            finally {
                sqlCon.Close();
                sqlCon.Dispose();
            }
          
            return ds;
        }

        public int ExecuteScalar(string cmdText, string sqlConString) {
            int ReturnID = 0;
            SqlConnection sqlCon = new SqlConnection(sqlConString);
            try
            {                
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlCon);
                sqlCommand.CommandType = CommandType.Text;

                ReturnID =  Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception)
            {
                return ReturnID;
            }
            finally {
                sqlCon.Close();
                sqlCon.Dispose();
            }
            return ReturnID;

        }


       
      

    }
}
