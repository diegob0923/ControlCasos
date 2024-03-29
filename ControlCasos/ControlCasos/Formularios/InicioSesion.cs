﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCasos.Modelos;
using ControlCasos.Constantes;
using ControlCasos.Clases;
using ControlCasos.BL;
using ControlCasos.Formularios;

namespace ControlCasos
{
    public partial class frmInicioSesion : Form
    {
        BLUsuarioSistema usuarioSistema = new BLUsuarioSistema();
        public frmInicioSesion()
        {
            InitializeComponent();
            Formato.DarAlturaCorrectaTextBoxSinBorde(txtUsuario);
        }

        private void abrirFormularioPrincipal()
        {
            frmPrincipal pantallaPrincipal = new frmPrincipal();
            pantallaPrincipal.Visible = true;
            this.Hide();
        }
        private void limpiarTextBoxUsuarioContrasena()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        #region Eventos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtUsuario.CausesValidation = true;
            txtContrasena.CausesValidation = true;
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    sp_ValidarUsuario_Result usuarioValidado = usuarioSistema.validarUsuario(txtUsuario.Text, txtContrasena.Text);

                    if (usuarioValidado == null)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpiarTextBoxUsuarioContrasena();
                        UsuarioLogueado.rolUsuarioLogueado = Rol.UsuarioInvalido;
                        UsuarioLogueado.usuarioLogueado = "";
                    }
                    else
                    {
                        if (usuarioValidado.IdRol == Rol.Administrador)
                        {
                            UsuarioLogueado.rolUsuarioLogueado = Rol.Administrador;
                            UsuarioLogueado.usuarioLogueado = usuarioValidado.Usuario;
                            abrirFormularioPrincipal();
                        }
                        else if (usuarioValidado.IdRol == Rol.General)
                        {
                            UsuarioLogueado.rolUsuarioLogueado = Rol.General;
                            UsuarioLogueado.usuarioLogueado = usuarioValidado.Usuario;
                            abrirFormularioPrincipal();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al ingresar, por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region Validación campos
        
        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                e.Cancel = true;
                txtUsuario.Focus();
                epUsuarioValidar.SetError(txtUsuario, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epUsuarioValidar.SetError(txtUsuario, "");
            }
        }

        private void txtContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                e.Cancel = true;
                txtUsuario.Focus();
                epContrasenaValidar.SetError(txtContrasena, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                epContrasenaValidar.SetError(txtContrasena, "");
            }
        }
        #endregion

        private void lnkRestablecerContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsuario.CausesValidation = true;
            txtContrasena.CausesValidation = false;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (MessageBox.Show("Está a punto de restablecer la contraseña para el usuario \"" + txtUsuario.Text + "\". Si el usuario es incorrecto, por favor presione \"No\" y cámbielo en la casilla \"Usuario\". ¿Desea continuar?", "Restablecer Contraseña", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frmRestablecerContrasena formularioRestablecerContrasena = new frmRestablecerContrasena(txtUsuario.Text);
                    formularioRestablecerContrasena.Visible = true;
                }
            }
        }

        private void frmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();// Si la razón del cierre es CloseReason.UserClosing, cerrar la aplicación completamente
            else
                e.Cancel = false;// Si la razón del cierre es distinta a CloseReason.UserClosing, permitir el cierre del formulario
        }
    }
}
