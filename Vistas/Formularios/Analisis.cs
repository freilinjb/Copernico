using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Diagnostics;

namespace Vistas.Formularios
{
    public partial class Analisis : FormBase
    {
        private float RetenidoAcumulado = 0;
        float PesoRetenido = 0;

        private DataSet ds;

        public Analisis()
        {
            InitializeComponent();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT NumMalla,Apertura FROM Tamiz");

            foreach(DataRow File in ds.Tables[0].Rows)
            {
                dataTamiz.Rows.Add(Convert.ToSingle(File["NumMalla"].ToString()), Convert.ToSingle(File["Apertura"].ToString()), 0, 0, 0, 0);
            }
        }

        private void MasterTemplate_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(e.Column.Name == "PesoRetenido")
            {
                Debug.WriteLine("Cambio");
                e.Row.Cells["Pasante"].Value = (((Single)e.Value * 100)/Convert.ToSingle(txtCantidadInicial.Text.Trim()))/100;
                e.Row.Cells["Retenido"].Value = (((Single)e.Value * 100) / Convert.ToSingle(txtCantidadInicial.Text.Trim())) / 100;

                //RetenidoAcumulado += (float)e.Row.Cells["Retenido"].Value;
                e.Row.Cells["RetenidoAcumulado"].Value =  RetenidoAcumulado;
                
            }
            if(e.Column.Name == "Retenido")
            {

            }
            PesoRetenido = 0;
            foreach (var File in dataTamiz.Rows)
            {
                PesoRetenido += (float)File.Cells["PesoRetenido"].Value;
            }
            txtCantidadFinal.Text = PesoRetenido.ToString();
        }
    }
}
