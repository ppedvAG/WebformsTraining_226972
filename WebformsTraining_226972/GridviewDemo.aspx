<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GridviewDemo.aspx.vb" Inherits="WebformsTraining_226972.GridviewDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:NorthwindContext %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = @CustomerID" InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)" SelectCommand="SELECT * FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CompanyName] = @CompanyName, [ContactName] = @ContactName, [ContactTitle] = @ContactTitle, [Address] = @Address, [City] = @City, [Region] = @Region, [PostalCode] = @PostalCode, [Country] = @Country, [Phone] = @Phone, [Fax] = @Fax WHERE [CustomerID] = @CustomerID">
        <DeleteParameters>
            <asp:Parameter Name="CustomerID" Type="String"></asp:Parameter>
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CustomerID" Type="String"></asp:Parameter>
            <asp:Parameter Name="CompanyName" Type="String"></asp:Parameter>
            <asp:Parameter Name="ContactName" Type="String"></asp:Parameter>
            <asp:Parameter Name="ContactTitle" Type="String"></asp:Parameter>
            <asp:Parameter Name="Address" Type="String"></asp:Parameter>
            <asp:Parameter Name="City" Type="String"></asp:Parameter>
            <asp:Parameter Name="Region" Type="String"></asp:Parameter>
            <asp:Parameter Name="PostalCode" Type="String"></asp:Parameter>
            <asp:Parameter Name="Country" Type="String"></asp:Parameter>
            <asp:Parameter Name="Phone" Type="String"></asp:Parameter>
            <asp:Parameter Name="Fax" Type="String"></asp:Parameter>
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CompanyName" Type="String"></asp:Parameter>
            <asp:Parameter Name="ContactName" Type="String"></asp:Parameter>
            <asp:Parameter Name="ContactTitle" Type="String"></asp:Parameter>
            <asp:Parameter Name="Address" Type="String"></asp:Parameter>
            <asp:Parameter Name="City" Type="String"></asp:Parameter>
            <asp:Parameter Name="Region" Type="String"></asp:Parameter>
            <asp:Parameter Name="PostalCode" Type="String"></asp:Parameter>
            <asp:Parameter Name="Country" Type="String"></asp:Parameter>
            <asp:Parameter Name="Phone" Type="String"></asp:Parameter>
            <asp:Parameter Name="Fax" Type="String"></asp:Parameter>
            <asp:Parameter Name="CustomerID" Type="String"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
