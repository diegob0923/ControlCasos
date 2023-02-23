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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLTipoProducto.insertarTipoProducto(txtTipoProducto.Text))
                {
                    recargarGridEnFormularioPrincipal();
                    this.Dispose();
                }
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
