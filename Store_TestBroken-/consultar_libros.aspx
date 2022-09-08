<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="consultar_libros.aspx.cs" Inherits="consultar_libros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>&nbsp;</h2>
    <h2 class="text-center">CONSULTAR Y ELIMINAR LIBROS</h2>
    <h2 class="text-center">&nbsp;</h2>
    <table class="w-100">
        <tr>
            <td class="text-right">NOMBRE LIBRO&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td style="width: 324px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="251px" DataSourceID="SqlDataSource1" DataTextField="libNombre" DataValueField="libNombre">
                </asp:DropDownList>
                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [libNombre] FROM [libros]"></asp:SqlDataSource>
            </td>
            <td style="width: 94px">
                <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="ml-0" Text="Eliminar" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <h2 class="text-center">&nbsp;</h2>
    <table class="w-100">
        <tr>
            <td style="width: 244px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-left: 368px">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="libNombre" />
                <asp:BoundField HeaderText="Numero de Paginas" DataField="libNumeroPagina" />
                <asp:BoundField HeaderText="Autor" DataField="libAutor"/>
                <asp:BoundField HeaderText="Editorial" DataField="libEditorial"/>
                <asp:BoundField HeaderText="Area" DataField="libArea"/>
            </Columns>
        </asp:GridView>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="text-center">&nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <h2 class="text-center"><br />
    </h2>
    </asp:Content>

