using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCasos.Formularios;
using ControlCasos.Formularios.Mantenimientos;
using ControlCasos.Formularios.Seguridad;
using ControlCasos.Formularios.Ayuda;
using ControlCasos.Clases;
using ControlCasos.Constantes;

namespace ControlCasos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            if (VariablesGlobales.rolUsuarioLogueado == Rol.General)
                btnSeguridad.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (pnlSubMenuMantenimientos.Visible == true)
                pnlSubMenuMantenimientos.Visible = false;
            if (pnlSubMenuSeguridad.Visible == true)
                pnlSubMenuSeguridad.Visible = false;
            if (pnlSubMenuAyuda.Visible == true)
                pnlSubMenuAyuda.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

#region Casos
        private void btnCasos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmCasos());
        }
#endregion

        #region Mantenimientos
        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuMantenimientos);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmClientes());
            ocultarSubMenu();
        }
        private void btnDoctores_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmDoctores());
            ocultarSubMenu();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmTipoProducto());
            ocultarSubMenu();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmMarcas());
            ocultarSubMenu();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmColores());
            ocultarSubMenu();
        }

        #endregion

#region Seguridad
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuSeguridad);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmUsuarios());
            ocultarSubMenu();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRoles());
            ocultarSubMenu();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRespaldos());
            ocultarSubMenu();
        }
        #endregion

#region Ayuda
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuAyuda);
        }

        private void btnCambioContrasena_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmCambiarContrasena());
            ocultarSubMenu();
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmManualUsuario());
            ocultarSubMenu();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmAcercaDe());
            ocultarSubMenu();
        }
#endregion

        private Form formularioAcivo = null;

        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioAcivo != null)
                formularioAcivo.Close();
            formularioAcivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFormularios.Controls.Add(formularioHijo); //se envía el formulario hijo al panel contenedor
            pnlFormularios.Tag = formularioHijo; // se asocia el formularioHijo con el panel contenedor
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }  
    }
}