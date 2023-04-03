<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="KundenTabelle.aspx.vb" Inherits="WebformsTraining_226972.KundenTabelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="Repeater1" runat="server"
        ItemType="WebformsTraining_226972.Customers"
        SelectMethod="Repeater1_GetData">
        <ItemTemplate>
            <%#Item.CompanyName %>
        </ItemTemplate>


    </asp:Repeater>

        https://github.com/drvic10k/bootstrap-sortable
</asp:Content>
