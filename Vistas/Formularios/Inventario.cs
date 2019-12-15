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
    public partial class Inventario : FormBase
    {
        private DataSet ds;

        private static Inventario Instancia;

        public static Inventario ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Inventario();

            Instancia.BringToFront();

            return Instancia;
        }

        private Inventario()
        {
            InitializeComponent();
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdInventario)+1 AS Mayor FROM Inventario");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.ProductoMaterialConstruccion' Puede moverla o quitarla según sea necesario.
            this.productoMaterialConstruccionTableAdapter.Fill(this.matrizDataSet.ProductoMaterialConstruccion);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaAlmacen' Puede moverla o quitarla según sea necesario.
            this.vistaAlmacenTableAdapter.Fill(this.matrizDataSet.VistaAlmacen);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentro' Puede moverla o quitarla según sea necesario.
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);

            IdMayor();

            GroupDescriptor descriptor2 = new GroupDescriptor();
            descriptor2.GroupNames.Add("Centro", ListSortDirection.Ascending);
            GroupDescriptor descriptor3 = new GroupDescriptor();
            descriptor3.GroupNames.Add("Inventario", ListSortDirection.Ascending);


            this.dataInventario.GroupDescriptors.Add(descriptor2);
            this.dataInventario.GroupDescriptors.Add(descriptor3);

            dataInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT IdInventario,Centro,Inventario,Producto AS Descripcion,Unidad,Stock,StockPromedio,StockMinimo,Estado FROM VistaInventario").Tables[0];
            cbbEstado.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoInventario,Descripcion AS Estado FROM EstadoInventario").Tables[0];
            cbbEstado.ValueMember = "IdEstadoInventario";
            cbbEstado.DisplayMember = "Estado";


            cbbProducto.DataSource = Negocios.Utilidades.Ejecutar($"SELECT P.IdProducto,P.Descripcion AS Producto,F.Descripcion AS Familia FROM Producto P INNER JOIN Familia F ON F.IdFamilia = P.IdFamilia INNER JOIN Rubro R ON R.IdRubro = P.IdRubro WHERE R.IdRubro = 33").Tables[0];
            cbbProducto.ValueMember = "IdProducto";
            cbbProducto.DisplayMember = "Producto";

            Negocios.Utilidades.Limpiar(this, errorProvider1);

        }

        private void cbbCentro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cbbCentro.SelectedIndex != -1)
            {
                cbbAlmacen.DataSource = Negocios.Utilidades.Ejecutar($"SELECT A.IdAlmacen,A.Descripcion AS Nombre FROM Almacen A INNER JOIN Centro C ON C.IdCentro = A.IdCentro WHERE C.IdCentro = {cbbCentro.SelectedValue}").Tables[0];
                cbbAlmacen.ValueMember = "IdAlmacen";
                cbbAlmacen.DisplayMember = "Nombre";
            }
        }

        private void cbbAlmacen_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cbbAlmacen.SelectedIndex != -1)
            {
                cbbInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT ALT.IdTipoInventario,TI.Descripcion AS Inventario FROM Almacen A INNER JOIN Almacen_VS_TipoInventario ALT ON ALT.IdAlmacen = A.IdAlmacen INNER JOIN TipoInventario TI ON TI.IdTipoInventario = ALT.IdTipoInventario WHERE A.IdAlmacen = {cbbAlmacen.SelectedValue}").Tables[0];
                cbbInventario.ValueMember = "IdTipoInventario";
                cbbInventario.DisplayMember = "Inventario";
            }
        }
        public override bool Guardar()
        {
            bool bien = false;
            try

            {
                errorProvider1.Clear();
                if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
                {
                    Negocios.Entidades.IventarioProducto iventario = new Negocios.Entidades.IventarioProducto(
                        Convert.ToInt32(txtCodigo.Text.Trim()),
                        (int)cbbInventario.SelectedValue,
                        (int)cbbAlmacen.SelectedValue,
                        (int)cbbProducto.SelectedValue,
                        (int)cbbUnidad.SelectedValue,
                        Convert.ToSingle(txtStockActual.Text.Trim()),
                        Convert.ToSingle(txtStockPromedio.Text.Trim()),
                        Convert.ToSingle(txtStockMinimo.Text.Trim()),
                        (int)cbbEstado.SelectedValue);

                    ds = Negocios.Utilidades.Ejecutar(iventario.getGuardar());
                    if (ds.Tables[0].Rows.Count > 0)
                        bien = true;
                }
            }
            catch (Exception ex)
            {
                bien = false;
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
            }
            return bien;
        }

        private void Inventario_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if (Guardar())
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    dataInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT IdInventario,Centro,Inventario,Producto AS Descripcion,Unidad,Stock,StockPromedio,StockMinimo,Estado FROM VistaInventario").Tables[0];
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    IdMayor();
                    dataInventario.Refresh();
                    toolRegistro.Text = "Nuevo Pedido";
                }
            }
        }

        private void txtStockActual_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }

        private void cbbProducto_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cbbProducto.SelectedIndex != -1)
            {
                cbbUnidad.DataSource = Negocios.Utilidades.Ejecutar($"SELECT U.IdUnidad,U.Descripcion AS Unidad,PU.IdProducto FROM Unidad U INNER JOIN Producto_VS_Unidad PU ON PU.IdUnidad = U.IdUnidad INNER JOIN Producto P ON P.IdProducto = PU.IdProducto WHERE PU.IdProducto = {cbbProducto.SelectedValue}").Tables[0];
                cbbUnidad.ValueMember = "IdUnidad";
                cbbUnidad.DisplayMember = "Unidad";
            }
        }
    }
}
