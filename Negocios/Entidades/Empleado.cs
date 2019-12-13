using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Empleado
    {
        public int IdEmpleado;
        public string Nombre;
        public string Apellido;
        public string Apodo;
        public int IdEstadoCivil;
        public int IdSexo;
        public int IdTipoIdentificacion;
        public int Identificacion;
        public string FechaNacimiento;
        public int IdProvincia;
        public int IdMunicipio;
        public int IdCiudad;
        public int IdSector;
        public string Direccion;
        public string FechaIngreso;
        public int IdTipoContrato;
        public int IdTipoNomina;
        public int IdTipoTurno;
        public int IdDepartamento;
        public int IdPuesto;
        public int IdEstadoEmpleado;

        public Empleado(int idEmpleado, string nombre, string apellido, string apodo, int idEstadoCivil, int idSexo, int idTipoIdentificacion, int identificacion, string fechaNacimiento, int idProvincia, int idMunicipio, int idCiudad, int idSector, string direccion, string fechaIngreso, int idTipoContrato, int idTipoNomina, int idTipoTurno, int idDepartamento, int idPuesto, int idEstadoEmpleado)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            Apodo = apodo;
            IdEstadoCivil = idEstadoCivil;
            IdSexo = idSexo;
            IdTipoIdentificacion = idTipoIdentificacion;
            Identificacion = identificacion;
            FechaNacimiento = fechaNacimiento;
            IdProvincia = idProvincia;
            IdMunicipio = idMunicipio;
            IdCiudad = idCiudad;
            IdSector = idSector;
            Direccion = direccion;
            FechaIngreso = fechaIngreso;
            IdTipoContrato = idTipoContrato;
            IdTipoNomina = idTipoNomina;
            IdTipoTurno = idTipoTurno;
            IdDepartamento = idDepartamento;
            IdPuesto = idPuesto;
            IdEstadoEmpleado = idEstadoEmpleado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarEmpleado] {IdEmpleado},'{Nombre}','{Apellido}','{Apodo}',{IdEstadoCivil},{IdSexo},{IdTipoIdentificacion},'{Identificacion}','{FechaNacimiento}',{IdProvincia},{IdMunicipio},{IdCiudad},{IdSector},{Direccion},{FechaIngreso},{IdTipoContrato},{IdTipoNomina},{IdTipoTurno},{IdDepartamento},{IdPuesto},{IdEstadoEmpleado}";
        }
    }
}
