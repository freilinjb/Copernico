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
    public partial class Lote : FormBase
    {
        private DataSet ds;

        private static Lote Instancia;

        public static Lote ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Lote();

            Instancia.BringToFront();

            return Instancia;
        }

        private Lote()
        {
            InitializeComponent();
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdLote)+1 AS Mayor FROM Lote");
            txtCodigo.Text = string.Format("{0:00000}", Convert.ToInt32((ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString()));
        }

        private void Lote_Load(object sender, EventArgs e)
        {
            dataLote.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdLote,Descripcion AS Lote FROM Lote").Tables[0];
            IdMayor();
        }

        public override bool Guardar()
        {
             public override bool Guardar()
        {
            bool bien = false;

            if (Negocios.Utilidades.Validar(radPanel1, errorProvider1) == false)
            {
                try
                {
                    Negocios.Entidades.Empleado centro = new Negocios.Entidades.Empleado(
                    Convert.ToInt32(lbCodigo.Text.Trim()),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtApodo.Text.Trim(),
                    (int)cbbEstadoCivil.SelectedValue,
                    (int)cbbSexo.SelectedValue,
                    (int)cbbTipoIndentificacion.SelectedValue,
                    txtIdentificacion.Text.Trim(),
                    txtFechNacimiento.Text.Trim(),
                    (int)cbbProvincia.SelectedValue,
                    (int)cbbCiudad.SelectedValue,
                    (int)cbbMunicipio.SelectedValue,
                    (int)cbbSector.SelectedValue,
                    txtDireccion.Text.Trim(),
                    txtFechaIngreso.Text.Trim(),
                    (int)cbbTipoIndentificacion.SelectedValue,
                    (int)cbbNomina.SelectedValue,
                    (int)cbbTurno.SelectedValue,
                    (int)cbbDepartamento.SelectedValue,
                    (int)cbbPuesto.SelectedValue,
                    (int)cbbEstado.SelectedValue);

                    ds = Negocios.Utilidades.Ejecutar(centro.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        bien = true;
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

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
    }

        private void trackFino_ValueChanged(object sender, EventArgs e)
        {
            float temp = Convert.ToSingle(trackFino.Value);
            lbPorcentajeFijo.Text = string.Format("{0:P3}", temp / 100);

            trackGrueso.Maximum = 100 - temp;
            trackGrueso.Value = trackGrueso.Maximum;
        }

        private void trackGrueso_ValueChanged(object sender, EventArgs e)
        {
            float temp = Convert.ToSingle(trackGrueso.Value);
            lbPorcentajeGrueso.Text = string.Format("{0:P3}", temp / 100);
        }
    }
}
