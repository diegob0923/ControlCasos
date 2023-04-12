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

namespace ControlCasos.Formularios.Casos
{
    public partial class frmCasos : Form
    {
        private IList<sp_Caso_Consultar_Result> listaCasos;
        private readonly BLDoctor BLDoctor = new BLDoctor();
        private readonly BLCaso BLCaso = new BLCaso();
        public frmCasos()
        {
            InitializeComponent();
            cargarComboDoctor();
            consultarCasos();
            eliminarImagenDefaultEnColumnaDetallesCuandoNoHayDatos();
        }

        private void cargarComboDoctor()
        {
            try
            {
                sp_Doctor_Consultar_Result opcionDefault = new sp_Doctor_Consultar_Result();
                opcionDefault.Doctor = "Seleccione:";

                IList<sp_Doctor_Consultar_Result> fuenteDatos = BLDoctor.consultarDoctores(null);//null es para que consulte todos
                fuenteDatos.Insert(0, opcionDefault);
                cmbDoctor.DataSource = fuenteDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar lista desplegable de clientes");
            }
        }

        public IList<sp_Caso_Consultar_Result> consultarCasos()
        {
            try
            {
                listaCasos = BLCaso.consultarCasos(null);
                return listaCasos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar casos");
                return null;
            }
        }

        private void cargarComboPaciente()
        {
            try
            {
                if (int.Parse(cmbDoctor.SelectedValue.ToString()) == 0)
                {
                    // aquí entra la primera vez que el grid carga
                    cmbPaciente.Text = "";
                    return;
                }

                if (int.Parse(cmbDoctor.SelectedValue.ToString()) != 0)
                {
                    cmbPaciente.DataSource = null;

                    var pacientesPorDoctor = listaCasos.Where(x => x.IdDoctor == int.Parse(cmbDoctor.SelectedValue.ToString())).ToList();

                    if (pacientesPorDoctor.Count != 0)
                    {
                        cmbPaciente.DataSource = pacientesPorDoctor;
                        cmbPaciente.DisplayMember = "Paciente";
                        cmbPaciente.ValueMember = "Paciente";
                    }
                    else
                    {
                        cmbPaciente.Text = "No hay pacientes asociados";
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al cargar los pacientes" + e);
            }
        }

        private void cargarGridCasos()
        {
            if (int.Parse(cmbDoctor.SelectedValue.ToString()) != 0 && cmbPaciente.SelectedValue != null)
            {
                var casosFiltrados = listaCasos.Where((x => x.IdDoctor == int.Parse(cmbDoctor.SelectedValue.ToString()) && x.Paciente.Contains(cmbPaciente.SelectedValue.ToString()))).ToList();
                dgvListaCasos.AutoGenerateColumns = false;
                dgvListaCasos.DataSource = casosFiltrados;
            }

            if (cmbPaciente.Text.Equals(""))
            {
                dgvListaCasos.DataSource = null;
                eliminarImagenDefaultEnColumnaDetallesCuandoNoHayDatos();
            }
        }

        public void recargarComboPacienteLuegoDeInsertarNuevoCaso()
        {
            consultarCasos();//para actulaizar la lista de casos
            cargarComboPaciente();//volver a cargar el comboPaciente para que aparezca el nuevo paciente en la lista
        }
        private void eliminarImagenDefaultEnColumnaDetallesCuandoNoHayDatos()
        {
            dgvListaCasos.Rows[0].Cells["Detalles"].Value = new Bitmap(1, 1);
        }

        #region Eventos
        private void cmbDoctor_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarComboPaciente();
        }
        private void cmbPaciente_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarGridCasos();
        }
        private void dgvListaCasos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaCasos.Columns[e.ColumnIndex].Name == "Detalles")
            {
                if (dgvListaCasos.CurrentRow.Cells["idCaso"].Value != null)
                {

                    int idCaso = int.Parse(dgvListaCasos.CurrentRow.Cells["idCaso"].Value.ToString());

                    frmProductos formularioEditarColor = new frmProductos(idCaso);
                    formularioEditarColor.Visible = true;
                }
            }
        }
        private void dgvListaCasos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Rectangle cellRect = dgvListaCasos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point relativePoint = dgvListaCasos.PointToClient(Cursor.Position);
                if (cellRect.Contains(relativePoint))
                {
                    dgvListaCasos.Cursor = Cursors.Hand;
                }
                else
                {
                    dgvListaCasos.Cursor = Cursors.Default;
                }
            }
            else
            {
                dgvListaCasos.Cursor = Cursors.Default;
            }
        }
        private void dgvListaCasos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                var cell = dgvListaCasos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    var image = (Image)cell.Value;
                    var width = image.Width + cell.Style.Padding.Horizontal;
                    if (dgvListaCasos.Columns[e.ColumnIndex].Width != width)
                    {
                        dgvListaCasos.Columns[e.ColumnIndex].Width = width;
                    }
                }
            }
        }
        #endregion

        private void lnkNuevoCaso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoCaso formularioNuevoCaso = new frmNuevoCaso(this);
            formularioNuevoCaso.Visible = true;
        }
    }
}
