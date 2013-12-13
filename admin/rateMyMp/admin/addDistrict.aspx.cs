using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using rateMyMp.App_Code;
using System.Configuration;
public partial class addDistrict : System.Web.UI.Page
{

    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;
    countryBAL CountryBAL = new countryBAL();

  
    protected void Page_Load(object sender, EventArgs e)
    {
        CountryBAL.load_country();
        dropCountry.Items.Clear();
  
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("districtIn", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@distName", txtDistrict.Text);
            cmd.Parameters.AddWithValue("@stateName", dropState.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }

        finally
        {
            care.Close();
        }
    }
}