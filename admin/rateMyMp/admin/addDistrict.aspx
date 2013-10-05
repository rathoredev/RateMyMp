<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addDistrict.aspx.cs" Inherits="addDistrict" MasterPageFile="~/admin/admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="cont">
        <div id="countr" class="cmn">
            <asp:Label ID="Label1" runat="server" Text="Select Country"></asp:Label><br />

            <asp:DropDownList ID="dropCountry" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="dropCountry" EnableClientScript="False"></asp:RequiredFieldValidator>
        </div>


        <div id="stat" class="cmn">
            <asp:Label ID="Label2" runat="server" Text="Select State"></asp:Label><br />

            <asp:DropDownList ID="dropState" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="dropState" EnableClientScript="False"></asp:RequiredFieldValidator>
        </div>


        <div id="consti" class="cmn">
            <asp:Label ID="Label3" runat="server" Text="Enter District Name"></asp:Label><br />

            <asp:TextBox ID="txtDistrict" runat="server"></asp:TextBox>

           

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtDistrict" EnableClientScript="False"></asp:RequiredFieldValidator>

           

        </div>

        
    </div>
    <br />

     <div id="btn">
             <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

         </div>

    </asp:Content>