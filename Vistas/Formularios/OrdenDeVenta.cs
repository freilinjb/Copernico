using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Globalization;

namespace Vistas.Formularios
{
    public partial class OrdenDeVenta : FormBase
    {
        private static OrdenDeVenta Instancia;

        private DataSet ds;
        private int IdContactoEncargado;

        private int cont_fila = 0;
        private int num_fila = 0;
        private bool existe = false;

        private OrdenDeVenta()
        {
            InitializeComponent();
        }


        public static OrdenDeVenta ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new OrdenDeVenta();

            Instancia.BringToFront();

            return Instancia;
        }

        private void OrdenDeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.UnidadProducto' Puede moverla o quitarla según sea necesario.
            this.unidadProductoTableAdapter.Fill(this.matrizDataSet.UnidadProducto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaProductoCentro' Puede moverla o quitarla según sea necesario.
            //this.vistaProductoCentroTableAdapter.Fill(this.matrizDataSet.VistaProductoCentro);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
            RadMessageBox.ThemeName = this.ThemeName;

            //this.orbraMantenimientoVentaTableAdapter.Fill(this.matrizDataSet.OrbraMantenimientoVenta);
            this.formaDePagoTableAdapter.Fill(this.matrizDataSet.FormaDePago);
            this.tipoVentaTableAdapter.Fill(this.matrizDataSet.TipoVenta);
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM OrdenDeVenta").Tables[0].Rows[0]["Mayor"].ToString();

            cbbTipoCredito.DataSource = Negocios.Utilidades.Ejecutar("SELECT * FROM TipoCredito").Tables[0];
            cbbTipoCredito.DisplayMember = "Descripcion";
            cbbTipoCredito.ValueMember = "IdTipoCredito";

            cbbEstado.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoVenta,Descripcion FROM EstadoVenta").Tables[0];
            cbbEstado.ValueMember = "IdEstadoVenta";
            cbbEstado.DisplayMember = "Descripcion";


            Negocios.Utilidades.Limpiar(this, errorProvider1);

        }

        public override bool Guardar()
        {
            bool bien = false;
            errorProvider1.Clear();
            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                if (dataProducto.Rows.Count > 0)
                {
                    RadMessageBox.Show("Validado");

                    string IdFormaDePago = (cbbFormaPago.SelectedValue == null) ? "null" : cbbFormaPago.SelectedValue.ToString();


                    Negocios.Entidades.OrdenDeVenta ordenDeVenta = new Negocios.Entidades.OrdenDeVenta(
                        Convert.ToInt32(txtNumOrden.Text.Trim()),
                        1,
                        (int)cbbCentro.SelectedValue,
                        1,
                        (int)cbbTipoVenta.SelectedValue,
                        (int)cbbCliente.SelectedValue,
                        (int)cbbObra.SelectedValue,
                        (int)IdContactoEncargado,
                        txtNumOrdenCompra.Text,
                        IdFormaDePago,
                        txtNota.Text.Trim(),
                        (int)cbbEstado.SelectedValue);


                    ds = Negocios.Utilidades.Ejecutar(ordenDeVenta.getGuardar());


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        float subtotal = 0, itbis = 0;
                        foreach (var Fila in dataProducto.Rows)
                        {
                            int ordenventa = Convert.ToInt32(dataProducto.Rows[dataProducto.CurrentRow.Index].Cells[0].Value.ToString());
                            subtotal += Convert.ToSingle(Convert.ToSingle(Fila.Cells["Cantidad"].Value.ToString()) * Convert.ToSingle(Fila.Cells["Precio"].Value.ToString()));
                            itbis += Convert.ToSingle(Fila.Cells["Itbis"].Value.ToString());
                            //Debug.WriteLine($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},'{Fila.Cells["Descripcion"].Value.ToString()}','{Fila.Cells["Unidad"].Value.ToString()}',{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");
                            Negocios.Utilidades.Ejecutar($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},'{Fila.Cells["Descripcion"].Value.ToString()}','{Fila.Cells["Unidad"].Value.ToString()}',{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");

                        }

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        cbbCliente.Focus();
                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                        //cbbProducto.EditorControl.Rows.Clear();

                        Imprimir ImprimirForm = new Imprimir("VistaOrdenVentaDataSet", "OrdenDeVenta",Negocios.Utilidades.Ejecutar("SELECT * FROM VistaOrdenVenta WHERE NumOrden = 8"));
                        ImprimirForm.Show();


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
            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM OrdenDeVenta").Tables[0].Rows[0]["Mayor"].ToString();

            return bien;
        }


        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCliente.SelectedIndex != -1)
            {
                txtCliente.Text = cbbCliente.EditorControl.Rows[cbbCliente.EditorControl.CurrentRow.Index].Cells[3].Value.ToString();
                //cbbCliente.Text = string.Format("{0:000000}", Convert.ToInt32(cbbCliente.Text.Trim()));

                ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaMantenimientoObra WHERE IdCliente = {cbbCliente.Text.Trim()} AND Estado = 1");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cbbObra.Enabled = true;
                    cbbObra.DataSource = ds.Tables[0];

                }
                else
                {
                    cbbObra.Enabled = false;
                    errorProvider1.SetError(cbbObra, "El cliente no contiene ningun proyecto registrado a su nombre");
                    txtObra.Text = null;
                    txtTelefono.Text = null;
                    txtCorreo.Text = null;
                }
            }

