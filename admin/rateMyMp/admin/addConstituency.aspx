<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addConstituency.aspx.cs" Inherits="addConstituency" MasterPageFile="~/admin/admin.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="cont">
        <div id="countr" class="cmn">
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Select Country"></asp:Label> <br />

            <asp:DropDownList ID="dropCountry" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="dropCountry_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br />
            <br />
        </div>


        <div id="stat" class="cmn">
            <asp:Label ID="Label2" runat="server" Text="Select State"></asp:Label> <br />

            <asp:DropDownList ID="dropState" runat="server"></asp:DropDownList>
            <br />
        </div>


        <div id="consti" class="cmn">
            <asp:Label ID="Label3" runat="server" Text="Enter Constituency Name"></asp:Label> 
            <br />

            <asp:TextBox ID="txtconstituency" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label4" runat="server" Text="Select Party"></asp:Label> <br />

            <asp:DropDownList ID="dropparty" runat="server"></asp:DropDownList>


            <br />


        </div>
     
           <div id="btn"">
             <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             

               </div>
     </div>
    
 


    </asp:Content>