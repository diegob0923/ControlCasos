using ControlCasos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.BL
{
    class BLMarca
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();

        public IList<sp_Marca_Consultar_Result> consultarMarcas(string marca = null)
        {
            IList<sp_Marca_Consultar_Result> listaMarcas = modeloBD.sp_Marca_Consultar(marca).ToList();
            return listaMarcas;
        }

        public bool insertarMarca(string marca)
        {
            int registrosAfectados = modeloBD.sp_Marca_Insertar(marca);

            if (registrosAfectados > 0)
                return true;

            return false;
        }
    }
}
