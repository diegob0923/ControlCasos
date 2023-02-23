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
            this.lnkNuevoTipoProducto = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaTipoProductos
            // 
            this.dgvListaTipoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTipoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTipoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProducto});
            this.dgvListaTipoProductos.Location = new System.Drawing.Point(96, 159);
            this.dgvListaTipoProductos.Name = "dgvListaTipoProductos";
            this.dgvListaTipoProductos.RowHeadersWidth = 51;
            this.dgvListaTipoProductos.RowTemplate.Height = 24;
            this.dgvListaTipoProductos.Size = new System.Drawing.Size(666, 150);
            this.dgvListaTipoProductos.TabIndex = 1;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "TipoProducto";
            this.TipoProducto.HeaderText = "Tipo de producto";
            this.TipoProducto.MinimumWidth = 6;
            this.TipoProducto.Name = "TipoProducto";
            // 
            // lnkNuevoTipoProducto
            // 
            this.lnkNuevoTipoProducto.AutoSize = true;
            this.lnkNuevoTipoProducto.Location = new System.Drawing.Point(581, 341);
            this.lnkNuevoTipoProducto.Name = "lnkNuevoTipoProducto";
            this.lnkNuevoTipoProducto.Size = new System.Drawing.Size(181, 20);
            this.lnkNuevoTipoProducto.TabIndex = 6;
            this.lnkNuevoTipoProducto.TabStop = true;
            this.lnkNuevoTipoProducto.Text = "Nuevo tipo de producto";
            this.lnkNuevoTipoProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoTipoProducto_LinkClicked);
            // 
            // frmTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.lnkNuevoTipoProducto);
            this.Controls.Add(this.dgvListaTipoProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTipoProducto";
            this.Text = "TipoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaTipoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.LinkLabel lnkNuevoTipoProducto;
    }
}