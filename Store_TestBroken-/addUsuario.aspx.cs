using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class addUsuario : System.Web.UI.Page
{

    //declaramos la conexion
    SqlConnection cn = new SqlConnection (@"server=DESKTOP-2IQU15V\SQLEXPRESS;user=DESKTOP-2IQU15V\JOHN;password=;database=Laboratorio16");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    public void obtener_usuario()
    {
        
        SqlConnection cn = new SqlConnection(@"server=DESKTOP-2IQU15V\SQLEXPRESS;user=DESKTOP-2IQU15V\JOHN;password=;database=Laboratorio16");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from usuario WHERE usuNombre = '" + DropDownList2.Text + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtNumeroID.Text = dt.Rows[0][0].ToString();
        txtNombre.Text = dt.Rows[0][1].ToString();
        txtDireccion.Text = dt.Rows[0][2].ToString();
        txtTelefono.Text = dt.Rows[0][3].ToString();
        txtCorreo.Text = dt.Rows[0][4].ToString();
        txtEstado.Text = dt.Rows[0][5].ToString();

    }


    public void modificar_usuario()
    {

        SqlCommand cmd;
        string cadena = (@"Update usuarios set usuDocumento = '" + txtNumeroID.Text + "', usuDireccion = '" + txtDireccion.Text + "', usuTelefono = '" + txtTelefono.Text + "' , usuCorreo = '" + txtCorreo.Text + "', usuEstado = '" + txtEstado.Text + "' , usuNombre = '" + txtNombre.Text + "'     where usuNombre = '" + DropDownList2.Text + "'");
        SqlConnection cn = new SqlConnection(@"server=DESKTOP-2IQU15V\SQLEXPRESS;user=DESKTOP-2IQU15V\JOHN;password=;database=Laboratorio16");
        cn.Open();

        cmd = new SqlCommand(cadena, cn);
        cmd.ExecuteNonQuery();
        cn.Close();

    }

    public void guardar_usuario()
    {


        //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=DESKTOP-2IQU15V\SQLEXPRESS;user=DESKTOP-2IQU15V\JOHN;password=;database=Laboratorio16");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("Insert into usuario " + "(usuDocumento,usuNombre, usuDireccion, usuTelefono,usuCorreo,usuEstado) values (@1,@2,@3,@4,@5,@6)", cn);
        cmd.Parameters.AddWithValue("@1", txtNumeroID.Text);
        cmd.Parameters.AddWithValue("@2", txtNombre.Text);
        cmd.Parameters.AddWithValue("@3", txtDireccion.Text);
        cmd.Parameters.AddWithValue("@4", txtTelefono.Text);
        cmd.Parameters.AddWithValue("@5", txtCorreo.Text);
        cmd.Parameters.AddWithValue("@6", txtEstado.Text);
        cmd.ExecuteNonQuery();
        

        cn.Close();
        Response.Redirect(Request.RawUrl, true);
        Response.Write("<script> alert('Se ha Registrado correctamente');</script>");
    }




    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (MODIFICAR.Checked == false)
            guardar_usuario();


        else
            modificar_usuario();
    }

    protected void btnObtener_Click(object sender, EventArgs e)
    {
        obtener_usuario();
    }
}