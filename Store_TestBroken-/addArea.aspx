<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="addArea.aspx.cs" Inherits="addArea" %>








<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
  


  
       
    <h1 class="text-center">
        &nbsp;</h1>
    <h1 class="text-center">
        <strong>REGISTRO Y MODIFICACION DE AREAS</strong></h1>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
             <td class="text-right">MODIFICAR AREA? </td>
            <td class="text-right" style="width: 335px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdLab16ConnectionString %>" SelectCommand="SELECT [areNombre] FROM [areas]"></asp:SqlDataSource>
                <asp:CheckBox ID="MODIFICAR" runat="server" />
                <asp:DropDownList ID="DropDownList1" runat="server" Width="244px" DataSourceID="SqlDataSource1" DataTextField="areNombre" DataValueField="areNombre" Height="33px" AutoPostBack="True">
                </asp:DropDownList>
                </td>
            
        </tr>
    </table>
    <p class="text-center">
        &nbsp;</p>
    <table class="w-100">
        <tr>
            <td class="text-right">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">CODIGO</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="height: 45px">NOMBRE</td>
            <td style="height: 45px">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right">TIEMPO MAXIMO</td>
            <td>
                <asp:TextBox ID="txtTiempo" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
  <br />
    <div style="text-align:center">
    <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" OnClick="btnGuardar_Click" />
        <br />
        </div>
  
       
</asp:Content>









