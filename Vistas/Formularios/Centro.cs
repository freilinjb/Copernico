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
    public partial class Centro : FormBase
    {
        private static Centro Instancia;
        private DataSet ds;

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
            this.vistaProductoCentroTableAdapter.Fill(this.matrizDataSet.VistaProductoCentro);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaProductoCentro' Puede moverla o quitarla según sea necesario.
            this.vistaProductoCentroTableAdapter.Fill(this.matrizDataSet.VistaProductoCentro);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentroMantenimiento' Puede moverla o quitarla según sea necesario.
            this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);
            RadMessageBox.ThemeName = this.ThemeName;

            txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString();


            toolEstado.Text = "Nuevo";

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
                    txtCodigo.Text,
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
                        toolEstado.Text = "Nuevo";
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

                        toolEstado.Text += "Editando";
                    }
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lbNombre.Text = txtNombre.Text;
        }

        private void Centro_KeyUp(object sender, KeyEventArgs e)
        {
            if (pagePrincipal.SelectedPage.Name == "pageCentroInformacionGeneral")
            {
                Guardar();
            }
        }

        private void pagePrincipal_SelectedPageChanged(object sender, EventArgs e)
        {
            if(pagePrincipal.SelectedPage.Name == "pageAsignacion")
            {
                if(cbbCentro.SelectedIndex != -1)
                {
                    Negocios.Utilidades.LimpiarRadDataGridView(dataCentro)
                }
            }
        }
    }
}
