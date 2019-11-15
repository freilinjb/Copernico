using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class OrdenDeVenta
    {
        public int NumOrden;
        public int IdTipoVenta;
        public int IdUsuario;
        public int IdCentro;
        public int IdProveedor;
        public int IdContacto;
        public string NumCotizacion;
        public string Nota;
        public int IdEstadoCompra;

        public OrdenDeVenta(int numOrden, int idTipoVenta, int idUsuario, int idCentro, int idProveedor, int idContacto, string numCotizacion, string nota, int idEstadoCompra)
        {
            NumOrden = numOrden;
            IdTipoVenta = idTipoVenta;
            IdUsuario = idUsuario;
            IdCentro = idCentro;
            IdProveedor = idProveedor;
            IdContacto = idContacto;
            NumCotizacion = numCotizacion;
            Nota = nota;
            IdEstadoCompra = idEstadoCompra;
        }

        public OrdenDeVenta(int NumOrden)
        {

        }

        public string getGuardar()
        {
            return $"EXEC RegistrarOrdenVenta {NumOrden},{IdTipoVenta},{IdUsuario},{IdCentro},{IdProveedor},{IdContacto},'{NumCotizacion}','{Nota}',{IdEstadoCompra}";
        }
    }
}
