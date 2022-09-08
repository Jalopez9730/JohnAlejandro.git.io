
using System;

namespace LaboratorioASP
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.ComboBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtDescripcion1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsul2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.txtEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.TxtConsultar = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.proCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsul = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlModificar.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlInsertar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.pnlModificar);
            this.groupBox1.Controls.Add(this.pnlEliminar);
            this.groupBox1.Controls.Add(this.pnlConsultar);
            this.groupBox1.Controls.Add(this.pnlInsertar);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.insertarProductoToolStripMenuItem.Text = "Insertar producto";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // pnlModificar
            // 
            this.pnlModificar.Controls.Add(this.txtCantidad1);
            this.pnlModificar.Controls.Add(this.label12);
            this.pnlModificar.Controls.Add(this.txtModificar);
            this.pnlModificar.Controls.Add(this.btnSave2);
            this.pnlModificar.Controls.Add(this.txtValor1);
            this.pnlModificar.Controls.Add(this.txtDescripcion1);
            this.pnlModificar.Controls.Add(this.label10);
            this.pnlModificar.Controls.Add(this.label8);
            this.pnlModificar.Controls.Add(this.btnConsul2);
            this.pnlModificar.Controls.Add(this.label6);
            this.pnlModificar.Location = new System.Drawing.Point(27, 53);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(740, 230);
            this.pnlModificar.TabIndex = 11;
            this.pnlModificar.Visible = false;
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(266, 165);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(202, 20);
            this.txtCantidad1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cantidad:";
            // 
            // txtModificar
            // 
            this.txtModificar.FormattingEnabled = true;
            this.txtModificar.Location = new System.Drawing.Point(249, 16);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(248, 21);
            this.txtModificar.TabIndex = 12;
            this.txtModificar.SelectedIndexChanged += new System.EventHandler(this.txtModificar_SelectedIndexChanged);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(277, 191);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(174, 23);
            this.btnSave2.TabIndex = 16;
            this.btnSave2.Text = "Guardar Cambios";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(266, 137);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(201, 20);
            this.txtValor1.TabIndex = 15;
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(267, 111);
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(201, 20);
            this.txtDescripcion1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descripcion:";
            // 
            // btnConsul2
            // 
            this.btnConsul2.Location = new System.Drawing.Point(329, 43);
            this.btnConsul2.Name = "btnConsul2";
            this.btnConsul2.Size = new System.Drawing.Size(75, 23);
            this.btnConsul2.TabIndex = 9;
            this.btnConsul2.Text = "Consultar";
            this.btnConsul2.UseVisualStyleBackColor = true;
            this.btnConsul2.Click += new System.EventHandler(this.btnConsul2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Productos";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.txtEliminar);
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.label11);
            this.pnlEliminar.Location = new System.Drawing.Point(30, 56);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(740, 230);
            this.pnlEliminar.TabIndex = 17;
            this.pnlEliminar.Visible = false;
            this.pnlEliminar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEliminar_Paint);
            // 
            // txtEliminar
            // 
            this.txtEliminar.FormattingEnabled = true;
            this.txtEliminar.Location = new System.Drawing.Point(246, 30);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(236, 21);
            this.txtEliminar.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(329, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Productos";
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.Controls.Add(this.TxtConsultar);
            this.pnlConsultar.Controls.Add(this.dgvProductos);
            this.pnlConsultar.Controls.Add(this.btnConsul);
            this.pnlConsultar.Controls.Add(this.label9);
            this.pnlConsultar.Location = new System.Drawing.Point(30, 56);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(740, 230);
            this.pnlConsultar.TabIndex = 10;
            this.pnlConsultar.Visible = false;
            // 
            // TxtConsultar
            // 
            this.TxtConsultar.FormattingEnabled = true;
            this.TxtConsultar.Location = new System.Drawing.Point(250, 33);
            this.TxtConsultar.Name = "TxtConsultar";
            this.TxtConsultar.Size = new System.Drawing.Size(244, 21);
            this.TxtConsultar.TabIndex = 12;
            this.TxtConsultar.SelectedIndexChanged += new System.EventHandler(this.TxtConsultar_SelectedIndexChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCodigo,
            this.proDescripcion,
            this.proValor,
            this.ProCantidad,
            this.ProNombre});
            this.dgvProductos.Location = new System.Drawing.Point(147, 107);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(444, 117);
            this.dgvProductos.TabIndex = 10;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proCodigo
            // 
            this.proCodigo.HeaderText = "Codigo";
            this.proCodigo.Name = "proCodigo";
            this.proCodigo.Visible = false;
            // 
            // proDescripcion
            // 
            this.proDescripcion.HeaderText = "Descripcion";
            this.proDescripcion.Name = "proDescripcion";
            // 
            // proValor
            // 
            this.proValor.HeaderText = "Valor";
            this.proValor.Name = "proValor";
            // 
            // ProCantidad
            // 
            this.ProCantidad.HeaderText = "Cantidad";
            this.ProCantidad.Name = "ProCantidad";
            // 
            // ProNombre
            // 
            this.ProNombre.HeaderText = "Nombre";
            this.ProNombre.Name = "ProNombre";
            // 
            // btnConsul
            // 
            this.btnConsul.Location = new System.Drawing.Point(329, 64);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(75, 23);
            this.btnConsul.TabIndex = 9;
            this.btnConsul.Text = "Consultar";
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.btnConsul_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Productos";
            // 
            // pnlInsertar
            // 
            this.pnlInsertar.Controls.Add(this.txtName);
            this.pnlInsertar.Controls.Add(this.txtNombre);
            this.pnlInsertar.Controls.Add(this.BtnClean);
            this.pnlInsertar.Controls.Add(this.BtnSave);
            this.pnlInsertar.Controls.Add(this.txtCantidad);
            this.pnlInsertar.Controls.Add(this.txtValor);
            this.pnlInsertar.Controls.Add(this.txtDescripcion);
            this.pnlInsertar.Controls.Add(this.txtCodigo);
            this.pnlInsertar.Controls.Add(this.label5);
            this.pnlInsertar.Controls.Add(this.label4);
            this.pnlInsertar.Controls.Add(this.label3);
            this.pnlInsertar.Controls.Add(this.label2);
            this.pnlInsertar.Location = new System.Drawing.Point(24, 53);
            this.pnlInsertar.Name = "pnlInsertar";
            this.pnlInsertar.Size = new System.Drawing.Size(740, 230);
            this.pnlInsertar.TabIndex = 2;
            this.pnlInsertar.Visible = false;
            this.pnlInsertar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInsertar_Paint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(269, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(164, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(47, 13);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.Click += new System.EventHandler(this.label12_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(402, 172);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 23);
            this.BtnClean.TabIndex = 9;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(271, 172);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(269, 124);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(219, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(269, 93);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(219, 20);
            this.txtValor.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(269, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(269, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(219, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.pnlConsultar.ResumeLayout(false);
            this.pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlInsertar.ResumeLayout(false);
            this.pnlInsertar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtName.Clear();
            txtDescripcion.Clear();
            txtValor.Clear();
            txtCantidad.Clear();

        }

        private void BtnSave_Click(object sender, EventArgs e)
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlConsultar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnConsul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtDescripcion1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsul2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox TxtConsultar;
        private System.Windows.Forms.ComboBox txtEliminar;
        private System.Windows.Forms.ComboBox txtModificar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn proDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNombre;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.Label label12;
    }
}