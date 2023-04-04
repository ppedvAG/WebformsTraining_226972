<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GridviewModelbinding.aspx.vb" Inherits="WebformsTraining_226972.GridviewModelbinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server"
       ItemType="WebformsTraining_226972.Customers"
        SelectMethod="GridView1_GetData"
        UpdateMethod="GridView1_UpdateItem"
        DeleteMethod="GridView1_DeleteItem"
        ></asp:GridView>

</asp:Content>
