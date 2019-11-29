using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Negocios;

namespace Vistas.Formularios
{
    public partial class Filtro : FormBase
    {
        private DataSet ds;
        private static Filtro Instancia;

        public static Filtro ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Filtro();

            Instancia.BringToFront();

            return Instancia;
        }

        private Filtro()
        {
            InitializeComponent();
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;

            this.vistaFiltroTableAdapter.Fill(this.matrizDataSet.VistaFiltro);
            this.tamizTableAdapter.Fill(this.matrizDataSet.Tamiz);
            cbbUnidad.SelectedIndex = 0;

            Utilidades.Limpiar(this, errorProvider1);
            cbbTamizFinal.DataSource = null;
            cbbTamizInicial.SelectedIndex = 0;
            //cbbTamizInicial.DataSource = matrizDataSet.Tamiz.DataSet.Tables[0];

            txtNumFiltro.Text = Utilidades.Ejecutar("SELECT MAX(IdFiltro)+1 AS Mayor FROM Filtro").Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void cbbTamizInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTamizInicial.SelectedIndex != -1)
            {
                cbbTamizFinal.EditorControl.ShowRowHeaderColumn = true;
                cbbTamizFinal.DataSource = Utilidades.Ejecutar($"select  NumMalla,Apertura,U.Descripcion AS Unidad from Tamiz T INNER JOIN Unidad U ON U.IdUnidad = T.IdUnidad WHERE NumMalla >= {cbbTamizInicial.SelectedValue.ToString()}").Tables[0];
            }
        }

        public override bool Guardar()
        {
            bool bien = true;

            try
            {
                if(Utilidades.Validar(this,errorProvider1) == false)
                {
                    Negocios.Entidades.Filtro filtro = new Negocios.Entidades.Filtro(
                        Convert.ToInt32(txtNumFiltro.Text.Trim()),
                        Convert.ToInt32(cbbTamizInicial.SelectedValue.ToString()),
                        Convert.ToInt32(cbbTamizFinal.SelectedValue.ToString()),
                        txtDescripcion.Text.Trim()
                        );

                    ds = Utilidades.Ejecutar(filtro.getGuardar());

                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        txtNumFiltro.Text = Utilidades.Ejecutar("SELECT MAX(IdFiltro)+1 AS Mayor FROM Filtro").Tables[0].Rows[0]["Mayor"].ToString();
                        Utilidades.Limpiar(this, errorProvider1);

                        this.vistaFiltroTableAdapter.Fill(this.matrizDataSet.VistaFiltro);

                    }
                }
            }
            catch(Exception ex)
            {
                bien = false;
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);

            }

            return bien;
        }

        private void Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Guardar();
            }
        }
    }
}
