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
using ControlCasos.Modelos;

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmClientes : Form
    {
        private BLCliente clientes = new BLCliente();
        public frmClientes()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }

        private void cargarDatosEnGrid()
        {
            IList<sp_Cliente_Consultar_Result> fuenteDatos = clientes.consultarClientes(null);//null es para que consulte todos
            dgvListaClientes.AutoGenerateColumns = false;
            dgvListaClientes.DataSource= fuenteDatos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<sp_Cliente_Consultar_Result> fuenteDatos = clientes.consultarClientes(txtBuscar.Text);
            dgvListaClientes.AutoGenerateColumns = false;
            dgvListaClientes.DataSource = fuenteDatos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDatosEnGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                btnCancelar.Visible = true;
            }
            else
            {
                btnCancelar.Visible = false;
            }
                
        }
    }
}
