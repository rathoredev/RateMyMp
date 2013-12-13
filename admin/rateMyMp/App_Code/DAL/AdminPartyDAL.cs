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

/// <summary>
/// Summary description for AdminPartyDAL
/// </summary>
public class AdminPartyDAL
{

        SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;
    SqlDataAdapter adapt;
    partyBO PartyBO = new partyBO();

    public DataTable load_party(int CountryId)
    {


        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            adapt = new SqlDataAdapter("fetchparty", care);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand.Parameters.AddWithValue("@countryId",CountryId);
            DataSet ds = new DataSet();
            adapt.Fill(ds,"tblParty");
            adapt.Dispose();
            return ds.Tables["tblparty"];
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
    public void partyIn(partyBO PartyBO)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }


            cmd = new SqlCommand("partyIn",care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@party",PartyBO.partyName);
            cmd.Parameters.AddWithValue("@abbreviation",PartyBO.abbreviation);
            cmd.Parameters.AddWithValue("@totalMember", PartyBO.totalMember);
            cmd.Parameters.AddWithValue("@countryId", PartyBO.countryId);
            cmd.ExecuteNonQuery();



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
}