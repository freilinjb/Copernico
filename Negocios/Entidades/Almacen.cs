using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Almacen
    {
        public int IdAlmacen;
        public int IdCentro;
        public string Nombre;
        public string Descripcion;
        public int IdProvincia;
        public int IdCiudad;
        public int IdMunicipio;
        public int IdSector;
        public string Direccion;
        public bool Estado;

        public Almacen(int idAlmacen, int idCentro, string nombre,string descripcion, int idProvincia, int idCiudad, int idMunicipio, int idSector, string direccion, bool estado)
        {
            IdAlmacen = idAlmacen;
            IdCentro = idCentro;
            Nombre = nombre;
            Descripcion = descripcion;
            IdProvincia = idProvincia;
            IdCiudad = idCiudad;
            IdMunicipio = idMunicipio;
            IdSector = idSector;
            Direccion = direccion;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistraAlmacen] {IdAlmacen},{IdCentro},'{Nombre}',{IdProvincia},{IdCiudad},{IdMunicipio},{IdSector},'{Descripcion}',{Estado}";
        }
    }
}
