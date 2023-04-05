<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" 
    
    CodeBehind="Caching.aspx.vb" Inherits="WebformsTraining_226972.Caching" %>
<%@ OutputCache Duration="10" VaryByParam="none"  %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%=DateTime.Now %>

    <uc1:WebUserControl1 runat="server" id="WebUserControl1" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderScripte" runat="server">
</asp:Content>
