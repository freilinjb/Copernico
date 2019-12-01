using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Centro
    {
        public int IdCentro;
        public int IdTipoCentro;
        public string Nombre;
        public string Correo;
        public string Telefono;
        public int IdProvincia;
        public int IdCiudad;
        public int IdMunicipio;
        public int IdSector;
        public string Descripcion;
        public bool Estado;

        public Centro(int idCentro,int idTipoCentro, string nombre, string correo, string telefono, int idProvincia, int idCiudad, int idMunicipio, int idSector, string descripcion, bool estado)
        {
            IdCentro = idCentro;
            IdTipoCentro = idTipoCentro;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            IdProvincia = idProvincia;
            IdCiudad = idCiudad;
            IdMunicipio = idMunicipio;
            IdSector = idSector;
            Descripcion = descripcion;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarCentro] {IdCentro},{IdTipoCentro},'{Nombre}','{Correo}','{Telefono}',{IdProvincia},{IdCiudad},{IdMunicipio},{IdSector},'{Descripcion}',{Estado}";
        }
    }
}
