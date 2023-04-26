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
using ControlCasos.Constantes;

namespace ControlCasos.Formularios.Mantenimientos
{
    public partial class frmClientes : Form
    {
        private BLCliente clientes = new BLCliente();
        public frmClientes()
        {
            InitializeComponent();
            Formato.DarFormatoDataGridView(dgvListaClientes);
            cargarDatosEnGrid();
  
        }

        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_Cliente_Consultar_Result> fuenteDatos = clientes.consultarClientes(null);//null es para que consulte todos
                dgvListaClientes.AutoGenerateColumns = false;
                dgvListaClientes.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los clientes");
            }
        }

        #region Filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_Cliente_Consultar_Result> fuenteDatos = clientes.consultarClientes(txtBuscar.Text);
                dgvListaClientes.AutoGenerateColumns = false;
                dgvListaClientes.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar clientes");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            lblBuscar.Visible = true;
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
        private void lnkNuevoCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoCliente formularioNuevoCliente = new frmNuevoCliente(this);//el constructor recibe un tipo frmCliente por eso se envía él mismo
            formularioNuevoCliente.Visible = true;
        }

        #region Eventos
        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCliente = int.Parse(dgvListaClientes.CurrentRow.Cells["Id"].Value.ToString());

            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmEditarCliente formularioEditarCliente = new frmEditarCliente(this, idCliente);
                formularioEditarCliente.Visible = true;
            }
            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Está a punto de eliminar el cliente: \" " + dgvListaClientes.CurrentRow.Cells["Cliente"].Value.ToString() + "\". ¿Desea continuar?", "Eliminar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    try
                    {
                        clientes.eliminarCliente(idCliente);
                        cargarDatosEnGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al eliminar el cliente.\nPosibles causas:\n Puede existan otros registros asociados al elemento que intenta borrar");
                    }
            }
        }
        
        private void dgvListaClientes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            // Se le asigna el numero de celda de las celdas editar-eliminar, porque es donde está la imagen
            if ((e.ColumnIndex == 3 || e.ColumnIndex == 2) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvListaClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvListaClientes.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvListaClientes.ResumeLayout();
                }
            }
        }
        #endregion

        
    }
}
