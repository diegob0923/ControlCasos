﻿namespace ControlCasos.Formularios.Casos
{
    partial class frmNuevoCaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.dgvResumenProductos = new System.Windows.Forms.DataGridView();
            this.Tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCaso = new System.Windows.Forms.Panel();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenProductos)).BeginInit();
            this.pnlCaso.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tamaño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Comentario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Diámetro";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(455, 161);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(186, 85);
            this.txtComentario.TabIndex = 11;
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(455, 78);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(186, 26);
            this.txtTamano.TabIndex = 12;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(455, 123);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(186, 26);
            this.txtDiametro.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 220);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(186, 26);
            this.txtCantidad.TabIndex = 14;
            // 
            // cmbColor
            // 
            this.cmbColor.DisplayMember = "ColorGuia";
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(133, 176);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(186, 28);
            this.cmbColor.TabIndex = 15;
            this.cmbColor.Text = " ";
            this.cmbColor.ValueMember = "idColor";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DisplayMember = "Marca";
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(136, 132);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(183, 28);
            this.cmbMarca.TabIndex = 16;
            this.cmbMarca.Text = " ";
            this.cmbMarca.ValueMember = "idMarca";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DisplayMember = "TipoProducto";
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(136, 82);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(183, 28);
            this.cmbTipoProducto.TabIndex = 17;
            this.cmbTipoProducto.Text = " ";
            this.cmbTipoProducto.ValueMember = "IdTipoProducto";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DisplayMember = "Doctor";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(126, 81);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(227, 28);
            this.cmbDoctor.TabIndex = 18;
            this.cmbDoctor.Text = " ";
            this.cmbDoctor.ValueMember = "iddoctor";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(126, 179);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(227, 26);
            this.dtpFecha.TabIndex = 19;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(126, 128);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(227, 26);
            this.txtPaciente.TabIndex = 20;
            // 
            // dgvResumenProductos
            // 
            this.dgvResumenProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumenProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tamano,
            this.Diametro,
            this.Cantidad,
            this.Color,
            this.Marca,
            this.TipoProducto,
            this.Comentario,
            this.Eliminar});
            this.dgvResumenProductos.Location = new System.Drawing.Point(26, 335);
            this.dgvResumenProductos.Name = "dgvResumenProductos";
            this.dgvResumenProductos.RowHeadersWidth = 51;
            this.dgvResumenProductos.RowTemplate.Height = 24;
            this.dgvResumenProductos.Size = new System.Drawing.Size(1053, 126);
            this.dgvResumenProductos.TabIndex = 21;
            this.dgvResumenProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumenProductos_CellContentClick);
            // 
            // Tamano
            // 
            this.Tamano.DataPropertyName = "tamano";
            this.Tamano.FillWeight = 50F;
            this.Tamano.HeaderText = "Tamaño";
            this.Tamano.MinimumWidth = 6;
            this.Tamano.Name = "Tamano";
            // 
            // Diametro
            // 
            this.Diametro.DataPropertyName = "diametro";
            this.Diametro.FillWeight = 50F;
            this.Diametro.HeaderText = "Diámentro";
            this.Diametro.MinimumWidth = 6;
            this.Diametro.Name = "Diametro";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.FillWeight = 50F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "color";
            this.Color.FillWeight = 75F;
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "marca";
            this.Marca.FillWeight = 75F;
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "tipoProducto";
            this.TipoProducto.FillWeight = 75F;
            this.TipoProducto.HeaderText = "Tipo Producto";
            this.TipoProducto.MinimumWidth = 6;
            this.TipoProducto.Name = "TipoProducto";
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "comentario";
            this.Comentario.FillWeight = 150F;
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 6;
            this.Comentario.Name = "Comentario";
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 40F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::ControlCasos.Properties.Resources.borrar;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Información del caso";
            // 
            // pnlCaso
            // 
            this.pnlCaso.Controls.Add(this.label5);
            this.pnlCaso.Controls.Add(this.label1);
            this.pnlCaso.Controls.Add(this.txtPaciente);
            this.pnlCaso.Controls.Add(this.label2);
            this.pnlCaso.Controls.Add(this.dtpFecha);
            this.pnlCaso.Controls.Add(this.label3);
            this.pnlCaso.Controls.Add(this.cmbDoctor);
            this.pnlCaso.Location = new System.Drawing.Point(33, 12);
            this.pnlCaso.Name = "pnlCaso";
            this.pnlCaso.Size = new System.Drawing.Size(363, 234);
            this.pnlCaso.TabIndex = 23;
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.btnAgregar);
            this.pnlProducto.Controls.Add(this.label12);
            this.pnlProducto.Controls.Add(this.label4);
            this.pnlProducto.Controls.Add(this.cmbTipoProducto);
            this.pnlProducto.Controls.Add(this.label9);
            this.pnlProducto.Controls.Add(this.label10);
            this.pnlProducto.Controls.Add(this.label11);
            this.pnlProducto.Controls.Add(this.cmbMarca);
            this.pnlProducto.Controls.Add(this.txtDiametro);
            this.pnlProducto.Controls.Add(this.txtComentario);
            this.pnlProducto.Controls.Add(this.txtTamano);
            this.pnlProducto.Controls.Add(this.label8);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.label7);
            this.pnlProducto.Controls.Add(this.label6);
            this.pnlProducto.Controls.Add(this.cmbColor);
            this.pnlProducto.Location = new System.Drawing.Point(417, 12);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(662, 302);
            this.pnlProducto.TabIndex = 24;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(557, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 30);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "Información del producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Resumen de productos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(997, 478);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 30);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmNuevoCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 535);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlCaso);
            this.Controls.Add(this.dgvResumenProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevoCaso";
            this.Text = "Agregar Caso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenProductos)).EndInit();
            this.pnlCaso.ResumeLayout(false);
            this.pnlCaso.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.DataGridView dgvResumenProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCaso;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}