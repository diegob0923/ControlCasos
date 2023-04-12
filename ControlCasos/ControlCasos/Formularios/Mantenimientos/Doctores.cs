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
using ControlCasos.Modelos;

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmDoctores : Form
    {
        private BLDoctor doctores = new BLDoctor();
        public frmDoctores()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_Doctor_Consultar_Result> fuenteDatos = doctores.consultarDoctores(null);//null es para que consulte todos
                dgvListaDoctores.AutoGenerateColumns = false;
                dgvListaDoctores.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los doctores");
            }
        }

        #region Filtro
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                btnCancelar.Visible = true;
            else
                btnCancelar.Visible = false;
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
                IList<sp_Doctor_Consultar_Result> fuenteDatos = doctores.consultarDoctores(txtBuscar.Text);
                dgvListaDoctores.AutoGenerateColumns = false;
                dgvListaDoctores.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar doctores");
            }
        }
        #endregion

        private void lnkNuevoCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoDoctor formularioNuevoDoctor = new frmNuevoDoctor(this);//el constructor recibe un tipo frmDoctor por eso se envía él mismo
            formularioNuevoDoctor.Visible = true;
        }

        #region Eventos
        private void dgvListaDoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDoctor = int.Parse(dgvListaDoctores.CurrentRow.Cells["Id"].Value.ToString());

            if (dgvListaDoctores.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmEditarDoctor formularioEditarDoctor = new frmEditarDoctor(this, idDoctor);
                formularioEditarDoctor.Visible = true;
            }

            if (dgvListaDoctores.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Está a punto de eliminar el doctor: \"" + dgvListaDoctores.CurrentRow.Cells["Doctor"].Value.ToString() + "\". ¿Desea continuar?", "Eliminar Doctor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    try
                    {
                        doctores.eliminarDoctor(idDoctor);
                        cargarDatosEnGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al eliminar el doctor.\nPosibles causas:\n Puede existan otros registros asociados al elemento que intenta borrar");
                    }
            }
        }
        
        private void dgvListaDoctores_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex == 6 || e.ColumnIndex == 7) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvListaDoctores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvListaDoctores.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvListaDoctores.ResumeLayout();
                }
            }
        }
        #endregion
    }
}
