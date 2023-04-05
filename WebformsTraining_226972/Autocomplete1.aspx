<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" 
    CodeBehind="Autocomplete1.aspx.vb" Inherits="WebformsTraining_226972.Autocomplete1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .autocomplete-suggestions {
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
    border: 1px solid #999;
    background: #FFF;
    cursor: default;
    overflow: auto;
    -webkit-box-shadow: 1px 4px 3px rgba(50, 50, 50, 0.64);
    -moz-box-shadow: 1px 4px 3px rgba(50, 50, 50, 0.64);
    box-shadow: 1px 4px 3px rgba(50, 50, 50, 0.64);
}

.autocomplete-suggestion {
    padding: 2px 5px;
    white-space: nowrap;
    overflow: hidden;
}

.autocomplete-no-suggestion {
    padding: 2px 5px;
}

.autocomplete-selected {
    background: #F0F0F0;
}

.autocomplete-suggestions strong {
    font-weight: bold;
    color: #000;
}

.autocomplete-group {
    padding: 2px 5px;
    font-weight: bold;
    font-size: 16px;
    color: #000;
    display: block;
    border-bottom: 1px solid #000;
}

    </style>
    <label for="search">Search:</label>

    <asp:TextBox runat="server" ID="suche" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolderScripte" runat="server" ID="content2">
    <script src="/lib/jquery.autocomplete/jquery.autocomplete.js"></script>
    <script>
        $(document).ready(function () {
            $('#<%=suche.ClientID%>').autocomplete({
                lookup: function (query, done) {
                var result;
                    $.ajax({
                        type: "GET",
                        url: "/API/Customers/" + query,
                        
                        dataType: "json",
                      
                        success: function (data) {
                             var result = new Object();
                            result.suggestions = data;
                            done(result);
                        }
                    });
                 
                },
                onSelect: function (suggestion) {
                    alert('You selected: ' + suggestion.value + ', ' + suggestion.data);
                }
            });

        });

    </script>

</asp:Content>
