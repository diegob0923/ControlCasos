﻿using ControlCasos.Modelos;
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
    }
}
