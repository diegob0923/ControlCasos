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
using ControlCasos.Constantes;

namespace ControlCasos.Formularios.Casos
{
    public partial class frmProductos : Form
    {
        private readonly BLCaso BLCaso = new BLCaso();
        public frmProductos(int idCaso)
        {
            InitializeComponent();
            Formato.DarFormatoDataGridView(dgvProductos);
            cargarGridProductos(idCaso);
        }

        private void cargarGridProductos(int idCaso)
        {
            try
            {
                IList<sp_ProductosPorCaso_Consultar_Result> fuenteDatos = BLCaso.consultarProductosPorCaso(idCaso);
                dgvProductos.AutoGenerateColumns = false;
                dgvProductos.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar los productos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Colores")
            {
                try
                {
                    int idProducto = int.Parse(dgvProductos.CurrentRow.Cells["Id"].Value.ToString());

                    IList<string> listaColores = BLCaso.consultarColoresPorProducto(idProducto);

                    string coloresEnProducto = "";
                    foreach (string color in listaColores)
                    {
                        coloresEnProducto += "* " + color+ "\n";
                    }

                    MessageBox.Show(coloresEnProducto,"Colores",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al cargar colores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            // Se le asigna el numero de celda de las celdas editar-eliminar, porque es donde está la imagen
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvProductos.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvProductos.ResumeLayout();
                }
            }
        }
    }
}
