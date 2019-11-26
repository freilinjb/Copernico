using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Orden
    {
        public int NumOrden;
        public int IdTipoOrden;
        public int IdUsuario;
        public int IdCentro;
        public int IdTercero;
        public DateTime Fecha;
        public string Descripcion;
        public int IdEstadoOrden;
    

    public Orden()
    {

    }
    
    public Orden(int NumOrden, int IdTipoOrden, int IdUsuario, int IdCentro, int IdTercero, DateTime Fecha, string Descripcion, int IdEstadoOrden)
        {
            this.NumOrden = NumOrden;
            this.IdTipoOrden = IdTipoOrden;
            this.IdUsuario = IdUsuario;
            this.IdCentro = IdCentro;
            this.IdTercero = IdTercero;
            this.Fecha = Fecha;
            this.Descripcion = Descripcion;
            this.IdEstadoOrden = IdEstadoOrden;
        }

        public string getGuardar()
        {
            return ($"EXEC RegistrarOrden {NumOrden},{IdTipoOrden},{IdUsuario},{IdCentro},{IdTercero},'{Fecha}','{Descripcion}','{IdEstadoOrden}'");
        }

    }
}
