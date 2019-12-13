using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Pedido : FormBase
    {
        private DataSet ds;

        private int cont_fila = 0;
        private int num_fila = 0;
        private bool existe = false;

        private static Pedido Instancia;

        public static Pedido ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Pedido();

            Instancia.BringToFront();

            return Instancia;
        }


        private Pedido()
        {
            InitializeComponent();

            IdMayor();
            txtFecha.Value = DateTime.Today;
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM Orden");
            txtNumOrden.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                existe = false;

                if (cbbProducto.EditorControl.Rows.Count > 0 && cbbProducto.SelectedIndex != -1)
                {


                    if (cont_fila == 0)
                    {
                        dataProducto.Rows.Add(
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString(),
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Producto"].Value.ToString(),
                        cbbUnidad.Text,
                        Convert.ToInt32(txtCantidad.Text.Trim())
                        );

                        cont_fila++;
                    }

                    else
                    {
                        foreach (var Fila in dataProducto.Rows)
                        {
                            if (Fila.Cells[0].Value.ToString() == cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString())
                            {
                                existe = true;
                                num_fila = Fila.Index;
                            }
                        }
                        if (existe == true)
                        {
                            Debug.WriteLine("Igual");
                            dataProducto.Rows[num_fila].Cells["Cantidad"].Value = Convert.ToInt32(txtCantidad.Text.Trim());

                        }
                        else
                        {
                            dataProducto.Rows.Add(
                                cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString(),
                                cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Producto"].Value.ToString(),
                                cbbUnidad.Text,
                                Convert.ToInt32(txtCantidad.Text.Trim())
                            );

                            cont_fila++;
                        }
                    }
                    cbbProducto.Focus();
                    txtCantidad.Text = null;
                    cbbProducto.SelectedIndex = -1;
                }
            }
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.matrizDataSet.Rubro);
            cbbAlmacen.DataSource = Negocios.Utilidades.Ejecutar("SELECT A.IdAlmacen,A.Descripcion AS Almacen FROM Almacen A INNER JOIN Centro C ON C.IdCentro = A.IdCentro WHERE C.IdCentro = 1").Tables[0];
            cbbAlmacen.DisplayMember = "Almacen";
            cbbAlmacen.ValueMember = "IdAlmacen";

            if(cbbAlmacen.Items.Count > 0)
            {
                cbbAlmacen.SelectedIndex = 0;
                //cbbInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT I.IdInventario,TI.Descripcion AS Inventario FROM Inventario I INNER JOIN Almacen A ON A.IdAlmacen = I.IdAlmacen INNER JOIN TipoInventario TI ON TI.IdTipoInventario = I.IdTipoInventario WHERE A.IdAlmacen = 1").Tables[0];
                //cbbInventario.ValueMember = "IdInventario";
                //cbbInventario.DisplayMember = "Inventario";

            }

            //cbbProducto.DataSource = Negocios.Utilidades.Ejecutar("SELECT P.IdProducto,P.Descripcion AS Producto,F.Descripcion AS Familia,TP.IdTipoProducto,TP.Descripcion AS TipoProducto FROM Producto P INNER JOIN Familia F  ON F.IdFamilia = P.IdFamilia INNER JOIN TipoProducto TP ON TP.IdTipoProducto = P.IdTipoProducto ").Tables[0];
            //cbbProducto.ValueMember = "IdProducto";
            //cbbProducto.DisplayMember = "Producto";

            cbbTipoPedido.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoPedido,Descripcion AS TipoPedido FROM TipoPedido").Tables[0];
            cbbTipoPedido.ValueMember = "IdTipoPedido";
            cbbTipoPedido.DisplayMember = "TipoPedido";


            Negocios.Utilidades.Limpiar(this, errorProvider1);


        }

        private void cbbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProducto.SelectedIndex != -1)
            {
                int IdProducto = Convert.ToInt32(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString());
                cbbUnidad.DataSource = Negocios.Utilidades.Ejecutar($"SELECT P.IdProducto, U.IdUnidad,U.Descripcion AS Unidad FROM Unidad U INNER JOIN Producto_VS_Unidad PU ON PU.IdUnidad = U.IdUnidad INNER JOIN Producto P ON P.IdProducto = PU.IdProducto WHERE P.IdProducto = {IdProducto}").Tables[0];
                //cbbUnidad.DataSource = matrizDataSet.UnidadProducto.DataSet.Tables[0];
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
                    if (dataProducto.Rows.Count > 0)
                    {

                        Negocios.Entidades.PedidoDeProducto pedido = new Negocios.Entidades.PedidoDeProducto(
                            Convert.ToInt32(txtNumOrden.Text.Trim()),
                            1,
                            1,
                            (int)cbbTipoPedido.SelectedValue,
                            (int)cbbAlmacen.SelectedValue,
                            1,
                            txtNota.Text.Trim(),
                            0);


                        ds = Negocios.Utilidades.Ejecutar(pedido.getGuardar());


                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (var Fila in dataProducto.Rows)
                            {
                                int ordenventa = Convert.ToInt32(dataProducto.Rows[dataProducto.CurrentRow.Index].Cells[0].Value.ToString());
                                //Debug.WriteLine($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},'{Fila.Cells["Descripcion"].Value.ToString()}','{Fila.Cells["Unidad"].Value.ToString()}',{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");
                                Negocios.Utilidades.Ejecutar($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},'{Fila.Cells["Descripcion"].Value.ToString()}','{Fila.Cells["Unidad"].Value.ToString()}',{Fila.Cells["Cantidad"].Value.ToString()},0,0;");
                            }


                            cbbProducto.Focus();



                            Imprimir ImprimirForm = new Imprimir("VistaOrdenVentaDataSet", "Orden", Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaOrdenVenta WHERE NumOrden = {txtNumOrden.Text.Trim()}"), "VistaDetalleOrdenDataSet", Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaDetalleOrden WHERE NumOrden = '{txtNumOrden.Text.Trim()}'"));


                            ImprimirForm.ShowDialog();
                            Negocios.Utilidades.Limpiar(this, errorProvider1);


                            if (dataProducto.Rows.Count > 0)
                            {
                                for (int i = dataProducto.Rows.Count - 1; i >= 0; i--)
                                {
                                    dataProducto.Rows.RemoveAt(i);
                                }
                            }
                        }
                    }

                    else
                    {
                        RadMessageBox.Show("Aun no ha registrado productos");
                        cbbProducto.Focus();

                    }
                }
            }
            catch (Exception ex)
            {
                bien = false;
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
            }
            return bien;
        }


        private void Pedido_KeyUp(object sender, KeyEventArgs e)
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

        private void cbbRubro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cbbRubro.SelectedIndex > -1)
            {
                cbbProducto.DataSource = Negocios.Utilidades.Ejecutar($"SELECT P.IdProducto,P.Descripcion AS Producto,F.Descripcion AS Familia,TP.IdTipoProducto,TP.Descripcion AS TipoProducto FROM Producto P INNER JOIN Familia F  ON F.IdFamilia = P.IdFamilia INNER JOIN TipoProducto TP ON TP.IdTipoProducto = P.IdTipoProducto WHERE P.IdRubro = {cbbRubro.SelectedValue}").Tables[0];
                cbbProducto.ValueMember = "IdProducto";
                cbbProducto.DisplayMember = "Producto";
            }
        }
    }
}