            if (string.IsNullOrEmpty(cbbCliente.Text.Trim()))
            {
                txtCliente.Text = null;

                txtTelefono.Text = null;
                txtCorreo.Text = null;
            }
        }

        public void ValidarImpresion()
        {
            Imprimir imprimir = new Imprimir("ControlDataSet", "OrdenDeVenta", Negocios.Utilidades.Ejecutar("SELECT * FROM VistaControl"));
            DialogResult dialog = RadMessageBox.Show("Si para Imprimir Directo a la impresora No para Visualizar Directo", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNoCancel, RadMessageIcon.Question, MessageBoxDefaultButton.Button1);
            if (imprimir.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OrdenDeVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Guardar();
            }
            if (e.KeyCode == Keys.F2)
            {
                ValidarImpresion();
            }
            if(e.KeyCode == Keys.F3)
            {
                Imprimir ImprimirForm = new Imprimir("VistaOrdenVentaDataSet", "Orden", Negocios.Utilidades.Ejecutar("SELECT * FROM VistaOrdenVenta WHERE NumOrden = 8"));
                ImprimirForm.Show();
            }
        }


        private void cbbTipoCredito_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void cbbTipoVenta_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbbTipoVenta.SelectedIndex >= 0)
            {
                if (cbbTipoVenta.SelectedIndex == 0)
                {
                    cbbFormaPago.SelectedIndex = -1;
                    cbbFormaPago.Enabled = false;
                    cbbFormaPago.Validar = false;

                    cbbTipoCredito.Enabled = true;
                    cbbTipoCredito.Validar = true;



                }
                else
                {
                    cbbTipoCredito.SelectedIndex = -1;
                    cbbTipoCredito.Enabled = false;
                    cbbTipoCredito.Validar = false;

                    cbbFormaPago.Enabled = true;
                    cbbFormaPago.Validar = true;
                }
            }
        }

        private void cbbObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbObra.SelectedIndex != -1)
            {
                if (cbbObra.EditorControl.Rows.Count > 0)
                {
                    cbbObra.Enabled = true;
                    txtObra.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[1].Value.ToString();
                    txtEncargado.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[5].Value.ToString();
                    txtTelefono.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[6].Value.ToString();
                    txtCorreo.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[7].Value.ToString();

                    IdContactoEncargado = Convert.ToInt32(cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[4].Value.ToString());

                    errorProvider1.Clear();
                }
            }
            else
            {
                txtObra.Text = null;
                txtTelefono.Text = null;
                txtCorreo.Text = null;
                txtEncargado.Text = null;
            }
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
                        //cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Unidad"].Value.ToString(),
                        cbbUnidad.Text,
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString(),
                        Convert.ToInt32(txtCantidad.Text.Trim()),
                        Convert.ToSingle(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString()) * Convert.ToSingle(txtCantidad.Text.Trim()) * 0.18,
                        (Convert.ToSingle(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString()) * Convert.ToSingle(txtCantidad.Text.Trim()) * 1.18)
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
                            dataProducto.Rows[num_fila].Cells["Importe"].Value = Convert.ToSingle(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString()) * Convert.ToSingle(txtCantidad.Text.Trim());

                        }
                        else
                        {
                            dataProducto.Rows.Add(
                                cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString(),
                                cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Producto"].Value.ToString(),
                                //cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Unidad"].Value.ToString(),
                                cbbUnidad.Text,
                                cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString(),
                                Convert.ToInt32(txtCantidad.Text.Trim()),
                                Convert.ToSingle(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString()) * Convert.ToSingle(txtCantidad.Text.Trim()) * 0.18,
                                (Convert.ToSingle(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Precio"].Value.ToString()) * Convert.ToSingle(txtCantidad.Text.Trim()) * 1.18)
                            );

                            cont_fila++;
                        }
                    }
                    cbbProducto.Focus();
                    txtCantidad.Text = null;
                    cbbProducto.SelectedIndex = -1;
                }

                float total = 0, subtotal = 0, itbis = 0;

                foreach (var Fila in dataProducto.Rows)
                {
                    int ordenventa = Convert.ToInt32(dataProducto.Rows[dataProducto.CurrentRow.Index].Cells[0].Value.ToString());
                    subtotal += Convert.ToSingle(Convert.ToSingle(Fila.Cells["Cantidad"].Value.ToString()) * Convert.ToSingle(Fila.Cells["Precio"].Value.ToString()));
                    itbis += Convert.ToSingle(Fila.Cells["Itbis"].Value.ToString());
                    //Debug.WriteLine($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},'{Fila.Cells["Descripcion"].Value.ToString()}','{Fila.Cells["Unidad"].Value.ToString()}',{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");
                    //Negocios.Utilidades.Ejecutar($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},{Fila.Cells["Descripcion"].Value.ToString()},{Fila.Cells["Unidad"].Value.ToString()},{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");

                }

                total += subtotal + itbis;

                txtItbis.Text = itbis.ToString("C2", CultureInfo.CreateSpecificCulture("es-DO"));
                txtSubTotal.Text = subtotal.ToString("C2", CultureInfo.CreateSpecificCulture("es-DO"));
                txtTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-DO"));
            }
        }

        private void cbbCentro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbbCentro.SelectedIndex != -1)
            {
                cbbProducto.DataSource = Negocios.Utilidades.Ejecutar($"SELECT DISTINCT * FROM VistaProducto WHERE IdCentro = {cbbCentro.SelectedValue}").Tables[0];

                cbbProducto.EditorControl.ShowColumnHeaders = (cbbProducto.EditorControl.Rows.Count > 0) ? true : false;
            }
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
    }
}
