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
    public partial class frmColores : Form
    {
        BLColor colores = new BLColor();
        public frmColores()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            IList<sp_Color_Consultar_Result> fuenteDatos = colores.consultarColores();//null es para que consulte todos
            dgvListaColores.AutoGenerateColumns = false;
            dgvListaColores.DataSource = fuenteDatos;
        }

        private void lnkNuevoColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoColor formularioNuevoColor = new frmNuevoColor(this);//como la instancia es de tipo frmColor se envía él mismo
            formularioNuevoColor.Visible = true;
        }

        #region Filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<sp_Color_Consultar_Result> fuenteDatos = colores.consultarColores(txtBuscar.Text,txtBuscar.Text);
            dgvListaColores.AutoGenerateColumns = false;
            dgvListaColores.DataSource = fuenteDatos;
        }

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
        #endregion
    }
}
