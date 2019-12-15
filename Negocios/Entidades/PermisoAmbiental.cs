using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class PermisoAmbiental
    {
        public int NumPermiso;
        public int IdTipoPermiso;
        public string FechaEmitida;
        public string FechaVencimiento;
        public int IdMina;
        public float CantidadAutorizada;
        public int IdEstadoPermiso;

        public PermisoAmbiental(int numPermiso, int idTipoPermiso, string fechaEmitida, string fechaVencimiento, int idMina, float cantidadAutorizada, int idEstadoPermiso)
        {
            NumPermiso = numPermiso;
            IdTipoPermiso = idTipoPermiso;
            FechaEmitida = fechaEmitida;
            FechaVencimiento = fechaVencimiento;
            IdMina = idMina;
            CantidadAutorizada = cantidadAutorizada;
            IdEstadoPermiso = idEstadoPermiso;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarPermisoAmbiental {NumPermiso},{IdTipoPermiso},'{FechaEmitida}','{FechaVencimiento}',{IdMina},{CantidadAutorizada}, {IdEstadoPermiso}";
        }
    }
}
