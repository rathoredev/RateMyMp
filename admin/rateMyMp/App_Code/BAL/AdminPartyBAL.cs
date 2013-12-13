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
using rateMyMp.App_Code.BO;
/// <summary>
/// Summary description for AdminPartyBAL
/// </summary>
public class AdminPartyBAL
{
    AdminPartyDAL partyDAL = new AdminPartyDAL();
    public DataTable load_party(int CountryId)
    {
        try
        {
            return partyDAL.load_party(CountryId);
        }
        catch
        {
            throw;
        }
        finally { }

    }



    public void partyIn(partyBO PartyBO)
    {
        try
        {
            partyDAL.partyIn(PartyBO);
        }
        catch
        {
            throw;
        }
        finally { }

    }
	
}