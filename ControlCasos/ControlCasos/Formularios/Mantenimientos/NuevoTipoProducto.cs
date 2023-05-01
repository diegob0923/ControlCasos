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
    public partial class frmNuevoTipoProducto : Form
    {
        private frmTipoProducto formularioTipoProductos;
        private readonly BLTipoProducto BLTipoProducto = new BLTipoProducto();
        public frmNuevoTipoProducto(frmTipoProducto formularioTipoProductos)
        {
            InitializeComponent();
            this.formularioTipoProductos = formularioTipoProductos;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioTipoProductos.cargarDatosEnGrid();
        }

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) 
            {
                try
                {
                    BLTipoProducto.insertarTipoProducto(txtTipoProducto.Text);

                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtTipoProducto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoProducto.Text))
            {
                e.Cancel = true;
                txtTipoProducto.Focus();
                epTipoProductoValidar.SetError(txtTipoProducto, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epTipoProductoValidar.SetError(txtTipoProducto, "");
            }
        }
        #endregion
    }
}
