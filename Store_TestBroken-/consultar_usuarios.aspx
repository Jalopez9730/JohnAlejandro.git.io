<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="consultar_usuarios.aspx.cs" Inherits="consultar_usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="text-center">&nbsp;</h3>
    <h3 class="text-center"><strong>CONSULTAR Y ELIMINAR USUARIO</strong><br />
    </h3>
    <table class="w-100">
        <tr>
            <td style="width: 514px" class="text-right">SELECCIONE EL USUARIO A CONSULTAR&nbsp;&nbsp;&nbsp; </td>
             <td style="width: 292px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="269px" DataSourceID="SqlDataSource1" DataTextField="usuNombre" DataValueField="usuNombre">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [usuNombre] FROM [usuarios]"></asp:SqlDataSource>
            </td>
            <td style="width: 124px">
                <asp:Button ID="Button2" runat="server" Text="BUSCAR" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="ELIMINAR" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <p>
    </p>
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-left: 368px; margin-right: 0px;">
            <Columns>
                <asp:BoundField HeaderText="NOMBRE" DataField="usuNombre" />
                <asp:BoundField HeaderText="DOCUMENTO" DataField="usuDocumento" />
                <asp:BoundField HeaderText="ESTADO" DataField="usuEstado"/>
            </Columns>
        </asp:GridView>



                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </asp:Content>

