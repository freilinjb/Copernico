using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class MConduce : FormBase
    {
        private static MConduce Instancia;

        private DataSet ds;
        private int IdContactoEncargado;

        private int cont_fila = 0;
        private int num_fila = 0;
        private bool existe = false;

        public MConduce()
        {
            InitializeComponent();
        }

        public static MConduce ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new MConduce();

            Instancia.BringToFront();

            return Instancia;
        }

        private void MConduce_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaProducto' Puede moverla o quitarla según sea necesario.
            this.vistaProductoTableAdapter.Fill(this.matrizDataSet.VistaProducto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.OrbraMantenimientoVenta' Puede moverla o quitarla según sea necesario.
            this.orbraMantenimientoVentaTableAdapter.Fill(this.matrizDataSet.OrbraMantenimientoVenta);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaOrdenVenta' Puede moverla o quitarla según sea necesario.
            //this.vistaOrdenVentaTableAdapter.Fill(this.matrizDataSet.VistaOrdenVenta);

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

                  
                       
                       
                }
            }
            return bien; 
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

        private void cbbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProducto.SelectedIndex != -1)
            {
                int IdProducto = Convert.ToInt32(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString());
                cbbUnidad.DataSource = Negocios.Utilidades.Ejecutar($"SELECT P.IdProducto, U.IdUnidad,U.Descripcion AS Unidad FROM Unidad U INNER JOIN Producto_VS_Unidad PU ON PU.IdUnidad = U.IdUnidad INNER JOIN Producto P ON P.IdProducto = PU.IdProducto WHERE P.IdProducto = {IdProducto}").Tables[0];
                //cbbUnidad.DataSource = matrizDataSet.UnidadProducto.DataSet.Tables[0];
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

        private void MConduce_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Guardar();
            }
            if (e.KeyCode == Keys.F2)
            {
                ValidarImpresion();
            }
            if (e.KeyCode == Keys.F3)
            {
                Imprimir ImprimirForm = new Imprimir("VistaOrdenVentaDataSet", "Orden", Negocios.Utilidades.Ejecutar("SELECT * FROM VistaOrdenVenta WHERE NumOrden = 8"));

                ImprimirForm.Show();
            }

        }
    }
}
