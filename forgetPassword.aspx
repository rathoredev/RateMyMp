<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgetPassword.aspx.cs" Inherits="Web_Forms_forgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script>
         (function (i, s, o, g, r, a, m) {
             i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                 (i[r].q = i[r].q || []).push(arguments)
             }, i[r].l = 1 * new Date(); a = s.createElement(o),
             m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
         })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

         ga('create', 'UA-44359262-1', 'venturepact.com');
         ga('send', 'pageview');

</script>
    <script>

        function information() {
            alert("Please look at your email id and use passcode  given in your email id to  reset new password yourself.");
        }
        function giveALLinfo()
        {
            alert("Please fill all the fields.");
        }
        function wrongCredential() {
            alert("Please enter the right passcode and password.");
        }

        function passwordUpdated() {
            alert("Password Successfully Updated. You will be redirected to Home page in 3 Seconds.");
            setTimeout("redirect()", 3000); // cal the redirect function after 3 seconds
           
        }
        function redirect() {
            document.location.href = "Default.aspx";
        }
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="emailid" runat="server" />
        <br /><br />
         Passcode  <asp:TextBox ID="txtPasscode" runat="server"></asp:TextBox><br />
         New Password  <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
        Confirm Password  <asp:TextBox ID="txtCPassword" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" /><br />
          <asp:Button ID="Button2" runat="server" Text="Cancel" />

    </div>
    </form>
   
      <script type="text/javascript">
          var _usersnapconfig = {
              apiKey: '4ad9c2d8-f944-4f85-adf1-2d118d7247ca',
              valign: 'bottom',
              halign: 'right',
              tools: ["pen", "highlight", "note"],
              lang: 'en',
              commentBox: true,
              emailBox: true
          };
          (function () {
              var s = document.createElement('script');
              s.type = 'text/javascript';
              s.async = true;
              s.src = '//api.usersnap.com/usersnap.js';
              var x = document.getElementsByTagName('head')[0];
              x.appendChild(s);
          })();
</script>
</body>
</html>
