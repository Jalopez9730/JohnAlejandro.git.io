using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class consultar_areas : System.Web.UI.Page
{
    
    //declaramos la conexion
    SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
    protected void Page_Load(object sender, EventArgs e)
     {
              
        }


    public void cargar_datos()
    {
        string com = "Select * from areas";
        SqlDataAdapter adpt = new SqlDataAdapter(com, cn);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        dlAreas.DataSource = dt;
        dlAreas.DataBind();
        dlAreas.DataTextField = "areNombre";
        dlAreas.DataValueField = "areNombre";
        dlAreas.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      
        SqlCommand cmd = new SqlCommand("SELECT * from areas WHERE areNombre = '" + dlAreas.Text + "'", cn);
        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adpt.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        



    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; user=sa;password=admin1;database=bdLab16;");
        cn.Open();
        SqlCommand cmd = new SqlCommand(@"delete from areas WHERE areNombre = '" + dlAreas.Text + "'", cn);
        cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("<script language=javascript>alert(' Se ha eliminado correctamente ');</script>");
        Response.Redirect("consultar_areas.aspx");

    }

    protected void dlAreas_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}