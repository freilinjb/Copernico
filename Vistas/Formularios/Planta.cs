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
    public partial class Planta : FormBase
    {
        private static Planta Instancia;

        public static Planta ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Planta();

            Instancia.BringToFront();

            return Instancia;
        }

        public Planta()
        {
            InitializeComponent();
        }

        private void Planta_Load(object sender, EventArgs e)
        {
            dataPlanta.DataSource = Negocios.Utilidades.Ejecutar("SELECT P.IdPlanta,LP.Descripcion AS Planta,T.Nombre AS Linea FROM Planta P INNER JOIN LineaProduccion LP ON LP.IdLinea = P.IdLinea INNER JOIN ActivoFijo A ON A.IdActivoFijo = P.IdActivoFijo INNER JOIN Tercero T ON T.IdTercero = A.IdTercero").Tables[0];
            cbbLinea.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdLinea,Descripcion AS Line FROM LineaProduccion ").Tables[0];
            cbbLinea.ValueMember = "IdLinea";
            cbbLinea.DisplayMember = "Line";

            cbbZaranda.DataSource = Negocios.Utilidades.Ejecutar("SELECT A.IdActivoFijo,T.Nombre AS Zaranda FROM ActivoFijo A INNER JOIN Tercero T ON T.IdTercero = A.IdTercero INNER JOIN SubGrupoActivoFijo S ON S.IdSubGrupoActivoFijo = A.IdSubGrupoActivoFijo WHERE S.IdSubGrupoActivoFijo = 41").Tables[0];
            cbbZaranda.ValueMember = "IdActivoFijo";
            cbbZaranda.DisplayMember = "Zaranda";

            cbbProducto.DataSource = Negocios.Utilidades.Ejecutar("SELECT P.IdProducto,P.Descripcion AS Producto FROM Producto P INNER JOIN Familia F ON F.IdFamilia = P.IdFamilia WHERE F.IdFamilia = 1").Tables[0];
            cbbProducto.ValueMember = "IdProducto";
            cbbProducto.DisplayMember = "Producto";
        }

        private void dataPlanta_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataPlanta.Rows.Count > 0)
            {
                if (RadMessageBox.Show($"Desea editar el Centro {dataPlanta.Rows[dataPlanta.CurrentRow.Index].Cells["Planta"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //txtPlanta.Text = Negocios.Utilidades.Ejecutar($"select L.IdLote,T.Nombre AS Mina from Lote L INNER JOIN Composicion C ON C.IdLote = L.IdLote INNER JOIN Mina M ON M.IdMina = C.IdMina INNER JOIN Tercero T ON T.IdTercero = M.IdTercero WHERE L.IdLote = {dataLote.Rows[dataLote.CurrentRow.Index].Cells["IdLote"].Value.ToString()}").Tables[0];
                    txtCodigo.Text = string.Format("{0:00000}", Convert.ToInt32(dataPlanta.Rows[dataPlanta.CurrentRow.Index].Cells["IdPlanta"].Value.ToString()));
                    txtPlanta.Text = dataPlanta.Rows[dataPlanta.CurrentRow.Index].Cells["Planta"].Value.ToString();
                }
            }
        }

        private void cbbProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(Negocios.Utilidades.Validar(this, errorProvider1) == false)
                {
                    if (cbbZaranda.SelectedIndex != -1 && cbbProducto.SelectedIndex != -1)
                    {
                        dataZaranda.Rows.Add(
                            Convert.ToInt32(txtCodigo.Text.Trim()),
                            (int)cbbZaranda.SelectedValue,
                            cbbZaranda.Text,
                            (int)cbbProducto.SelectedValue,
                            cbbProducto.Text);
                    }
                }
            }
        }

        private void dataZaranda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataZaranda.RowCount > 0)
                {
                    if (RadMessageBox.Show($"Desea Eliminar la Zaranda {dataZaranda.Rows[dataZaranda.CurrentRow.Index].Cells["Zaranda"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        dataZaranda.Rows.RemoveAt(dataZaranda.CurrentRow.Index);
                    }
                }
            }
        }
    }
}
