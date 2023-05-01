namespace ControlCasos.Formularios.Ayuda
{
    partial class frmCambiarContrasena
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
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.epNuevaContrasenaValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmarContrasenaValidar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epNuevaContrasenaValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmarContrasenaValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNuevaContrasena.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContrasena.Location = new System.Drawing.Point(434, 186);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '●';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(227, 24);
            this.txtNuevaContrasena.TabIndex = 0;
            this.txtNuevaContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.txtNuevaContrasena_Validating);
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(434, 257);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '●';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(227, 24);
            this.txtConfirmarContrasena.TabIndex = 1;
            this.txtConfirmarContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmarContrasena_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cambiar contraseña";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva contraseña";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(562, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 32);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // epNuevaContrasenaValidar
            // 
            this.epNuevaContrasenaValidar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNuevaContrasenaValidar.ContainerControl = this;
            // 
            // epConfirmarContrasenaValidar
            // 
            this.epConfirmarContrasenaValidar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epConfirmarContrasenaValidar.ContainerControl = this;
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCambiarContrasena";
            this.Text = "CambiarContrasena";
            ((System.ComponentModel.ISupportInitialize)(this.epNuevaContrasenaValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmarContrasenaValidar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider epNuevaContrasenaValidar;
        private System.Windows.Forms.ErrorProvider epConfirmarContrasenaValidar;
    }
}