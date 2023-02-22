using ControlCasos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.BL
{
    class BLTipoProducto
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();

        public IList<sp_TipoProducto_Consultar_Result> consultarTipoProductos(string tipoProducto = null)
        {
            IList<sp_TipoProducto_Consultar_Result> listaTipoProductos = modeloBD.sp_TipoProducto_Consultar(tipoProducto).ToList();
            return listaTipoProductos;
        }

        public bool insertarTipoProducto(string tipoProducto)
        {
            int registrosAfectados = modeloBD.sp_TipoProducto_Insertar(tipoProducto);

            if (registrosAfectados > 0)
                return true;

            return false;
        }
    }
}
