using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class ActivoFijoMaquinaria
    {
        public int IdActivoFijo;
        public int IdMaquinaria;
        public string Nombre;
        public int IdMarca;
        public int IdModelo;
        public int IdMotor;
        public int IdColor;
        public int Anio;
        public int IdPropietario;
        public string Placa;
        public int IdEstadoMaquinaria;
        public int IdEstadoActivoFijo;
        public int IdGrupoActivoFijo;
        public int IdSubGrupoActivoFijo;

        public ActivoFijoMaquinaria(int idActivoFijo, int idMaquinaria, string nombre, int idMarca, int idModelo, int idMotor, int idColor, int anio, int idPropietario, string placa, int idEstadoMaquinaria, int idEstadoActivoFijo,int idGrupoActivoFijo, int idSubGrupoActivoFijo)
        {
            IdActivoFijo = idActivoFijo;
            IdMaquinaria = idMaquinaria;
            Nombre = nombre;
            IdMarca = idMarca;
            IdModelo = idModelo;
            IdMotor = idMotor;
            IdColor = idColor;
            Anio = anio;
            IdPropietario = idPropietario;
            Placa = placa;
            IdEstadoMaquinaria = idEstadoMaquinaria;
            IdEstadoActivoFijo = idEstadoActivoFijo;
            IdGrupoActivoFijo = idGrupoActivoFijo;
            IdSubGrupoActivoFijo = idSubGrupoActivoFijo;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarActivoFijoEquipo] {IdActivoFijo},{IdMaquinaria},'{Nombre}',{IdMarca},{IdModelo},{IdMotor},{IdColor},{Anio},{IdPropietario},'{Placa}',{IdEstadoMaquinaria},{IdEstadoActivoFijo},{IdGrupoActivoFijo},{IdSubGrupoActivoFijo}";
        }
    }
}
