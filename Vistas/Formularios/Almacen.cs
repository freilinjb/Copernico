using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Almacen : FormBase
    {
        private DataSet ds;

        private static Almacen Instancia;

        public static Almacen ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Almacen();

            Instancia.BringToFront();

            return Instancia;
        }

        private Almacen()
        {
            InitializeComponent();
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdAlmacen)+1 AS Mayor FROM Almacen");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        public override bool Guardar()
        {
            bool bien = true;

            if (pagePrincipal.SelectedPage.Name == "pageAlmacen")
            {

                if (Negocios.Utilidades.Validar(pageAlmacen, errorProvider1) == false)
                {
                    Negocios.Entidades.Almacen almacen = new Negocios.Entidades.Almacen(
                        Convert.ToInt32(txtCodigo.Text.Trim()),
                        (int)cbbCentro.SelectedValue,
                        txtNombre.Text.Trim(),
                        txtDescripcion.Text.Trim(),
                        (int)cbbProvincia.SelectedValue,
                        (int)cbbCiudad.SelectedValue,
                        (int)cbbMunicipio.SelectedValue,
                        (int)cbbSector.SelectedValue,
                        txtDireccion.Text,
                        chEstado.Value);

                    ds = Negocios.Utilidades.Ejecutar(almacen.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        Negocios.Utilidades.Limpiar(this, errorProvider1);

                        lbEstatus.Text = "Nuevo Registro";
                        //this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);
                        this.vistaAlmacenTableAdapter.Fill(this.matrizDataSet.VistaAlmacen);

                        IdMayor();
                    }
                }
            }

            else if (pagePrincipal.SelectedPage.Name == "pageInventario")
            {
                if(lbEstatus.Text == "Modo edicion")
                {
                    if (Negocios.Utilidades.Validar(pageInventario, errorProvider1) == false)
                    {
                        Negocios.Utilidades.Ejecutar($"DELETE Almacen_VS_TipoInventario WHERE IdAlmacen = {txtCodigo.Text.Trim()}");

                        foreach (var Fila in dataInventario.Rows)
                        {
                            ds = Negocios.Utilidades.Ejecutar($"EXEC [RegistraAlmacen_VS_TipoInventario] {txtCodigo.Text},{Fila.Cells["IdTipoInventario"].Value.ToString()}");

                        }

                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                            Negocios.Utilidades.Limpiar(this, errorProvider1);

                            lbEstatus.Text = "Nuevo Registro";
                            //this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);
                            this.vistaAlmacenTableAdapter.Fill(this.matrizDataSet.VistaAlmacen);

                            IdMayor();
                        }
                    }
                }
            }

            return bien;
        }

        private void Almacen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if(Guardar())
                {
                    Negocios.Utilidades.Limpiar(pageAlmacen, errorProvider1);
                    Negocios.Utilidades.Limpiar(pageInventario, errorProvider1);

                    dataInventario.Enabled = false;
                    cbbTipoInventario.Enabled = false;
                    cbbTipoInventario.SelectedIndex = -1;
                    lbEstatus.Text = "Nuevo Registro";
                    Negocios.Utilidades.LimpiarRadDataGridView(dataInventario);

                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                Negocios.Utilidades.Limpiar(this, errorProvider1);
                lbEstatus.Text = "Nuevo Registro";
                dataInventario.Enabled = false;
                cbbTipoInventario.Enabled = false;
                cbbTipoInventario.SelectedIndex = -1;

                Negocios.Utilidades.LimpiarRadDataGridView(dataInventario);
            }
        }

        private void dataAlmacen_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataAlmacen.Rows.Count > 0)
            {
                if (RadMessageBox.Show($"Desea editar el Almacen {dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Nombre"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    txtCodigo.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["IdAlmacen"].Value.ToString();
                    cbbCentro.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Centro"].Value.ToString();
                    txtNombre.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Descripcion"].Value.ToString();
                    cbbProvincia.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Provincia"].Value.ToString();
                    cbbCiudad.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Ciudad"].Value.ToString();
                    cbbMunicipio.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Municipio"].Value.ToString();
                    cbbSector.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Sector"].Value.ToString();
                    txtDireccion.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Direccion"].Value.ToString();
                    chEstado.Value = (Convert.ToBoolean(dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Estado"].Value.ToString()));


                    cbbTipoInventario.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoInventario,Descripcion AS Inventario FROM TipoInventario").Tables[0];
                    cbbTipoInventario.ValueMember = "IdTipoInventario";
                    cbbTipoInventario.DisplayMember = "Inventario";


                    dataInventario.Enabled = true;
                    cbbTipoInventario.Enabled = true;
                    cbbTipoInventario.SelectedIndex = -1;

                    lbEstatus.Text = "Modo edicion";



                    dataInventario.DataSource = Negocios.Utilidades.Ejecutar($"SELECT TI.IdTipoInventario,TI.Descripcion AS Inventario FROM Almacen_VS_TipoInventario ALT INNER JOIN TipoInventario TI ON TI.IdTipoInventario = ALT.IdTipoInventario WHERE ALT.IdAlmacen = {txtCodigo.Text.Trim()}").Tables[0];
                }
            }
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            IdMayor();

            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaAlmacen' Puede moverla o quitarla según sea necesario.
            this.vistaAlmacenTableAdapter.Fill(this.matrizDataSet.VistaAlmacen);
            cbbCentro.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdCentro,Nombre AS Centro FROM VistaCentro").Tables[0];
            cbbCentro.ValueMember = "IdCentro";
            cbbCentro.DisplayMember = "Centro";

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

            lbEstatus.Text = "Nuevo Registro";
            dataInventario.Enabled = false;
            cbbTipoInventario.Enabled = false;
            cbbTipoInventario.SelectedIndex = -1;


            Negocios.Utilidades.Limpiar(this, errorProvider1);
        }

        private void cbbCentro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbbCentro.SelectedIndex != -1)
            {
                txtNombre.Text = $"ALM-{cbbCentro.Text}-{string.Format("{0:00}", Convert.ToInt32(txtCodigo.Text.Trim()))}";
            }
        }

        private void cbbTipoInventario_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cbbTipoInventario.SelectedIndex != -1)
                {
                    bool exists = false;

                    //ds = Negocios.Utilidades.Ejecutar("SELECT IdTipoInventario,Descripcion AS Inventario FROM TipoInventario");

                    foreach (var Fila in dataInventario.Rows)
                    {
                        if (Fila.Cells["IdTipoInventario"].Value.ToString() == cbbTipoInventario.SelectedValue.ToString())
                            exists = true;
                    }

                    if(exists == false)
                        dataInventario.Rows.Add(Convert.ToInt32(cbbTipoInventario.SelectedValue.ToString()), cbbTipoInventario.Text.Trim());
                }
            }
        }

        private void dataInventario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataInventario.RowCount > 0)
                {
                    if (RadMessageBox.Show($"Desea Eliminar el Inventario {dataInventario.Rows[dataInventario.CurrentRow.Index].Cells["Inventario"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dataInventario.Rows.RemoveAt(dataInventario.CurrentRow.Index);
                    }
                }
            }
        }
    }
}
