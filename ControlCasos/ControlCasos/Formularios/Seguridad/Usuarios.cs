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

namespace ControlCasos.Formularios.Seguridad
{
    public partial class frmUsuarios : Form
    {
        BLUsuarioSistema usuarios = new BLUsuarioSistema();
        public frmUsuarios()
        {
            InitializeComponent();
            cargarDatosEnGrid();
        }
        public void cargarDatosEnGrid()
        {
            try
            {
                IList<sp_UsuarioSistema_Consultar_Result> fuenteDatos = usuarios.consultarUsuarios(null);//null es para que consulte todos
                dgvListaUsuarios.AutoGenerateColumns = false;
                dgvListaUsuarios.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los usuarios");
            }
        }

        private void lnkNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoUsuario formularioNuevoUsuario = new frmNuevoUsuario(this);
            formularioNuevoUsuario.Visible = true;
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte idUsuario = byte.Parse(dgvListaUsuarios.CurrentRow.Cells["Id"].Value.ToString());

            if (dgvListaUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmEditarUsuario formularioEditarMarca = new frmEditarUsuario(this, idUsuario);
                formularioEditarMarca.Visible = true;
            }
            
            if (dgvListaUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Está a punto de eliminar el usuario: \"" + dgvListaUsuarios.CurrentRow.Cells["Usuario"].Value.ToString() + "\". ¿Desea continuar?", "Eliminar Marca", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    try
                    {
                        usuarios.eliminarUsuario(idUsuario);
                        cargarDatosEnGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al eliminar el usuario");
                    }
            }
        }

        #region Filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IList<sp_UsuarioSistema_Consultar_Result> fuenteDatos = usuarios.consultarUsuarios(txtBuscar.Text);
                dgvListaUsuarios.AutoGenerateColumns = false;
                dgvListaUsuarios.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al buscar usuarios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDatosEnGrid();
        }
        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                btnCancelar.Visible = true;
            else
                btnCancelar.Visible = false;
        }

        private void dgvListaUsuarios_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex == 6 || e.ColumnIndex == 7) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvListaUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvListaUsuarios.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvListaUsuarios.ResumeLayout();
                }
            }
        }
    }
}
