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
        
        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    BLClientes.insertarCliente(txtNombreCliente.Text);
                
                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar cliente");
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
