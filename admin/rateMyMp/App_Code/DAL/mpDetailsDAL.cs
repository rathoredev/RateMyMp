using System;
using System.Collections.Generic;

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
/// Summary description for mpDetailsDAL
/// </summary>
public class mpDetailsDAL
{

    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;
    SqlDataAdapter adap;
    DataSet set;
    DataTable table;

    

    public string registerMp(mpDetailsBO MpDetailsBO,userMasterBO UserMasterBO)
    {
        try
        {
            cmd = new SqlCommand("regMp", care);
            cmd.CommandType = CommandType.StoredProcedure;
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd.Parameters.AddWithValue("@email", UserMasterBO.email);
            cmd.Parameters.AddWithValue("@pasword",UserMasterBO.password);
            cmd.Parameters.AddWithValue("@roleId",UserMasterBO.roleId);
            cmd.Parameters.AddWithValue("@firstName",UserMasterBO.firstName);
            cmd.Parameters.AddWithValue("@middleName",UserMasterBO.middleName);
            cmd.Parameters.AddWithValue("@lastName",UserMasterBO.lastName);
            cmd.Parameters.AddWithValue("@socialNetwork",UserMasterBO.socialNetwork);
            cmd.Parameters.AddWithValue("@sntypeId",UserMasterBO.snTypeId);
            cmd.Parameters.AddWithValue("@status",UserMasterBO.status);
            cmd.Parameters.AddWithValue("@passcode",UserMasterBO.passcode);
            cmd.Parameters.AddWithValue("@profilePic",UserMasterBO.profilePic);
            cmd.Parameters.AddWithValue("@countryId", MpDetailsBO.countryId);
            cmd.Parameters.AddWithValue("@constituencyId", MpDetailsBO.constituencyId);
            cmd.Parameters.AddWithValue("@electedYear", MpDetailsBO.electedYear);
            cmd.Parameters.AddWithValue("@partyId", MpDetailsBO.partyId);
            cmd.Parameters.AddWithValue("@phone", MpDetailsBO.phone);
            cmd.Parameters.AddWithValue("@mobile", MpDetailsBO.mobile);
            cmd.Parameters.AddWithValue("@qualification", MpDetailsBO.qualification);
            cmd.Parameters.AddWithValue("@profession", MpDetailsBO.profession);
            cmd.Parameters.AddWithValue("@permenantAddr", MpDetailsBO.permenantAddress);
            cmd.Parameters.AddWithValue("@permenantDistId", MpDetailsBO.permenantDist);
            cmd.Parameters.AddWithValue("@permenantStateId", MpDetailsBO.permanentState);
            cmd.Parameters.AddWithValue("@CurrentAddr", MpDetailsBO.currentAddress);
            cmd.Parameters.AddWithValue("@currentDistId", MpDetailsBO.currentDistrictId);
            cmd.Parameters.AddWithValue("@currentStateId", MpDetailsBO.currentStateId);

            cmd.ExecuteNonQuery();
          
            return "done";
        }
        catch {
            throw;
        }
        finally {
            care.Close();
        }
    }


  





}