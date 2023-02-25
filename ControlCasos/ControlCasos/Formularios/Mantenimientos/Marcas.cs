﻿using ControlCasos.BL;
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
            IList<sp_Marca_Consultar_Result> fuenteDatos = marcas.consultarMarcas(txtBuscar.Text);
            dgvListaMarcas.AutoGenerateColumns = false;
            dgvListaMarcas.DataSource = fuenteDatos;
        }
        #endregion

        private void lnkNuevaMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevaMarca formularioNuevaMarca = new frmNuevaMarca(this);//como la instancia es de tipo frmCliente se envía él mismo
            formularioNuevaMarca.Visible = true;
        }
    }
}
