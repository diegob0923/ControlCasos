using ControlCasos.BL;
using ControlCasos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCasos.Formularios.Ayuda
{
    public partial class frmCambiarContrasena : Form
    {
        BLUsuarioSistema usuarios = new BLUsuarioSistema();
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtNuevaContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtNuevaContrasena.Text.Equals(txtConfirmarContrasena.Text))
                {
                    try
                    {
                        usuarios.RestablecerContrasena(UsuarioLogueado.usuarioLogueado, txtNuevaContrasena.Text);
                        MessageBox.Show("Contraseña cambiada exitosamente.","Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarCampos();
                }
            }
        }
        #endregion

        #region Validación campos
        /// <summary>
        /// Evita que se active el errorProvider al hacer click en la X para cerrar el formulario
        /// </summary>
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
        #endregion
    }
}
