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
    public partial class frmEditarMarca : Form
    {
        private frmMarcas formularioMarcas;
        private readonly BLMarca BLMarca = new BLMarca();
        private readonly int IdMarca;
        public frmEditarMarca(frmMarcas formularioMarcas, int idMarca)
        {
            InitializeComponent();
            cargarDatosMarca(idMarca);
            IdMarca = idMarca;
            this.formularioMarcas = formularioMarcas;
        }

        private void recargarGridEnFormularioPrincipal()
        {
            formularioMarcas.cargarDatosEnGrid();
        }
        private void cargarDatosMarca(int idMarca)
        {
            try
            {
                sp_MarcaID_Consultar_Result datosMarca = BLMarca.consultarMarcaId(idMarca);
                txtMarca.Text = datosMarca.Marca;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos de la marca");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BLMarca.editarMarca(IdMarca, txtMarca.Text);
                recargarGridEnFormularioPrincipal();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar marca");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
