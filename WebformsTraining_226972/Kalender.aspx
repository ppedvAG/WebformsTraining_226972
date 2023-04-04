<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Kalender.aspx.vb" Inherits="WebformsTraining_226972.Kalender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">

        <%For i = 1 To 12%>

    <div  class='col'>
      <h3> <%= DateTime.Now.AddDays(i).ToString("ddd dd. MMM") %></h3> 
       
    </div>


    <%    Next %>
  
    </div>
</asp:Content>
