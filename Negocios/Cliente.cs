using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Cliente
    {
        public int idcliente;
        public string nombre;
        public string razonSocial;
        public string Observacion;
        public int idTipoIdentificacion;
        public string identificacion;
        public string telefono;
        public string correo;
        public int idMunicipio;
        public int idProvincia;
        public int idSector;
        public string direccion;
        public int idCentro;
        public bool estado;

        public Cliente()
        {

        }
        public Cliente(int idcliente, string nombre, string razonSocial,string observacion, int idTipoIdentificacion, string identificacion, string telefono, string correo, int idMunicipio, int idProvincia, int idSector, string direccion, int idCentro, bool estado)
        {
            this.idcliente = idcliente;
            this.nombre = nombre;
            this.razonSocial = razonSocial;
            this.Observacion = observacion;
            this.idTipoIdentificacion = idTipoIdentificacion;
            this.identificacion = identificacion;
            this.telefono = telefono;
            this.correo = correo;
            this.idMunicipio = idMunicipio;
            this.idProvincia = idProvincia;
            this.idSector = idSector;
            this.direccion = direccion;
            this.idCentro = idCentro;
            this.estado = estado;
        }
        public string getGuardar()
        {
            return ($"EXEC RegistrarCliente {idcliente},'{nombre}','{razonSocial}','{Observacion}',{idTipoIdentificacion},'{identificacion}','{telefono}','{correo}',{idMunicipio},{idProvincia},{idSector},'{direccion}',{idCentro},{(estado ? 1 : 0)}");
        }
    }
}
