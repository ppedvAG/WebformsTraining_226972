<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="KundenlisteCollapse.aspx.vb" Inherits="WebformsTraining_226972.KundenlisteCollapse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <div class="accordion" id="accordionExample">
                <asp:Repeater ID="Repeater1" runat="server"
                    ItemType="WebformsTraining_226972.Customers"
                    SelectMethod="Repeater1_GetData">
                    <ItemTemplate>

                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed"
                                    type="button"
                                    data-bs-toggle="collapse"
                                    data-bs-target="#Bereich<%#Item.CustomerID %>"
                                    aria-expanded="true" aria-controls="collapseOne">
                                    <%#Item.CompanyName %>
                                    <%#Item.Orders.Count %>
                                </button>
                            </h2>
                            <div id="Bereich<%#Item.CustomerID %>" class="accordion-collapse collapse "
                                data-bs-parent="#accordionExample">
                                <div class="accordion-body">
                                    <ul>
                                    <asp:Repeater ID="rptOrders" runat="server"
                                        DataSource="<%#Item.Orders %>">
                                        <ItemTemplate>
                                            <li><%#Eval("OrderDate") %></li>
                                        </ItemTemplate>

                                    </asp:Repeater>

                                    </ul>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>


                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
