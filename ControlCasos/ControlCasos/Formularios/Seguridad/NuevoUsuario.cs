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
        private const int UsuarioRepetido = -1;
        public frmNuevoUsuario(frmUsuarios formularioUsuarios)
        {
            InitializeComponent();
            this.formularioUsuarios = formularioUsuarios;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idRol = cmbRol.Text.Equals("Administrador") ? Rol.Administrador : Rol.General;
                string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;

                usuarios.insertarUsuario(txtUsuario.Text, txtNombre.Text, txtApellido1.Text, DateTime.Now.Date, UsuarioLogueado.usuarioLogueado, idRol, apellido2);
                
                this.Dispose();
                formularioUsuarios.cargarDatosEnGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar usuario. \nPosibles causas:\nPuede que el usuario \""+txtUsuario.Text+"\" ya exista. Por favor intente con otro.");
            }
        }
    }
}
