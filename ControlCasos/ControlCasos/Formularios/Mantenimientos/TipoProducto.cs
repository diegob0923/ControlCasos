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
            try
            {
                IList<sp_TipoProducto_Consultar_Result> fuenteDatos = tipoProductos.consultarTipoProductos(null);//null es para que consulte todos
                dgvListaTipoProductos.AutoGenerateColumns = false;
                dgvListaTipoProductos.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los tipos de producto");
            }
        }

        private void lnkNuevoTipoProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoTipoProducto formularioNuevoTipoProducto = new frmNuevoTipoProducto(this);//el constructor recibe un tipo frmTipoProducto por eso se envía él mismo
            formularioNuevoTipoProducto.Visible = true;
        }
        #region Filtro
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDatosEnGrid();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                btnCancelar.Visible = true;
            else
                btnCancelar.Visible = false;
        }      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_TipoProducto_Consultar_Result> fuenteDatos = tipoProductos.consultarTipoProductos(txtBuscar.Text);
                dgvListaTipoProductos.AutoGenerateColumns = false;
                dgvListaTipoProductos.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar tipos de producto");
            }
        }
        #endregion
    }
}
