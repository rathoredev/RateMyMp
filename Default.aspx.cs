using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Forms_Home : System.Web.UI.Page
{
    string fname;
    string lname;
    userMasterBO userMasterBO = new userMasterBO();
    userMasterBAL userMasterBAL = new userMasterBAL();

    //public string passemail
    //{
    //    get;
    //    set;
    //}

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["UserCookies"] != null)// checking wether there is active cookie for this user or not.
        {
            Response.Redirect("test.aspx");
        }
            if (Session["userEmail"] !=null)
            {
                Session.Abandon();
            }
    }
    protected void btnSingin_Click(object sender, EventArgs e)
    {
        string[] userdetails=new string[2];

        // here we will check user and  if user exist we will create session and then redirect to next page.
        userMasterBO.email = signinemail.Text;
        userMasterBO.password = signinPassword.Text;
        if (userMasterBO.email == "" || userMasterBO.password == "")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "userLoginCheck()", true);
        }
        else
        {
                userdetails= (userMasterBAL.checkUser(userMasterBO)); // if user is valid then it return the user information  email and guid
            if (userdetails[0]!="")
            {
                //here we will maintain cookies for remember me option

                if (chkRememberMe.Checked == true)
                { // here we will create the cookie
                    if (Request.Cookies["UserCookies"] == null)
                    {
                        Response.Cookies["UserCookies"].Value = userdetails[0];
                        Response.Cookies["UserCookies"].Expires = DateTime.Now.AddDays(1);
                    }
                }
                else
                {      //we will delete the cookie
                    if (Request.Cookies["UserCookies"]!=null)
                    {

                        Response.Cookies["UserCookies"].Expires = DateTime.Now.AddDays(-1);
                    }
                }

                //here we will maintain the session and then transfer to the second page.
                Session["userEmail"] = userdetails[0];
                Session["guid"] = userdetails[1]; //unique id for each user.
                Session["socialType"] = "local";
                Session["socialOrNot"] = 0; //HERE 0 MEANS LOCAL USER.
                ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "rightCredential()", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "WrongCredential()", true);
            }

        }
    }
    protected void btnSignup_Click(object sender, EventArgs e)
    {

        if (email.Text == "" || password.Text == "" || firstName.Text == "" || lastName.Text == "")
        {

            ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "userSignUpCheck()", true);

        }
        else
        {

            if (Session["userEmail"] == null)
            {
                Session["userEmail"] = email.Text;
                //here we will add first name and last name and put into username.
                fname = firstName.Text;
                lname = lastName.Text;
               
                Session["socialType"] = "local";
                Session["socialOrNot"] = 0; //HERE 0 MEANS LOCAL USER.
               

                //give code for insert
                //give the code to insert data into the usermaster table.
                userMasterBO.email = Session["userEmail"].ToString();
                userMasterBO.password = password.Text;
                userMasterBO.lastName = lname;
                userMasterBO.firstName = fname;
                userMasterBO.middleName = "";
                userMasterBO.socialNetwork = false;
                userMasterBO.status = true;
                userMasterBO.roleId = 3;  //3 for user , 2 for mp,1 for admin, 4  for moderator
                // userMasterBO.snTypeId = 0;
                HiddenField1.Value = userMasterBAL.insertUser(userMasterBO);

                if (HiddenField1.Value == "User Successfully Created.")
                {
                   
                     Session["guid"] = (userMasterBAL.getGuid(userMasterBO)).ToString();
                    ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "userCreated()", true);
                    // Response.Redirect("test.aspx", true);
                }
                else if (HiddenField1.Value == "User Already Exists.")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "userNotCreated()", true);
                }
                else if (HiddenField1.Value == "User Updated.")
                {
                    Session["guid"] = (userMasterBAL.getGuid(userMasterBO)).ToString();
                    ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "userUpdated()", true);
                }

            }
            else
            {

            }
        }
    }
}