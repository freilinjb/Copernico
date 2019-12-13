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
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaAlmacen' Puede moverla o quitarla según sea necesario.
            this.vistaAlmacenTableAdapter.Fill(this.matrizDataSet.VistaAlmacen);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentro' Puede moverla o quitarla según sea necesario.
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);

            IdMayor();

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
                    Negocios.Entidades.IventarioProducto pedido = new Negocios.Entidades.IventarioProducto(
                        Convert.ToInt32(txtCodigo.Text.Trim()),
                        (int)cbbInventario.SelectedValue,
                        (int)cbbAlmacen.SelectedValue,
                        (int)cbbProducto.SelectedValue,
                        Convert.ToSingle(txtStockActual.Text.Trim()),
                        Convert.ToSingle(txtStockPromedio.Text.Trim()),
                        Convert.ToSingle(txtStockMinimo.Text.Trim()),
                        (int)cbbEstado.SelectedValue);

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
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    IdMayor();
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
    }
}
