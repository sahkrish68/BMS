using BloodManagementSystem.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodBankManagementSystem.DAL
{
    class loginDAL
    {
        //Create Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Connecting DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Check Login BAsed on Usename and Password
                string sql = "SELECT * FROM tbl_user WHERE user_name=@user_name AND password=@password";

                //Create SQL Command to Pass the value to SQL Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the value to SQL Query Using Parameters
                cmd.Parameters.AddWithValue("@user_name", l.username);
                cmd.Parameters.AddWithValue("@password", l.Password);

                //SQl Data Adapeter to Get the Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //DataTable to Hold the data from database temporarily
                DataTable dt = new DataTable();

                //Filld the data from adapter to dt
                adapter.Fill(dt);

                //Chekc whether user exists or not
                if (dt.Rows.Count > 0)
                {
                    //User Exists and Login Successful
                    isSuccess = true;
                }
                else
                {
                    //Login Failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exception Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
    }
}