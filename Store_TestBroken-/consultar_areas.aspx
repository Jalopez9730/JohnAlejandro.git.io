<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="consultar_areas.aspx.cs" Inherits="consultar_areas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="text-center">
        <br />
        CONSULTAR Y ELIMINACION DE AREAS</h2>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td style="width: 430px">SELECCIONE EL AREA QUE DESEA CONSULTAR</td>
            <td style="width: 317px">
                 <asp:DropDownList ID="dlAreas" runat="server" CssClass="ml-0" Width="226px" OnSelectedIndexChanged="dlAreas_SelectedIndexChanged" Height="30px" DataSourceID="SqlDataSource1" DataTextField="areNombre" DataValueField="areNombre">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [areNombre] FROM [areas]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Eliminar Area" Width="140px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
    <div class="text-center">
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-left: 368px">
            <Columns>
                <asp:BoundField HeaderText="CODIGO" DataField="areCodigo" />
                <asp:BoundField HeaderText="NOMBRE" DataField="areNombre" />
                <asp:BoundField HeaderText="FECHA" DataField="areTiempo"/>
            </Columns>
        </asp:GridView>



                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />



    </div>

</asp:Content>

