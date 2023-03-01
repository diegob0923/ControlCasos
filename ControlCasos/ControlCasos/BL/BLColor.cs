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

        public void insertarColor(string color,string guia)
        {
            modeloBD.sp_Color_Insertar(color,guia);
        }

        public void editarColor(int idColor, string color, string guia)
        {
            modeloBD.sp_Color_Editar(idColor, color, guia);
        }

        public void eliminarColor(int idColor)
        {
            modeloBD.sp_Cliente_Eliminar(idColor);
        }
    }
}
