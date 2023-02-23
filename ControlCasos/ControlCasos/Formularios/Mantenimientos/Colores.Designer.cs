namespace ControlCasos.Formularios.Mantenimientos
{
    partial class frmColores
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
            this.dgvListaColores = new System.Windows.Forms.DataGridView();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkNuevoColor = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaColores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaColores
            // 
            this.dgvListaColores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaColores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Color,
            this.Guia});
            this.dgvListaColores.Location = new System.Drawing.Point(98, 189);
            this.dgvListaColores.Name = "dgvListaColores";
            this.dgvListaColores.RowHeadersWidth = 51;
            this.dgvListaColores.RowTemplate.Height = 24;
            this.dgvListaColores.Size = new System.Drawing.Size(666, 150);
            this.dgvListaColores.TabIndex = 1;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            // 
            // Guia
            // 
            this.Guia.DataPropertyName = "Guia";
            this.Guia.HeaderText = "Guía";
            this.Guia.MinimumWidth = 6;
            this.Guia.Name = "Guia";
            // 
            // lnkNuevoColor
            // 
            this.lnkNuevoColor.AutoSize = true;
            this.lnkNuevoColor.Location = new System.Drawing.Point(654, 362);
            this.lnkNuevoColor.Name = "lnkNuevoColor";
            this.lnkNuevoColor.Size = new System.Drawing.Size(98, 20);
            this.lnkNuevoColor.TabIndex = 6;
            this.lnkNuevoColor.TabStop = true;
            this.lnkNuevoColor.Text = "Nuevo color";
            this.lnkNuevoColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoColor_LinkClicked);
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.lnkNuevoColor);
            this.Controls.Add(this.dgvListaColores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmColores";
            this.Text = "Colores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaColores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaColores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guia;
        private System.Windows.Forms.LinkLabel lnkNuevoColor;
    }
}