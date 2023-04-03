<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="KundenListeSQL.aspx.vb" Inherits="WebformsTraining_226972.KundenListeSQL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <ul class="list-group">

   <%For Each item In kunden%>
        <li class="list-group-item"><h3><%=item.CompanyName %></h3>

            <%=item.CustomerID %> <%=item.OrderDate.Value.ToString("dd.MMM.yyyy") %> <%=item.Freight %>
        </li>
      <%  Next %>
    </ul>
 
</asp:Content>
