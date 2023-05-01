using ControlCasos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCasos.Formularios
{
    public partial class frmRestablecerContrasena : Form
    {
        BLUsuarioSistema usuarios = new BLUsuarioSistema();
        string usuarioRestablecer;

        public frmRestablecerContrasena(string usuarioRestablecer)
        {
            InitializeComponent();
            this.usuarioRestablecer = usuarioRestablecer;
        }

        #region Eventos
        private void txtCedula_Click(object sender, EventArgs e)
        {
            lblCedula.Visible = true;
            ttCedula.Show("El número de cédula nos ayudará a confirmar su identidad", txtCedula);
        }

        private void txtCedula_MouseHover(object sender, EventArgs e)
        {
            ttCedula.Show("El número de cédula nos ayudará a confirmar su identidad", txtCedula);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtNuevaContrasena.Text.Equals(txtConfirmarContrasena.Text))
                {
                    try
                    {
                        if (usuarios.RestablecerContrasena(usuarioRestablecer, txtNuevaContrasena.Text, txtCedula.Text))
                        {
                            MessageBox.Show("Contraseña restablecida exitosamente.","Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error al confirmar su identidad, asegúrese de que su número de cédula es correcto. Recuerde utilizar ceros y no poner guiones ni espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al restablecer la contraseña.\nPosibles causas:\nNo se pudo confirmar su identidad.");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContrasena.Text = "";
                    txtConfirmarContrasena.Text = "";
                    txtCedula.Text = "";
                }
            }
        }

        #endregion

        #region Validación Campos
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtNuevaContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevaContrasena.Text))
            {
                e.Cancel = true;
                txtNuevaContrasena.Focus();
                epNuevaContrasenaValidar.SetError(txtNuevaContrasena, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epNuevaContrasenaValidar.SetError(txtNuevaContrasena, "");
            }
        }

        private void txtConfirmarContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
            {
                e.Cancel = true;
                txtConfirmarContrasena.Focus();
                epConfirmarContrasenaValidar.SetError(txtConfirmarContrasena, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epConfirmarContrasenaValidar.SetError(txtConfirmarContrasena, "");
            }
        }

        private void txtNumeroCedula_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                e.Cancel = true;
                txtCedula.Focus();
                epNumeroCedulaValidar.SetError(txtCedula, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epNumeroCedulaValidar.SetError(txtCedula, "");
            }
        }
        #endregion
    }
}
