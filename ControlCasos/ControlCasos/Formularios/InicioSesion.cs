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
using ControlCasos;
namespace ControlCasos
{
    public partial class frmInicioSesion : Form
    {
        private ControlCasosEntities modeloControlCasos = new ControlCasosEntities();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var usuarioVlidado = modeloControlCasos.sp_ValidarUsuario(txtUsuario.Text, txtContrasena.Text).FirstOrDefault();
            
            if (usuarioVlidado == Rol.Administrador)
            {
                VariablesGlobales.rolUsuarioLogueado = Rol.Administrador;
                abrirFormularioPrincipal();
                this.Hide();
            }
            else if (usuarioVlidado == Rol.General)
            {
                VariablesGlobales.rolUsuarioLogueado = Rol.General;
                abrirFormularioPrincipal();
                this.Hide();
            }
            else
            {
                VariablesGlobales.rolUsuarioLogueado = Rol.UsuarioInvalido;
                MessageBox.Show(usuarioVlidado + "Usuario o contraseña incorrectos");
                limpiarTextBoxUsuarioContrasena();
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
