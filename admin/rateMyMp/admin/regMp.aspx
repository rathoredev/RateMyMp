<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regMp.aspx.cs" Inherits="admin_regMp" MasterPageFile="~/admin/admin.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="cont">
        <asp:Label CssClass="lbl" ID="fstName" runat="server" Text="First Name" Width="200px"></asp:Label>
        <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
        <br />
        <asp:Label CssClass="lbl" ID="MdlName" runat="server" Text="Middle Name" Width="200px"></asp:Label>
        <asp:TextBox ID="txtmname" runat="server"></asp:TextBox>
        <br/>
        
        <asp:Label CssClass="lbl" ID="lstName" runat="server" Text="Last Name" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
        <br/>
        <asp:Label CssClass="lbl" ID="email" runat="server" Text="E-Mail" Width="200px"></asp:Label>   
         <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        <br/>
        <asp:Label CssClass="lbl" ID="password" runat="server" Text="Password" Width="200px"></asp:Label> 
         <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
          <br/>
        <asp:Label CssClass="lbl" ID="role" runat="server" Text="Role" Width="200px"></asp:Label>
        <asp:DropDownList ID="droprole" runat="server" OnSelectedIndexChanged="droprole_SelectedIndexChanged" AutoPostBack="True" >
        </asp:DropDownList>
        
         <br/>
        <asp:Label CssClass="lbl" ID="socialNetworkBit" runat="server" Text="Using Any Social Network" Width="200px"></asp:Label>         
        <asp:DropDownList ID="dropusenetwork" runat="server">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>    

         <br/>
        <asp:Label CssClass="lbl" ID="socialNetType" runat="server" Text="Select Social Network" Width="200px"></asp:Label>
         <asp:DropDownList ID="dropnetwork" runat="server">
        </asp:DropDownList>

           <br/>
        <asp:Label CssClass="lbl" ID="status" runat="server" Text="Status" Width="200px"></asp:Label>   
         <asp:TextBox ID="txtstatus" runat="server"></asp:TextBox>

        <br/>
        <asp:Label CssClass="lbl" ID="passcode" runat="server" Text="Passcode" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtpasscode" runat="server"></asp:TextBox>

        <br/>
        <asp:Label CssClass="lbl" ID="profilepic" runat="server" Text="Upload A profile Pic" Width="200px"></asp:Label>   
        <asp:FileUpload ID="FileUpload1" runat="server" />
        
        <br/>
        <asp:Label CssClass="lbl" ID="country" runat="server" Text="Country" Width="200px"></asp:Label>   
        <asp:DropDownList ID="dropcountry" runat="server" OnSelectedIndexChanged="dropcountry_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>

        <br/>
        <asp:Label CssClass="lbl" ID="constituency" runat="server" Text="Constituency" Width="200px"></asp:Label>   
        <asp:DropDownList ID="dropconstituency" runat="server" AutoPostBack="True"></asp:DropDownList>

        <br/>
        
        
        <asp:Label CssClass="lbl" ID="electedYear" runat="server" Text="Elected Year" Width="200px"></asp:Label>  
        <asp:DropDownList ID="dropelectedyear" runat="server"></asp:DropDownList>

         <br/>
        <asp:Label CssClass="lbl" ID="party" runat="server" Text="Party" Width="200px"></asp:Label>  
        <asp:DropDownList ID="dropparty" runat="server"></asp:DropDownList>
        
         <br/>
        <asp:Label CssClass="lbl" ID="phone" runat="server" Text="Phone" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
        
        <br/>
        <asp:Label CssClass="lbl" ID="mobile" runat="server" Text="Mobile" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
        
        <br/>
        <asp:Label CssClass="lbl" ID="qualfication" runat="server" Text="Qualification" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtqualification" runat="server"></asp:TextBox>
        
        <br/>
        <asp:Label CssClass="lbl" ID="profession" runat="server" Text="Profession" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtprofession" runat="server"></asp:TextBox>
        
        <br/>
        <asp:Label CssClass="lbl" ID="permAddr" runat="server" Text="Permenant Address" Width="200px"></asp:Label>
        <asp:TextBox ID="txtperaddr" runat="server"></asp:TextBox>
        

         <br/>
        <asp:Label CssClass="lbl" ID="permState" runat="server" Text="Permenant State" Width="200px"></asp:Label>  
        <asp:DropDownList ID="dropperstate" runat="server" OnSelectedIndexChanged="dropperstate_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        

         <br/>
        <asp:Label CssClass="lbl" ID="permDist" runat="server" Text="Permenant District" Width="200px"></asp:Label>   
        <asp:DropDownList ID="dropperdist" runat="server" AutoPostBack="True"></asp:DropDownList>

       
         <br/>
        <asp:Label CssClass="lbl" ID="curAddr" runat="server" Text="Current Address" Width="200px"></asp:Label>   
        <asp:TextBox ID="txtcurraddr" runat="server"></asp:TextBox>


         <br/>
        <asp:Label CssClass="lbl" ID="curDist" runat="server" Text="Current State" Width="200px"></asp:Label>   
        <asp:DropDownList ID="dropcurstate" runat="server" OnSelectedIndexChanged="dropcurstate_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>

        
        <br/>
        <asp:Label CssClass="lbl" ID="curState" runat="server" Text="Current District" Width="200px"></asp:Label>  
        <asp:DropDownList ID="dropcurdist" runat="server" AutoPostBack="True"></asp:DropDownList>
        
        

        <br/>
        <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click" />
    
    </div>
   </asp:Content>