using ControlCasos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.BL
{
    class BLUsuarioSistema
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();
        
        public sp_ValidarUsuario_Result validarUsuario(string usuario, string contrasena)
        {
            return modeloBD.sp_ValidarUsuario(usuario, contrasena).FirstOrDefault();
        }

        public IList<sp_UsuarioSistema_Consultar_Result> consultarUsuarios(string buscar = null)
        {
            IList<sp_UsuarioSistema_Consultar_Result> listaUsuarios = modeloBD.sp_UsuarioSistema_Consultar(buscar).ToList();
            return listaUsuarios;
        }
        public sp_UsuarioSistemaID_Consultar_Result consultarUsuariosID(byte idUsuario)
        {
            sp_UsuarioSistemaID_Consultar_Result usuario = modeloBD.sp_UsuarioSistemaID_Consultar(idUsuario).FirstOrDefault();
            return usuario;
        }
        public void insertarUsuario(string usuario, string nombre, string apellido1,DateTime fecha, string creador,int idRol, string cedula, string apellido2 = null)
        {
            modeloBD.sp_UsuarioSistema_Insertar(usuario, nombre, apellido1, apellido2, fecha, creador, idRol, cedula);
        }
        public void editarUsuario(byte idUsuario, string usuario, string nombre, string apellido1, bool estado, int idRol, string cedula, string apellido2 = null)
        {
            modeloBD.sp_UsuarioSistema_Editar(idUsuario, usuario, nombre, apellido1, apellido2, estado, idRol, cedula);
        }
        public void cambioContrasena(string usuario, string nuevaContrasena)
        {
            modeloBD.sp_UsuarioSistemaCambioContrasena_Editar(usuario, nuevaContrasena);
        }
        public bool RestablecerContrasena(string usuario, string nuevaContrasena, string cedula)
        {
            int respuesta = modeloBD.sp_RestablecerContrasena_Editar(usuario, nuevaContrasena, cedula);
            if (respuesta > 0)
                return true;
            else
                return false;
        }
        public void eliminarUsuario(byte idUsuario)
        {
            modeloBD.sp_UsuarioSistema_Eliminar(idUsuario);
        }
    }
}
