﻿using ControlCasos.BL;
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
    }
}
