using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace LaboratorioASP.Recursos
{
    class ClassProductos : Ifunciones
    {

      SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);
        
       
        public  int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Valor { get; set; }
        public int Cantidad { get; set; }


        public ClassProductos()
        {
            
        }


        public ClassProductos(int codigo, string nombre, string descripcion, int valor, int cantidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Valor = valor;
            this.Cantidad = cantidad;
        }


        public bool Actualizar()
        {
            Boolean Estado;
            try
            {
                using (var Command = new SqlCommand("SP_ActualizarProducto", Connection))
                {
                    
                    Command.Parameters.AddWithValue("@Descripcion", this.Descripcion);
                    Command.Parameters.AddWithValue("@Valor", this.Valor);
                    Command.Parameters.AddWithValue("@Cantidad", this.Cantidad);
                    
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    Estado = true;
                    System.Windows.Forms.MessageBox.Show("El Articulo se actualizo exitosamente!");
                    

                }
            }

            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                Estado = false;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return Estado;
        }

        public DataTable BuscarPorCodigo(int Codigo)
        {
            var tabla = new DataTable();
            try
            {
                using (var Adaptador = new SqlDataAdapter("SP_ConsultarProducto", Connection))
                {
                    Adaptador.SelectCommand.Parameters.AddWithValue("@Codigo", Codigo);
                    Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adaptador.Fill(tabla);

                }

            }

            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return tabla;
        }
         

        public bool Eliminar(int Codigo)
        {
            Boolean Estado;
            try
            {
                using (var Command = new SqlCommand("SP_EliminarProducto", Connection))
                {
                    Command.Parameters.AddWithValue("@Codigo", Codigo);
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Estado = true;
                    System.Windows.Forms.MessageBox.Show("El Articulo se elimino correctamente!");
                    Connection.Close();

                }
            }

            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                Estado = false;
            }
            finally
            {
                if(Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return Estado;  
        }

        public DataTable Listar()
        {
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("SP_ListarProductos", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }
            }
            catch(SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return tabla;

        }

        public int Registrar()
        {
            int Estado = 0;
            try { 
                using(var Command = new SqlCommand("SP_RegistrarProducto", Connection))
                {
                   
                    Command.Parameters.AddWithValue("@Codigo", this.Codigo);
                    Command.Parameters.AddWithValue("@Descripcion", this.Descripcion);
                    Command.Parameters.AddWithValue("@Valor", this.Valor);
                    Command.Parameters.AddWithValue("@Cantidad", this.Cantidad);
                    Command.Parameters.AddWithValue("@Nombre", this.Nombre);
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Se ha almacenado con exito!");
                    Connection.Close();


                }
            }
            catch(SqlException e)
            
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                Estado = 1;
            }
            
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    
                }
                
            }
            return Estado;
        }
    }
}
