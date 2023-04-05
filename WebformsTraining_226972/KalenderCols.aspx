<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="KalenderCols.aspx.vb" Inherits="WebformsTraining_226972.KalenderCols" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-3">
            <h5>Artikel</h5>


            <asp:Repeater ID="Repeater1" runat="server"
                ItemType="WebformsTraining_226972.Customers"
                SelectMethod="Repeater1_GetData">
                <ItemTemplate>

                    <div style="height: 20px"><%#Item.CompanyName %></div>

                </ItemTemplate>


            </asp:Repeater>
        </div>
        <div class="col-9">
            <div class="row">

                <%For i = 1 To 12%>

                <div class='col'>
                    <h5><%= DateTime.Now.AddDays(i).ToString("ddd dd.") %></h5>
                    foreach db
                    filter datum und id
                      <div style="height: 20px"></div>

                </div>


                <%    Next %>
            </div>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderScripte" runat="server">
</asp:Content>
