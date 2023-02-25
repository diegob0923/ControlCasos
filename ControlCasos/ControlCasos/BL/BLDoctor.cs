using ControlCasos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.BL
{
    class BLDoctor
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();

        public IList<sp_Doctor_Consultar_Result> consultarDoctores(string nombreDoctor = null)
        {
            IList<sp_Doctor_Consultar_Result> listaDoctores = modeloBD.sp_Doctor_Consultar(nombreDoctor).ToList();
            return listaDoctores;
        }

        /*public bool insertarCliente(string doctor)
        {
            int registrosAfectados = modeloBD.sp_Cliente_Insertar(cliente);

            if (registrosAfectados > 0)
                return true;

            return false;
        }*/
    }
}
