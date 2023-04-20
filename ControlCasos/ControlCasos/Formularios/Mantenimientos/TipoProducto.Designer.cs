namespace ControlCasos.Formularios.Mantenimientos
{
    partial class frmTipoProducto
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
            this.dgvListaTipoProductos = new System.Windows.Forms.DataGridView();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkNuevoTipoProducto = new System.Windows.Forms.LinkLabel();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipoProductos)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaTipoProductos
            // 
            this.dgvListaTipoProductos.AllowUserToAddRows = false;
            this.dgvListaTipoProductos.AllowUserToDeleteRows = false;
            this.dgvListaTipoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTipoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTipoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProducto,
            this.Editar,
            this.Eliminar,
            this.Id});
            this.dgvListaTipoProductos.Location = new System.Drawing.Point(70, 234);
            this.dgvListaTipoProductos.Name = "dgvListaTipoProductos";
            this.dgvListaTipoProductos.ReadOnly = true;
            this.dgvListaTipoProductos.RowHeadersWidth = 51;
            this.dgvListaTipoProductos.RowTemplate.Height = 27;
            this.dgvListaTipoProductos.Size = new System.Drawing.Size(719, 282);
            this.dgvListaTipoProductos.TabIndex = 1;
            this.dgvListaTipoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTipoProductos_CellContentClick);
            this.dgvListaTipoProductos.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaTipoProductos_CellMouseMove);
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "TipoProducto";
            this.TipoProducto.FillWeight = 140F;
            this.TipoProducto.HeaderText = "Tipo de producto";
            this.TipoProducto.MinimumWidth = 6;
            this.TipoProducto.Name = "TipoProducto";
            // 
            // Editar
            // 
            this.Editar.FillWeight = 20F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ControlCasos.Properties.Resources.editar;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 20F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::ControlCasos.Properties.Resources.borrar;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdTipoProducto";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // lnkNuevoTipoProducto
            // 
            this.lnkNuevoTipoProducto.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.lnkNuevoTipoProducto.AutoSize = true;
            this.lnkNuevoTipoProducto.LinkColor = System.Drawing.Color.Teal;
            this.lnkNuevoTipoProducto.Location = new System.Drawing.Point(627, 201);
            this.lnkNuevoTipoProducto.Name = "lnkNuevoTipoProducto";
            this.lnkNuevoTipoProducto.Size = new System.Drawing.Size(162, 17);
            this.lnkNuevoTipoProducto.TabIndex = 6;
            this.lnkNuevoTipoProducto.TabStop = true;
            this.lnkNuevoTipoProducto.Text = "Nuevo Tipo de Producto";
            this.lnkNuevoTipoProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoTipoProducto_LinkClicked);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.pnlFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltro.Controls.Add(this.txtBuscar);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Location = new System.Drawing.Point(70, 174);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(371, 36);
            this.pnlFiltro.TabIndex = 7;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(3, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(279, 16);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::ControlCasos.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(330, -2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::ControlCasos.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(290, -2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(34, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ControlCasos.Properties.Resources.editar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 68;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 20F;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::ControlCasos.Properties.Resources.borrar;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista Tipos de Producto";
            // 
            // frmTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.lnkNuevoTipoProducto);
            this.Controls.Add(this.dgvListaTipoProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTipoProducto";
            this.Text = "TipoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipoProductos)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaTipoProductos;
        private System.Windows.Forms.LinkLabel lnkNuevoTipoProducto;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label1;
    }
}