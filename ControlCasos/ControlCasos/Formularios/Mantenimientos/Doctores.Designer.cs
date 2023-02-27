namespace ControlCasos.Formularios.Mantenimientos
{
    partial class frmDoctores
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
            this.dgvListaDoctores = new System.Windows.Forms.DataGridView();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lnkNuevoCliente = new System.Windows.Forms.LinkLabel();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoctores)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaDoctores
            // 
            this.dgvListaDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor,
            this.Cliente,
            this.Cedula,
            this.Correo,
            this.Telefono,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.dgvListaDoctores.Location = new System.Drawing.Point(45, 167);
            this.dgvListaDoctores.Name = "dgvListaDoctores";
            this.dgvListaDoctores.RowHeadersWidth = 51;
            this.dgvListaDoctores.RowTemplate.Height = 27;
            this.dgvListaDoctores.Size = new System.Drawing.Size(769, 150);
            this.dgvListaDoctores.TabIndex = 1;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.pnlFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltro.Controls.Add(this.txtBuscar);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Location = new System.Drawing.Point(45, 85);
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
            // lnkNuevoCliente
            // 
            this.lnkNuevoCliente.AutoSize = true;
            this.lnkNuevoCliente.Location = new System.Drawing.Point(706, 338);
            this.lnkNuevoCliente.Name = "lnkNuevoCliente";
            this.lnkNuevoCliente.Size = new System.Drawing.Size(108, 20);
            this.lnkNuevoCliente.TabIndex = 6;
            this.lnkNuevoCliente.TabStop = true;
            this.lnkNuevoCliente.Text = "Nuevo doctor";
            this.lnkNuevoCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoCliente_LinkClicked);
            // 
            // Doctor
            // 
            this.Doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doctor.DataPropertyName = "Doctor";
            this.Doctor.FillWeight = 160.4292F;
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 150.5124F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            // 
            // Cedula
            // 
            this.Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cedula.DataPropertyName = "cedula";
            this.Cedula.FillWeight = 100.4648F;
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.DataPropertyName = "correo";
            this.Correo.FillWeight = 110.5418F;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.FillWeight = 85.48956F;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.DataPropertyName = "estado";
            this.Estado.FillWeight = 70.56223F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // Editar
            // 
            this.Editar.FillWeight = 25F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ControlCasos.Properties.Resources.editar;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::ControlCasos.Properties.Resources.borrar;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // frmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.lnkNuevoCliente);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.dgvListaDoctores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoctores";
            this.Text = "Doctores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoctores)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDoctores;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel lnkNuevoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}