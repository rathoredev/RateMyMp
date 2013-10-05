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
/// Summary description for AdminStateDAL
/// </summary>
public class AdminStateDAL
{

    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;
    SqlDataAdapter adapt;
    DataTable table;
    stateBO sbo = new stateBO();

    public DataTable load_states(int CountryId)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }

            adapt=new SqlDataAdapter("fetchState",care);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand.Parameters.AddWithValue("@countryId",CountryId);
            DataSet ds = new DataSet();
            adapt.Fill(ds,"tblState");
            adapt.Dispose();

            return ds.Tables["tblState"];
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
    public void StateIn(stateBO StateBO)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }

            cmd = new SqlCommand("StateIn", care);     
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stateName", StateBO.state);
            cmd.Parameters.AddWithValue("@noOfConstituency", StateBO.noOfConstituency);
            cmd.Parameters.AddWithValue("@countryId", StateBO.countryId);
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