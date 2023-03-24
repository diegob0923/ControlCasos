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
    }
}
