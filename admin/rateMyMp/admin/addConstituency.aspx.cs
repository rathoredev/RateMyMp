using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using rateMyMp.App_Code.BO;

public partial class addConstituency : System.Web.UI.Page
{
    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;


    AdminConstituencyBAL constituencyBAL = new AdminConstituencyBAL();
    AdminStateBAL stateBAL = new AdminStateBAL();
    constituencyBO constituencyBO = new constituencyBO();
    countryBAL CountryBAL = new countryBAL();
    AdminPartyBAL partyBAL=new AdminPartyBAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CountryBAL.load_country();
            dropCountry.Items.Clear();
            dropCountry.Items.Add("Select Country");
            dropCountry.DataSource = (DataTable)(CountryBAL.load_country());
            dropCountry.DataTextField = "country";
            dropCountry.DataValueField = "countryId";
            dropCountry.DataBind();
        }
        dropparty.Items.Add("Party");
        dropState.Items.Add("State");
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
       
        try
        {
            constituencyBO.constituency = txtconstituency.Text;
            constituencyBO.partyId = Int16.Parse(dropparty.SelectedValue.ToString());
            constituencyBO.StateId = byte.Parse(dropState.SelectedValue.ToString());
            constituencyBO.countryId = int.Parse((dropCountry.SelectedValue.ToString()));
            constituencyBAL.constituencyIn(constituencyBO);            
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
    protected void dropCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        //stateBAL.load_states(int.Parse(dropCountry.SelectedValue.ToString()));
        dropState.Items.Clear();
        dropState.Items.Add("State");
        dropState.DataSource = (DataTable)(stateBAL.load_states(int.Parse(dropCountry.SelectedValue.ToString())));
        dropState.DataTextField = "state";
        dropState.DataValueField = "stateId";
        dropState.DataBind();

        //partyBAL.load_party(int.Parse(dropCountry.SelectedValue.ToString()));
        dropparty.Items.Clear();
        dropparty.Items.Add("Party");
        dropparty.DataSource = (DataTable)(partyBAL.load_party(int.Parse(dropCountry.SelectedValue.ToString())));
        dropparty.Items.Add("Party");
        dropparty.DataTextField = "partyName";
        dropparty.DataValueField = "partyId";
        dropparty.DataBind();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      
        
    }
}