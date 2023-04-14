using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCasos.BL;
using ControlCasos.Clases;
using ControlCasos.Constantes;
using ControlCasos.Modelos;

namespace ControlCasos.Formularios.Seguridad
{
    public partial class frmEditarUsuario : Form
    {
        private frmUsuarios formularioUsuarios;
        private readonly BLUsuarioSistema BLUsuario = new BLUsuarioSistema();
        private readonly byte idUsuario;
        private bool usuarioEditadoEsElLogueado;
        public frmEditarUsuario(frmUsuarios formularioUsuarios, byte idUsuario)
        {
            InitializeComponent();
            cargarDatosTipoProducto(idUsuario);
            this.idUsuario = idUsuario;
            this.formularioUsuarios = formularioUsuarios;
            usuarioEditadoEsElLogueado = varificarUsuarioAEditarEsMiUsuario(txtUsuario.Text);
        }
        private void recargarGridEnFormularioPrincipal()
        {
            formularioUsuarios.cargarDatosEnGrid();
        }
        private void cargarDatosTipoProducto(byte idUsuario)
        {
            try
            {
                sp_UsuarioSistemaID_Consultar_Result datosUsuario = BLUsuario.consultarUsuariosID(idUsuario);
                txtUsuario.Text = datosUsuario.Usuario;
                txtNombre.Text = datosUsuario.Nombre;
                txtApellido1.Text = datosUsuario.Apellido1;
                txtApellido2.Text = datosUsuario.Apellido2;
                txtCedula.Text = datosUsuario.Cedula;
                cmbEstado.Text = datosUsuario.Estado;
                cmbRol.Text = datosUsuario.Rol;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos del tipo de producto");
            }
        }
        private bool varificarUsuarioAEditarEsMiUsuario(string usuario)
        {
            if (usuario.Equals(UsuarioLogueado.usuarioLogueado))
                return true;
            
            return false;
        }
        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;
                    bool estado = cmbEstado.Text.Equals("Activo") ? Estado.Activo : Estado.Inactivo;
                    int idRol = cmbRol.Text.Equals("Administrador") ? Rol.Administrador : Rol.General;

                    BLUsuario.editarUsuario(idUsuario, txtUsuario.Text, txtNombre.Text, txtApellido1.Text, estado, idRol, txtCedula.Text, txtApellido2.Text);

                    if (usuarioEditadoEsElLogueado)
                        UsuarioLogueado.usuarioLogueado = txtUsuario.Text;//actualiza usuarioLogueado con el nuevo usuario

                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al editar usuario. \n Posibles causas:\n Puede que ya exista un usuario \"" + txtUsuario.Text + "\"");
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
        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                e.Cancel = true;
                txtCedula.Focus();
                epCedulaValidar.SetError(txtCedula, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epCedulaValidar.SetError(txtCedula, "");
            }
        }
        #endregion
    }
}
