<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="addPrestamo.aspx.cs" Inherits="addPrestamo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="text-center"><strong>AGREGAR PRESTAMO</strong></h3>
    <p class="text-center">&nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 368px">FECHA&nbsp; </td>
            <td class="text-center" style="width: 328px">
                <asp:TextBox ID="txtFecha1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
             <td>
                &nbsp;</td>
        </tr>
    </table>
    <table class="w-100">
        <tr>
            <td style="width: 452px" class="text-right">CODIGO&nbsp; </td>
            <td>
                <br />
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 452px">USUARIO&nbsp; </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="270px" DataSourceID="SqlDataSource1" DataTextField="usuNombre" DataValueField="usuNombre">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [usuNombre] FROM [usuarios]"></asp:SqlDataSource>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 452px">
                <table class="w-100">
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Button ID="btnGuardarP" runat="server" OnClick="btnGuardarP_Click" Text="GUARDAR PRESTAMO" Width="159px" />
            </td>
        </tr>
    </table>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 369px">LIBRO&nbsp; </td>
            <td style="width: 382px" class="text-right">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="275px" DataSourceID="SqlDataSource2" DataTextField="libNombre" DataValueField="libNombre" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [libNombre] FROM [libros]"></asp:SqlDataSource>
            </td>
            <td class="text-center">
                <br />
                <br />
                <asp:TextBox ID="txtArea" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 369px">&nbsp;</td>
            <td style="width: 382px" class="text-right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table class="w-100">
        <tr>
            <td class="text-right">CANTIDAD&nbsp; </td>
            <td class="text-center" style="width: 420px">
                <asp:TextBox ID="txtCantidad" runat="server" Width="64px"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Verificar Fecha Maxima" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">&nbsp;</td>
            <td class="text-center" style="width: 420px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 368px">FECHA MAXIMA DE ENTREGA:&nbsp; &nbsp; </td>
            <td class="text-center" style="width: 328px">
                <asp:TextBox ID="txtFecha2" runat="server"></asp:TextBox>
            </td>
            <td>
                <div style="text-align:center">
                <asp:Calendar ID="Cal1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="96px" ShowGridLines="True" Width="208px" OnSelectionChanged="Cal1_SelectionChanged">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
                    </div>
            </td>
        </tr>
    </table>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" Text="AGREGAR LIBRO" style="margin-bottom: 18" OnClick="Button1_Click" />
            </p>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td style="width: 318px">&nbsp;</td>
            <td style="width: 470px">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="48px" Width="534px">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [dtpLibro], [dtpCantidad], [dtpFechaFin], [dtpFechaDevolucion] FROM [detallePrestamos] WHERE ([dtpPrestamos] = @dtpPrestamos)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtCodigo" Name="dtpPrestamos" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
</asp:Content>

