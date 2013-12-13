using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for countryDAL
/// </summary>
public class countryDAL
{
    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlDataAdapter adapt;
    SqlCommand cmd;

    public void countryInsert(String countryName)
    {
        try
        {
            cmd = new SqlCommand("countryIn", care);
            care.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@countryName",countryName);
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


    public DataTable load_country()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            adapt = new SqlDataAdapter("fetchCountry", care);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adapt.Fill(ds, "tblCountry");
            adapt.Dispose();
            return ds.Tables["tblCountry"];
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