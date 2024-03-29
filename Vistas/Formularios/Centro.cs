﻿using System;
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
    public partial class Centro : FormBase
    {
        private DataSet ds;

        private int cont_fila = 0;
        private int num_fila = 0;
        private bool existe = false;

        private static Centro Instancia;


        private Centro()
        {
            InitializeComponent();
        }

        public static Centro ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Centro();

            Instancia.BringToFront();

            return Instancia;
        }

        private void Centro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaProductoCentro' Puede moverla o quitarla según sea necesario.
            //this.vistaProductoCentroTableAdapter.Fill(this.matrizDataSet.VistaProductoCentro);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaProductoCentro' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentroMantenimiento' Puede moverla o quitarla según sea necesario.
            this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);
            RadMessageBox.ThemeName = this.ThemeName;

            txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString();


            toolRegistro.Text = "Nuevo Registro";

            cbbTipoCentro.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoCentro,Descripcion AS Tipo FROM TipoCentro").Tables[0];
            cbbTipoCentro.ValueMember = "IdTipoCentro";
            cbbTipoCentro.DisplayMember = "Tipo";

            cbbProvincia.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdProvincia,Descripcion AS Provincia FROM Provincia").Tables[0];
            cbbProvincia.ValueMember = "IdProvincia";
            cbbProvincia.DisplayMember = "Provincia";

            cbbCiudad.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdCiudad,IdProvincia,Descripcion AS Ciudad FROM Ciudad").Tables[0];
            cbbCiudad.ValueMember = "IdCiudad";
            cbbCiudad.DisplayMember = "Ciudad";

            cbbMunicipio.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdMunicipio,IdProvincia,Descripcion AS Municipio FROM Municipio").Tables[0];
            cbbMunicipio.ValueMember = "IdMunicipio";
            cbbMunicipio.DisplayMember = "Municipio";

            cbbSector.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdSector,Descripcion AS Sector FROM Sector").Tables[0];
            cbbSector.ValueMember = "IdSector";
            cbbSector.DisplayMember = "Sector";

            Negocios.Utilidades.Limpiar(this, errorProvider1);
            Negocios.Utilidades.LimpiarRadDataGridView(dataProducto);

        }



        public override bool Guardar()
        {
            bool bien = true;
            if(Negocios.Utilidades.Validar(panelInformacion,errorProvider1) == false)
            {
                try
                {
                    Negocios.Entidades.Centro centro = new Negocios.Entidades.Centro(
                    Convert.ToInt32(txtCodigo.Text.Trim()),
                    (int)cbbTipoCentro.SelectedValue,
                    txtNombre.Text.Trim(),
                    txtCorreo.Text,
                    txtTelefono.Text.Trim(),
                    (int)cbbProvincia.SelectedValue,
                    (int)cbbCiudad.SelectedValue,
                    (int)cbbMunicipio.SelectedValue,
                    (int)cbbSector.SelectedValue,
                    txtDireccion.Text.Trim(),
                    chEstado.Value);

                    ds = Negocios.Utilidades.Ejecutar(centro.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        Negocios.Utilidades.Limpiar(this, errorProvider1);

                        txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString();
                        toolRegistro.Text = "Nuevo Registro";
                        this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);

                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    bien = false;
                }
            }

            return bien;
        }

        private void dataCentro_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (dataCentro.Rows.Count > 0)
                {
                    if (RadMessageBox.Show($"Desea editar el Centro {dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Nombre"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txtCodigo.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["IdCentro"].Value.ToString();
                        lbNombre.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Nombre"].Value.ToString();

                        if (pagePrincipal.SelectedPage.Name == "pageCentroInformacionGeneral")
                        {
                            cbbTipoCentro.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["TipoCentro"].Value.ToString();
                            txtNombre.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Nombre"].Value.ToString();
                            txtCorreo.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Correo"].Value.ToString();
                            txtTelefono.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Telefono"].Value.ToString();
                            cbbProvincia.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Provincia"].Value.ToString();
                            cbbCiudad.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Ciudad"].Value.ToString();
                            cbbMunicipio.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Municipio"].Value.ToString();
                            cbbSector.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Sector"].Value.ToString();
                            txtDireccion.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Direccion"].Value.ToString();
                            chEstado.Value = (Convert.ToBoolean(dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Estado"].Value.ToString()));

                        }

                        else if (pagePrincipal.SelectedPage.Name == "pageAsignacion")
                        {
                            ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaProducto WHERE IdCentro = {txtCodigo.Text.Trim()}");

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow Fila in ds.Tables[0].Rows)
                                {
                                    dataProducto.Rows.Add(
                                        Convert.ToInt32(Fila["IdProducto"].ToString()),
                                        Convert.ToString(Fila["Producto"].ToString()),
                                        Convert.ToString(Fila["Familia"].ToString()),
                                        Convert.ToString(Fila["TipoProducto"].ToString()),
                                        Convert.ToSingle(Fila["Precio"].ToString()),
                                        Convert.ToBoolean(Fila["IncluirItbis"].ToString())
                                        );
                                }
                                //foreach (DataRow Fila in ds.Tables[0].Rows)
                                //{
                                //    dataProducto.Rows.Add(
                                //        Convert.ToInt32(Fila.Cells["IdProducto"].Value.ToString()),
                                //        Fila.Cells["IdProducto"].Value.ToString(),
                                //        Fila.Cells["Producto"].Value.ToString(),
                                //        Fila.Cells["Familia"].Value.ToString(),
                                //        Fila.Cells["TipoProducto"].Value.ToString(),
                                //        Convert.ToBoolean(Fila.Cells["IncluirItbis"].Value.ToString())
                                //        );
                                //}
                            }
                        }


                        else if (pagePrincipal.SelectedPage.Name == pageMateriaPrima.Name)
                        {
                            Negocios.Utilidades.LimpiarRadDataGridView(dataMateriaPrima);

                            ds = Negocios.Utilidades.Ejecutar($"SELECT M.IdMateriaPrima,P.IdProducto,P.Descripcion AS Producto,F.Descripcion AS Familia,R.Descripcion AS Rubro FROM MateriaPrima M INNER JOIN Producto P ON P.IdProducto = M.IdProducto INNER JOIN Familia F ON F.IdFamilia = P.IdFamilia INNER JOIN Rubro R ON R.IdRubro = P.IdRubro WHERE  M.IdCentro = {txtCodigo.Text.Trim()}");
                            cbbProductoMateriaPrima.DataSource = Negocios.Utilidades.Ejecutar("SELECT P.IdProducto,P.Descripcion AS Producto,F.Descripcion AS Familia, R.Descripcion AS Rubro FROM Producto P INNER JOIN Rubro R ON R.IdRubro = P.IdRubro INNER JOIN Familia F ON F.IdFamilia = P.IdFamilia WHERE R.IdRubro = 33").Tables[0];
                            cbbProductoMateriaPrima.ValueMember = "IdProducto";
                            cbbProductoMateriaPrima.DisplayMember = "Producto";

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow Fila in ds.Tables[0].Rows)
                                {
                                    dataMateriaPrima.Rows.Add(
                                        Convert.ToInt32(Fila["IdMateriaPrima"].ToString()),
                                        Convert.ToInt32(Fila["IdProducto"].ToString()),
                                        Convert.ToString(Fila["Producto"].ToString()),
                                        Convert.ToString(Fila["Familia"].ToString()),
                                        Convert.ToString(Fila["Rubro"].ToString())
                                        );
                                }
                            }
                        }

                        else
                        {
                            Negocios.Utilidades.LimpiarRadDataGridView(dataMateriaPrima);
                            //Negocios.Utilidades.LimpiarRadDataGridView(data);

                        }
                        toolRegistro.Text = "Modo edicion";
                    }
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lbNombre.Text = txtNombre.Text;
        }

        private void Centro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (pagePrincipal.SelectedPage.Name == pageCentroInformacionGeneral.Name)
                {
                    Guardar();
                }

                if (pagePrincipal.SelectedPage.Name == pageAsignacion.Name)
                {
                    ds = Negocios.Utilidades.Ejecutar($"DELETE FROM Precio WHERE IdCentro = {txtCodigo.Text.Trim()}");

                    foreach (var Fila in dataProducto.Rows)
                    {
                        Debug.WriteLine("DEPURACION");
                        ds = Negocios.Utilidades.Ejecutar($"EXEC [RegistrarPrecioDeProducto] {txtCodigo.Text.Trim()},{Fila.Cells["IdProducto"].Value.ToString()},'{Fila.Cells["Precio"].Value.ToString()}'");
                        //Debug.WriteLine($"EXEC [RegistrarPrecioDeProducto] {txtCodigo.Text.Trim()},{Fila.Cells["IdProducto"].Value.ToString()},'{Fila.Cells["Precio"].Value.ToString()}'");
                    }

                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        cbbProducto.Focus();

                        Negocios.Utilidades.LimpiarRadDataGridView(dataProducto);
                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                        toolRegistro.Text = "Nuevo Registro";
                        txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString();

                    }
                }

                if (pagePrincipal.SelectedPage.Name == pageMateriaPrima.Name)
                {
                    //ds = Negocios.Utilidades.Ejecutar($"DELETE FROM MateriaPrima WHERE IdCentro = {txtCodigo.Text.Trim()}");

                    foreach (var Fila in dataProducto.Rows)
                    {
                        Debug.WriteLine("DEPURACION");
                        ds = Negocios.Utilidades.Ejecutar($"EXEC [RegistrarPrecioDeProducto] {txtCodigo.Text.Trim()},{Fila.Cells["IdProducto"].Value.ToString()},'{Fila.Cells["Precio"].Value.ToString()}'");
                        //Debug.WriteLine($"EXEC [RegistrarPrecioDeProducto] {txtCodigo.Text.Trim()},{Fila.Cells["IdProducto"].Value.ToString()},'{Fila.Cells["Precio"].Value.ToString()}'");
                    }

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        cbbProducto.Focus();

                        Negocios.Utilidades.LimpiarRadDataGridView(dataProducto);
                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                        toolRegistro.Text = "Nuevo Registro";
                        txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString();

                    }
                }
            }

            if(e.KeyCode == Keys.F2)
            {
                Negocios.Utilidades.Limpiar(this, errorProvider1);
                txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString();
                Negocios.Utilidades.LimpiarRadDataGridView(dataMateriaPrima);
            }
        }

        private void pagePrincipal_SelectedPageChanged(object sender, EventArgs e)
        {
            if(pagePrincipal.SelectedPage.Name == "pageAsignacion")
            {
                if(toolRegistro.Text == "Modo edicion")
                {
                    ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaProducto WHERE IdCentro = {txtCodigo.Text.Trim()}");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow Fila in ds.Tables[0].Rows)
                        {
                            dataProducto.Rows.Add(
                                Convert.ToInt32(Fila["IdProducto"].ToString()),
                                Convert.ToString(Fila["Producto"].ToString()),
                                Convert.ToString(Fila["Familia"].ToString()),
                                Convert.ToString(Fila["TipoProducto"].ToString()),
                                Convert.ToSingle(Fila["Precio"].ToString()),
                                Convert.ToBoolean(Fila["IncluirItbis"].ToString())
                                );
                        }
                        //foreach (DataRow Fila in ds.Tables[0].Rows)
                        //{
                        //    dataProducto.Rows.Add(
                        //        Convert.ToInt32(Fila.Cells["IdProducto"].Value.ToString()),
                        //        Fila.Cells["IdProducto"].Value.ToString(),
                        //        Fila.Cells["Producto"].Value.ToString(),
                        //        Fila.Cells["Familia"].Value.ToString(),
                        //        Fila.Cells["TipoProducto"].Value.ToString(),
                        //        Convert.ToBoolean(Fila.Cells["IncluirItbis"].Value.ToString())
                        //        );
                        //}
                    }
                    //this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
                }
                else if(toolRegistro.Text == "Nuevo Registro")
                {
                    Negocios.Utilidades.LimpiarRadDataGridView(dataProducto);
                }
            }
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
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
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Descripcion"].Value.ToString(),
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Familia"].Value.ToString(),
                        cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["TipoProducto"].Value.ToString(),
                        Convert.ToDecimal(txtPrecio.Text),
                        Convert.ToBoolean(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IncluirItbis"].Value.ToString())
                        );

                        cont_fila++;
                    }

                    else
                    {
                        foreach (var Fila in dataProducto.Rows)
                        {
                            if (Fila.Cells[1].Value.ToString() == cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString())
                            {
                                existe = true;
                                num_fila = Fila.Index;
                            }
                        }
                        if (existe == true)
                        {
                            Debug.WriteLine("Igual");
                            dataProducto.Rows[num_fila].Cells["Precio"].Value = Convert.ToDecimal(txtPrecio.Text.Trim());
                        }
                        else
                        {
                            dataProducto.Rows.Add(
                            cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString(),
                            cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Descripcion"].Value.ToString(),
                            cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["Familia"].Value.ToString(),
                            cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["TipoProducto"].Value.ToString(),
                            Convert.ToDecimal(txtPrecio.Text),
                            Convert.ToBoolean(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IncluirItbis"].Value.ToString())
                            );

                            cont_fila++;
                        }
                    }
                    cbbProducto.Focus();
                    cbbProducto.SelectedIndex = -1;
                    txtPrecio.Text = null;
                }
            }
        }

        private void dataProducto_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void cbbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProducto.SelectedIndex != -1)
            {
                int IdProducto = Convert.ToInt32(cbbProducto.EditorControl.Rows[cbbProducto.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value.ToString());
                cbbUnidad.DataSource = Negocios.Utilidades.Ejecutar($"SELECT P.IdProducto, U.IdUnidad,U.Descripcion AS Unidad FROM Unidad U INNER JOIN Producto_VS_Unidad PU ON PU.IdUnidad = U.IdUnidad INNER JOIN Producto P ON P.IdProducto = PU.IdProducto WHERE P.IdProducto = {IdProducto}").Tables[0];

                //dataProducto.DataSource = Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaProducto WHERE IdCentro = {txtCodigo.Text.Trim()}").Tables[0];
                //this.productoTableAdapter.Fill(this.matrizDataSet.Producto);
                //cbbUnidad.DataSource = matrizDataSet.UnidadProducto.DataSet.Tables[0];
            }
        }

        private void dataProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (dataProducto.RowCount > 0)
                {
                    if (RadMessageBox.Show($"Desea editar el Producto {dataProducto.Rows[dataProducto.CurrentRow.Index].Cells["Producto"].Value.ToString()} de este el centro {lbNombre.Text}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dataProducto.Rows.RemoveAt(dataProducto.CurrentRow.Index);
                        cont_fila--;
                        cbbProducto.Focus();

                    }
                }
            }
        }

        private void cbbProductoMateriaPrima_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bool existe = false;


                try
                {
                    if (cbbProductoMateriaPrima.SelectedIndex != -1)
                    {
                        foreach (var File in dataMateriaPrima.Rows)
                            if ((int)cbbProductoMateriaPrima.EditorControl.Rows[cbbProductoMateriaPrima.EditorControl.CurrentRow.Index].Cells["IdProducto"].Value == (int)File.Cells["IdProducto"].Value)
                                existe = true;

                        if (existe == false)
                        {
                            dataMateriaPrima.Rows.Add(
                                0,
                                cbbProductoMateriaPrima.SelectedValue,
                                cbbProductoMateriaPrima.Text,
                                cbbProductoMateriaPrima.EditorControl.Rows[cbbProductoMateriaPrima.EditorControl.CurrentRow.Index].Cells["Familia"].Value,
                                cbbProductoMateriaPrima.EditorControl.Rows[cbbProductoMateriaPrima.EditorControl.CurrentRow.Index].Cells["Rubro"].Value
                                );
                        }
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);

                }
            }
        }
    }
}
