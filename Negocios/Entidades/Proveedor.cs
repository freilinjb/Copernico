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
        public int IdRubro;
        public string Telefono;
        public string Correo;
        public int IdProvincia;
        public int IdMunicipio;
        public int IdSector;
        public string Direccion;
        public string Observacion;
        public int IdCentro;
        public int Estado;

        public Proveedor()
        {

        }

        public Proveedor(int idProveedor, int idTercero, string nombre, string razonSocial, string identificacion, int idTipoIdentificacion,int idRubro, string telefono, string correo, int idProvincia, int idMunicipio, int idSector, string direccion, string observacion, int idCentro, int estado)
        {
            IdProveedor = idProveedor;
            IdTercero = idTercero;
            Nombre = nombre;
            RazonSocial = razonSocial;
            Identificacion = identificacion;
            IdTipoIdentificacion = idTipoIdentificacion;
            IdRubro = idRubro;
            Telefono = telefono;
            Correo = correo;
            IdProvincia = idProvincia;
            IdMunicipio = idMunicipio;
            IdSector = idSector;
            Direccion = direccion;
            Observacion = observacion;
            IdCentro = idCentro;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarProveedor {IdProveedor},'{Nombre}','{RazonSocial}','{Correo}','{Telefono}','{IdTipoIdentificacion}','{Identificacion}',{IdRubro},{IdMunicipio},{IdProvincia},'{IdSector}','{Direccion}','{Observacion}',{IdCentro},{Estado}";
        }
    }
}
