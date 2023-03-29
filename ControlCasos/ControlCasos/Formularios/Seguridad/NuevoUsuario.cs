using System;
using ControlCasos.Constantes;
using ControlCasos.BL;
using ControlCasos.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCasos.Formularios.Seguridad
{
    public partial class frmNuevoUsuario : Form
    {
        private frmUsuarios formularioUsuarios;
        BLUsuarioSistema usuarios = new BLUsuarioSistema();
        public frmNuevoUsuario(frmUsuarios formularioUsuarios)
        {
            InitializeComponent();
            this.formularioUsuarios = formularioUsuarios;
            cmbRol.SelectedIndex = 0;
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    int idRol = 0;
                    if (cmbRol.Text.Equals("Administrador"))
                        idRol = Rol.Administrador;
                    if (cmbRol.Text.Equals("General"))
                        idRol = Rol.General;

                    string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;

                    usuarios.insertarUsuario(txtUsuario.Text, txtNombre.Text, txtApellido1.Text, DateTime.Now.Date, UsuarioLogueado.usuarioLogueado, idRol, apellido2);

                    this.Dispose();
                    formularioUsuarios.cargarDatosEnGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al agregar usuario.\nPosibles causas:\nPuede que ya exista un usuario \"" + txtUsuario.Text + "\"");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                e.Cancel = true;
                txtUsuario.Focus();
                epUsuarioValidar.SetError(txtUsuario, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epUsuarioValidar.SetError(txtUsuario, "");
            }
        }
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                e.Cancel = true;
                txtNombre.Focus();
                epNombreValidar.SetError(txtNombre, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epNombreValidar.SetError(txtNombre, "");
            }
        }
        private void txtApellido1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido1.Text))
            {
                e.Cancel = true;
                txtApellido1.Focus();
                epApellido1Validar.SetError(txtApellido1, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epApellido1Validar.SetError(txtApellido1, "");
            }
        }
        private void cmbRol_Validating(object sender, CancelEventArgs e)
        {
            if (cmbRol.Text.Equals("Seleccione:"))
            {
                e.Cancel = true;
                cmbRol.Focus();
                epRolValidar.SetError(cmbRol, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epRolValidar.SetError(cmbRol, "");
            }
        }
        #endregion
    }
}
