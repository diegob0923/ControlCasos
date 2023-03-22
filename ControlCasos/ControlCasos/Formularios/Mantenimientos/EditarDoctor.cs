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
                MessageBox.Show("Error al cargar lista desplegable de clientes");
            }
        }

        private void cargarDatosDoctor(int idDoctor)
        {
            try
            {
                sp_DoctorID_Consultar_Result datosDoctor = BLDoctor.consultarDoctorID(idDoctor);
                string[] nombreDoctorSeparado = datosDoctor.Doctor.Split(' ');// el orden quedaría nombre apellodo1 apellido2
                txtCedula.Text = datosDoctor.cedula;
                txtNombre.Text = nombreDoctorSeparado[0];
                txtApellido1.Text = nombreDoctorSeparado[1];
                txtApellido2.Text = nombreDoctorSeparado[2];
                txtCorreo.Text = datosDoctor.correo;
                txtTelefono.Text = datosDoctor.telefono;
                cmbCliente.Text = datosDoctor.Cliente;
                cmbEstado.Text = datosDoctor.Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos color");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool estado = cmbEstado.Text.Equals("Activo") ? Estado.Activo : Estado.Inactivo;
                string cedula = txtCedula.Text.Equals("") ? null : txtCedula.Text;
                string apellido2 = txtApellido2.Text.Equals("") ? null : txtApellido2.Text;
                string correo = txtCorreo.Text.Equals("") ? null : txtCorreo.Text;
                string telefono = txtTelefono.Text.Equals("") ? null : txtTelefono.Text;

                BLDoctor.editarDoctor(IdDoctor, txtNombre.Text,txtApellido1.Text,
                                        estado, int.Parse(cmbCliente.SelectedValue.ToString()),
                                        cedula, apellido2, correo, telefono);
                recargarGridEnFormularioPrincipal();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar color");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
