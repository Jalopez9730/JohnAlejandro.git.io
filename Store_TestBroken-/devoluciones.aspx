<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="devoluciones.aspx.cs" Inherits="devoluciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 class="text-center">
        &nbsp;</h3>
    <h3 class="text-center">
        <br />
        <strong>REALIZAR DEVOLUCION</strong></h3>
    <p class="text-center">
        &nbsp;</p>
        <strong> </strong>
    <table class="w-100">
        <tr>
            <td class="text-right" style="width: 445px">FECHA&nbsp; </td>
            <td>
                <asp:TextBox ID="txtFecha" runat="server" Width="205px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
    </table>
    
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
             <td class="text-right" style="width: 444px">USUARIO&nbsp; </td>
            <td style="width: 361px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="308px" DataSourceID="SqlDataSource1" DataTextField="preUsuario" DataValueField="preUsuario">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [preUsuario] FROM [prestamos]"></asp:SqlDataSource>
                <asp:TextBox ID="txtcodigo" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>
        <asp:Button ID="Button1" runat="server" Text="Consultar Prestamos" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 444px">&nbsp;</td>
            <td style="width: 361px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 444px">LIBRO&nbsp; </td>
            <td style="width: 361px">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="369px" DataSourceID="SqlDataSource3" DataTextField="dtpLibro" DataValueField="dtpLibro">
                </asp:DropDownList>
                
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [dtpPrestamos], [dtpCantidad], [dtpFechaFin], [dtpFechaDevolucion], [dtpLibro] FROM [detallePrestamos] WHERE ([dtpPrestamos] = @dtpPrestamos)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtcodigo" Name="dtpPrestamos" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Realizar devolucion" Width="146px" />
            </td>
        </tr>
        <tr>
            <td style="width: 444px">&nbsp;</td>
            <td style="width: 361px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <table class="w-100">
        <tr>
            <td style="width: 186px" class="text-right">
                &nbsp;</td>
            <td style="width: 367px" class="text-right">
                FECHA FIN:&nbsp;
                <asp:TextBox ID="txtFecha2" runat="server"></asp:TextBox>
            </td>
            <td class="text-center">
                DIAS
                <asp:TextBox ID="txtTotal" runat="server" Width="117px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" ForeColor="#0000CC"></asp:Label>
    </p>
    <table class="w-100">
        <tr>
            <td style="width: 394px">&nbsp;</td>
            <td style="width: 542px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333" GridLines="None" Height="176px" style="margin-left: 0px" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="dtpPrestamos" HeaderText="CODIGO" SortExpression="dtpPrestamos" />
                <asp:BoundField DataField="dtpLibro" HeaderText="NOMBRE DEL LIBRO" SortExpression="dtpLibro" />
                <asp:BoundField DataField="dtpCantidad" HeaderText="CANTIDAD" SortExpression="dtpCantidad" />
                <asp:BoundField DataField="dtpFechaFin" HeaderText="FECHA" SortExpression="dtpFechaFin" />
                <asp:BoundField DataField="dtpFechaDevolucion" HeaderText="FECHA DEVOLUCION" SortExpression="dtpFechaDevolucion" />
            </Columns>
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
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="text-center">
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [dtpPrestamos], [dtpLibro], [dtpCantidad], [dtpFechaFin], [dtpFechaDevolucion] FROM [detallePrestamos] WHERE ([dtpPrestamos] = @dtpPrestamos)">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtcodigo" Name="dtpPrestamos" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    
</asp:Content>

