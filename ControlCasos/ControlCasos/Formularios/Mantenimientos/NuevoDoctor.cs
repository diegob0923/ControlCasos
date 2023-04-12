using ControlCasos.BL;
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

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmNuevoDoctor : Form
    {
        private frmDoctores formularioDoctores;
        private readonly BLCliente BLClientes = new BLCliente();
        private readonly BLDoctor BLDoctor = new BLDoctor();
        public frmNuevoDoctor(frmDoctores formularioDoctores)
        {
            InitializeComponent();
            this.formularioDoctores = formularioDoctores;
            cargarComboBoxClientes();
        }

        private void cargarComboBoxClientes()
        {
            try
            {
                sp_Cliente_Consultar_Result opcionDefault = new sp_Cliente_Consultar_Result();
                opcionDefault.Cliente = "Seleccione:";
            
                IList<sp_Cliente_Consultar_Result> fuenteDatos = BLClientes.consultarClientes(null);//null es para que consulte todos
                fuenteDatos.Insert(0,opcionDefault);
                cmbCliente.DataSource = fuenteDatos; 
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de clientes");
            }
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioDoctores.cargarDatosEnGrid();
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    string cedula = txtCedula.Text.Equals("") ? null : txtCedula.Text;
                    string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;
                    string correo = txtCorreo.Text.Equals("") ? null : txtCorreo.Text;
                    string telefono = txtTelefono.Text.Equals("") ? null : txtTelefono.Text;

                    BLDoctor.insertarDoctor(txtNombre.Text, txtApellido1.Text,
                                                int.Parse(cmbCliente.SelectedValue.ToString()), cedula,
                                                apellido2, correo, telefono);

                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar doctor");
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
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                e.Cancel = true;
                epNombreValidar.SetError(txtNombre, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epNombreValidar.SetError(txtNombre, "");
            }
        }
        private void txtApellido1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido1.Text))
            {
                e.Cancel = true;
                epApellido1Validar.SetError(txtApellido1, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epApellido1Validar.SetError(txtApellido1, "");
            }
        }
        private void cmbCliente_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCliente.Text.Equals("Seleccione:"))
            {
                e.Cancel = true;
                epClienteValidar.SetError(cmbCliente, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epClienteValidar.SetError(cmbCliente, "");
            }
        }
        #endregion
    }
}