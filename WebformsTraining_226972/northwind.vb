Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class northwind
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=northwind")
    End Sub

    Public Overridable Property Customers As DbSet(Of Customers)
    Public Overridable Property Order_Details As DbSet(Of Order_Details)
    Public Overridable Property Orders As DbSet(Of Orders)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Customers)() _
            .Property(Function(e) e.CustomerID) _
            .IsFixedLength()

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
    End Sub
End Class
