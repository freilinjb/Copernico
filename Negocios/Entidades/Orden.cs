using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocios.Entidades
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

        private DataSet ds;

        public Orden(int NumOrden)
        {
            ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM ");
        }

        public Orden(int numOrden, int idTipoOrden, int idUsuario, int idCentro, int idTercero, DateTime fecha, string descripcion, int idEstadoOrden)
        {
            NumOrden = numOrden;
            IdTipoOrden = idTipoOrden;
            IdUsuario = idUsuario;
            IdCentro = idCentro;
            IdTercero = idTercero;
            Fecha = fecha;
            Descripcion = descripcion;
            IdEstadoOrden = idEstadoOrden;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarOrden] {NumOrden},{IdTipoOrden},{IdUsuario},{IdCentro},{IdTercero},'{Fecha}','{Descripcion}'{IdEstadoOrden}";
        }
    }
}
