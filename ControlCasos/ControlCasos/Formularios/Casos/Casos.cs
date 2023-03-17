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
            listaCasos = consultarCasos();
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

        private IList<sp_Caso_Consultar_Result> consultarCasos()
        {
            try
            {
                IList<sp_Caso_Consultar_Result> listaCasos = BLCaso.consultarCasos(null);
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
        private void dgvListaCasos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaCasos.Columns[e.ColumnIndex].Name == "Detalles")
            {
                if(dgvListaCasos.CurrentRow.Cells["idCaso"].Value != null) {
                    
                    int idCaso = int.Parse(dgvListaCasos.CurrentRow.Cells["idCaso"].Value.ToString());

                    frmProductos formularioEditarColor = new frmProductos(idCaso);
                    formularioEditarColor.Visible = true;
                }  
            }
        }
        #endregion

        private void lnkNuevoCaso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoCaso formularioNuevoCaso = new frmNuevoCaso();
            formularioNuevoCaso.Visible = true;
        }
    }
}
