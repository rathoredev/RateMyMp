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

public partial class admin_regMp : System.Web.UI.Page
{
    mpDetailsBAL MpDetailsBAL = new mpDetailsBAL();
    mpDetailsBO MpDetailsBO = new mpDetailsBO();
    userMasterBO UserMasterBO = new userMasterBO();
    AdminDistrictBAL adminDistrictBAL = new AdminDistrictBAL();
    districtBO DistrictBO = new districtBO();
    countryBO CountryBO = new countryBO();
    countryBAL CountryBAL = new countryBAL();
    stateBO StateBO = new stateBO();
    AdminStateBAL stateBAL=new AdminStateBAL();
    AdminConstituencyBAL constituencyBAL = new AdminConstituencyBAL();

    

    SqlConnection care=new SqlConnection(ConfigurationManager.ConnectionStrings["trial"].ToString());
   

    int roleId, SnTypeId, Guid, CountryId, ConstituencyId, PartyId, PermDist, PermState, CurDist, CurState;


  

    protected void Page_Load(object sender, EventArgs e)
    {
        
        CountryBAL.load_country();
        
        dropcountry.Items.Clear();
        dropcountry.DataTextField = "country";
        dropcountry.DataValueField = "countryId";
        dropcountry.DataSource = (DataTable)(CountryBAL.load_country());
        dropcountry.DataBind();

        int yr;
        for (yr = 1970; yr <= DateTime.Now.Year; yr++)
        {
            dropelectedyear.Items.Add(yr.ToString());
        }
        
        
    }

    protected void btnreg_Click(object sender, EventArgs e)
    {

UserMasterBO.email=txtemail.Text.ToString();
UserMasterBO.password=txtpass.Text;

UserMasterBO.roleId=roleId;
UserMasterBO.firstName=txtfname.Text;
UserMasterBO.middleName=txtmname.Text;
UserMasterBO.lastName=txtlname.Text;
if (dropusenetwork.SelectedItem.Text == "Yes")
{
    UserMasterBO.socialNetwork = true;
    UserMasterBO.snTypeId = SnTypeId;
}
else
{
    UserMasterBO.socialNetwork = false;
    UserMasterBO.snTypeId = 0;
}


UserMasterBO.status = true;
UserMasterBO.passcode=Int16.Parse(txtpasscode.Text);
UserMasterBO.profilePic=FileUpload1.ToString();
MpDetailsBO.countryId=CountryId;
MpDetailsBO.constituencyId = Int16.Parse(ConstituencyId.ToString());
MpDetailsBO.electedYear = Int16.Parse(dropelectedyear.SelectedItem.ToString());
MpDetailsBO.partyId = byte.Parse(PartyId.ToString());
MpDetailsBO.phone = txtphone.Text;
MpDetailsBO.mobile = txtmobile.Text;
MpDetailsBO.qualification = txtqualification.Text;
MpDetailsBO.profession = txtprofession.Text;
MpDetailsBO.permenantAddress=txtperaddr.Text;
MpDetailsBO.permenantDist = byte.Parse(PermDist.ToString());
MpDetailsBO.permanentState=byte.Parse(PermState.ToString());
MpDetailsBO.currentAddress=txtcurraddr.Text;
MpDetailsBO.currentDistrictId =byte.Parse(CurDist.ToString());
MpDetailsBO.currentStateId = byte.Parse(CurState.ToString());


MpDetailsBAL.registerMp(MpDetailsBO,UserMasterBO);

    }


    /*

    //district
    public void load_districts()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchDist", care);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    dropcurdist.Items.Add(reader[0].ToString());
                    dropperdist.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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
    */

    

    /*
    //constituency

    public void load_constituency()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchDist", care);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    dropconstituency.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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


    //networks
    public void load_networks()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchSocialNetworks", care);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    dropnetwork.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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


    //roles
    public void load_roles()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchroles", care);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    droprole.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    //party
    public void load_party()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchparty", care);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    dropparty.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_country()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchcountry", care);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    dropcountry.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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




    //fetch id


    public void load_CurDistrictsId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchcurdist", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@currentDist",dropcurdist.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    PermDist = int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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


    public void load_PermDistrictsId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchpermDist", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@permenantDist", dropperdist.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    CurDist = int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_CurStateId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchcurstate", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@currentstate",dropcurstate.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    CurState = int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_PermStateId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchpermstate", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@permenantstate",dropperstate.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    dropcurstate.Items.Add(reader[0].ToString());
                    dropperstate.Items.Add(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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
    
    public void load_constituencyId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchconsti", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@constituency",dropconstituency.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    ConstituencyId = int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_networksId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchSocial", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@socialNetworkBit",dropnetwork.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    SnTypeId = int.Parse(reader[0].ToString());   
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_rolesId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchrole",care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@role", droprole.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    roleId = int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_partyId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchpartyId", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@party", dropparty.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    PartyId=int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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

    public void load_countryId()
    {
        try
        {
            if (care.State == ConnectionState.Closed)
            {
                care.Open();
            }
            cmd = new SqlCommand("fetchcountryid", care);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@country", dropcountry.SelectedItem.ToString());
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Write("Data Found Writing");
                while (reader.Read())
                {
                    CountryId = int.Parse(reader[0].ToString());
                }
            }

            else
            {
                Response.Write("No Data Found");
            }
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
     * */
    protected void dropcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        CountryId = int.Parse(dropcountry.SelectedItem.Value);
        Response.Write(CountryId);
        stateBAL.load_states(CountryId);
        dropperstate.Items.Clear();
        dropcurstate.Items.Clear();
        dropperstate.Items.Add("Permenant State");
        dropcurstate.Items.Add("Current State");
        dropperstate.DataSource = (DataTable)(stateBAL.load_states(CountryId));
        dropcurstate.DataSource = (DataTable)(stateBAL.load_states(CountryId));
        dropperstate.DataTextField = dropcurstate.DataTextField = "state";
        dropperstate.DataValueField = dropcurstate.DataValueField = "stateId";
        dropcurstate.DataBind();
        dropperstate.DataBind();


    }
    protected void dropperstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        Int16 stateId;
        stateId = Int16.Parse(dropperstate.SelectedItem.Value);
        adminDistrictBAL.load_districts(stateId);
        dropperdist.Items.Clear();
        dropperdist.Items.Add("District");
        dropperdist.DataSource = (DataTable)(adminDistrictBAL.load_districts(stateId));
        dropperdist.DataTextField = "districtName";
        dropperdist.DataValueField = "districtId";
        dropperdist.DataBind();

    }
    protected void dropcurstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        Int16 stateId;
        stateId = Int16.Parse(dropcurstate.SelectedValue);
        adminDistrictBAL.load_districts(stateId);
        dropcurdist.Items.Clear();
        dropcurdist.Items.Add("District");
        dropcurdist.DataSource = (DataTable)(adminDistrictBAL.load_districts(stateId));
        dropcurdist.DataTextField = "districtName";
        dropcurdist.DataValueField = "districtId";
        dropcurdist.DataBind();

        CountryId = int.Parse(dropcountry.SelectedValue.ToString());
        constituencyBAL.load_Constituency(CountryId,stateId);
        
    }
   
    protected void droprole_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write("hgjkgdb");
    }
    
}