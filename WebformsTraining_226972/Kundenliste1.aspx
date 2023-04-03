<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Kundenliste1.aspx.vb" Inherits="WebformsTraining_226972.Kundenliste1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <div class="input-group mb-3">
                <asp:TextBox class="form-control" ID="txtSuche" runat="server"
                    placeholder="suche"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="suche"
                    OnClick="Button1_Click"
                    class="btn btn-outline-secondary" />
            </div>
        </div>
    </div>
 

    <div class="row">
        <div class="col">
            <ul class="list-group">
                <asp:Repeater ID="Repeater1" runat="server"
                    ItemType="WebformsTraining_226972.Customers"
                    SelectMethod="Repeater1_GetData">
                    <ItemTemplate>
                        <li class="list-group-item">

                            <%#Item.CompanyName %>
                            <span class="float-end badge text-bg-primary"><%#Item.Orders.Count %></span>

                        </li>

                    </ItemTemplate>


                </asp:Repeater>
            </ul>
        </div>
    </div>

</asp:Content>
