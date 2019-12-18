using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;

namespace Vistas.Formularios
{
    public partial class MantenimientoInventario : Telerik.WinControls.UI.RadForm
    {
        private static MantenimientoInventario Instancia;

        public static MantenimientoInventario ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new MantenimientoInventario();

            Instancia.BringToFront();

            return Instancia;
        }

        private MantenimientoInventario()
        {
            InitializeComponent();
        }

        private void MantenimientoInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentro' Puede moverla o quitarla según sea necesario.
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            cbbEstado.SelectedIndex = -1;

            GroupDescriptor descriptor2 = new GroupDescriptor();
            descriptor2.GroupNames.Add("Centro", ListSortDirection.Ascending);
            GroupDescriptor descriptor3 = new GroupDescriptor();
            descriptor3.GroupNames.Add("Inventario", ListSortDirection.Ascending);


            this.dataInventario.GroupDescriptors.Add(descriptor2);
            this.dataInventario.GroupDescriptors.Add(descriptor3);

            dataInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT IdInventario,Centro,Inventario,Producto AS Descripcion,Unidad,Stock,StockPromedio,StockMinimo,Estado FROM VistaInventario").Tables[0];
        }

        private void cbbEstado_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cbbEstado.SelectedIndex != -1)
            {
                dataInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT IdInventario,Centro,Inventario,Producto AS Descripcion,Unidad,Stock,StockPromedio,StockMinimo,Estado FROM VistaInventario").Tables[0];
            }

            else if(cbbEstado.SelectedIndex > -1)
            {
                dataInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT IdInventario,Centro,Inventario,Producto AS Descripcion,Unidad,Stock,StockPromedio,StockMinimo,Estado FROM VistaInventario WHERE IdCentro = {cbbEstado.SelectedValue}").Tables[0];
            }
        }
    }
}
