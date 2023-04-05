<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Autocomplete.aspx.vb" Inherits="WebformsTraining_226972.Autocomplete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <label for="search">Search:</label>
    <input type="text" id="suche1">
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolderScripte" runat="server" ID="content2">
    <script src="/lib/jquery.autocomplete/jquery.autocomplete.js"></script>
    <script>
        $(document).ready(function () {
            $('#suche1').autocomplete({
                serviceUrl: '/api/customers/' + $('#suche1').value,
                onSelect: function (suggestion) {
                    alert('You selected: ' + suggestion.value + ', ' + suggestion.data);
                }
            });

        });

    </script>

</asp:Content>
