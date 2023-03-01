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
    public partial class frmDoctores : Form
    {
        private BLDoctor doctores = new BLDoctor();
        public frmDoctores()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_Doctor_Consultar_Result> fuenteDatos = doctores.consultarDoctores(null);//null es para que consulte todos
                dgvListaDoctores.AutoGenerateColumns = false;
                dgvListaDoctores.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los doctores");
            }
        }

        #region Filtro
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                btnCancelar.Visible = true;
            else
                btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDatosEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_Doctor_Consultar_Result> fuenteDatos = doctores.consultarDoctores(txtBuscar.Text);
                dgvListaDoctores.AutoGenerateColumns = false;
                dgvListaDoctores.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar doctores");
            }
        }
        #endregion

        private void lnkNuevoCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoDoctor formularioNuevoDoctor = new frmNuevoDoctor(this);//el constructor recibe un tipo frmDoctor por eso se envía él mismo
            formularioNuevoDoctor.Visible = true;
        }
    }
}
