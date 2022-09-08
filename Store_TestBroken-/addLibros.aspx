<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="addLibros.aspx.cs" Inherits="addLibros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="text-center">&nbsp;</h3>
    <h3 class="text-center"><strong>AGREGAR O MODIFICAR LIBRO</strong></h3>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 371px">MODIFICAR?</td>
            <td class="text-center">
                <asp:CheckBox ID="MODIFICAR" runat="server" />
                <asp:DropDownList ID="DropDownList2" runat="server" Width="261px" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="libNombre" DataValueField="libNombre">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [libNombre] FROM [libros]"></asp:SqlDataSource>
            </td>
            <td>
                 <asp:Button ID="btnObtener" runat="server" OnClick="btnObtener_Click" Text="OBTENER" />
            </td>
        </tr>
    </table>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 466px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 466px">CODIGO&nbsp;&nbsp; </td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" style="margin-left: 23" Width="120px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 466px">NOMBRE </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="307px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 466px">NUMERO DE PAGINAS&nbsp; </td>
            <td>
                <asp:TextBox ID="txtNumeroPag" runat="server" Width="78px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 466px">AUTOR&nbsp; </td>
            <td>
                <asp:TextBox ID="txtAutor" runat="server" Width="301px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 466px">EDITORIAL&nbsp; </td>
            <td>
                <asp:TextBox ID="txtEditorial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 466px">AREA&nbsp; </td>
            <td>
                <asp:DropDownList ID="txtArea" runat="server" Width="198px" DataSourceID="SqlDataSource1" DataTextField="areNombre" DataValueField="areNombre">
                    <asp:ListItem Value="Seleecione uno"></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [areNombre] FROM [areas]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <br />

    <div style="text-align:center">
    <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" OnClick="btnGuardar_Click" />
        </div>
</asp:Content>

