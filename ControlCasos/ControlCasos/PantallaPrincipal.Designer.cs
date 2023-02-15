namespace ControlCasos
{
    partial class frmPrincipal
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
            this.PnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlSubMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnRespaldos = new System.Windows.Forms.Button();
            this.btnCambioContrasena = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnUsuariosMenu = new System.Windows.Forms.Button();
            this.pnlSubMenuClientes = new System.Windows.Forms.Panel();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnDoctores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnClientesMenu = new System.Windows.Forms.Button();
            this.pnlSubMenuProductos = new System.Windows.Forms.Panel();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnTipoProducto = new System.Windows.Forms.Button();
            this.btnProductosMenu = new System.Windows.Forms.Button();
            this.btnCasos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.PnlMenuLateral.SuspendLayout();
            this.pnlSubMenuUsuarios.SuspendLayout();
            this.pnlSubMenuClientes.SuspendLayout();
            this.pnlSubMenuProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenuLateral
            // 
            this.PnlMenuLateral.AutoScroll = true;
            this.PnlMenuLateral.BackColor = System.Drawing.Color.DarkGray;
            this.PnlMenuLateral.Controls.Add(this.pnlSubMenuUsuarios);
            this.PnlMenuLateral.Controls.Add(this.btnUsuariosMenu);
            this.PnlMenuLateral.Controls.Add(this.pnlSubMenuClientes);
            this.PnlMenuLateral.Controls.Add(this.btnClientesMenu);
            this.PnlMenuLateral.Controls.Add(this.pnlSubMenuProductos);
            this.PnlMenuLateral.Controls.Add(this.btnProductosMenu);
            this.PnlMenuLateral.Controls.Add(this.btnCasos);
            this.PnlMenuLateral.Controls.Add(this.panel1);
            this.PnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuLateral.Name = "PnlMenuLateral";
            this.PnlMenuLateral.Size = new System.Drawing.Size(200, 764);
            this.PnlMenuLateral.TabIndex = 1;
            // 
            // pnlSubMenuUsuarios
            // 
            this.pnlSubMenuUsuarios.BackColor = System.Drawing.Color.LightGray;
            this.pnlSubMenuUsuarios.Controls.Add(this.btnAyuda);
            this.pnlSubMenuUsuarios.Controls.Add(this.btnRespaldos);
            this.pnlSubMenuUsuarios.Controls.Add(this.btnCambioContrasena);
            this.pnlSubMenuUsuarios.Controls.Add(this.btnUsuarios);
            this.pnlSubMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuUsuarios.Location = new System.Drawing.Point(0, 549);
            this.pnlSubMenuUsuarios.Name = "pnlSubMenuUsuarios";
            this.pnlSubMenuUsuarios.Size = new System.Drawing.Size(200, 179);
            this.pnlSubMenuUsuarios.TabIndex = 8;
            this.pnlSubMenuUsuarios.Visible = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(0, 135);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(200, 41);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnRespaldos
            // 
            this.btnRespaldos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRespaldos.FlatAppearance.BorderSize = 0;
            this.btnRespaldos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRespaldos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRespaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespaldos.Location = new System.Drawing.Point(0, 90);
            this.btnRespaldos.Name = "btnRespaldos";
            this.btnRespaldos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRespaldos.Size = new System.Drawing.Size(200, 45);
            this.btnRespaldos.TabIndex = 4;
            this.btnRespaldos.Text = "Respaldos";
            this.btnRespaldos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldos.UseVisualStyleBackColor = true;
            this.btnRespaldos.Click += new System.EventHandler(this.btnRespaldos_Click);
            // 
            // btnCambioContrasena
            // 
            this.btnCambioContrasena.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambioContrasena.FlatAppearance.BorderSize = 0;
            this.btnCambioContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCambioContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCambioContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioContrasena.Location = new System.Drawing.Point(0, 45);
            this.btnCambioContrasena.Name = "btnCambioContrasena";
            this.btnCambioContrasena.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCambioContrasena.Size = new System.Drawing.Size(200, 45);
            this.btnCambioContrasena.TabIndex = 3;
            this.btnCambioContrasena.Text = "Cambio Contraseña";
            this.btnCambioContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioContrasena.UseVisualStyleBackColor = true;
            this.btnCambioContrasena.Click += new System.EventHandler(this.btnCambioContrasena_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(200, 45);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnUsuariosMenu
            // 
            this.btnUsuariosMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosMenu.FlatAppearance.BorderSize = 0;
            this.btnUsuariosMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUsuariosMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUsuariosMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosMenu.Location = new System.Drawing.Point(0, 504);
            this.btnUsuariosMenu.Name = "btnUsuariosMenu";
            this.btnUsuariosMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuariosMenu.Size = new System.Drawing.Size(200, 45);
            this.btnUsuariosMenu.TabIndex = 7;
            this.btnUsuariosMenu.Text = "Usuarios";
            this.btnUsuariosMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosMenu.UseVisualStyleBackColor = true;
            this.btnUsuariosMenu.Click += new System.EventHandler(this.btnUsuariosMenu_Click);
            // 
            // pnlSubMenuClientes
            // 
            this.pnlSubMenuClientes.BackColor = System.Drawing.Color.LightGray;
            this.pnlSubMenuClientes.Controls.Add(this.btnPacientes);
            this.pnlSubMenuClientes.Controls.Add(this.btnDoctores);
            this.pnlSubMenuClientes.Controls.Add(this.btnClientes);
            this.pnlSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuClientes.Location = new System.Drawing.Point(0, 368);
            this.pnlSubMenuClientes.Name = "pnlSubMenuClientes";
            this.pnlSubMenuClientes.Size = new System.Drawing.Size(200, 136);
            this.pnlSubMenuClientes.TabIndex = 6;
            this.pnlSubMenuClientes.Visible = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Location = new System.Drawing.Point(0, 90);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPacientes.Size = new System.Drawing.Size(200, 46);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnDoctores
            // 
            this.btnDoctores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctores.FlatAppearance.BorderSize = 0;
            this.btnDoctores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDoctores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctores.Location = new System.Drawing.Point(0, 45);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDoctores.Size = new System.Drawing.Size(200, 45);
            this.btnDoctores.TabIndex = 3;
            this.btnDoctores.Text = "Doctores";
            this.btnDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctores.UseVisualStyleBackColor = true;
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(200, 45);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnClientesMenu
            // 
            this.btnClientesMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesMenu.FlatAppearance.BorderSize = 0;
            this.btnClientesMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClientesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClientesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesMenu.Location = new System.Drawing.Point(0, 323);
            this.btnClientesMenu.Name = "btnClientesMenu";
            this.btnClientesMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientesMenu.Size = new System.Drawing.Size(200, 45);
            this.btnClientesMenu.TabIndex = 5;
            this.btnClientesMenu.Text = "Clientes";
            this.btnClientesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesMenu.UseVisualStyleBackColor = true;
            this.btnClientesMenu.Click += new System.EventHandler(this.btnClientesMenu_Click);
            // 
            // pnlSubMenuProductos
            // 
            this.pnlSubMenuProductos.BackColor = System.Drawing.Color.LightGray;
            this.pnlSubMenuProductos.Controls.Add(this.btnMarcas);
            this.pnlSubMenuProductos.Controls.Add(this.btnColores);
            this.pnlSubMenuProductos.Controls.Add(this.btnTipoProducto);
            this.pnlSubMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuProductos.Location = new System.Drawing.Point(0, 190);
            this.pnlSubMenuProductos.Name = "pnlSubMenuProductos";
            this.pnlSubMenuProductos.Size = new System.Drawing.Size(200, 133);
            this.pnlSubMenuProductos.TabIndex = 4;
            this.pnlSubMenuProductos.Visible = false;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Location = new System.Drawing.Point(0, 90);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(200, 43);
            this.btnMarcas.TabIndex = 6;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnColores
            // 
            this.btnColores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColores.FlatAppearance.BorderSize = 0;
            this.btnColores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnColores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColores.Location = new System.Drawing.Point(0, 45);
            this.btnColores.Name = "btnColores";
            this.btnColores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnColores.Size = new System.Drawing.Size(200, 45);
            this.btnColores.TabIndex = 5;
            this.btnColores.Text = "Colores";
            this.btnColores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnTipoProducto
            // 
            this.btnTipoProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoProducto.FlatAppearance.BorderSize = 0;
            this.btnTipoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTipoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoProducto.Location = new System.Drawing.Point(0, 0);
            this.btnTipoProducto.Name = "btnTipoProducto";
            this.btnTipoProducto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTipoProducto.Size = new System.Drawing.Size(200, 45);
            this.btnTipoProducto.TabIndex = 4;
            this.btnTipoProducto.Text = "Tipo Producto";
            this.btnTipoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoProducto.UseVisualStyleBackColor = true;
            this.btnTipoProducto.Click += new System.EventHandler(this.btnTipoProducto_Click);
            // 
            // btnProductosMenu
            // 
            this.btnProductosMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosMenu.FlatAppearance.BorderSize = 0;
            this.btnProductosMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProductosMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProductosMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosMenu.Location = new System.Drawing.Point(0, 145);
            this.btnProductosMenu.Name = "btnProductosMenu";
            this.btnProductosMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductosMenu.Size = new System.Drawing.Size(200, 45);
            this.btnProductosMenu.TabIndex = 3;
            this.btnProductosMenu.Text = "Productos";
            this.btnProductosMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosMenu.UseVisualStyleBackColor = true;
            this.btnProductosMenu.Click += new System.EventHandler(this.Productos_Click);
            // 
            // btnCasos
            // 
            this.btnCasos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCasos.FlatAppearance.BorderSize = 0;
            this.btnCasos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCasos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasos.Location = new System.Drawing.Point(0, 100);
            this.btnCasos.Name = "btnCasos";
            this.btnCasos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCasos.Size = new System.Drawing.Size(200, 45);
            this.btnCasos.TabIndex = 1;
            this.btnCasos.Text = "Casos";
            this.btnCasos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCasos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(200, 0);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(860, 764);
            this.pnlFormularios.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 764);
            this.Controls.Add(this.pnlFormularios);
            this.Controls.Add(this.PnlMenuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.PnlMenuLateral.ResumeLayout(false);
            this.pnlSubMenuUsuarios.ResumeLayout(false);
            this.pnlSubMenuClientes.ResumeLayout(false);
            this.pnlSubMenuProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenuLateral;
        private System.Windows.Forms.Button btnProductosMenu;
        private System.Windows.Forms.Button btnCasos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSubMenuClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnClientesMenu;
        private System.Windows.Forms.Panel pnlSubMenuProductos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnTipoProducto;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnDoctores;
        private System.Windows.Forms.Panel pnlSubMenuUsuarios;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnRespaldos;
        private System.Windows.Forms.Button btnCambioContrasena;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnUsuariosMenu;
        private System.Windows.Forms.Panel pnlFormularios;
    }
}

