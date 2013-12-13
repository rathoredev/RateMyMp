<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addCountry.aspx.cs" Inherits="admin_addCountry" MasterPageFile="~/admin/admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div>
        <asp:Label ID="Label1" runat="server" Text="ENTER COUNTRY NAME"></asp:Label><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCountry" ErrorMessage="Enter A Country  Name" EnableClientScript="False"></asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <br />
</div>
    </asp:Content>