using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCasos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ocultarSubMenu()
        {
            if (pnlSubMenuProductos.Visible == true)
                pnlSubMenuProductos.Visible = false;
            if (pnlSubMenuClientes.Visible == true)
                pnlSubMenuClientes.Visible = false;
            if (pnlSubMenuUsuarios.Visible == true)
                pnlSubMenuUsuarios.Visible = false;
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

#region Productos
        private void Productos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuProductos);
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        #endregion

#region Clientes
        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuClientes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        #endregion

#region Usuarios
        private void btnUsuariosMenu_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuUsuarios);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnCambioContrasena_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
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