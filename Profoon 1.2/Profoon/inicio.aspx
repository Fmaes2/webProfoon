<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Profoon.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DataList ID="DataList1" runat="server" BackColor="#CCCCCC" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
        CellSpacing="2" ForeColor="Black" GridLines="Both" 
    RepeatDirection="Horizontal" style="text-align: center">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="White" />
        <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
               <ItemTemplate>
                            
                                <asp:Image ID="Image1" runat="server" Height="100px" 
                                    ImageUrl='<%# Eval("imagen") %>' Width="100px" />
                                <br />
                                <asp:Label ID="nombreLabel" runat="server" Font-Bold="True" Font-Size="Large" 
                                    Text='<%# Eval("nombre") %>' />
                                <br />
                                <br />
                                <asp:Label ID="descripcionLabel" runat="server" 
                                    Text='<%# Eval("descripcion") %>' Width="200px" />
                                <br />
                                <br />
                                <strong>Precio:</strong>
                                <asp:Label ID="precioLabel" runat="server" Text='<%# Eval("precio") %>' />
                                <br />
                                <br />
                                <asp:Button ID="Button1" runat="server" Text="Carrito" />
                                <asp:Button ID="Button2" runat="server" Text="Detalles" />
                                <br />
                           
                        </ItemTemplate>
                        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    </asp:DataList>
</asp:Content>
