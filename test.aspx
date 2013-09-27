<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="Web_Forms_test" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <!-- script to logout from  google session  -->
    <script>
        function logout() {

            document.location.href = " https://www.google.com/accounts/Logout?continue=https://appengine.google.com/_ah/logout?continue=http://localhost:2203/Default.aspx";
        }

    </script> 

    <!-- script to logout from facebook session -->
   <script type="text/javascript" src="/JS/fb.js"></script>
    <script>
        //Load the SDK Asynchronously
        (function (d) {
            var js, id = 'facebook-jssdk', ref = d.getElementsByTagName('script')[0];
            if (d.getElementById(id)) { return; }
            js = d.createElement('script'); js.id = id; js.async = true;
            js.src = "//connect.facebook.net/en_US/all.js";
            ref.parentNode.insertBefore(js, ref);
        }(document));

        // Init the SDK upon load
        var fbl;
        window.fbAsyncInit = function () {
            fb1 = FB.init({
                appId: '421695167935164', // App ID 
                channelUrl: '//' + window.location.hostname + '/channel', // Path to your Channel File
                status: true, // check login status
                cookie: true, // enable cookies to allow the server to access the session
                xfbml: true  // parse XFBML
            });

            $("#Button2").click(function () {
                FB.logout(function () {
                     
                    window.location.reload();
                    document.location.href = "Default.aspx";

                });
            });


        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;Comming Soon.........<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="google logout" OnClick="Button1_Click" />
    &nbsp;
        <input id="Button2" type="button" value="facebook logout" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="local user logout" />
        </div>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>