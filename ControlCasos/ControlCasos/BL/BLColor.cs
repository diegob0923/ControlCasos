using ControlCasos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.BL
{
    class BLColor
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();

        public IList<sp_Color_Consultar_Result> consultarColores(string color = null, string guia = null)
        {
            IList<sp_Color_Consultar_Result> listaMarcas = modeloBD.sp_Color_Consultar(color,guia).ToList();
            return listaMarcas;
        }

        public bool insertarMarca(string color,string guia)
        {
            int registrosAfectados = modeloBD.sp_Color_Insertar(color,guia);

            if (registrosAfectados > 0)
                return true;

            return false;
        }
    }
}
