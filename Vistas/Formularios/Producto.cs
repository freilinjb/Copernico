﻿using System;
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
    public partial class Producto : FormBase
    {
        private DataSet ds;

        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
            RadMessageBox.ThemeName = this.ThemeName;
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.TipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.matrizDataSet.TipoProducto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Familia' Puede moverla o quitarla según sea necesario.
            this.familiaTableAdapter.Fill(this.matrizDataSet.Familia);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.matrizDataSet.Unidad);


            cbbEstado.SelectedIndex = 0;
            txtIdProducto.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdProducto)+1 AS Mayor FROM Producto").Tables[0].Rows[0]["Mayor"].ToString();

            Negocios.Utilidades.Limpiar(this, errorProvider1);
        }

        public override bool Guardar()
        {
            bool bien = true;

            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                try
                {
                    Negocios.Entidades.Producto producto = new Negocios.Entidades.Producto(
                    Convert.ToInt32(txtIdProducto.Text.Trim()),
                    (int)cbbTipoProducto.SelectedValue,
                    (int)cbbFamilia.SelectedValue,
                    txtNombre.Text.Trim(),
                    (chItbis.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click ? true : false),
                    txtNota.Text.Trim(),
                    (int)cbbEstado.SelectedIndex+1);

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
                            cbbUnidades.CheckedItems.Clear();
                        }
                    }
                }
                catch(Exception ex)
                {
                    bien = false;
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                }
            }
            return bien;
        }

        private void Producto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Guardar();
            }
            if(e.KeyCode == Keys.F2)
            {
                txtNombre.Focus();
                Negocios.Utilidades.Limpiar(this, errorProvider1);

                txtIdProducto.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdProducto)+1 AS Mayor FROM Producto").Tables[0].Rows[0]["Mayor"].ToString();
                cbbFamilia.SelectedIndex = -1;
                cbbTipoProducto.SelectedIndex = -1;
            }
        }

        private void dataProducto_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if(dataProducto.Rows.Count > 0)
            {
                if(RadMessageBox.Show($"Desea editar el Producto {dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["Descripcion"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    txtIdProducto.Text = dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["IdProducto"].Value.ToString();

                    if (pagePrincipal.SelectedPage.Name == "pageProductio")
                    {
                        cbbEstado.Text = dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["Estado"].Value.ToString();
                        cbbTipoProducto.Text = dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["TipoProducto"].Value.ToString();
                        cbbFamilia.Text = dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["Familia"].Value.ToString();
                        txtNombre.Text = dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["Descripcion"].Value.ToString();

                        txtNota.Text = Negocios.Utilidades.Ejecutar($"SELECT Nota FROM Producto WHERE IdProducto = {txtIdProducto.Text}").Tables[0].Rows[0]["Nota"].ToString();

                    }

                    else if(pagePrincipal.SelectedPage.Name == "pagePrecio")
                    {
                        if(cbbCentro.SelectedIndex != -1)
                        {
                            ds = Negocios.Utilidades.Ejecutar($"SELECT IdCentro,IdProducto FROM Precio WHERE IdProducto = {} AND IdCentro = {cbbCentro.Text}");
                        }
                    }
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lbNombrer.Text = txtNombre.Text;
        }
    }
}
