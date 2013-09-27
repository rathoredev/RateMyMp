<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgetPassword.aspx.cs" Inherits="Web_Forms_forgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="emailid" runat="server" />
         Please look at your email id and use passcode  given in your email id to  reset new password yourself.<br /><br />
         Passcode  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
         New Password  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        Confirm Password  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Ok" /><br />
          <asp:Button ID="Button2" runat="server" Text="Cancel" />

    </div>
    </form>
   
</body>
</html>
