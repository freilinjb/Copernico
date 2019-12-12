using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class ActivoFijoGeneral
    {
        public int IdActivoFijo;
        public int IdGrupo;
        public int IdSubGrupo;
        public string Nombre;
        public int IdEstadoActivoFijo;

        public ActivoFijoGeneral(int idActivoFijo, int idGrupo, int idSubGrupo, string nombre, int idEstadoActivoFijo)
        {
            IdActivoFijo = idActivoFijo;
            IdGrupo = idGrupo;
            IdSubGrupo = idSubGrupo;
            Nombre = nombre;
            IdEstadoActivoFijo = idEstadoActivoFijo;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarActivoFijoGeneral] {IdActivoFijo},{IdGrupo},{IdSubGrupo},'{Nombre}',{IdEstadoActivoFijo}";
        }
    }
}
