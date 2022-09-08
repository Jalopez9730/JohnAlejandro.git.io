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
    internal class ClassFactura : Ifunciones
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public int ValorTotal { get; set; }
        public int Vendedor { get; set; }

        public ClassFactura( DateTime _fecha, int _cliente, int _valorTotal, int _vendedor)

        {   
            this.Fecha = _fecha;
            this.Cliente = _cliente;
            this.ValorTotal = _valorTotal;
            this.Vendedor = _vendedor;
        }
        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarPorCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            throw new NotImplementedException();
        }

        public int Registrar()
        {
            int UltimaFactura = 0;
            try
            {
                using (var Command = new SqlCommand("SP_RegistrarFactura", Connection))
                {
                    //Command.Parameters.AddWithValue("@Numero", this.Numero);
                    Command.Parameters.AddWithValue("@Fecha", this.Fecha);
                    Command.Parameters.AddWithValue("@Cliente", this.Cliente);
                    Command.Parameters.AddWithValue("@ValorTotal", this.ValorTotal);
                    Command.Parameters.AddWithValue("@Vendedor", this.Vendedor);
                    Command.Parameters.Add("@UltimaFactura", SqlDbType.Int).Direction = ParameterDirection.Output;
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    UltimaFactura = Convert.ToInt32(Command.Parameters["@UltimaFactura"].Value.ToString());
                    Connection.Close();
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return UltimaFactura;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return UltimaFactura;
        }
    } 
}
