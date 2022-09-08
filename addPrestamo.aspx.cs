using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class addPrestamo : System.Web.UI.Page
{

     //declaramos la conexion
    SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
    }

    

   

    protected void Cal1_SelectionChanged(object sender, EventArgs e)
    {
        txtFecha2.Text = Cal1.SelectedDate.ToString("dd-MM-yyyy");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFecha2.Text))
        {
            Response.Write("<script language=javascript>alert(' INGRESE LA FECHA FIN ');</script>");


        }

        else

        {

            guardar_pLibro();

            cargar_gridview();



        }





    }

    public void obtener_estado()
    {
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from usuarios WHERE usuNombre = '" + DropDownList1.SelectedItem + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        Label1.Text = dt.Rows[0][5].ToString();
        cn.Close();
    }
    public void consultar_sancion()
    {
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from sancion WHERE sanPrestamo = '" + DropDownList1.SelectedItem + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        Label1.Text = " NO PUEDE REALIZAR PRESTAMOS USUARIO SANCIONADO HASTA" +  dt.Rows[0][4].ToString();
        cn.Close();
    }


    public void cargar_gridview() {

        //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("SELECT[dtpLibro], [dtpCantidad], [dtpFechaFin], [dtpFechaDevolucion] FROM[detallePrestamos] WHERE([dtpPrestamos] = @dtpPrestamos)  ", cn);
        cmd.Parameters.AddWithValue("@dtpPrestamos", txtCodigo.Text);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        cmd.ExecuteNonQuery();

        cn.Close();

    }


    public void guardar_pLibro()
    {

        //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;


        cmd = new SqlCommand("insert into detallePrestamos (dtpPrestamos, dtpLibro,dtpCantidad,dtpFechaFin,dtpFechaDevolucion) values ('" + txtCodigo.Text + "','" + DropDownList2.SelectedValue.ToString() + "','" + txtCantidad.Text + "','" + txtFecha1.Text + "','" + txtFecha2.Text + "')", cn);

        cn.Open();

        cmd.ExecuteNonQuery();

        cn.Close();

                 
               

    }







   

    protected void btnGuardarP_Click(object sender, EventArgs e)
    {

        obtener_estado();

        if (Label1.Text == "ACTIVO")
        {
            //declaramos la conexion
            SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
            SqlCommand cmd;


            cmd = new SqlCommand("insert into prestamos (preCodigo, preFecha,preUsuario) values ('" + txtCodigo.Text + "','" + txtFecha1.Text + "','" + DropDownList1.SelectedItem.ToString() + "')", cn);

            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();

        }

        else
        {
            consultar_sancion();

        }

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
    }

    

    public void mostrar_area()
    {
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from libros WHERE libNombre = '" + DropDownList2.SelectedItem + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtArea.Text = dt.Rows[0][5].ToString();
        cn.Close();

       
    }



    public void Obtener_fecha_max()
    {

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from areas WHERE areNombre = '" + txtArea.Text + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtFecha2.Text = dt.Rows[0][2].ToString();
        cn.Close();
                
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        mostrar_area();
        Obtener_fecha_max();
    }
}