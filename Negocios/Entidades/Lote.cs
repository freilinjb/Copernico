using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Lote
    {
        public int IdLote;
        public float PorcentajeFino;
        public float PorcentajeGrueso;
        public float PorcentajeDesperdicio;
        public bool Estado;

        public Lote(int idLote, float porcentajeFino, float porcentajeGrueso, float porcentajeDesperdicio, bool estado)
        {
            IdLote = idLote;
            PorcentajeFino = porcentajeFino;
            PorcentajeGrueso = porcentajeGrueso;
            PorcentajeDesperdicio = porcentajeDesperdicio;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarLote {IdLote},{PorcentajeFino},{PorcentajeGrueso},{0},{Estado}";
        }
    }
}
