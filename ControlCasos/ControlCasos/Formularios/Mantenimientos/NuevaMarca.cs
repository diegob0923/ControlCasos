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

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Validación campos
        /// <summary>
        /// Evita que se active el errorProvider al hacer click en la X para cerrar el formulario
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                e.Cancel = true;
                txtMarca.Focus();
                epMarcaValidar.SetError(txtMarca, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epMarcaValidar.SetError(txtMarca, "");
            }
        }
        #endregion
    }
}
