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

        public void insertarMarca(string marca)
        {
            modeloBD.sp_Marca_Insertar(marca);
        }

        public void editarMarca(int idMarca, string marca)
        {
            modeloBD.sp_Marca_Editar(idMarca, marca);
        }

        public void eliminarMarca(int idMarca)
        {
            modeloBD.sp_Marca_Eliminar(idMarca);
        }
    }
}
