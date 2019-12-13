using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class PedidoDeProducto
    {
        public int NumOrde;
        public int IdUsuario;
        public int IdCentro;
        public int IdTipoOrden;
        public int IdTipoPedido;
        public string Nota;
        public int IdEstado;

        public PedidoDeProducto(int numOrde, int idUsuario, int idCentro,int idTipoOrden, int idTipoPedido, string nota, int idEstado)
        {
            NumOrde = numOrde;
            IdUsuario = idUsuario;
            IdCentro = idCentro;
            IdTipoOrden = idTipoOrden;
            IdTipoPedido = idTipoPedido;
            Nota = nota;
            IdEstado = idEstado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarPedidoDeCompra] {NumOrde},{IdUsuario},{IdCentro},{IdTipoOrden},{IdTipoPedido},'{Nota}',{IdEstado}";
        }
    }
}
