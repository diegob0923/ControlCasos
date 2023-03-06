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
                opcionDefault.Cliente = "Seleccione un cliente";
            
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtCedula.Text.Equals("")? null: txtCedula.Text;
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
                MessageBox.Show("Error al agregar cliente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}