using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class devoluciones : System.Web.UI.Page
{
    //declaramos la conexion
    SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
    }

      public void Obtener_codigoP()
    {

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from prestamos WHERE preUsuario = '" + DropDownList1.SelectedItem + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtcodigo.Text = dt.Rows[0][0].ToString();
         cn.Close();
                
    }

    public void eliminarPrestamo2()
    {
        // if (DropDownList2.SelectedItem.ToString() = )
        string sql = @"Delete from prestamos  where preCodigo= '" + txtcodigo.Text + "'";

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();

        cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();

        cn.Close();


    }
    public void eliminarPrestamo()
    {
       // if (DropDownList2.SelectedItem.ToString() = )
        string sql = @"Delete from detallePrestamos  where dtpLibro= '" + DropDownList2.SelectedItem + "'";

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();

        cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();
        
        cn.Close();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        if (DropDownList1.Items.Count < 1)
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('No hay prestamos')</script>");
        }

        else
        {
            Obtener_codigoP();
        }

    }

    public void obtener_fecha()
    {

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from detallePrestamos WHERE dtpLibro = '" + DropDownList2.SelectedItem + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtFecha2.Text = dt.Rows[0][4].ToString();
        cn.Close();
    }

    public void validar_fecha()
    {

        int x;
        x = Convert.ToInt16(txtTotal.Text);

        if (x > 0)
        {
            Label1.Text = "";
        }
        else
        {
            Label1.Text = "El usuario se ha pasado de la fecha Estipulada SE APLICARA LA SANCION";
        }
    }

    public void aplicar_sancion()
    {
        
        //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("UPDATE usuarios SET usuEstado = @Estado" + " WHERE usuNombre = @Nombre", cn);
        cmd.Parameters.AddWithValue("@Nombre", DropDownList1.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@Estado", "INACTIVO");
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public void agregarSancion()
    {
        DateTime fechafins = DateTime.Parse(txtFecha.Text);
             
        DateTime fechasn = fechafins.AddDays(5);
        //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("Insert into sancion " + "( sanPrestamo, sanDiasSancion,sanFechaInicio,sanFechaFin) values (@1,@2,@3,@4)", cn);
        cmd.Parameters.AddWithValue("@1", DropDownList1.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@2", "5");
        cmd.Parameters.AddWithValue("@3", txtFecha.Text);
        cmd.Parameters.AddWithValue("@4", fechasn.ToString());

        cmd.ExecuteNonQuery();
        Response.Write("<script> alert('Se ha Registrado correctamente');</script>");

        cn.Close();
    }

    public void bd_vacia()
    {


        cmd = new SqlCommand("SELECT * from detallePrestamos WHERE dtpLibro = '" + DropDownList2.SelectedItem + "'", cn);
        

        cn.Open();


        int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('No hay mas libros que devolver')</script>");
        }
          //no hay registros, esta vacia
         else {
            Response.Write("<script LANGUAGE='JavaScript' >alert('aun hay libros')</script>");
        }
        cn.Close();

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        

       

        if (DropDownList2.Items.Count < 1)
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('No hay libros que devolver ...')</script>");
        }

        else {

            obtener_fecha();
            DateTime fechainicio = DateTime.Parse(txtFecha.Text);
            DateTime fechafin = DateTime.Parse(txtFecha2.Text);

            TimeSpan duracion = fechafin - fechainicio;
            txtTotal.Text = duracion.TotalDays.ToString();
            validar_fecha();
            eliminarPrestamo(); // elimina de la tabla detalle prestamo 
            eliminarPrestamo2();// elimina de la tabla prestamo         
            bd_vacia();

            if (string.IsNullOrEmpty(Label1.Text))
            {

                                              
            }
            else
            {
                aplicar_sancion();
                agregarSancion();
                
            }

           

        }

    }




   
}