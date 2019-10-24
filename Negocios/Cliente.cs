using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }

        public string getGuardar()
        {
            return ("EXEC RegistrarCliente");
        }
        public Cliente(int idCliente, string nombre, string razonSocial)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            RazonSocial = razonSocial;
        }
    }
}
