namespace ControlCasos.Formularios.Mantenimientos
{
    partial class frmMarcas
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
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lnkNuevaMarca = new System.Windows.Forms.LinkLabel();
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.pnlFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltro.Controls.Add(this.txtBuscar);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Location = new System.Drawing.Point(88, 83);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(371, 36);
            this.pnlFiltro.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(3, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(279, 19);
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
            // lnkNuevaMarca
            // 
            this.lnkNuevaMarca.AutoSize = true;
            this.lnkNuevaMarca.Location = new System.Drawing.Point(646, 323);
            this.lnkNuevaMarca.Name = "lnkNuevaMarca";
            this.lnkNuevaMarca.Size = new System.Drawing.Size(108, 20);
            this.lnkNuevaMarca.TabIndex = 7;
            this.lnkNuevaMarca.TabStop = true;
            this.lnkNuevaMarca.Text = "Nueva Marca";
            this.lnkNuevaMarca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevaMarca_LinkClicked);
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProducto,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.dgvListaMarcas.Location = new System.Drawing.Point(88, 150);
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.RowHeadersWidth = 51;
            this.dgvListaMarcas.RowTemplate.Height = 27;
            this.dgvListaMarcas.Size = new System.Drawing.Size(666, 150);
            this.dgvListaMarcas.TabIndex = 8;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "Marca";
            this.TipoProducto.FillWeight = 140F;
            this.TipoProducto.HeaderText = "Marca";
            this.TipoProducto.MinimumWidth = 6;
            this.TipoProducto.Name = "TipoProducto";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ControlCasos.Properties.Resources.editar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 20F;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::ControlCasos.Properties.Resources.borrar;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.dgvListaMarcas);
            this.Controls.Add(this.lnkNuevaMarca);
            this.Controls.Add(this.pnlFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMarcas";
            this.Text = "Marcas";
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel lnkNuevaMarca;
        private System.Windows.Forms.DataGridView dgvListaMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}