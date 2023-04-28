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
                MessageBox.Show("Error al cargar cliente.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
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
                    MessageBox.Show("Error al editar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                e.Cancel = true;
                txtNombreCliente.Focus();
                epNombreValidar.SetError(txtNombreCliente, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epNombreValidar.SetError(txtNombreCliente, "");
            }
        }
        #endregion
    }
}
