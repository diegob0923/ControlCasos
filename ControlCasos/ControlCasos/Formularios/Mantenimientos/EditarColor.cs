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
    public partial class frmEditarColor : Form
    {
        private frmColores formularioColores;
        private readonly BLColor BLColor = new BLColor();
        private readonly int IdColor;
        public frmEditarColor(frmColores formularioColores, int idColor)
        {
            InitializeComponent();
            cargarDatosColor(idColor);
            IdColor = idColor;
            this.formularioColores = formularioColores;
        }
        private void recargarGridEnFormularioPrincipal()
        {
            formularioColores.cargarDatosEnGrid();
        }
        private void cargarDatosColor(int idColor)
        {
            try
            {
                sp_ColorID_Consultar_Result datosColor = BLColor.consultarColorID(idColor);
                txtColor.Text = datosColor.Color;
                txtGuia.Text = datosColor.Guia;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos color");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLColor.editarColor(IdColor, txtColor.Text, txtGuia.Text);
                recargarGridEnFormularioPrincipal();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar color");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
