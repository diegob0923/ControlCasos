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
    }
}
