using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;


namespace LaboratorioASP
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ActualizarProductos = new Recursos.ClassProductos(
                Convert.ToInt32(txtModificar.SelectedValue.ToString()),
                txtModificar.Text,
                txtDescripcion1.Text,
                Convert.ToInt32(txtValor1.Text.Trim()),
                Convert.ToInt32(txtCantidad1.Text.Trim())
                );

            ActualizarProductos.Actualizar();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertar.Visible = true;
            pnlModificar.Visible = false;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible = false;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlConsultar.Visible = true;
            pnlEliminar.Visible = false;
            pnlInsertar.Visible = false;
            pnlModificar.Visible = false;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlModificar.Visible = true;
            pnlInsertar.Visible = false;
            pnlEliminar.Visible = false;
            pnlConsultar.Visible = false;

            var Funciones = new Recursos.ClaseFunciones();
            txtModificar.DataSource = Funciones.ListarProductos();
            txtModificar.DisplayMember = "proNombre";
            txtModificar.ValueMember = "proCodigo";

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEliminar.Visible = true;
            pnlConsultar.Visible = false;
            pnlModificar.Visible = false;
            pnlInsertar.Visible = false;

            var Funciones = new Recursos.ClaseFunciones();
            txtEliminar.DataSource = Funciones.ListarProductos();
            txtEliminar.DisplayMember = "ProNombre";
            txtEliminar.ValueMember = "proCodigo";
        }

        private void TxtConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlEliminar_Paint(object sender, PaintEventArgs e)
        {

        }



        private void frmProductos_Load(object sender, EventArgs e)
        {
            var Funciones = new Recursos.ClaseFunciones();
            txtModificar.DataSource = Funciones.ListarProductos();
            txtModificar.DisplayMember = "proNombre";

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var RegistrarProducto = new Recursos.ClassProductos(
                Convert.ToInt32(txtCodigo.Text.Trim()),
                txtName.Text,
                txtDescripcion.Text,
                Convert.ToInt32(txtValor.Text),
                Convert.ToInt32(txtCantidad.Text.Trim())
                );

            RegistrarProducto.Registrar();
        }


        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtName.Clear();
            txtDescripcion.Clear();
            txtValor.Clear();
            txtCantidad.Clear();

        }
        private void btnConsul_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            var Productos = new Recursos.ClassProductos();
            var Tabla = Productos.Listar();
            var NumeroFilas = Tabla.Rows.Count;
            if (NumeroFilas > 0)
            {
                for (int i = 0; i < NumeroFilas; i++)
                {
                    String Codigo = Tabla.Rows[i][0].ToString();
                    String Nombre1 = Tabla.Rows[i][1].ToString();
                    String Descripcion = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][3].ToString();
                    String Cantidad = Tabla.Rows[i][4].ToString();


                    dgvProductos.Rows.Add(
                        Codigo, Nombre1, Descripcion, Valor, Cantidad);
                }

            }
        }

        private void txtModificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var EliminarProducto = new Recursos.ClassProductos();
            int Codigo = Convert.ToInt32(txtEliminar.SelectedValue.ToString());
            EliminarProducto.Eliminar(Codigo);
        }

        private void btnConsul2_Click(object sender, EventArgs e)
        {
            var ConsultarProducto = new Recursos.ClassProductos();
            int Codigo = Convert.ToInt32(txtModificar.SelectedValue.ToString());
            var Tabla = ConsultarProducto.BuscarPorCodigo(Codigo);
            var NumeroFilas = Tabla.Rows.Count;
            if (NumeroFilas > 0)
            {
                for (int i = 0; i < NumeroFilas; i++)
                {
                    String Descripcion = Tabla.Rows[i][0].ToString();
                    String Valor = Tabla.Rows[i][1].ToString();
                    String Cantidad = Tabla.Rows[i][2].ToString();

                    txtDescripcion1.Text = Descripcion;
                    txtValor1.Text = Valor;
                    txtCantidad1.Text = Cantidad;

                }


            }
        }

        private void pnlInsertar_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
