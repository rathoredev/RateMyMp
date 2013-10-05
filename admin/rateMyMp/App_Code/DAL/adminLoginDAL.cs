using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using rateMyMp.App_Code.BO;


    

    public class adminLoginDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader drd;
        string query;

        public bool AdminLoginCheck(adminLoginBO AdminLoginBO)
        {
            try
            {
                query = "SELECT * FROM adminLogin WHERE username=@username AND password=@password";
                cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@username", AdminLoginBO.username);
                cmd.Parameters.AddWithValue("@password", AdminLoginBO.password);
                drd = cmd.ExecuteReader();
                if (drd.HasRows)
                {
                    drd.Read();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void ChangePassword(adminLoginBO AdminLoginBO)
        {
            try
            {
                query = "UPDATE adminLogin SET password=@password WHERE username=@username";
                cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@username", AdminLoginBO.username);
                cmd.Parameters.AddWithValue("@password", AdminLoginBO.password);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
