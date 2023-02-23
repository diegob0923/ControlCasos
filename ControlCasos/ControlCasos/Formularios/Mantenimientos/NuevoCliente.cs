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
namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmNuevoCliente : Form
    {
        private frmClientes formularioClientes;
        private readonly BLCliente BLClientes = new BLCliente();
        public frmNuevoCliente(frmClientes formularioClientes)
        {
            InitializeComponent();
            this.formularioClientes = formularioClientes;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioClientes.cargarDatosEnGrid();  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLClientes.insertarCliente(txtNombreCliente.Text))
                {
                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar cliente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
