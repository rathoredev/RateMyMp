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
/// Summary description for AdminDistrictBAL
/// </summary>
public class AdminDistrictBAL
{
    AdminDistrictDAL DistrictsDAL = new AdminDistrictDAL();



    public DataTable load_districts(Int16 stateId)
    {
        try
        {
            return DistrictsDAL.load_districts(stateId);
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