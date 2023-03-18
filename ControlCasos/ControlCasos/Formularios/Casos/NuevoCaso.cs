using ControlCasos.BL;
using ControlCasos.Modelos;
using ControlCasos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCasos.Formularios.Casos
{
    public partial class frmNuevoCaso : Form
    {
        private readonly BLDoctor BLDcotores = new BLDoctor();
        private readonly BLMarca BLMarcas = new BLMarca();
        private readonly BLTipoProducto BLTipoProductos = new BLTipoProducto();
        private readonly BLColor BLColores = new BLColor();
        private List<Producto> listaProducto = new List<Producto>();

        public frmNuevoCaso()
        {
            InitializeComponent();
            eliminarImagenDefaultEnColumnaEliminarCuandoNoHayDatos();
            cargarComboBoxDoctores();
            cargarComboBoxMarca();
            cargarComboBoxTipoProducto();
            cargarComboBoxColor();
        }

#region Cargar ComboBoxes
        private void cargarComboBoxDoctores()
        {
            try
            {
                sp_Doctor_Consultar_Result  opcionDefault = new sp_Doctor_Consultar_Result();
                opcionDefault.Doctor = "Seleccione:";

                IList<sp_Doctor_Consultar_Result> fuenteDatos = BLDcotores.consultarDoctores(null);//null es para que consulte todos
                fuenteDatos.Insert(0, opcionDefault);
                cmbDoctor.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de doctores");
            }
        }
        private void cargarComboBoxMarca()
        {
            try
            {
                sp_Marca_Consultar_Result opcionDefault = new sp_Marca_Consultar_Result();
                opcionDefault.Marca = "Seleccione:";

                IList<sp_Marca_Consultar_Result> fuenteDatos = BLMarcas.consultarMarcas(null);//null es para que consulte todos
                fuenteDatos.Insert(0, opcionDefault);
                cmbMarca.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de marcas");
            }
        }
        private void cargarComboBoxTipoProducto()
        {
            try
            {
                sp_TipoProducto_Consultar_Result opcionDefault = new sp_TipoProducto_Consultar_Result();
                opcionDefault.TipoProducto = "Seleccione:";

                IList<sp_TipoProducto_Consultar_Result> fuenteDatos = BLTipoProductos.consultarTipoProductos(null);//null es para que consulte todos
                fuenteDatos.Insert(0, opcionDefault);
                cmbTipoProducto.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de tipo productos");
            }
        }
        private void cargarComboBoxColor()
        {
            try
            {
                sp_Color_Consultar_Result opcionDefault = new sp_Color_Consultar_Result();
                opcionDefault.ColorGuia = "Seleccione:";

                IList<sp_Color_Consultar_Result> fuenteDatos = BLColores.consultarColores(null,null);//null es para que consulte todos
                fuenteDatos.Insert(0, opcionDefault);
                cmbColor.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de colores");
            }
        }
        #endregion
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto();
            nuevoProducto.tamano = txtTamano.Text;
            nuevoProducto.diametro = txtDiametro.Text;
            nuevoProducto.cantidad = byte.Parse(txtCantidad.Text);
            nuevoProducto.idColor = byte.Parse(cmbColor.SelectedValue.ToString());
            nuevoProducto.color = cmbColor.Text;
            nuevoProducto.idMarca = byte.Parse(cmbMarca.SelectedValue.ToString());
            nuevoProducto.marca = cmbMarca.Text;
            nuevoProducto.idTipoProducto = byte.Parse(cmbTipoProducto.SelectedValue.ToString());
            nuevoProducto.tipoProducto = cmbTipoProducto.Text;
            nuevoProducto.comentario = txtComentario.Text;

            listaProducto.Add(nuevoProducto);
            cargarDatosEnGrid();
        }

        public void cargarDatosEnGrid()
        {
            try
            {
                dgvResumenProductos.DataSource = null;
                dgvResumenProductos.AutoGenerateColumns = false;
                dgvResumenProductos.DataSource = listaProducto;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los datos de productos");
            }
        }

        private void eliminarImagenDefaultEnColumnaEliminarCuandoNoHayDatos()
        {
            dgvResumenProductos.Rows[0].Cells["Eliminar"].Value = new Bitmap(1, 1);
        }

        private void dgvResumenProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResumenProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                try
                {
                    listaProducto.RemoveAt(dgvResumenProductos.CurrentRow.Index);//el currentRow index es equivalente al index de listaProductos
                    cargarDatosEnGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al eliminar prducto");
                }
            }
        }
    }
}
