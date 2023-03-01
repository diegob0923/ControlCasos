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

        public void insertarTipoProducto(string tipoProducto)
        {
            modeloBD.sp_TipoProducto_Insertar(tipoProducto);
        }
        public void editarTipoProducto(int idTipoProducto, string tipoProducto)
        {
            modeloBD.sp_TipoProducto_Editar(idTipoProducto, tipoProducto);
        }

        public void eliminarTipoProducto(int idTipoProducto)
        {
            modeloBD.sp_TipoProducto_Eliminar(idTipoProducto);
        }
    }
}
