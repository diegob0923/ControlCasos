using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCasos.Modelos;

namespace ControlCasos.BL
{
    class BLCaso
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();

        public IList<sp_Caso_Consultar_Result> consultarCasos(string criterioBusqueda = null)
        {
            IList<sp_Caso_Consultar_Result> listaCasos = modeloBD.sp_Caso_Consultar(criterioBusqueda).ToList();
            return listaCasos;
        }

        public IList<sp_ProductosPorCaso_Consultar_Result> consultarProductosPorCaso(int idCaso)
        {
            IList<sp_ProductosPorCaso_Consultar_Result> listaProductosPorCaso = modeloBD.sp_ProductosPorCaso_Consultar(idCaso).ToList();
            return listaProductosPorCaso;
        }
    }
}
