using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    adminLoginBAL AdminLoginBAL = new adminLoginBAL();
    adminLoginBO AdminLoginBO = new adminLoginBO();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            AdminLoginBO.username = txtUser.Text;
            AdminLoginBO.password = txtPass.Text;

            if (AdminLoginBAL.AdminLoginCheck(AdminLoginBO) == true)
            {
                Session["adminUsername"] = txtUser.Text;
                Response.Redirect("Home.aspx", false);
            }
            else
            {
                lblMessage.Text = "Username or Password does not match";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
}