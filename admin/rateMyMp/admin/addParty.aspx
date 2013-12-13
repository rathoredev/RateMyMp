<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addParty.aspx.cs" Inherits="admin_addParty" MasterPageFile="~/admin/admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="cont">
        <div id="countr" class="cmn">
            <asp:Label ID="Label1" runat="server" Text="Select Country"></asp:Label> <br />

            <asp:DropDownList ID="dropCountry" runat="server" AppendDataBoundItems="True"  ></asp:DropDownList>
        </div>
                        <br /><br />

        <div id="party" class="cmn">
            <asp:Label ID="Label3" runat="server" Text="Enter Party Name Name"></asp:Label> <br />

            <asp:TextBox ID="txtParty" runat="server"></asp:TextBox>

                        <br /><br />
            <div id="Div2" class="cmn">
            <asp:Label ID="Label4" runat="server" Text="Abbreviation"></asp:Label> <br />

            <asp:TextBox ID="txtabbr" runat="server"></asp:TextBox>

            <br /><br />


            <div id="Div1" class="cmn">
            <asp:Label ID="Label2" runat="server" Text="Enter Total Number Of Members"></asp:Label> <br />

            <asp:TextBox ID="txtTotMembers" runat="server"></asp:TextBox>

            <br /><br />


        </div>
     
           <div id="btn"">
             <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" style="width: 37px" />

         </div>
     </div>
            </div>
        </div>
    
 


    </asp:Content>