using ControlCasos.BL;
using ControlCasos.Modelos;
using ControlCasos.Constantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmEditarCliente : Form
    {
        private frmClientes formularioClientes;
        private readonly BLCliente BLClientes = new BLCliente();
        private readonly int IdCliente;
        public frmEditarCliente(frmClientes formularioClientes, int idCliente)
        {
            InitializeComponent();
            cargarDatosCliente(idCliente); 
            IdCliente = idCliente;
            this.formularioClientes = formularioClientes;
        }
        private void recargarGridEnFormularioPrincipal()
        {
            formularioClientes.cargarDatosEnGrid();
        }

        private void cargarDatosCliente(int idCliente)
        {
            try
            {
                sp_ClienteID_Consultar_Result datosCliente = BLClientes.consultarClienteID(idCliente);
                txtNombreCliente.Text = datosCliente.Cliente;
                cmbEstado.Text = datosCliente.Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar cliente");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool estado = cmbEstado.Text.Equals("Activo") ? Estado.Activo : Estado.Inactivo;

                BLClientes.editarCliente(IdCliente, txtNombreCliente.Text, estado);
                recargarGridEnFormularioPrincipal();
                this.Dispose();   
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar cliente");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
