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
        public int IdCentro;
        public int IdDepartamento;
        public bool Estado;

        public ActivoFijoGeneral(int idActivoFijo, int idGrupo, int idSubGrupo, string nombre, int idEstadoActivoFijo, int idCentro, int idDepartamento, bool estado)
        {
            IdActivoFijo = idActivoFijo;
            IdGrupo = idGrupo;
            IdSubGrupo = idSubGrupo;
            Nombre = nombre;
            IdEstadoActivoFijo = idEstadoActivoFijo;
            IdCentro = idCentro;
            IdDepartamento = idDepartamento;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarActivoFijoGeneral] {IdActivoFijo},{IdGrupo},{IdSubGrupo},'{Nombre}',{IdEstadoActivoFijo},{IdCentro},{IdDepartamento},{Estado}";
        }
    }
}
