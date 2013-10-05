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
/// Summary description for AdminConstituencyBAL
/// </summary>
public class AdminConstituencyBAL
{
    AdminConstituencyDAL constituencyDAL = new AdminConstituencyDAL();
    public DataTable load_Constituency(int CountryId,Int16 StateId)
    {
        try
        {
            return constituencyDAL.load_constituency(CountryId,StateId);
        }
        catch
        {
            throw;
        }
        finally
        {
        }
    }


    public void constituencyIn(constituencyBO ConstituencyBO)
    {
        constituencyDAL.constituencyIn(ConstituencyBO);
    }

}