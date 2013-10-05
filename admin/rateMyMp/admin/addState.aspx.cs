using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using rateMyMp.App_Code.BO;

public partial class admin_addState : System.Web.UI.Page
{
    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;
    AdminStateBAL adminStateBAL = new AdminStateBAL();
    stateBO StateBO = new stateBO();
    countryBAL CountryBAL = new countryBAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CountryBAL.load_country();
            dropCountry.Items.Clear();
            dropCountry.DataSource = (DataTable)(CountryBAL.load_country());
            dropCountry.DataTextField = "country";
            dropCountry.DataValueField = "countryId";
            dropCountry.DataBind();
        }
        

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        StateBO.countryId = int.Parse(dropCountry.SelectedValue.ToString());
        StateBO.noOfConstituency = byte.Parse(txtNoConsti.Text);
        StateBO.state = txtstate.Text;        
        adminStateBAL.stateIn(StateBO);
    }
    
 
}