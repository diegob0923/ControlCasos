using ControlCasos.BL;
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
    public partial class frmMarcas : Form
    {
        private BLMarca marcas = new BLMarca();
        public frmMarcas()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            IList<sp_Marca_Consultar_Result> fuenteDatos = marcas.consultarMarcas(null);//null es para que consulte todos
            dgvListaMarcas.AutoGenerateColumns = false;
            dgvListaMarcas.DataSource = fuenteDatos;
        }
    }
}
