using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioASP.Recursos
{
    internal class ClaseFunciones
    {

        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);
        public DataTable ListarProductos()
        {
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("select proCodigo,proNombre from Productos", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return tabla;

        }
        public int ConsultarPrecio(int Codigo)
        {
            int Precio = 0;
            DataTable tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("Select proValor from Productos Where proCodigo=" + Codigo, Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                    Precio = Convert.ToInt16(tabla.Rows[0][0]);
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return Precio;
        }

        public DataTable ListarVendedores()
        {
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("Select VenId,venUsuario from Vendedores", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return tabla;
        }
        public DataTable ListarClientes()
        {
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("Select cliId,cliNombre from Clientes", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return tabla;
        }
    }
}
