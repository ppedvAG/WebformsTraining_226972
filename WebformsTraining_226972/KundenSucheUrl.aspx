<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="KundenSucheUrl.aspx.vb" Inherits="WebformsTraining_226972.KundenSucheUrl" %>
<%@ Import Namespace="Microsoft.Aspnet.FriendlyUrls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <div class="row">
        <div class="col">
            <div class="input-group mb-3">
                <asp:TextBox class="form-control" ID="txtSuche" 
                    onkeydown="if (event.keyCode==13) {link.click();return false;}"
                    runat="server" ClientIDMode="Static"
                    placeholder="suche"></asp:TextBox>
             
                  <a href="#" class="btn btn-primary" id="link" >click</a>
         
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
    <script>
        $(function () {
            $('#link').click(function (event) {
                var v = $("#txtSuche").val();
                
                var url = '<%=FriendlyUrl.Href("~/KundensucheUrl/")%>' + v;
                event.preventDefault();

                window.location.replace ( url);
                return false;
            });

         
        });

    </script>

</asp:Content>
