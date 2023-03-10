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

namespace ControlCasos.Formularios.Casos
{
    public partial class frmProductos : Form
    {
        private readonly BLCaso BLCaso = new BLCaso();
        public frmProductos(int idCaso)
        {
            InitializeComponent();
            cargarGridProductos(idCaso);
        }

        private void cargarGridProductos(int idCaso)
        {
            try
            {
                IList<sp_ProductosPorCaso_Consultar_Result> fuenteDatos = BLCaso.consultarProductosPorCaso(idCaso);
                dgvProductos.AutoGenerateColumns = false;
                dgvProductos.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los productos");
            }
        }
    }
}
