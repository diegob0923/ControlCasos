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

        public sp_MarcaID_Consultar_Result consultarMarcaId(int idMarca)
        {
            sp_MarcaID_Consultar_Result datosMarca = modeloBD.sp_MarcaID_Consultar(idMarca).FirstOrDefault();
            return datosMarca;
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
