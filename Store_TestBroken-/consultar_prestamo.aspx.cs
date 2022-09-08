using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class cosultar_prestamo : System.Web.UI.Page
{
    //declaramos la conexion
    SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
         //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("SELECT [preCodigo], [preFecha], [preUsuario] FROM [prestamos] WHERE ([preUsuario] = @preUsuario)", cn);
        cmd.Parameters.AddWithValue("@preUsuario", DropDownList1.SelectedItem.ToString());
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        cmd.ExecuteNonQuery();

        cn.Close();
        datos_gridView();

    }

    public void datos_gridView()
    {
        string valor = GridView1.Rows[0].Cells[0].Text;
        //declaramos la conexion
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        SqlCommand cmd;
        cn.Open();
        cmd = new SqlCommand("SELECT[dtpLibro], [dtpCantidad], [dtpFechaFin], [dtpFechaDevolucion] FROM[detallePrestamos] WHERE([dtpPrestamos] = @dtpPrestamos)  ", cn);
        cmd.Parameters.AddWithValue("@dtpPrestamos", valor.ToString());
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView2.DataSource = dt;
        GridView2.DataBind();
        cmd.ExecuteNonQuery();

        cn.Close();
    }
}