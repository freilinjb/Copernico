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

        public int Anio;
        public int IdMarca;
        public int IdModelo;
        public int IdMotor;
        public int IdColor;

        public ActivoFijoGeneral(int idActivoFijo,string nombre, int idMarca, int idModelo, int idMotor, int color, int anio, int idEstadoActivoFijo, int idGrupo, int idSubgrupo)
        {
            this.IdActivoFijo = idActivoFijo;
            this.Nombre = nombre;
            this.IdMarca = idMarca;
            this.IdModelo = idModelo;
            this.IdMotor = idMotor;
            this.IdColor = color;
            this.Anio = anio;
            this.IdEstadoActivoFijo = idEstadoActivoFijo;
            this.IdGrupo = idGrupo;
            this.IdSubGrupo = idSubgrupo;
        }

        public string getGuardar2()
        {
            return $"EXEC [RegistrarActivoFijoEspesificacion] {IdActivoFijo},'{Nombre}',{IdMarca},{IdModelo},{IdMotor},{IdColor},{Anio},{1},{IdEstadoActivoFijo},{IdGrupo},{IdSubGrupo}";
        }

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
