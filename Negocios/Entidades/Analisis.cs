using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Analisis
    {
        public int IdAnalisis;
        public string Fecha;
        public int IdTipoAnalisis;
        public int IdMina;
        public string Banqueta;
        public float HumedadPorcentual;
        public float CantidadInicial;
        public string Observacion;

        public Analisis(int idAnalisis, string fecha, int idTipoAnalisis, int idMina, string banqueta, float humedadPorcentual, float cantidadInicial, string observacion)
        {
            IdAnalisis = idAnalisis;
            Fecha = fecha;
            IdTipoAnalisis = idTipoAnalisis;
            IdMina = idMina;
            Banqueta = banqueta;
            HumedadPorcentual = humedadPorcentual;
            CantidadInicial = cantidadInicial;
            Observacion = observacion;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistraAnalisis] {IdAnalisis},'{Fecha}',{IdTipoAnalisis},{IdMina},'{Banqueta}',{HumedadPorcentual},{CantidadInicial},'{Observacion}'";
        }
    }
}
