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

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmNuevoColor : Form
    {
        private frmColores formularioColores;
        private readonly BLColor BLColores = new BLColor();
        public frmNuevoColor(frmColores formularioColores)
        {
            InitializeComponent();
            this.formularioColores = formularioColores;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioColores.cargarDatosEnGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLColores.insertarColor(txtColor.Text, txtGuia.Text);
                
                recargarGridEnFormularioPrincipal();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar color");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
