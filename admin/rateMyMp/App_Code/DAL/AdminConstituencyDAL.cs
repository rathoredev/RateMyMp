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
/// <summary>
/// Summary description for AdminConstituencyDAL
/// </summary>
public class AdminConstituencyDAL
{
    
    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    
    SqlDataAdapter adapt;
    
    stateBO sbo = new stateBO();
    public DataTable load_constituency(int CountryId,Int16 StateId)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }

            adapt = new SqlDataAdapter("fetchconstituency",care);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand.Parameters.AddWithValue("@CountryId",CountryId);
            adapt.SelectCommand.Parameters.AddWithValue("@stateId", StateId);
            DataSet ds = new DataSet();
            adapt.Fill(ds,"tblConstituency");
            adapt.Dispose();
            return ds.Tables["tblConstituency"];
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

    public void constituencyIn(constituencyBO ConstituencyBO)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("constituencyIn",care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@constituency",ConstituencyBO.constituency);
            cmd.Parameters.AddWithValue("@stateId", ConstituencyBO.StateId);
            cmd.Parameters.AddWithValue("countryId", ConstituencyBO.countryId);
            cmd.Parameters.AddWithValue("@partyId", ConstituencyBO.partyId);
            
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