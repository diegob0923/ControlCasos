using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCasos.Modelos;
using ControlCasos.Constantes;
using ControlCasos.Clases;
using ControlCasos.BL;
using ControlCasos.Formularios;

namespace ControlCasos
{
    public partial class frmInicioSesion : Form
    {
        BLUsuarioSistema usuarioSistema = new BLUsuarioSistema();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void abrirFormularioPrincipal()
        {
            frmPrincipal pantallaPrincipal = new frmPrincipal();
            pantallaPrincipal.Visible = true;
        }
        private void limpiarTextBoxUsuarioContrasena()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        #region Eventos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    sp_ValidarUsuario_Result usuarioValidado = usuarioSistema.validarUsuario(txtUsuario.Text, txtContrasena.Text);

                    if (usuarioValidado == null)
                    {
                        MessageBox.Show(usuarioValidado + "Usuario o contraseña incorrectos");
                        limpiarTextBoxUsuarioContrasena();
                        UsuarioLogueado.rolUsuarioLogueado = Rol.UsuarioInvalido;
                        UsuarioLogueado.usuarioLogueado = "";
                    }
                    else
                    {
                        if (usuarioValidado.IdRol == Rol.Administrador)
                        {
                            UsuarioLogueado.rolUsuarioLogueado = Rol.Administrador;
                            UsuarioLogueado.usuarioLogueado = usuarioValidado.Usuario;
                            abrirFormularioPrincipal();
                            this.Hide();
                        }
                        else if (usuarioValidado.IdRol == Rol.General)
                        {
                            UsuarioLogueado.rolUsuarioLogueado = Rol.General;
                            UsuarioLogueado.usuarioLogueado = usuarioValidado.Usuario;
                            abrirFormularioPrincipal();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al ingresar, por favor vuelva a intentarlo");
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

        private void txtContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                e.Cancel = true;
                txtUsuario.Focus();
                epContrasenaValidar.SetError(txtContrasena, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epContrasenaValidar.SetError(txtContrasena, "");
            }
        }
        #endregion

        private void lnkRestablecerContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Está a punto de restablecer la contraseña para el usuario \"" + txtUsuario.Text + "\". Si el usuario es incorrecto, por favor presione \"No\" y cambielo en la casilla \"Usuario\". ¿Desea continuar?", "Restablecer Contraseña", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmRestablecerContrasena formularioRestablecerContrasena = new frmRestablecerContrasena(txtUsuario.Text);
                formularioRestablecerContrasena.Visible = true;
            }
        }
    }
}
