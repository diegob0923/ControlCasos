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

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    BLColores.insertarColor(txtColor.Text, txtGuia.Text);

                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtColor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                e.Cancel = true;
                txtColor.Focus();
                epColorValidar.SetError(txtColor, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epColorValidar.SetError(txtColor, "");
            }
        }
        #endregion
    }
}