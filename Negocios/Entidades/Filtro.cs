using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Filtro
    {
        public int IdFiltro;
        public int NumMallaInicial;
        public int NumMallaFinal;
        public int IdProducto;

        public Filtro(int idFiltro, int numMallaInicial, int numMallaFinal, int idProducto)
        {
            IdFiltro = idFiltro;
            NumMallaInicial = numMallaInicial;
            NumMallaFinal = numMallaFinal;
            IdProducto = idProducto;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarFiltro {IdFiltro},{NumMallaInicial},{NumMallaFinal},{IdProducto}";
        }
    }
}
