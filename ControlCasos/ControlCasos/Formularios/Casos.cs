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

namespace ControlCasos.Formularios
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
            IList<sp_Caso_Consultar_Result> listaCasos = BLCaso.consultarCasos(null);
            return listaCasos;
        }

        private void cargarComboPaciente()
        {
            try
            {
                if (int.Parse(cmbDoctor.SelectedValue.ToString()) == 0) {
                    // aquí entra la primera vez que el grid carga
                    cmbPaciente.Text = "";
                    return;
                }

                if (int.Parse(cmbDoctor.SelectedValue.ToString()) != 0)
                {
                    cmbPaciente.DataSource = null;

                    var pacientesPorDoctor = listaCasos.Where(x => x.IdDoctor == int.Parse(cmbDoctor.SelectedValue.ToString())).ToList();
                    
                    if(pacientesPorDoctor.Count != 0)
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
                MessageBox.Show("Ocurrio un error al cargar los pacientes"+ e);
            }
            
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboPaciente();
        }
    }
}
