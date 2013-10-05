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
public partial class admin_addParty : System.Web.UI.Page
{
    countryBAL CountryBAL = new countryBAL();
    partyBO PartyBO = new partyBO();
    AdminPartyBAL partyBAL = new AdminPartyBAL();

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
        PartyBO.partyName = txtParty.Text;
        PartyBO.totalMember = int.Parse(txtTotMembers.Text);
        PartyBO.abbreviation = txtabbr.Text;
        PartyBO.countryId = int.Parse(dropCountry.SelectedValue.ToString());
        partyBAL.partyIn(PartyBO);

    }
}