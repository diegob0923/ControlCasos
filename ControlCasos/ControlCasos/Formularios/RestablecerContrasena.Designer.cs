namespace ControlCasos.Formularios
{
    partial class frmRestablecerContrasena
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.ttCedula = new System.Windows.Forms.ToolTip(this.components);
            this.epNuevaContrasenaValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmarContrasenaValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumeroCedulaValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.epNuevaContrasenaValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmarContrasenaValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroCedulaValidar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(163, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 29);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirmar contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nueva contraseña";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(28, 132);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '●';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(227, 22);
            this.txtConfirmarContrasena.TabIndex = 7;
            this.txtConfirmarContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmarContrasena_Validating);
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContrasena.Location = new System.Drawing.Point(27, 58);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '●';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(227, 22);
            this.txtNuevaContrasena.TabIndex = 6;
            this.txtNuevaContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.txtNuevaContrasena_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cédula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(27, 206);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(227, 23);
            this.txtCedula.TabIndex = 13;
            this.ttCedula.SetToolTip(this.txtCedula, "La cédula nos ayudará a confirmar su identidad");
            this.txtCedula.Click += new System.EventHandler(this.txtCedula_Click);
            this.txtCedula.MouseHover += new System.EventHandler(this.txtCedula_MouseHover);
            this.txtCedula.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroCedula_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 15;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(25, 232);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(198, 15);
            this.lblCedula.TabIndex = 16;
            this.lblCedula.Text = "(Con ceros, sin guiones ni espacios)";
            this.lblCedula.Visible = false;
            // 
            // ttCedula
            // 
            this.ttCedula.AutomaticDelay = 2500;
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
            // epNumeroCedulaValidar
            // 
            this.epNumeroCedulaValidar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNumeroCedulaValidar.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNuevaContrasena);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtConfirmarContrasena);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 309);
            this.panel1.TabIndex = 17;
            // 
            // frmRestablecerContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 310);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(298, 349);
            this.Name = "frmRestablecerContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restablecer Contrasena";
            ((System.ComponentModel.ISupportInitialize)(this.epNuevaContrasenaValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmarContrasenaValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroCedulaValidar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.ToolTip ttCedula;
        private System.Windows.Forms.ErrorProvider epNuevaContrasenaValidar;
        private System.Windows.Forms.ErrorProvider epConfirmarContrasenaValidar;
        private System.Windows.Forms.ErrorProvider epNumeroCedulaValidar;
        private System.Windows.Forms.Panel panel1;
    }
}