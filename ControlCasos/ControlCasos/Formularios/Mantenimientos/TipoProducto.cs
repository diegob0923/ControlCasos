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
using ControlCasos.Modelos;
using ControlCasos.Constantes;

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmTipoProducto : Form
    {
        private BLTipoProducto tipoProductos = new BLTipoProducto();
        public frmTipoProducto()
        {
            InitializeComponent();
            Formato.DarFormatoDataGridView(dgvListaTipoProductos);
            Formato.DarAlturaCorrectaTextBoxSinBorde(txtBuscar);
            cargarDatosEnGrid();
        }
        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_TipoProducto_Consultar_Result> fuenteDatos = tipoProductos.consultarTipoProductos(null);//null es para que consulte todos
                dgvListaTipoProductos.AutoGenerateColumns = false;
                dgvListaTipoProductos.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar los tipos de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkNuevoTipoProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoTipoProducto formularioNuevoTipoProducto = new frmNuevoTipoProducto(this);//el constructor recibe un tipo frmTipoProducto por eso se envía él mismo
            formularioNuevoTipoProducto.Visible = true;
        }
        #region Filtro
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDatosEnGrid();
        }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_TipoProducto_Consultar_Result> fuenteDatos = tipoProductos.consultarTipoProductos(txtBuscar.Text);
                dgvListaTipoProductos.AutoGenerateColumns = false;
                dgvListaTipoProductos.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al buscar tipos de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Eventos
        private void dgvListaTipoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTipoProducto = int.Parse(dgvListaTipoProductos.CurrentRow.Cells["Id"].Value.ToString());

            if (dgvListaTipoProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmEditarTipoProducto formularioEditarTipoProducto = new frmEditarTipoProducto(this, idTipoProducto);
                formularioEditarTipoProducto.Visible = true;
            }

            if (dgvListaTipoProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Está a punto de eliminar el tipo de producto: \"" + dgvListaTipoProductos.CurrentRow.Cells["TipoProducto"].Value.ToString() + "\". ¿Desea continuar?", "Eliminar Tipo Producto", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    try
                    {
                        tipoProductos.eliminarTipoProducto(idTipoProducto);
                        cargarDatosEnGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el tipo de producto.\nPosibles causas:\n Puede existan otros registros asociados al elemento que intenta borrar.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void dgvListaTipoProductos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            // Se le asigna el numero de celda de las celdas editar-eliminar, porque es donde está la imagen
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvListaTipoProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvListaTipoProductos.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvListaTipoProductos.ResumeLayout();
                }
            }
        }
        #endregion
    }
}
