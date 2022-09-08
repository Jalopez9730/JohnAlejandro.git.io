using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class addArea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       


     }

    public void obtener_area() {

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from areas WHERE areNombre = '" + DropDownList1.Text + "'", cn);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        txtCodigo.Text = dt.Rows[0][0].ToString();
        txtNombre.Text = dt.Rows[0][1].ToString();
        txtTiempo.Text = dt.Rows[0][2].ToString();
       
    }

    public void modificar_area()
    {

        SqlCommand cmd;
        string cadena = (@"Update areas set areCodigo = '" + txtCodigo.Text + "', areNombre = '" + txtNombre.Text + "', areTiempo = '" + txtTiempo.Text + "'  where areNombre = '" + DropDownList1.Text + "'");
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();

        cmd = new SqlCommand(cadena, cn);
        cmd.ExecuteNonQuery();
        

    }




    public void guardar_area()
    {
        

            //declaramos la conexion
            SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
            SqlCommand cmd;
            cn.Open();
            cmd = new SqlCommand("Insert into areas " + "(areCodigo, areNombre, areTiempo) values (@1,@2,@3)", cn);
            cmd.Parameters.AddWithValue("@1", txtCodigo.Text);
            cmd.Parameters.AddWithValue("@2", txtNombre.Text);
            cmd.Parameters.AddWithValue("@3", txtTiempo.Text);

            cmd.ExecuteNonQuery();
        Response.Write("<script> alert('Se ha Registrado correctamente');</script>");

        cn.Close();
        Response.Redirect(Request.RawUrl, true);
    }


    protected void btnGuardar_Click(object sender, EventArgs e)


    {

        if (MODIFICAR.Checked == false)
            guardar_area();
        

        else
            modificar_area();
        

    }

    protected void btnObtener_Click(object sender, EventArgs e)
    {
        obtener_area();
    }
}