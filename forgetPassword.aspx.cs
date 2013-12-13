using System;
using System.Collections.Generic;
////
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;
using System.Web.Security;

public partial class Web_Forms_forgetPassword : System.Web.UI.Page
{
    userMasterBO userMasterBO = new userMasterBO();
    userMasterBAL userMasterBAL = new userMasterBAL();
    protected void Page_Load(object sender, EventArgs e)
    {

       
            emailid.Value = Request["email"].ToString();
            if (emailid.Value != "")
            {

                //check email first
                userMasterBO.email = emailid.Value;
                if (!IsPostBack)
                {
                bool valid = userMasterBAL.checkValidEmailToResetPassword(userMasterBO);

                if (valid == true)
                {

                    // first create the passcode here. to generate passcode  i have to write the storedprocedure

                    // now first check  passcode is null or not.


                    Random rnd = new Random();
                    int passcode = rnd.Next(00000000, 99999999);
                    userMasterBO.passcode = passcode;


                    //code to send email
                    MailMessage vMsg = new MailMessage();
                    MailAddress vFrom = new MailAddress("dhandrohit@gmail.com", "RATEmymp");
                    vMsg.From = vFrom;
                    vMsg.To.Add(emailid.Value); //This is a string which contains delimited :semicolons for multiple 
                    vMsg.Subject = "Passcode to reset Password in rateMyMp"; //This is the subject;
                    vMsg.Body = passcode.ToString(); //This is the message that needs to be passed.

                    //Create an object SMTPclient for relaying
                    // SmtpClient vSmtp = new SmtpClient();
                    SmtpClient vSmtp = new SmtpClient("smtp.gmail.com", 587);
                    vSmtp.Host = ConfigurationManager.AppSettings["SMTP"];
                    vSmtp.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["FROMEMAIL"], ConfigurationManager.AppSettings["FROMPWD"]);
                    //vSmtp.Credentials = new System.Net.NetworkCredential("lovelybatch", ConfigurationManager.AppSettings["FROMPWD"]);
                    vSmtp.EnableSsl = true;
                    vSmtp.Send(vMsg);

                    //now store same passcode in database under corresponding email address
                    bool success = userMasterBAL.insertPasscode(userMasterBO);
                    if (success == true)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "information()", true);
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
                }
            }
            else
            {
                //redirect to home page.
                Response.Redirect("Default.aspx");

            }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        // first check passcode is correct or not.
        if (txtPasscode.Text != "" && txtPassword.Text != "" && txtCPassword.Text != "")
        {
            if (txtPassword.Text == txtCPassword.Text)
            {
                userMasterBO.passcode = int.Parse(txtPasscode.Text);
                userMasterBO.password = txtPassword.Text;
                bool res = userMasterBAL.updatePassword(userMasterBO);
                if (res == true)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "passwordUpdated()", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "wrongCredential()", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "wrongCredential()", true); 
            }

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "giveALLinfo()", true);
        }
        

    }
}