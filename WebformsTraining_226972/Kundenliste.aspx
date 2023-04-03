<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Kundenliste.aspx.vb" Inherits="WebformsTraining_226972.Kundenliste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <table class="table">

        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Name</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server"
                ItemType="WebformsTraining_226972.Customers"
                SelectMethod="Repeater1_GetData">
                <ItemTemplate>
                    <tr>
                        <td><%#Item.CustomerID %></td>
                        <td><%#Item.CompanyName %></td>
                    </tr>

                </ItemTemplate>


            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
