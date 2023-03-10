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

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmNuevaMarca : Form
    {
        private frmMarcas formularioMarcas;
        private readonly BLMarca BLMarca = new BLMarca();
        public frmNuevaMarca(frmMarcas formularioMarcas)
        {
            InitializeComponent();
            this.formularioMarcas = formularioMarcas;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioMarcas.cargarDatosEnGrid();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLMarca.insertarMarca(txtMarca.Text);
                
                recargarGridEnFormularioPrincipal();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar cliente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
