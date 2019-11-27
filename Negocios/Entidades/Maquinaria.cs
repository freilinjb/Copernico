using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Maquinaria
    {
        public int IdMaquinaria;
        public string Nombre;
        public int IdMarca;
        public int IdModelo;
        public int IdMotor;
        public int IdColor;
        public int Anio;
        public string Placa;
        public int IdPropietario;
        public int IdEstadoMaquinaria;

        public Maquinaria(int idMaquinaria, string nombre, int idMarca, int idModelo, int idMotor, int idColor, int anio, string placa, int idPropietario, int idEstadoMaquinaria)
        {
            IdMaquinaria = idMaquinaria;
            Nombre = nombre;
            IdMarca = idMarca;
            IdModelo = idModelo;
            IdMotor = idMotor;
            IdColor = idColor;
            Anio = anio;
            Placa = placa;
            IdPropietario = idPropietario;
            IdEstadoMaquinaria = idEstadoMaquinaria;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarVehiculo] {IdMaquinaria},{Nombre},{IdMarca},{IdModelo},{IdMotor},{IdColor},{Anio},'{Placa}',{IdPropietario},{IdEstadoMaquinaria}";
        }
    }
}
