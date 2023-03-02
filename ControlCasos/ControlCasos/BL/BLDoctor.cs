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

        public sp_DoctorID_Consultar_Result consultarDoctorID(int idDoctor)
        {
            sp_DoctorID_Consultar_Result datosColor = modeloBD.sp_DoctorID_Consultar(idDoctor).FirstOrDefault();
            return datosColor;
        }

        public void insertarDoctor(string cedula, string nombre, string apellido1, int idCliente,
                                    string apellido2 = null, string correo = null, string telefono = null)
        {
            modeloBD.sp_Doctor_Insertar(cedula,nombre,apellido1,apellido2,correo,telefono,idCliente);
        }

        public void editarDoctor(int idDoctor, string cedula, string nombre, string apellido1,
                                    bool estado, int idCliente, string apellido2, string correo = null,
                                    string telefono = null)
        {
            modeloBD.sp_Doctor_Editar(idDoctor, cedula, nombre,apellido1,apellido2,correo,telefono,
                                        estado,idCliente);
        }

        public void eliminarDoctor(int idDoctor)
        {
            modeloBD.sp_Doctor_Eliminar(idDoctor);
        }
    }
}
