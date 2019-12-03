using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocios.Entidades
{
    public class Conduce
    {
        public int IdConduce;
        public int NumOrden;
        public int IdUsuario;
        public int IdCliente;
        public int IdMaquinaria;
        public int IdProducto;
        public string Descripcion;
        public float Capacidad;
        public float Precio;
        public float Itbis;
        public string Nota;
        public int Estado;

        public Conduce(int idConduce, int numOrden, int idUsuario, int idCliente, int idMaquinaria, int idProducto, string descripcion, float capacidad, float precio, float itbis, string nota, int estado)
        {
            IdConduce = idConduce;
            NumOrden = numOrden;
            IdUsuario = idUsuario;
            IdCliente = idCliente;
            IdMaquinaria = idMaquinaria;
            IdProducto = idProducto;
            Descripcion = descripcion;
            Capacidad = capacidad;
            Precio = precio;
            Itbis = itbis;
            Nota = nota;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarConduce] {IdConduce},{NumOrden},{IdUsuario},{IdMaquinaria},{IdProducto},'{Descripcion}',{Capacidad},{Precio},{Itbis},'{Nota}',{Estado}";
        }
    }
           
}