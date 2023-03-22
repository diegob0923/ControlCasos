using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.Clases
{
    class Producto
    {
        public string tamano { get; set; }
        public string diametro { get; set; }
        public Nullable<byte> cantidad { get; set; }
        public byte idColor { get; set; }
        public string color { get; set; }
        public byte idMarca { get; set; }
        public string marca { get; set; }
        public byte idTipoProducto { get; set; }
        public string tipoProducto { get; set; }
        public string comentario { get; set; }

        public Producto()
        {
            tamano = null;
            diametro = null;
            cantidad = null;
            idColor = 0;
            color = null;
            idMarca = 0;
            marca = null;
            idTipoProducto = 0;
            tipoProducto = null;
            comentario = null;
        }
    }
}
