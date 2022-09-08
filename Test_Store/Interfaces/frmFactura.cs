using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioASP
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            txtCantida.Text = "1";
            var Funciones = new Recursos.ClaseFunciones();
            txtVendedo.DataSource = Funciones.ListarVendedores();
            txtVendedo.DisplayMember = "venUsuario";
            txtVendedo.ValueMember = "venId";

            txtClientes.DataSource = Funciones.ListarClientes();
            txtClientes.DisplayMember = "cliNombre";
            txtClientes.ValueMember = "cliId";

            txtArticul.DataSource = Funciones.ListarProductos();
            txtArticul.DisplayMember = "proNombre";
            txtArticul.ValueMember = "proCodigo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int Numero = txtCoding.Text.Length;
            int NumeroFilas = dgvFactura.Rows.Count;
            DateTime date = txtFecha.Value;
            int Cliente = Convert.ToInt32(txtClientes.SelectedValue.ToString());
            int Vendedor = Convert.ToInt32(txtVendedo.SelectedValue.ToString());
            int ValorTotal = Convert.ToInt32(txtTotal.Text.ToString());
            var RegistrarFactura = new Recursos.ClassFactura(date, Cliente, ValorTotal, Vendedor);
            int UltimaFactura = RegistrarFactura.Registrar();
            for (int i = 0; i < (NumeroFilas - 1); i++)
            {
                int Articulo = Convert.ToInt32(dgvFactura.Rows[i].Cells[0].Value.ToString());
                int Cantidad = Convert.ToInt32(dgvFactura.Rows[i].Cells[2].Value.ToString());
                var AgregarProducto = new Recursos.ClassFacturaDetalle(UltimaFactura, Articulo, Cantidad);
            }
            System.Windows.Forms.MessageBox.Show("La factura se registro exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Funciones = new Recursos.ClaseFunciones();
            int Codigo = Convert.ToInt32(txtArticul.SelectedValue.ToString());
            String Articulo = txtArticul.Text;
            String Cantidad = txtCantida.Text;
            int Valor = Funciones.ConsultarPrecio(Codigo); ;
            dgvFactura.Rows.Add(Codigo, Articulo, Cantidad, Valor);
            int NumeroFilas = dgvFactura.Rows.Count;
            int ValorTotal = 0;
            if (NumeroFilas > 1)
            {
                for (int i = 0; i < (NumeroFilas - 1); i++)
                {
                    int Can = Convert.ToInt32(dgvFactura.Rows[i].Cells[2].Value.ToString());
                    int Val = Convert.ToInt32(dgvFactura.Rows[i].Cells[3].Value.ToString());
                    ValorTotal += Can * Val;
                }
                txtTotal.Text = ValorTotal.ToString();
            }
            else
            {
                txtTotal.Text = Valor.ToString();
            }
        }

        private void txtVendedo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtVendedo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
