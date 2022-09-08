using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class addLibros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    public void guardar_libro()
    {


         //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("Insert into libros " + "(libCodigo, libNombre, libNumeroPagina, libAutor,libEditorial, libArea) values (@1,@2,@3,@4,@5,@6)", cn);
        cmd.Parameters.AddWithValue("@1", txtCodigo.Text);
        cmd.Parameters.AddWithValue("@2", txtNombre.Text);
        cmd.Parameters.AddWithValue("@3", txtNumeroPag.Text);
        cmd.Parameters.AddWithValue("@4", txtAutor.Text);
        cmd.Parameters.AddWithValue("@5", txtEditorial.Text);
        cmd.Parameters.AddWithValue("@6", txtArea.Text);
        cmd.ExecuteNonQuery();
        Response.Write("<script> alert('Se ha Registrado correctamente');</script>");

        cn.Close();
        Response.Redirect(Request.RawUrl, true);
    }

    public void modificar_libro()
    {

        SqlCommand cmd;
        string cadena = (@"Update libros set libCodigo = '" + txtCodigo.Text + "', libNombre = '" + txtNombre.Text + "',libNumeroPagina = '" + txtNumeroPag.Text + "', libAutor =  '" + txtAutor.Text + "' , libEditorial =  '" + txtEditorial.Text + "' , libArea =  '" + txtArea.Text + "' where libNombre = '" + DropDownList2.Text + "'");
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();

        cmd = new SqlCommand(cadena, cn);
        cmd.ExecuteNonQuery();
        Response.Redirect(Request.RawUrl, true);

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {

        if (MODIFICAR.Checked == false)
            guardar_libro();


        else
            modificar_libro();

       
    }

    protected void btnObtener_Click(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from libros WHERE libNombre = '" + DropDownList2.Text + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtCodigo.Text = dt.Rows[0][0].ToString();
        txtNombre.Text = dt.Rows[0][1].ToString();
        txtNumeroPag.Text = dt.Rows[0][2].ToString();
        txtAutor.Text = dt.Rows[0][3].ToString();
        txtEditorial.Text = dt.Rows[0][4].ToString();
        txtArea.Text = dt.Rows[0][5].ToString();
    }
}