using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioASP.Interfaces
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            var Funciones = new Recursos.ClaseFunciones();
            txtProducto.DataSource = Funciones.ListarProductos();
            txtProducto.DisplayMember = "proNombre";
            txtProducto.ValueMember = "proCodigo";

            dvgInventario.Rows.Clear();
            var Productos = new Recursos.ClassProductos();
            var Tabla = Productos.Listar();
            var NumeroFilas = Tabla.Rows.Count;
            if (NumeroFilas > 0)
            {
                for (int i = 0; i < NumeroFilas; i++)
                {
                    String Codigo = Tabla.Rows[i][0].ToString();
                    String Nombre = Tabla.Rows[i][1].ToString();
                    String Descripcion = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][3].ToString();
                    String Cantidad = Tabla.Rows[i][4].ToString();

                    dvgInventario.Rows.Add(
                        Codigo, Nombre, Descripcion, Valor, Cantidad
                        );
                }
            }
        }

        private void btnConsultar3_Click(object sender, EventArgs e)
        {

        }
    }
}
