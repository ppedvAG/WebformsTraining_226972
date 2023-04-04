<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="kundenedit.aspx.vb" Inherits="WebformsTraining_226972.kundenedit" %>

<%@ Import Namespace="Microsoft.Aspnet.FriendlyUrls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="FormView1" runat="server"
        DataKeyNames="CustomerID"
        ItemType="WebformsTraining_226972.Customers"
        DefaultMode="Edit"
        SelectMethod="FormView1_GetItem"
        UpdateMethod="FormView1_UpdateItem"
        DeleteMethod="FormView1_DeleteItem"
        InsertMethod="FormView1_InsertItem"
        GridLines="None"
        RenderOuterTable="false">
        <EditItemTemplate>
            <div>

                <div class="mb-3 row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Kundenname</label>
                    <div class="col-sm-10">

                        <asp:TextBox ID="TextBox1" class="form-control" runat="server" Text="<%#BindItem.CompanyName %>"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="^[^M]*$"
                            ErrorMessage="kein M" ControlToValidate="TextBox1"></asp:RegularExpressionValidator>

                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Ansprechpartner</label>
                    <div class="col-sm-10">

                        <asp:TextBox ID="TextBox2" class="form-control" runat="server" Text="<%#BindItem.ContactName %>"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Da muss auch was rein" ControlToValidate="Textbox2"></asp:RequiredFieldValidator>
                    </div>
                </div>
                 <div class="mb-3 row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">City</label>
                    <div class="col-sm-10">

                       
                        <asp:DropDownList runat="server" class="form-control" SelectedValue="<%#BindItem.City %>" ID="drpOrte"
                            SelectMethod="LadeOrte"
                            > 
                            <asp:ListItem Text="84489 Burghausen" Value=""></asp:ListItem>

                        </asp:DropDownList>
                          </div>
                </div>
            </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" class="" />

            <div class="btn-group" role="group" aria-label="Basic outlined example">
                <asp:Button ID="Button1" runat="server" Text="löschen" class="btn btn-outline-danger" />
                <a href="/tabelleeditdelete" class="btn btn-outline-primary">zurück</a>
                <asp:Button ID="Button2" runat="server" Text="save" class="btn btn-outline-primary" CommandName="Update" />
            </div>

        </EditItemTemplate>
        <EmptyDataTemplate>
            nicht gefunden
        </EmptyDataTemplate>
    </asp:FormView>



</asp:Content>
