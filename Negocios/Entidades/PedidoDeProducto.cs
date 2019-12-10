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
        public int IdTipoPedido;
        public int IdAlmacen;
        public int IdInventario;
        public string Nota;
        public int IdEstado;

        public PedidoDeProducto(int numOrde, int idUsuario, int idCentro, int idTipoPedido,int idAlmacen,int idInventario, string nota, int idEstado)
        {
            NumOrde = numOrde;
            IdUsuario = idUsuario;
            IdCentro = idCentro;
            IdTipoPedido = idTipoPedido;
            IdAlmacen = idAlmacen;
            IdInventario = idInventario;
            Nota = nota;
            IdEstado = idEstado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarPedidoDeCompra] {NumOrde},{IdUsuario},{IdCentro},{IdTipoPedido},{IdAlmacen},{IdInventario}'{Nota}',{IdEstado}";
        }
    }
}
