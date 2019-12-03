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
        public Almacen()
        {
            InitializeComponent();

            IdMayor();
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdAlmacen)+1 Mayor FROM Almacen");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        public override bool Guardar()
        {
            bool bien = true;

            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
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
                    IdMayor();
                }
            }

            return bien;
        }

        private void Almacen_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Guardar();
            }
        }

        private void dataAlmacen_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataAlmacen.Rows.Count > 0)
            {
                if (RadMessageBox.Show($"Desea editar el Almacen {dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["Nombre"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    txtCodigo.Text = dataAlmacen.Rows[dataAlmacen.CurrentRow.Index].Cells["IdAlmacen"].Value.ToString();
                    //cbbTipoCentro.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["TipoCentro"].Value.ToString();
                    //txtNombre.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Nombre"].Value.ToString();
                    //txtCorreo.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Correo"].Value.ToString();
                    //txtTelefono.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Telefono"].Value.ToString();
                    //cbbProvincia.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Provincia"].Value.ToString();
                    //cbbCiudad.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Ciudad"].Value.ToString();
                    //cbbMunicipio.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Municipio"].Value.ToString();
                    //cbbSector.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Sector"].Value.ToString();
                    //txtDireccion.Text = dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Direccion"].Value.ToString();
                    //chEstado.Value = (Convert.ToBoolean(dataCentro.Rows[dataCentro.CurrentRow.Index].Cells["Estado"].Value.ToString()));
                }
            }
        }
    }
}
