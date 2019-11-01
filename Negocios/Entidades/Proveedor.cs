using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Proveedor
    {
        public int IdProveedor;
        public int IdTercero;
        public string Nombre;
        public string RazonSocial;
        public string Identificacion;
        public int IdTipoIdentificacion;
        public string Telefono;
        public string Correo;
        public int IdProvincia;
        public int IdMunicipio;
        public int IdSector;
        public string Direccion;
        public string Observacion;
        public int Estado;

        public Proveedor()
        {

        }

        public Proveedor(int idProveedor, int idTercero, string nombre, string razonSocial, string identificacion, int idTipoIdentificacion, string telefono, string correo, int idProvincia, int idMunicipio, int idSector, string direccion, string observacion, int estado)
        {
            IdProveedor = idProveedor;
            IdTercero = idTercero;
            Nombre = nombre;
            RazonSocial = razonSocial;
            Identificacion = identificacion;
            IdTipoIdentificacion = idTipoIdentificacion;
            Telefono = telefono;
            Correo = correo;
            IdProvincia = idProvincia;
            IdMunicipio = idMunicipio;
            IdSector = idSector;
            Direccion = direccion;
            Observacion = observacion;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarProveedor {IdProveedor},{IdTercero},'{Nombre}','{RazonSocial}','{Identificacion}',{IdTipoIdentificacion},'{Telefono}','{Correo}',{IdProvincia},{IdMunicipio},{IdSector},'{Direccion}','{Observacion}',{Estado}";
        }
    }
}
