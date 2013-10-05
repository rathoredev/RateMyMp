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

/// <summary>
/// Summary description for mpDetailsBAL
/// </summary>
public class mpDetailsBAL
{
    mpDetailsDAL MpDetailsDAL = new mpDetailsDAL();
    public string registerMp(mpDetailsBO MpDetailsBO,userMasterBO UserMasterBO)
    {
        try
        {
            return MpDetailsDAL.registerMp(MpDetailsBO, UserMasterBO);
        }
        catch
        {
            throw;
        }
        finally
        { }
    }
	
}