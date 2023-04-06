using ControlCasos.Modelos;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCasos.BL
{
    class BLRespaldos
    {
        private ControlCasosEntities modeloBD = new ControlCasosEntities();
        
        public void generarRespaldo()
        {

        }

        /// <summary>
        /// Metodo que se encarga de hacer la restauración de la BD, se tuvo que hacer con el
        /// comando SQL y el ExecuteSqlCommand porque se necesita estar en master para poder hacer 
        /// la restauración y desde los stored procedures, funciones o triggers no se puede usar el 
        /// "USE master".
        /// SET SINGLE_USER se encarga de cerrar otras conexiones si están abiertas 
        /// SET MULTI_USER lo vuelve a dejar como estaba al principio
        /// </summary>
        /// <param name="ruta">ruta de donde se encuentra el archivo .bak para el respaldo</param>
        public void restaurarBD(string ruta)
        {
            using (var context = new ControlCasosEntities())
            {
                var query = "USE master " +
                    "ALTER DATABASE ControlCasos SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    "RESTORE DATABASE ControlCasos FROM DISK = @ruta " +
                    "ALTER DATABASE ControlCasos SET MULTI_USER;";
                var parameter = new SqlParameter("@ruta", ruta);

                context.Database.ExecuteSqlCommand(query, parameter);
            }
        }
    }
}
