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
using ControlCasos.Constantes;
using ControlCasos.Modelos;

namespace ControlCasos.Formularios.Seguridad
{
    public partial class frmEditarUsuario : Form
    {
        private frmUsuarios formularioUsuarios;
        private readonly BLUsuarioSistema BLUsuario = new BLUsuarioSistema();
        private readonly byte idUsuario;
        public frmEditarUsuario(frmUsuarios formularioUsuarios, byte idUsuario)
        {
            InitializeComponent();
            cargarDatosTipoProducto(idUsuario);
            this.idUsuario = idUsuario;
            this.formularioUsuarios = formularioUsuarios;
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
                cmbEstado.Text = datosUsuario.Estado;
                cmbRol.Text = datosUsuario.Rol;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos del tipo de producto");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;
                bool estado = cmbEstado.Text.Equals("Activo") ? Estado.Activo : Estado.Inactivo;
                int idRol = cmbRol.Text.Equals("Administrador") ? Rol.Administrador : Rol.General;

                BLUsuario.editarUsuario(idUsuario, txtUsuario.Text,txtNombre.Text,txtApellido1.Text,estado,idRol,txtApellido2.Text);
                recargarGridEnFormularioPrincipal();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar usuario. \n Posibles causas:\n Puede que ya exista un usuario \"" + txtUsuario.Text+"\"");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
