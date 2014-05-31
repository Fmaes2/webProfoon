<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Profoon._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        recomendaciones</h2>
    <p>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                descripcion:
                <asp:DynamicControl ID="descripcionDynamicControl" runat="server" 
                    DataField="descripcion" Mode="Edit" />
                <br />
                precio:
                <asp:DynamicControl ID="precioDynamicControl" runat="server" DataField="precio" 
                    Mode="Edit" />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Actualizar" ValidationGroup="Insert" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                descripcion:
                <asp:DynamicControl ID="descripcionDynamicControl" runat="server" 
                    DataField="descripcion" Mode="Insert" ValidationGroup="Insert" />
                <br />
                precio:
                <asp:DynamicControl ID="precioDynamicControl" runat="server" DataField="precio" 
                    Mode="Insert" ValidationGroup="Insert" />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Insertar" ValidationGroup="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                &nbsp;<asp:Image ID="Image1" runat="server" />
                <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("descripcion", "{0}") %>' 
                    Width="250px"></asp:Label>
                <br />
                <br />
                Precio:
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("precio") %>'></asp:Label>
            </ItemTemplate>
        </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            
            SelectCommand="SELECT descripcion,precio FROM Articulos WHERE (sistema_operativo = 'IOS')">
    </asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
