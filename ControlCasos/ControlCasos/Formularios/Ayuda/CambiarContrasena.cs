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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.Text.Equals(txtConfirmarContrasena.Text))
            {
                try
                {
                    usuarios.cambioContrasena(UsuarioLogueado.usuarioLogueado,txtNuevaContrasena.Text);
                    MessageBox.Show("Contraseña cambiada exitosamente.");
                    limpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al cambiar la contraseña.");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor vuelva a intentarlo.");
                limpiarCampos();
            }
        }
    }
}
