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
    internal class ClassFacturaDetalle
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);

        public int Numero { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }

        public ClassFacturaDetalle(int _numero, int _producto, int _cantidad)
        {
            this.Numero = _numero;
            this.Producto = _producto;
            this.Cantidad = _cantidad;
        }

        public bool Registrar()
        {
            bool i = false;
            try
            {
                using (var Command = new SqlCommand("SP_RegistrarFacturaDetalle", Connection))
                {
                    Command.Parameters.AddWithValue("@Numero", this.Numero);
                    Command.Parameters.AddWithValue("@Producto", this.Producto);
                    Command.Parameters.AddWithValue("@Cantidad", this.Cantidad);
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    i = true;
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return i;
        }
    }
}
