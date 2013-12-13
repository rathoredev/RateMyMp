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
/// Summary description for AdminDistrictDAL
/// </summary>
public class AdminDistrictDAL
{

    SqlConnection care = new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
    SqlCommand cmd;
    SqlDataReader reader;
    SqlDataAdapter adapt;
    DataTable table;


    districtBO district = new districtBO();

    //district
    public DataTable load_districts(Int16 stateId)
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }

            adapt = new SqlDataAdapter("fetchDist", care);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand.Parameters.AddWithValue("@stateId", stateId);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "tblDist");
            adapt.Dispose();
            return ds.Tables["tblDist"];
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