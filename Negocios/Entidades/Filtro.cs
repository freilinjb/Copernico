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
        public string Descripcion;

        public Filtro(int idFiltro, int numMallaInicial, int numMallaFinal, string descripcion)
        {
            IdFiltro = idFiltro;
            NumMallaInicial = numMallaInicial;
            NumMallaFinal = numMallaFinal;
            Descripcion = descripcion;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarFiltro {IdFiltro},{NumMallaInicial},{NumMallaFinal},'{Descripcion}'";
        }
    }
}
