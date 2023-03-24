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
    public partial class frmClientes : Form
    {
        private BLCliente clientes = new BLCliente();
        public frmClientes()
        {
            InitializeComponent();
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
            cargarDatosEnGrid();
        }
        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                btnCancelar.Visible = true;
            else
                btnCancelar.Visible = false;   
        }
        #endregion
        private void lnkNuevoCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoCliente formularioNuevoCliente = new frmNuevoCliente(this);//el constructor recibe un tipo frmCliente por eso se envía él mismo
            formularioNuevoCliente.Visible = true;
        }

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
