﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCasos.Modelos;
namespace ControlCasos.BL
{
    class BLCliente
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();

        public IList<sp_Cliente_Consultar_Result> consultarClientes(string nombre=null)
        {
            IList<sp_Cliente_Consultar_Result> listaClientes = modeloBD.sp_Cliente_Consultar(nombre).ToList();
            return listaClientes;
        }

        public sp_ClienteID_Consultar_Result consultarClienteID(int idCliente)
        {
            sp_ClienteID_Consultar_Result datosCliente = modeloBD.sp_ClienteID_Consultar(idCliente).FirstOrDefault();
            return datosCliente;
        }

        public bool insertarCliente(string cliente)
        {
            int registrosAfectados = modeloBD.sp_Cliente_Insertar(cliente);

            if (registrosAfectados>0)
                return true;
            
            return false;
        }

        public bool editarCliente(int idCliente, string cliente, bool estado)
        {
            int registrosAfectados = modeloBD.sp_Cliente_Editar(idCliente,cliente, estado);

            if (registrosAfectados > 0)
                return true;

            return false;
        }
    }
}
