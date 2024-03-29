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
using System.Globalization;
using ControlCasos.Constantes;

namespace ControlCasos.Formularios.Casos
{
    public partial class frmNuevoCaso : Form
    {
        private readonly BLDoctor BLDcotores = new BLDoctor();
        private readonly BLMarca BLMarcas = new BLMarca();
        private readonly BLTipoProducto BLTipoProductos = new BLTipoProducto();
        private readonly BLColor BLColores = new BLColor();
        private readonly BLCaso BLCasos = new BLCaso();
        private List<Producto> listaProductos = new List<Producto>();
        private List<sp_Color_Consultar_Result> listaColores = new List<sp_Color_Consultar_Result>();
        private frmCasos formularioCasos;
        private const int ErrorAlInsertarProducto = -1;

        public frmNuevoCaso(frmCasos formularioCasos)
        {
            InitializeComponent();
            Formato.DarFormatoDataGridView(dgvResumenProductos); 
            Formato.DarFormatoDataGridView(dgvListaColores);
            this.formularioCasos = formularioCasos;
            cargarComboBoxDoctores();
            cargarComboBoxMarca();
            cargarComboBoxTipoProducto();
            cargarComboBoxColor();
        }

        #region Cargar Grids
        public void cargarDatosEnGrid()
        {
            try
            {
                dgvResumenProductos.DataSource = null;
                dgvResumenProductos.AutoGenerateColumns = false;
                dgvResumenProductos.DataSource = listaProductos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos de productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosEnGridColores()
        {
            try
            {
                dgvListaColores.DataSource = null;
                dgvListaColores.AutoGenerateColumns = false;
                dgvListaColores.DataSource = listaColores;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos del color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        /// <summary>
        /// cambia el formato del nombre para que sea tipo título
        /// "lorem lipsum et" a "Lorem Lipsum Et"
        /// </summary>
        /// <param name="paciente">nombre del paciente</param>
        /// <returns></returns>
        private string darFormatoDeTituloAlStringPaciente(string paciente)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(paciente);
        }

        #region Cargar ComboBoxes
        private void cargarComboBoxDoctores()
        {
            try
            {
                sp_Doctor_Consultar_Result  opcionDefault = new sp_Doctor_Consultar_Result();
                opcionDefault.DoctorCliente = "Seleccione:";

                IList<sp_Doctor_Consultar_Result> fuenteDatos = BLDcotores.consultarDoctores(null);//null es para que consulte todos
                fuenteDatos.Insert(0, opcionDefault);
                cmbDoctor.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de doctores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al cargar lista desplegable de marcas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al cargar lista desplegable de tipo productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al cargar lista desplegable de colores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        
        #region LimpiarCampos
        private void limpiarDatosProducto()
        {
            txtTamano.Text = "";
            txtDiametro.Text = "";
            nudCantidad.Text = 1.ToString();
            cmbColor.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbTipoProducto.SelectedIndex = 0;
            txtComentario.Text = "";
            listaColores.Clear();
            dgvListaColores.DataSource = null;
        }

        private void limpiarTodoSiError()
        {
            cmbDoctor.SelectedIndex = 0;
            txtPaciente.Text = "";
            dtpFecha.Value = DateTime.Now;
            limpiarDatosProducto();
            listaProductos.Clear();//limpia los posibles datos en la lista de productos
            listaColores.Clear();//limpia los posibles datos en la lista de colores
            dgvResumenProductos.DataSource = null; // dejar el grid resumenProductos vacío
            dgvListaColores.DataSource = null;// dejar el grid listaColores vacío
        }
        #endregion
        
        #region Eventos

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //controles que quiero validar
            cmbDoctor.CausesValidation = true;
            txtPaciente.CausesValidation = true;

            //controles que no quiero validar
            cmbTipoProducto.CausesValidation = false;
            cmbMarca.CausesValidation = false;
            cmbColor.CausesValidation = false;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (listaProductos.Count != 0 && cmbDoctor.SelectedIndex != 0 && txtPaciente.Text != "")
                {
                    try
                    {
                        IList<int> listaRegistrosInsertados = new List<int>();
                        int idNuevoRegistro = 0;
                        int maxCasoId = 0;

                        if (BLCasos.insertarCaso(dtpFecha.Value, int.Parse(cmbDoctor.SelectedValue.ToString()),
                                                darFormatoDeTituloAlStringPaciente(txtPaciente.Text)))
                        {

                            maxCasoId = BLCasos.consultarCasoMaxID();//aquí el caso ya se creo exitosamente, recuperamos el id de ese caso recien insertado para asignar los productos con este caso

                            try
                            {
                                foreach (Producto producto in listaProductos)
                                {
                                    idNuevoRegistro = BLCasos.insertarProducto(producto.idMarca, producto.idTipoProducto, maxCasoId, producto.tamano, producto.diametro, producto.cantidad, producto.comentario);

                                    if (idNuevoRegistro != ErrorAlInsertarProducto)
                                    {
                                        listaRegistrosInsertados.Add(idNuevoRegistro);

                                        //agregar colores al producto
                                        foreach (sp_Color_Consultar_Result color in producto.colores)
                                        {
                                            BLCasos.insertarProductoColor(idNuevoRegistro, color.IdColor);
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                //eliminar posibles productos que se hayan creado
                                if (listaRegistrosInsertados.Count != 0)//si la lista tiene registros se empiezan a eliminar
                                {
                                    foreach (int idProducto in listaRegistrosInsertados)
                                    {
                                        BLCasos.eliminarProductoColor(idProducto);
                                        BLCasos.eliminarProducto(idProducto);
                                    }
                                }

                                //eliminar ultimo caso creado
                                if (maxCasoId != 0)
                                {
                                    BLCasos.eliminarCaso(maxCasoId);
                                }

                                limpiarTodoSiError();
                                throw new Exception();
                            }
                        }

                        MessageBox.Show("Nuevo caso creado satisfactoriamente.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        formularioCasos.recargarComboPacienteLuegoDeInsertarNuevoCaso();//esto va a actualizar la lista de casos para que los nuevos registros sean visibles

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al crear el caso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (listaProductos.Count == 0)
                        MessageBox.Show("Por favor agregue al menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cmbDoctor.SelectedIndex == 0 || txtPaciente.Text == "")
                        MessageBox.Show("Por favor ingrese un doctor y un paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //controles que quiero validar
            cmbTipoProducto.CausesValidation = true;
            cmbMarca.CausesValidation = true;

            //controles que no quiero validar
            cmbDoctor.CausesValidation = false;
            txtPaciente.CausesValidation = false;
            cmbColor.CausesValidation = false;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (listaColores.Count != 0)
                {
                    try
                    {
                        Producto nuevoProducto = new Producto();
                        nuevoProducto.tamano = txtTamano.Text;
                        nuevoProducto.diametro = txtDiametro.Text;
                        nuevoProducto.cantidad = byte.Parse(nudCantidad.Text);

                        foreach (sp_Color_Consultar_Result color in listaColores)
                        {
                            nuevoProducto.colores.Add(color);
                        }

                        nuevoProducto.color = cmbColor.Text;
                        nuevoProducto.idMarca = byte.Parse(cmbMarca.SelectedValue.ToString());
                        nuevoProducto.marca = cmbMarca.Text;
                        nuevoProducto.idTipoProducto = byte.Parse(cmbTipoProducto.SelectedValue.ToString());
                        nuevoProducto.tipoProducto = cmbTipoProducto.Text;
                        nuevoProducto.comentario = txtComentario.Text;

                        listaProductos.Add(nuevoProducto);
                        cargarDatosEnGrid();
                        limpiarDatosProducto();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Por favor agregue al menos un color.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            //controles que quiero validar
            cmbColor.CausesValidation = true;

            //controles que no quiero validar
            cmbDoctor.CausesValidation = false;
            txtPaciente.CausesValidation = false;
            cmbTipoProducto.CausesValidation = false;
            cmbMarca.CausesValidation = false;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    listaColores.Add((sp_Color_Consultar_Result)cmbColor.SelectedItem);
                    cargarDatosEnGridColores();
                    cmbColor.SelectedIndex = 0;// el index 0 es " Seleccione: "
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvResumenProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResumenProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                try
                {
                    listaProductos.RemoveAt(dgvResumenProductos.CurrentRow.Index);//el currentRow index es equivalente al index de listaProductos
                    cargarDatosEnGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al eliminar producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (dgvResumenProductos.Columns[e.ColumnIndex].Name == "Colores")
            {
                try
                {
                    string coloresEnProducto = "";
                    foreach (sp_Color_Consultar_Result color in listaProductos[e.RowIndex].colores)
                    {
                        coloresEnProducto += "● " + color.ColorGuia+"\n";
                    }
                   
                    MessageBox.Show(coloresEnProducto, "Colores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al cargar colores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvResumenProductos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            //Se le asigna el numero de celda de la celda eliminar, porque es donde está la imagen
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 2) && e.RowIndex != -1)
            {
                // Verificar si la fila y la columna son válidas
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtener la posición de la imagen en la celda actual
                    DataGridViewImageCell cell = (DataGridViewImageCell)dgvResumenProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle imageRectangle = cell.GetContentBounds(e.RowIndex);

                    // Deshabilitar temporalmente la actualización del control
                    dgvResumenProductos.SuspendLayout();

                    // Verificar si el puntero del mouse está sobre la imagen en la celda actual
                    if (imageRectangle.Contains(e.Location))
                        Cursor = Cursors.Hand; // Cambiar el cursor a mano
                    else
                        Cursor = Cursors.Default;// Cambiar el cursor al valor predeterminado

                    // Habilitar la actualización del control
                    dgvResumenProductos.ResumeLayout();
                }
            }
        }
        
        private void dgvResumenProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                var cell = dgvResumenProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    var image = (Image)cell.Value;
                    var width = image.Width + cell.Style.Padding.Horizontal;
                    if (dgvResumenProductos.Columns[e.ColumnIndex].Width != width)
                    {
                        dgvResumenProductos.Columns[e.ColumnIndex].Width = width;
                    }
                }
            }
        }
       
        private void dgvListaColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaColores.Columns[e.ColumnIndex].Name == "ColoresEliminar")
            {
                try
                {
                    listaColores.RemoveAt(dgvListaColores.CurrentRow.Index);//el currentRow index es equivalente al index de listaProductos
                    cargarDatosEnGridColores();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al eliminar color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListaColores_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.Default;

            //Se le asigna el numero de celda de la celda eliminar, porque es donde está la imagen
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
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

        #region Validación campos
        /// <summary>
        /// Evita que se active el errorProvider al hacer click en la X para cerrar el formulario
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        
        private void cmbDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDoctor.Text.Equals("Seleccione:"))
            {
                e.Cancel = true;
                epDoctorValidar.SetError(cmbDoctor, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epDoctorValidar.SetError(cmbDoctor, "");
            }
        }
        
        private void txtPaciente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaciente.Text))
            {
                e.Cancel = true;
                epPacienteValidar.SetError(txtPaciente, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epPacienteValidar.SetError(txtPaciente, "");
            }
        }

        private void cmbTipoProducto_Validating(object sender, CancelEventArgs e)
        {
            if (cmbTipoProducto.Text.Equals("Seleccione:"))
            {
                e.Cancel = true;
                epTipoProductoValidar.SetError(cmbTipoProducto, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epTipoProductoValidar.SetError(cmbTipoProducto, "");
            }
        }

        private void cmbMarca_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMarca.Text.Equals("Seleccione:"))
            {
                e.Cancel = true;
                epMarcaValidar.SetError(cmbMarca, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epMarcaValidar.SetError(cmbMarca, "");
            }
        }
       
        private void cmbColor_Validating(object sender, CancelEventArgs e)
        {
            if (cmbColor.Text.Equals("Seleccione:"))
            {
                e.Cancel = true;
                epColorValidar.SetError(cmbColor, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epColorValidar.SetError(cmbColor, "");
            }
        }
        #endregion
    }
}
