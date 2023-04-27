using ControlCasos.BL;
using ControlCasos.Modelos;
using ControlCasos.Constantes;
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
    public partial class frmMarcas : Form
    {
        private BLMarca marcas = new BLMarca();
        public frmMarcas()
        {
            InitializeComponent();
            Formato.DarFormatoDataGridView(dgvListaMarcas);
            Formato.DarAlturaCorrectaTextBoxSinBorde(txtBuscar);
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_Marca_Consultar_Result> fuenteDatos = marcas.consultarMarcas(null);//null es para que consulte todos
                dgvListaMarcas.AutoGenerateColumns = false;
                dgvListaMarcas.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar las marcas");
            }
        }

        #region Filtro
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                btnCancelar.Visible = true;
            else
            {
                btnCancelar.Visible = false;
                lblBuscar.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDatosEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_Marca_Consultar_Result> fuenteDatos = marcas.consultarMarcas(txtBuscar.Text);
                dgvListaMarcas.AutoGenerateColumns = false;
                dgvListaMarcas.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar marcas");
            }
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            txtBuscar.Select();
        }

        private void lblBuscar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.IBeam;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
        }
        #endregion

        private void lnkNuevaMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevaMarca formularioNuevaMarca = new frmNuevaMarca(this); //el constructor recibe un tipo frmMarca por eso se envía él mismo
            formularioNuevaMarca.Visible = true;
        }

        #region Eventos
        private void dgvListaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMarca = int.Parse(dgvListaMarcas.CurrentRow.Cells["Id"].Value.ToString());

            if (dgvListaMarcas.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmEditarMarca formularioEditarMarca = new frmEditarMarca(this, idMarca);
                formularioEditarMarca.Visible = true;
            }

            if (dgvListaMarcas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Está a punto de eliminar la marca: \"" + dgvListaMarcas.CurrentRow.Cells["Marca"].Value.ToString() + "\". ¿Desea continuar?", "Eliminar Marca", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    try
                    {
                        marcas.eliminarMarca(idMarca);
                        cargarDatosEnGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al eliminar la marca.\nPosibles causas:\n Puede existan otros registros asociados al elemento que intenta borrar");
                    }
            }
        }

        private void dgvListaMarcas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            // Se le asigna el numero de celda de las celdas editar-eliminar, porque es donde está la imagen
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvListaMarcas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvListaMarcas.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvListaMarcas.ResumeLayout();
                }
            }
        }
        #endregion
    }
}
