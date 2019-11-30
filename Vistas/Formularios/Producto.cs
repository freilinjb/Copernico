using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Diagnostics;

namespace Vistas.Formularios
{
    public partial class Producto : Telerik.WinControls.UI.RadForm
    {
        private DataSet ds;

        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.TipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.matrizDataSet.TipoProducto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Familia' Puede moverla o quitarla según sea necesario.
            this.familiaTableAdapter.Fill(this.matrizDataSet.Familia);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.matrizDataSet.Unidad);

            txtIdProducto.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdProducto)+1 AS Mayor FROM Producto").Tables[0].Rows[0]["Mayor"].ToString();
        }

        //public override 

        private void Producto_KeyUp(object sender, KeyEventArgs e)
        {
            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                Negocios.Entidades.Producto producto = new Negocios.Entidades.Producto(
                    Convert.ToInt32(txtIdProducto.Text.Trim()),
                    (int)cbbTipoProducto.SelectedValue,
                    (int)cbbFamilia.SelectedValue,
                    txtNombre.Text.Trim(),
                    (chItbis.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click ? true : false),
                    txtNota.Text.Trim(),
                    (int)cbbEstado.SelectedIndex);

                ds = Negocios.Utilidades.Ejecutar(producto.getGuardar());

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (RadCheckedListDataItem item in cbbUnidades.CheckedItems)
                    {
                        //("VALOR: = " + item.Value.ToString() + " DATO = " + item.Text);
                        ds = Negocios.Utilidades.Ejecutar($"EXEC RegistrarProductoPorUnidad {txtIdProducto.Text.Trim()}, {item.Value.ToString()}");
                    }

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                        txtIdProducto.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdProducto)+1 AS Mayor FROM Producto").Tables[0].Rows[0]["Mayor"].ToString();
                        txtNombre.Focus();
                    }
                }
            }
        }
    }
}
