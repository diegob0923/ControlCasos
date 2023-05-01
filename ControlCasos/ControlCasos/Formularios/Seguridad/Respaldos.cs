using System;
using ControlCasos.BL;
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
    public partial class frmRespaldos : Form
    {
        private readonly BLRespaldos respaldos = new BLRespaldos();
        public frmRespaldos()
        {
            InitializeComponent();
        }

        private void btnGenerarRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialogoGuardar = new SaveFileDialog();
                dialogoGuardar.FileName = "ControlCasos-" + DateTime.Now.ToString("dd-MM-yyyy") + ".bak";//nombre predeterminado (igual se puede cambiar en el saveDialog)
                dialogoGuardar.Filter = "Archivos de respaldo (*.bak)|*.bak";

                if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                {
                    string ruta = dialogoGuardar.FileName;//ruta + nombre del archivo
                    respaldos.generarRespaldo(ruta);
                    MessageBox.Show("Respaldo de datos creado satisfactoriamente.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el respaldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialogoAbrir = new OpenFileDialog();
                dialogoAbrir.Filter = "Archivos de respaldo (*.bak)|*.bak";

                if (dialogoAbrir.ShowDialog() == DialogResult.OK)
                {
                    string ruta = dialogoAbrir.FileName;//ruta + nombre del archivo
                    respaldos.restaurarBD(ruta);
                    MessageBox.Show("Restauración de datos completada satisfactoriamente.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar restaurar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
