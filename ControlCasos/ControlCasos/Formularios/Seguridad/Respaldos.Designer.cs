namespace ControlCasos.Formularios.Seguridad
{
    partial class frmRespaldos
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
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.btnRestaurarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarRespaldo
            // 
            this.btnGenerarRespaldo.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnGenerarRespaldo.Location = new System.Drawing.Point(330, 113);
            this.btnGenerarRespaldo.Name = "btnGenerarRespaldo";
            this.btnGenerarRespaldo.Size = new System.Drawing.Size(167, 47);
            this.btnGenerarRespaldo.TabIndex = 2;
            this.btnGenerarRespaldo.Text = "Generar Respaldo";
            this.btnGenerarRespaldo.UseVisualStyleBackColor = true;
            this.btnGenerarRespaldo.Click += new System.EventHandler(this.btnGenerarRespaldo_Click);
            // 
            // btnRestaurarDatos
            // 
            this.btnRestaurarDatos.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnRestaurarDatos.Location = new System.Drawing.Point(330, 232);
            this.btnRestaurarDatos.Name = "btnRestaurarDatos";
            this.btnRestaurarDatos.Size = new System.Drawing.Size(167, 47);
            this.btnRestaurarDatos.TabIndex = 3;
            this.btnRestaurarDatos.Text = "Restaurar Datos";
            this.btnRestaurarDatos.UseVisualStyleBackColor = true;
            this.btnRestaurarDatos.Click += new System.EventHandler(this.btnRestaurarDatos_Click);
            // 
            // frmRespaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.btnRestaurarDatos);
            this.Controls.Add(this.btnGenerarRespaldo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRespaldos";
            this.Text = "Respaldos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarRespaldo;
        private System.Windows.Forms.Button btnRestaurarDatos;
    }
}