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
        public frmClientes()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }

        void cargarDatosEnGrid()
        {
            BLCliente clientes = new BLCliente();
            IList<sp_Cliente_Consultar_Result> fuenteDatos = clientes.consultarClientes(null);//null es para que consulte todos
            dgvListaClientes.AutoGenerateColumns = false;
            dgvListaClientes.DataSource= fuenteDatos;
        }
    }
}
