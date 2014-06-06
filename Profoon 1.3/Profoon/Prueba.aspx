<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="Profoon.Prueba" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" DataKeyField="id" 
            DataSourceID="SqlDataSource1">
            <ItemTemplate>
                id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                nombre:
                <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
                <br />
                marca:
                <asp:Label ID="marcaLabel" runat="server" Text='<%# Eval("marca") %>' />
                <br />
                descripcion:
                <asp:Label ID="descripcionLabel" runat="server" 
                    Text='<%# Eval("descripcion") %>' />
                <br />
                stock:
                <asp:Label ID="stockLabel" runat="server" Text='<%# Eval("stock") %>' />
                <br />
                stock_minimo:
                <asp:Label ID="stock_minimoLabel" runat="server" 
                    Text='<%# Eval("stock_minimo") %>' />
                <br />
                precio:
                <asp:Label ID="precioLabel" runat="server" Text='<%# Eval("precio") %>' />
                <br />
                tipo_producto:
                <asp:Label ID="tipo_productoLabel" runat="server" 
                    Text='<%# Eval("tipo_producto") %>' />
                <br />
                valoracion:
                <asp:Label ID="valoracionLabel" runat="server" 
                    Text='<%# Eval("valoracion") %>' />
                <br />
                sistema_operativo:
                <asp:Label ID="sistema_operativoLabel" runat="server" 
                    Text='<%# Eval("sistema_operativo") %>' />
                <br />
                destacado:
                <asp:Label ID="destacadoLabel" runat="server" Text='<%# Eval("destacado") %>' />
                <br />
                imagen:
                <asp:Label ID="imagenLabel" runat="server" Text='<%# Eval("imagen") %>' />
                <br />
<br />
                <asp:LinkButton ID="LinkButton1" runat="server" 
                    PostBackUrl="~/App_Data/Profoon.mdf">Buscar</asp:LinkButton>
                <br />
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Articulos]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
