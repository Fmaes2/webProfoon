<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Profoon.Producto"  enableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:DataList ID="DataList1" runat="server">
        <ItemStyle Height="100%" Width="100%" />
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" Height="50%" Width="50%"  ImageUrl='<%# Eval("imagen") %>'/>
            <asp:Label ID="Nombre" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
            <br />
            <asp:Label ID="Descripcion" runat="server" style="text-align: right" Text='<%# Eval("descripcion") %>'></asp:Label>
            <br />
            <strong>Precio:</strong>
            <asp:Label ID="Precio" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Añadir" />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
