Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class NorthwindContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=NorthwindContext")
    End Sub

    Public Overridable Property Categories As DbSet(Of Categories)
    Public Overridable Property CustomerDemographics As DbSet(Of CustomerDemographics)
    Public Overridable Property Customers As DbSet(Of Customers)
    Public Overridable Property Employees As DbSet(Of Employees)
    Public Overridable Property Order_Details As DbSet(Of Order_Details)
    Public Overridable Property Orders As DbSet(Of Orders)
    Public Overridable Property Products As DbSet(Of Products)
    Public Overridable Property Region As DbSet(Of Region)
    Public Overridable Property Shippers As DbSet(Of Shippers)
    Public Overridable Property Suppliers As DbSet(Of Suppliers)
    Public Overridable Property Buch_Techniks As DbSet(Of BUCH_Technik)
    Public Overridable Property BUCH_Technik_Auswahls As DbSet(Of BUCH_Technik_Auswahl)

    Public Overridable Property Territories As DbSet(Of Territories)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of CustomerDemographics)() _
            .Property(Function(e) e.CustomerTypeID) _
            .IsFixedLength()

        modelBuilder.Entity(Of CustomerDemographics)() _
            .HasMany(Function(e) e.Customers) _
            .WithMany(Function(e) e.CustomerDemographics) _
            .Map(Function(m) m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"))

        modelBuilder.Entity(Of Customers)() _
            .Property(Function(e) e.CustomerID) _
            .IsFixedLength()

        modelBuilder.Entity(Of Employees)() _
            .HasMany(Function(e) e.Employees1) _
            .WithOptional(Function(e) e.Employees2) _
            .HasForeignKey(Function(e) e.ReportsTo)

        modelBuilder.Entity(Of Employees)() _
            .HasMany(Function(e) e.Territories) _
            .WithMany(Function(e) e.Employees) _
            .Map(Function(m) m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"))

        modelBuilder.Entity(Of Order_Details)() _
            .Property(Function(e) e.UnitPrice) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Orders)() _
            .Property(Function(e) e.CustomerID) _
            .IsFixedLength()

        modelBuilder.Entity(Of Orders)() _
            .Property(Function(e) e.Freight) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Orders)() _
            .HasMany(Function(e) e.Order_Details) _
            .WithRequired(Function(e) e.Orders) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Products)() _
            .Property(Function(e) e.UnitPrice) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Products)() _
            .HasMany(Function(e) e.Order_Details) _
            .WithRequired(Function(e) e.Products) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Region)() _
            .Property(Function(e) e.RegionDescription) _
            .IsFixedLength()

        modelBuilder.Entity(Of Region)() _
            .HasMany(Function(e) e.Territories) _
            .WithRequired(Function(e) e.Region) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Shippers)() _
            .HasMany(Function(e) e.Orders) _
            .WithOptional(Function(e) e.Shippers) _
            .HasForeignKey(Function(e) e.ShipVia)

        modelBuilder.Entity(Of Territories)() _
            .Property(Function(e) e.TerritoryDescription) _
            .IsFixedLength()
    End Sub
End Class
