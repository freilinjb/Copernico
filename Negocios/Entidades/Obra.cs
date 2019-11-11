using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Obra
    {
        public int IdObra;
        public int IdCliente;
        public string Nombre;
        public int IdContacto;
        public int IdProvincia;
        public int IdCiudad;
        public int IdMunicipio;
        public int IdSector;
        public string Direccion;
        public string Observacion;
        public bool Estado;

        public Obra(int idObra, int idCliente, string nombre, int idContacto, int idProvincia, int idCiudad, int idMunicipio, int idSector, string direccion, string observacion, bool estado)
        {
            IdObra = idObra;
            IdCliente = idCliente;
            Nombre = nombre;
            IdContacto = idContacto;
            IdProvincia = idProvincia;
            IdCiudad = idCiudad;
            IdMunicipio = idMunicipio;
            IdSector = idSector;
            Direccion = direccion;
            Observacion = observacion;
            Estado = estado;
        }

        public Obra()
        {

        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarObra] {IdObra},{IdCliente},'{Nombre}',{IdContacto},{IdProvincia},{IdCiudad},{IdMunicipio},{IdSector},'{Direccion}','{Observacion}',{(Estado ? 1 : 0)}";
        }
    }


}
