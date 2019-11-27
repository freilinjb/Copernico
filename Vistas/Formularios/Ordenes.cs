using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Vistas.Formularios
{
    public partial class Ordenes : FormBase
    {
        private DataSet ds;

        private int cont_fila = 0;
        private int num_fila = 0;
        private bool existe = false;
        private int IdUsuario;
        private int IdTercero;
        public Ordenes()
        {
            InitializeComponent();
        }
      
        private void Ordenes_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.F1)
                {
                    Guardar();
                }
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentro' Puede moverla o quitarla según sea necesario.
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaProducto' Puede moverla o quitarla según sea necesario.
            this.vistaProductoTableAdapter.Fill(this.matrizDataSet.VistaProducto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCliente' Puede moverla o quitarla según sea necesario.
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
            RadMessageBox.ThemeName = this.ThemeName;

            //this.orbraMantenimientoVentaTableAdapter.Fill(this.matrizDataSet.OrbraMantenimientoVenta);
          

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM Orden").Tables[0].Rows[0]["Mayor"].ToString();

            //cbbTipoCredito.DataSource = Negocios.Utilidades.Ejecutar("SELECT * FROM TipoCredito").Tables[0];
            //cbbTipoCredito.DisplayMember = "Descripcion";
            //cbbTipoCredito.ValueMember = "IdTipoCredito";

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

                    Negocios.Entidades.Orden orden = new Negocios.Entidades.Orden(
                        Convert.ToInt32(txtNumOrden.Text.Trim()),
                        (int)cbbTipoOrden.SelectedValue,
                        IdUsuario,
                        (int)cbbCentro.SelectedValue,
                        IdTercero,
                        DateTime.Parse(radDateTimePicker1.Text),
                        txtNota.Text,
                        (chEstado.ToggleStateMode == ToggleStateMode.Click) ? 1 : 0);


                    ds = Negocios.Utilidades.Ejecutar(orden.getGuardar());


                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        foreach (var Fila in dataProducto.Rows)
                        {
                            int ordenventa = Convert.ToInt32(dataProducto.Rows[dataProducto.CurrentRow.Index].Cells[0].Value.ToString());
                            Debug.WriteLine($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},{Fila.Cells["Descripcion"].Value.ToString()},{Fila.Cells["Unidad"].Value.ToString()},{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");
                            //Negocios.Utilidades.Ejecutar($"EXEC [RegistrarDetalleOrden] {txtNumOrden.Text.Trim()},{Fila.Cells["Codigo"].Value.ToString()},{Fila.Cells["Descripcion"].Value.ToString()},{Fila.Cells["Unidad"].Value.ToString()},{Fila.Cells["Cantidad"].Value.ToString()},{Fila.Cells["Itbis"].Value.ToString()},{Fila.Cells["Precio"].Value.ToString()};");

                        }
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        cbbCliente.Focus();
                        Negocios.Utilidades.Limpiar(this, errorProvider1);

                    }
                }
                else
                {
                    RadMessageBox.Show("Aun no ha registrado productos");

                    //cbbProducto.Focus();

                }
            }
            else
            {

            }
            return bien;
        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCliente.SelectedIndex != -1)
            {
                txtCliente.Text = cbbCliente.EditorControl.Rows[cbbCliente.EditorControl.CurrentRow.Index].Cells[3].Value.ToString();
                cbbCliente.Text = string.Format("{0:000000}", Convert.ToInt32(cbbCliente.Text.Trim()));

                ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaMantenimientoObra WHERE IdCliente = {cbbCliente.Text.Trim()} AND Estado = 1");


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
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Unidad"].Value.ToString(),
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
                                cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Unidad"].Value.ToString(),
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
            }
        }

        private void cbbCentro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbbCentro.SelectedIndex != -1)
            {
                cbbProducto.DataSource = Negocios.Utilidades.Ejecutar($"SELECT DISTINCT * FROM VistaProducto WHERE IdTercero = (SELECT TOP 1 IdTercero FROM ProductoPorTercero WHERE IdTercero = (SELECT IdTercero FROM Centro WHERE IdTercero = {cbbCentro.SelectedValue}))").Tables[0];

                cbbProducto.EditorControl.ShowColumnHeaders = (cbbProducto.EditorControl.Rows.Count > 0) ? true : false;
            }
        }
    }
}
