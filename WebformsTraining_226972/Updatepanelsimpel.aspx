<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Updatepanelsimpel.aspx.vb" Inherits="WebformsTraining_226972.Updatepanelsimpel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"/>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
