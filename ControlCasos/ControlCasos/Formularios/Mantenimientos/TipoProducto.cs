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
    public partial class frmTipoProducto : Form
    {
        private BLTipoProducto tipoProductos = new BLTipoProducto();
        public frmTipoProducto()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }
        public void cargarDatosEnGrid()
        {
            IList<sp_TipoProducto_Consultar_Result> fuenteDatos = tipoProductos.consultarTipoProductos(null);//null es para que consulte todos
            dgvListaTipoProductos.AutoGenerateColumns = false;
            dgvListaTipoProductos.DataSource = fuenteDatos;
        }

        private void lnkNuevoTipoProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoTipoProducto formularioNuevoTipoProducto = new frmNuevoTipoProducto(this);//como la instancia es de tipo frmCliente se envía él mismo
            formularioNuevoTipoProducto.Visible = true;
        }
    }
}
