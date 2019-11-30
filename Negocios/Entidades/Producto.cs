﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Producto
    {
        public int IdProducto;
        public int IdTipoProducto;
        public int IdFamilia;
        public string Nombre;
        public bool Itbis;
        public string Nota;
        public int IdEstado;


        public Producto(int idProducto,int idTipoProducto, int idFamilia, string nombre, bool itbis, string nota, int idEstado)
        {
            IdProducto = idProducto;
            IdTipoProducto = idTipoProducto;
            IdFamilia = idFamilia;
            Nombre = nombre;
            Itbis = itbis;
            Nota = nota;
            IdEstado = idEstado;
        }
        public string getGuardar()
        {
            return $"EXEC [RegistrarProducto] {IdProducto},{IdTipoProducto},{IdFamilia},'{Nombre}',{(Itbis ? 1 : 0)},'{Nota}',{IdEstado}";
        }
    }
}
