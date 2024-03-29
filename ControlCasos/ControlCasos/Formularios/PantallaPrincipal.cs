﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCasos.Formularios;
using ControlCasos.Formularios.Casos;
using ControlCasos.Formularios.Mantenimientos;
using ControlCasos.Formularios.Seguridad;
using ControlCasos.Formularios.Ayuda;
using ControlCasos.Clases;
using ControlCasos.Constantes;
using System.IO;
using System.Drawing.Imaging;

namespace ControlCasos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            if (UsuarioLogueado.rolUsuarioLogueado == Rol.General)
                btnSeguridad.Visible = false;

            cambiraOpacidadImagen(pbImagenCentral,0.3f);
        }

        private void ocultarSubMenu()
        {
            if (pnlSubMenuMantenimientos.Visible == true)
                pnlSubMenuMantenimientos.Visible = false;
            if (pnlSubMenuSeguridad.Visible == true)
                pnlSubMenuSeguridad.Visible = false;
            if (pnlSubMenuAyuda.Visible == true)
                pnlSubMenuAyuda.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Casos
        private void btnCasos_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmCasos());
        }
        #endregion

        #region Mantenimientos
        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuMantenimientos);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmClientes());
        }
        private void btnDoctores_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmDoctores());
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmTipoProducto());
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmMarcas());
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmColores());
        }

        #endregion

        #region Seguridad
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuSeguridad);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmUsuarios());        
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmRespaldos());
        }
        #endregion

        #region Ayuda
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuAyuda);
        }

        private void btnCambioContrasena_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmCambiarContrasena());
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                
                var archivoPDF = Properties.Resources.ManualUsuario;//archivo guardado en los recursos del proyecto

                SaveFileDialog dialogoGuardar = new SaveFileDialog();
                dialogoGuardar.FileName = "ManualUsuario.pdf";//nombre predeterminado para el pdf (igual se puede cambiar en el saveDialog)
                dialogoGuardar.Filter = "PDF (*.pdf)|*.pdf";

                if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dialogoGuardar.FileName, archivoPDF);

                    MessageBox.Show("Manual de Usuario descargado.", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ocultarSubMenu();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al descargar el manual de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormularioHijo(new frmAcercaDe());
        }
        #endregion

        private Form formularioAcivo = null;

        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioAcivo != null)
                formularioAcivo.Close();
            formularioAcivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFormularios.Controls.Add(formularioHijo); //se envía el formulario hijo al panel contenedor
            pnlFormularios.Tag = formularioHijo; // se asocia el formularioHijo con el panel contenedor
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            UsuarioLogueado.usuarioLogueado = "";
            UsuarioLogueado.rolUsuarioLogueado = Rol.UsuarioInvalido;

            frmInicioSesion formularioInicioSesion = new frmInicioSesion();
            formularioInicioSesion.Visible = true;
            
            this.Dispose();
        }

        private void cambiraOpacidadImagen(PictureBox imagenPictureBox, float opacidad)
        {
            Image imagen = imagenPictureBox.Image;//Obtener la imagen del PictureBox

            Bitmap bitmap = new Bitmap(imagen.Width, imagen.Height);//Crear un Bitmap a partir de la imagen
            
            Graphics graphics = Graphics.FromImage(bitmap);//Crear un objeto Graphics a partir del Bitmap

            // Crear un objeto ColorMatrix para ajustar la opacidad
            ColorMatrix colorMatrix = new ColorMatrix();
            colorMatrix.Matrix33 = opacidad;

            // Crear un objeto ImageAttributes para aplicar el ColorMatrix
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            graphics.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, imageAttributes);//Dibujar la imagen con la opacidad ajustada en el Bitmap

            imagenPictureBox.Image = bitmap;//Establecer el Bitmap modificado como la imagen del PictureBox
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();// Si la razón del cierre es CloseReason.UserClosing, cerrar la aplicación completamente
            else
                e.Cancel = false;// Si la razón del cierre es distinta a CloseReason.UserClosing, permitir el cierre del formulario
        }
    }
}