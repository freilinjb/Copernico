﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class IventarioProducto
    {
        public int IdInventario;
        public int IdTipoInventario;
        public int IdAlmacen;
        public int IdProducto;
        public float StockInicial;
        public float StockPromedio;
        public float StockMinimo;
        public int IdEstadoInventario;

        public IventarioProducto(int idInventario, int idTipoInventario, int idAlmacen, int idProducto, float stockInicial, float stockPromedio, float stockMinimo, int idEstadoInventario)
        {
            IdInventario = idInventario;
            IdTipoInventario = idTipoInventario;
            IdAlmacen = idAlmacen;
            IdProducto = idProducto;
            StockInicial = stockInicial;
            StockPromedio = stockPromedio;
            StockMinimo = stockMinimo;
            IdEstadoInventario = idEstadoInventario;
        }

        public string getGuardar()
        {
            return $"EXEC [RegistrarInventarioProducto] {IdInventario},{IdTipoInventario},{IdAlmacen},{IdProducto},{StockInicial},{StockPromedio},{StockMinimo},{IdEstadoInventario}";
        }
    }
}
