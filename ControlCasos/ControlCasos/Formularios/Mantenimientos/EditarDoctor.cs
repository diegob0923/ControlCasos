using ControlCasos.BL;
using ControlCasos.Constantes;
using ControlCasos.Modelos;
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
    public partial class frmEditarDoctor : Form
    {
        private frmDoctores formularioDoctores;
        private readonly BLDoctor BLDoctor = new BLDoctor();
        private readonly BLCliente BLClientes = new BLCliente();
        private readonly int IdDoctor;
        public frmEditarDoctor(frmDoctores formularioDoctores, int idDoctor)
        {
            InitializeComponent();
            cargarComboBoxClientes();
            cargarDatosDoctor(idDoctor);
            IdDoctor = idDoctor;
            this.formularioDoctores = formularioDoctores;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioDoctores.cargarDatosEnGrid();
        }

        private void cargarComboBoxClientes()
        {
            try
            {
                IList<sp_Cliente_Consultar_Result> fuenteDatos = BLClientes.consultarClientes(null);//null es para que consulte todos
                cmbCliente.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de clientes.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatosDoctor(int idDoctor)
        {
            try
            {
                sp_DoctorID_Consultar_Result datosDoctor = BLDoctor.consultarDoctorID(idDoctor);
                txtCedula.Text = datosDoctor.cedula;
                txtNombre.Text = datosDoctor.Nombre;
                txtApellido1.Text = datosDoctor.Apellido1;
                txtApellido2.Text = datosDoctor.Apellido2;
                txtCorreo.Text = datosDoctor.correo;
                txtTelefono.Text = datosDoctor.telefono;
                cmbCliente.Text = datosDoctor.Cliente;
                cmbEstado.Text = datosDoctor.Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string cedula = txtCedula.Text.Equals("") ? null : txtCedula.Text;
                    string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;
                    string correo = txtCorreo.Text.Equals("") ? null : txtCorreo.Text;
                    string telefono = txtTelefono.Text.Equals("") ? null : txtTelefono.Text;

                    BLDoctor.editarDoctor(IdDoctor, txtNombre.Text, txtApellido1.Text,
                                            estado, int.Parse(cmbCliente.SelectedValue.ToString()),
                                            cedula, apellido2, correo, telefono);
                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al editar doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtNombre.Focus();
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
                txtApellido1.Focus();
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
            if (string.IsNullOrWhiteSpace(cmbCliente.Text))
            {
                e.Cancel = true;
                cmbCliente.Focus();
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
