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
    public partial class frmEditarTipoProducto : Form
    {
        private frmTipoProducto formularioTipoProducto;
        private readonly BLTipoProducto BLTipoProducto = new BLTipoProducto();
        private readonly int IdTipoProducto;
        public frmEditarTipoProducto(frmTipoProducto formularioTipoProducto, int idTipoProducto)
        {
            InitializeComponent();
            cargarDatosTipoProducto(idTipoProducto);
            IdTipoProducto = idTipoProducto;
            this.formularioTipoProducto = formularioTipoProducto;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioTipoProducto.cargarDatosEnGrid();
        }
        private void cargarDatosTipoProducto(int idTipoProducto)
        {
            try
            {
                sp_TipoProductoID_Consultar_Result datosTipoProducto = BLTipoProducto.consultarTipoProductoID(idTipoProducto);
                txtTipoProducto.Text = datosTipoProducto.TipoProducto;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos del tipo de producto");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLTipoProducto.editarTipoProducto(IdTipoProducto, txtTipoProducto.Text);
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
