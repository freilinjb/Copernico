using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class PreAsignacion
    {
        public int IdEmpleado;
        public int IdActivoFijo;
        public string Fecha;
        public int IdEstado;

        public PreAsignacion(int idEmpleado, int idActivoFijo, string fecha, int idEstado)
        {
            IdEmpleado = idEmpleado;
            IdActivoFijo = idActivoFijo;
            Fecha = fecha;
            IdEstado = idEstado;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarPreAsignacion {IdEmpleado},{IdActivoFijo},'{Fecha}',{IdEstado}";
        }
    }
}
