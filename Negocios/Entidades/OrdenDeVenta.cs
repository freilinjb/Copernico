using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocios.Entidades
{
    public class OrdenDeVenta
    {
        public int NumOrden;
        public int IdUsuario;
        public int IdCentro;
        public int IdTipoOrden;
        public int IdTipoVenta;
        public int IdCliente;
        public int IdObra;
        public int IdContacto;
        public string NumOrDenDeCompra;
        public string IdFormaDePago;
        public string Nota;
        public int IdEstadoVenta;

        private DataSet ds;

        public OrdenDeVenta(int NumOrden)
        {
            ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM ");
        }

        public OrdenDeVenta(int numOrden,int idUsuario, int idCentro, int idTipoOrden, int idTipoVenta, int idCliente, int idObra, int idContacto, string numOrDenDeCompra, string idFormaDePago, string nota, int idEstadoVenta)
        {
            NumOrden = numOrden;
            IdUsuario = idUsuario;
            IdCentro = idCentro;
            IdTipoOrden = idTipoOrden;
            IdTipoVenta = idTipoVenta;
            IdCliente = idCliente;
            IdObra = idObra;
            IdContacto = idContacto;
            NumOrDenDeCompra = numOrDenDeCompra;
            IdFormaDePago = idFormaDePago;
            Nota = nota;
            IdEstadoVenta = idEstadoVenta;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarOrdenVenta] {NumOrden},{IdUsuario},{IdCentro},{IdTipoOrden},{IdTipoVenta},{IdCliente},{IdObra},{IdContacto},'{NumOrDenDeCompra}',{IdFormaDePago},'{Nota}',{IdEstadoVenta}";
        }
    }
}
