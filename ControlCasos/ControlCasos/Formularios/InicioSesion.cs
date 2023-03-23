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
namespace ControlCasos
{
    public partial class frmInicioSesion : Form
    {
        BLUsuarioSistema usuarioSistema = new BLUsuarioSistema();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //sp_ValidarUsuario_Result usuarioValidado = modeloControlCasos.sp_ValidarUsuario(txtUsuario.Text, txtContrasena.Text).FirstOrDefault();
            sp_ValidarUsuario_Result usuarioValidado = usuarioSistema.validarUsuario(txtUsuario.Text, txtContrasena.Text);

            if(usuarioValidado == null)
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
    }
}
