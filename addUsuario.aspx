<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="addUsuario.aspx.cs" Inherits="addUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="text-center">
        <br />
        <strong>AGREGAR Y MODIFICAR USUARIO</strong></h3>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 309px">MODIFICAR?</td>
            <td class="text-right" style="width: 157px">
                 <asp:CheckBox ID="MODIFICAR" runat="server" />
            </td>
            <td style="width: 335px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="310px" AutoPostBack="True" CssClass="ml-0" DataSourceID="SqlDataSource1" DataTextField="usuNombre" DataValueField="usuNombre">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Laboratorio16 %>" SelectCommand="SELECT [usuNombre] FROM [usuario]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="btnObtener" runat="server" CssClass="ml-0" Height="33px" OnClick="btnObtener_Click" Text="Obtener" />
            </td>
        </tr>
    </table>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 548px">&nbsp; </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 548px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 548px">NUMERO DE IDENTIFICACION&nbsp; </td>
            <td>
                <asp:TextBox ID="txtNumeroID" runat="server" Width="151px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 548px">NOMBRE COMPLETO&nbsp; </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="298px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 548px">DIRECCION&nbsp; </td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server" Width="263px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 548px">NUMERO DE TELEFONO&nbsp; </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 548px">CORREO ELECTRONICO&nbsp; </td>
            <td>
                <asp:TextBox ID="txtCorreo" runat="server" Width="247px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 548px">ESTADO&nbsp; </td>
            <td>
                <asp:DropDownList ID="txtEstado" runat="server" Width="218px">
                    <asp:ListItem>ACTIVO</asp:ListItem>
                    <asp:ListItem>INACTIVO</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 548px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="text-center">
        <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" OnClick="btnGuardar_Click" />
    </p>
    <p class="text-center">
        &nbsp;</p>
</asp:Content>

