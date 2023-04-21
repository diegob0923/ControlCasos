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
    public partial class frmColores : Form
    {
        BLColor colores = new BLColor();
        public frmColores()
        {
            InitializeComponent();
            Formato.DarFormatoDataGridView(dgvListaColores);
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_Color_Consultar_Result> fuenteDatos = colores.consultarColores();//null es para que consulte todos
                dgvListaColores.AutoGenerateColumns = false;
                dgvListaColores.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los colores");
            }
        }

        private void lnkNuevoColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoColor formularioNuevoColor = new frmNuevoColor(this);//el constructor recibe un tipo frmColor por eso se envía él mismo
            formularioNuevoColor.Visible = true;
        }

        #region Filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_Color_Consultar_Result> fuenteDatos = colores.consultarColores(txtBuscar.Text, txtBuscar.Text);
                dgvListaColores.AutoGenerateColumns = false;
                dgvListaColores.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar colores");
            }
        }

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
        private void dgvListaColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColor = int.Parse(dgvListaColores.CurrentRow.Cells["Id"].Value.ToString());

            if (dgvListaColores.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmEditarColor formularioEditarColor = new frmEditarColor(this, idColor);
                formularioEditarColor.Visible = true;
            }

            if (dgvListaColores.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Está a punto de eliminar el color: \"" + dgvListaColores.CurrentRow.Cells["ColorGuia"].Value.ToString() +"\". ¿Desea continuar?", "Eliminar Color", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    try
                    {
                        colores.eliminarColor(idColor);
                        cargarDatosEnGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al eliminar el color.\nPosibles causas:\n Puede existan otros registros asociados al elemento que intenta borrar");
                    }
            }
        }

        private void dgvListaColores_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            // Se le asigna el numero de celda de las celdas editar-eliminar, porque es donde está la imagen
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvListaColores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvListaColores.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvListaColores.ResumeLayout();
                }
            }
        }
        #endregion
    }
}
