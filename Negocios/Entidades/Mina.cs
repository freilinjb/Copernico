using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Mina
    {
        public int IdMina;
        public int IdProveedor;
        public int IdProducto;
        public string Nombre;
        public string Descripcion;
        public int IdProvincia;
        public int IdCiudad;
        public int IdMunicipio;
        public int IdSector;
        public string Direccion;
        public int IdEstado;

        public Mina(int idMina, int idProveedor, int idProducto, string nombre, string descripcion, int idProvincia, int idCiudad, int idMunicipio, int idSector, string direccion, int idEstado)
        {
            IdMina = idMina;
            IdProveedor = idProveedor;
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            IdProvincia = idProvincia;
            IdCiudad = idCiudad;
            IdMunicipio = idMunicipio;
            IdSector = idSector;
            Direccion = direccion;
            IdEstado = idEstado;
        }

        public Mina(int IdMina)
        {

        }

        public string getGuardar()
        {
            return $"[RegistrarMina] {IdMina},{IdProveedor},{IdProducto},'{Nombre}','{Descripcion}',{IdProvincia},{IdCiudad},{IdMunicipio},{IdSector},'{Direccion}',{IdEstado}";
        }
    }
}
