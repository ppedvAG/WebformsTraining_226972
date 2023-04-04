<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Bestellungen.aspx.vb" Inherits="WebformsTraining_226972.Bestellungen" %>

<%@ Import Namespace="Microsoft.Aspnet.FriendlyUrls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <asp:FormView ID="FormView2" runat="server"
                DataKeyNames="CustomerID"
                ItemType="WebformsTraining_226972.Orders"
                DefaultMode="Edit"
                SelectMethod="FormView1_GetItem"
                GridLines="None"
                RenderOuterTable="false">
                <EditItemTemplate>
                    <div>
                        <div class="row g-3">
                            <div class="col-md-3">
                                <label for="inputCity" class="form-label">Lieferdatum</label>
                                <asp:TextBox ID="TextBox1" class="form-control" runat="server" Text="<%#BindItem.OrderDate %>" TextMode="Date"></asp:TextBox>

                            </div>
                            <div class="col-md-3">
                                <label for="inputCity" class="form-label">City</label>
                                <asp:TextBox ID="TextBox3" class="form-control" runat="server" Text="<%#BindItem.ShipCity %>"></asp:TextBox>

                            </div>
                            <div class="col-md-4">
                                <label for="inputCity" class="form-label">Name</label>
                                <asp:TextBox ID="TextBox4" class="form-control" runat="server" Text="<%#BindItem.ShipName %>"></asp:TextBox>

                            </div>
                            <div class="col-md-2">
                                <div class="btn-group" role="group" aria-label="Basic outlined example">
                                    <asp:Button ID="Button2" runat="server" Text="save" class="btn btn-outline-primary" CommandName="Update" />
                                    <button type="button" class="btn btn-outline-info" data-bs-toggle="modal" data-bs-target="#exampleModal">+Pos</button>
                                </div>
                            </div>
                        </div>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    nicht gefunden
                </EmptyDataTemplate>
            </asp:FormView>
        </div>
    </div>
    <div class="row">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always" OnLoad="UpdatePanel1_Load">
            <ContentTemplate>
                <div class="col">

                    <table class="table sortable">

                        <thead>
                            <tr>
                                <th scope="col">ID#</th>
                                <th scope="col">Anzahl</th>
                                <th scope="col">Rabatt</th>
                                <th scope="col">Preis</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server"
                                ItemType="WebformsTraining_226972.Order_Details"
                                SelectMethod="Repeater1_GetData">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Item.ProductID %></td>
                                        <td><%#Item.Quantity %></td>
                                        <td><%#Item.Discount %></td>
                                        <td><%#Item.UnitPrice %></td>
                                    </tr>

                                </ItemTemplate>


                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="AddPositionButton" />
            </Triggers>
        </asp:UpdatePanel>

    </div>
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Neue Position</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">

                    <div class="mb-3 row">
                        <label class="col-sm-2 col-form-label">product</label>
                        <div class="col-sm-10">

                            <asp:DropDownList ID="txtProduktDownList1" runat="server" ItemType="WebformsTraining_226972.Products" class="form-control"
                                DataTextField="ProductName" DataValueField="ProductID" AppendDataBoundItems="true"
                                SelectMethod="LadeProdukte">
                                <asp:ListItem Text="wählen..."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="mb-3 row">
                        <label class="col-sm-2 col-form-label">anzahl</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtAnzahl" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                    <div class="mb-3 row">
                        <label class="col-sm-2 col-form-label">discount</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtDiscount" class="form-range" runat="server" TextMode="Range" step="0.01" min="0" Max="1"></asp:TextBox>
                        </div>
                    </div>
                    <div class="mb-3 row">
                        <label class="col-sm-2 col-form-label">preis</label>

                        <div class="col-sm-10">
                            <asp:TextBox ID="txtPreis" class="form-control" runat="server" TextMode="Number" step="0.01"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
                        <ContentTemplate>
  <asp:Button ID="AddPositionButton" runat="server" Text="save" class="btn btn-primary" OnClick="Insert_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
         <%--           <asp:Button ID="AddPositionButton" runat="server" Text="save" class="btn btn-primary" OnClick="Insert_Click" />

    --%>            </div>
            </div>
        </div>
    </div>
</asp:Content>
