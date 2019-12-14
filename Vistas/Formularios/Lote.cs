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
            RadMessageBox.ThemeName = this.ThemeName;
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
            bool bien = false;

            try
            {
                if (pagePrincipal.SelectedPage.Name == pageLote.Name)
                {
                    if (Negocios.Utilidades.Validar(pageLote, errorProvider1) == false)
                    {
                        Negocios.Entidades.Lote centro = new Negocios.Entidades.Lote(
                            Convert.ToInt32(txtCodigo.Text.Trim()),
                            trackFino.Value,
                            trackGrueso.Value,
                            0,
                            chEstado.Value);

                        ds = Negocios.Utilidades.Ejecutar(centro.getGuardar());

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            bien = true;
                            RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                bien = false;
            }

            return bien;
        }

        private void trackFino_ValueChanged(object sender, EventArgs e)
        {
            float temp = Convert.ToSingle(trackFino.Value);
            lbPorcentajeFijo.Text = string.Format("{0:P3}", temp / 100);

            trackGrueso.Maximum = 100 - temp;
            trackGrueso.Value = trackGrueso.Maximum;

            txtNombre.Text = $"Lote {trackFino.Value}/{trackGrueso.Value}";
        }

        private void trackGrueso_ValueChanged(object sender, EventArgs e)
        {
            float temp = Convert.ToSingle(trackGrueso.Value);
            lbPorcentajeGrueso.Text = string.Format("{0:P3}", temp / 100);

            txtNombre.Text = $"Lote {trackFino.Value}/{trackGrueso.Value}";

        }

        private void Lote_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if(Guardar())
                {
                    dataLote.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdLote,Descripcion AS Lote FROM Lote").Tables[0];
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    trackFino.Value = 0;
                    trackGrueso.Value = 0;
                    IdMayor();
                }
            }
        }

        private void dataLote_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(dataLote.Rows.Count > 0)
            {
                if(RadMessageBox.Show($"Desea editar el Centro {dataLote.Rows[dataLote.CurrentRow.Index].Cells["Lote"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    dataConfiguracion.DataSource = Negocios.Utilidades.Ejecutar($"select L.IdLote,T.Nombre AS Mina from Lote L INNER JOIN Composicion C ON C.IdLote = L.IdLote INNER JOIN Mina M ON M.IdMina = C.IdMina INNER JOIN Tercero T ON T.IdTercero = M.IdTercero WHERE L.IdLote = {dataLote.Rows[dataLote.CurrentRow.Index].Cells["IdLote"].Value.ToString()}").Tables[0];

                }
            }
        }
    }
}
