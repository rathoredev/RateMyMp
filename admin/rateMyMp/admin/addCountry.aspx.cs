using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class admin_addCountry : System.Web.UI.Page
{
    countryBAL CountryBAL = new countryBAL();
    countryBO CountryBO = new countryBO();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            CountryBAL.countryInsert(txtCountry.Text);
        }
        catch(SqlException ex)
        {
            lblError.Text = ex.Message.ToString();
        }
        
    }
}