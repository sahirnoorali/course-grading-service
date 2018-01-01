using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace WebService
{
    public class DBHelper
    {
        SqlConnection connectionObj;
/*******************************************************************************************************************/
        public DBHelper()
        {
            connectionObj = new SqlConnection();
            connectionObj.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }//close ctor
/*******************************************************************************************************************/
        private void ConnectionOpen()
        {
            connectionObj.Open();
        }//close ConnectionOpen
/******************************************************************************************************************/
        private void ConnectionClose()
        {
            connectionObj.Close();
        }//close ConnectionClose
/******************************************************************************************************************/
        public bool ExecuteNonQuery(string query, DateTime? dt = null)
        {
            bool bReturn = false;
            try
            {
                ConnectionOpen();
                SqlCommand command = new SqlCommand(query, connectionObj);

                //If DateTime Passed - Add into the Command:
                if(dt.HasValue)
                    command.Parameters.AddWithValue("@date", dt);

                int count = command.ExecuteNonQuery();

                if (count > 0)
                    bReturn = true;
                else
                    bReturn = false;

                ConnectionClose();
            }//close try

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//close catch

            return bReturn;
        }//close ExecuteNonQuery
/******************************************************************************************************************/
        public int ExecuteScalar(string query)
        {
            int value = 0;
            try
            {
                ConnectionOpen();
                SqlCommand command = new SqlCommand(query, connectionObj);
                object obj = command.ExecuteScalar();
                
                if (obj != DBNull.Value)
                    value = Convert.ToInt32(obj);
                else
                    value = -1;
 
                ConnectionClose();
            }//close try

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                value = -1;
            }

            return value;
        }//close ExecuteScalar
/******************************************************************************************************************/
        public DataTable GetDataTable(string query)
        {
            try
            {
                DataTable dt = new DataTable("Table");
                ConnectionOpen();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionObj);
               
                adapter.Fill(dt);
                ConnectionClose();
                return dt;

            }//close try

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }//close catch

        }//close GetDataTable
/******************************************************************************************************************/
    }//close DBHelper
}//close namespace