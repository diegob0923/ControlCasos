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

        #region Consultar
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
        
        public int consultarCasoMaxID()
        {
            var maxIdCaso = modeloBD.sp_CasoMaxID_Consultar().FirstOrDefault();
            return (int)maxIdCaso;
        }

        public IList<string> consultarColoresPorProducto(int idProducto)
        {
            IList<string> colores= modeloBD.sp_Producto_ColorIdProducto_Consultar(idProducto).ToList();
            return colores;
        }
        #endregion

        #region Insertar
        public bool insertarCaso(DateTime fecha, int idDoctor, string paciente)
        {
            int registroAfectados = modeloBD.sp_Caso_Insertar(fecha, idDoctor, paciente);

               if (registroAfectados > 0)
                return true;

            return false;
        }

        public int insertarProducto(byte idMarca, byte idTipoProducto, int idCaso,
                                    string tamano = null, string diametro = null,
                                    Nullable<byte> cantidad = null, string comentario = null)
        {
            int idNuevoRegistro = (int) modeloBD.sp_Producto_Insertar(tamano,diametro,cantidad,
                                                                  idMarca,idTipoProducto,comentario,
                                                                  idCaso).FirstOrDefault();
            return idNuevoRegistro;
        }

        /// <summary>
        /// Insert en la tabla Producto_Color almacena los colores asociados a un producto
        /// </summary>
        /// <returns></returns>
        public bool insertarProductoColor(int idProducto, byte idColor)
        {
            int registroAfectados = modeloBD.sp_Producto_Color_Insertar(idProducto, idColor);

            if (registroAfectados > 0)
                return true;

            return false;
        }
        #endregion

        #region Eliminar
        public void eliminarCaso(int idCaso)
        {
            modeloBD.sp_Caso_Eliminar(idCaso);
        }
        
        public void eliminarProducto(int idProducto)
        {
            modeloBD.sp_Producto_Eliminar(idProducto);
        }

        /// <summary>
        /// Elimina todos los colores asociados a un producto de la tabla Producto_Color
        /// </summary>
        public void eliminarProductoColor(int idProducto)
        {
            modeloBD.sp_Producto_Color_Eliminar(idProducto);
        }
        #endregion
    }
}
