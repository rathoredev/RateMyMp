<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addState.aspx.cs" Inherits="admin_addState" MasterPageFile="~/admin/admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

     <div id="cont">
        <div id="countr" class="cmn">
            <asp:Label ID="Label1" runat="server" Text="Select Country"></asp:Label><br />

            <asp:DropDownList ID="dropCountry" runat="server" ></asp:DropDownList>
        </div>


        <div id="stat" class="cmn">
            <asp:Label ID="Label2" runat="server" Text="Enter State"></asp:Label><br />

             <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
        </div>

         <div id="no" class="cmn">
            <asp:Label ID="Label3" runat="server" Text="No Of Constituency"></asp:Label><br />

             <asp:TextBox ID="txtNoConsti" runat="server"></asp:TextBox>
        </div>
         
         <div id="btn" class="cmn">
             <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

         </div>
    </div>
    

    </asp:Content>