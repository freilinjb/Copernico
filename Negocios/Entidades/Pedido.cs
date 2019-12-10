using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Pedido
    {
        public int NumOrde;
        public int IdUsuario;
        public int IdCentro;
        public int IdTipoPedido;
        public string Nota;
        public int IdEstado;

        public Pedido(int numOrde, int idUsuario, int idCentro, int idTipoPedido, string nota, int idEstado)
        {
            NumOrde = numOrde;
            IdUsuario = idUsuario;
            IdCentro = idCentro;
            IdTipoPedido = idTipoPedido;
            Nota = nota;
            IdEstado = idEstado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarPedidoDeCompra] {NumOrde},{IdUsuario},{IdCentro},{IdTipoPedido},'{Nota}',{IdEstado}";
        }
    }
}
