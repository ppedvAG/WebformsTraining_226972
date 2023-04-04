<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Wochentage.aspx.vb" Inherits="WebformsTraining_226972.Wochentage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <ul class="list-group">
        <%For i = 1 To 7%>

    <li class='list-group-item <%=If(i > 5, "list-group-item-dark", "") %>'>
        <%= WeekdayName(i) %>
       
    </li>


    <%    Next %>
    </ul>

</asp:Content>
