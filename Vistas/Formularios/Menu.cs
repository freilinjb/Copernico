using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Menu : FormBase
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            Centro instancia = Centro.ObtenerInstancia();
            instancia.MdiParent = this;
            instancia.Show();
        }

        private void btObra_Click(object sender, EventArgs e)
        {
            Obra obra = Obra.ObtenerInstancia();
            obra.MdiParent = this;
            obra.Show();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObtenerInstancia();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void btMina_Click(object sender, EventArgs e)
        {
            Mina mina = Mina.ObtenerInstancia();
            mina.MdiParent = this;
            mina.Show();
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            OrdenDeVenta venta = OrdenDeVenta.ObtenerInstancia();
            venta.MdiParent = this;
            venta.Show();
        }

        private void btAnalisis_Click(object sender, EventArgs e)
        {
            Analisis analisis = Analisis.ObtenerInstancia();
            analisis.MdiParent = this;
            analisis.Show();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            Filtro filtro = Filtro.ObtenerInstancia();
            filtro.MdiParent = this;
            filtro.Show();
        }

        private void btProducto_Click(object sender, EventArgs e)
        {
            Producto producto = Producto.ObtenerInstancia();
            producto.MdiParent = this;
            producto.Show();
        }

        private void btProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = Proveedor.ObtenerInstancia();
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void btAlmacen_Click(object sender, EventArgs e)
        {
            Almacen almacen = Almacen.ObtenerInstancia();
            almacen.MdiParent = this;
            almacen.Show();
        }

        private void radButtonElement3_Click_1(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObtenerInstancia();
            pedido.MdiParent = this;
            pedido.Show();
        }

        private void btCubicacion_Click(object sender, EventArgs e)
        {
            ActivoCubicacion activoCubicacion = ActivoCubicacion.ObtenerInstancia();
            activoCubicacion.MdiParent = this;
            activoCubicacion.Show();

        }

        private void btEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = Empleado.ObtenerInstancia();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void btCubicacion_Click_1(object sender, EventArgs e)
        {
            ActivoCubicacion activoCubicacion = ActivoCubicacion.ObtenerInstancia();
            activoCubicacion.MdiParent = this;
            activoCubicacion.Show();
        }

        private void btActivoFijo_Click(object sender, EventArgs e)
        {
            ActivoFijo activo = ActivoFijo.ObtenerInstancia();
            activo.MdiParent = this;
            activo.Show();
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = Inventario.ObtenerInstancia();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void btCentro_Click(object sender, EventArgs e)
        {
            Centro centro = Centro.ObtenerInstancia();
            centro.MdiParent = this;
            centro.Show();
        }

        private void btLote_Click(object sender, EventArgs e)
        {
            Lote lote = Lote.ObtenerInstancia();
            lote.MdiParent = this;
            lote.Show();
        }
    }
}
