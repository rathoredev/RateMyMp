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
/// Summary description for AdminStateBAL
/// </summary>
public class AdminStateBAL
{
    AdminStateDAL StateDAL = new AdminStateDAL();

    public DataTable load_states(int CountryId)
    {
        try
        {
            return StateDAL.load_states(CountryId);
        }
        catch
        {
            throw;
        }
        finally
        {
        }
    }

    public void stateIn(stateBO StateBO)
    {
        try
        {
            StateDAL.StateIn(StateBO);
        }
        catch
        {
            throw;
        }
        finally
        {
        }
    }
    
}