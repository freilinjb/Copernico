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
            float pasante = 0;
            float porcentajePasante = 0;
            if(e.Column.Name == "PesoRetenido")
            {


                if (porcentajePasante <= 1)
                {
                    RadMessageBox.Show("REVISAR EL PORCENTAJE GRANULOMETRICO, SOBREPASA LA CANTIDAD INICIAL!!", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    foreach (var File in dataTamiz.Rows)
                    {
                        porcentajePasante += (float)File.Cells["Pasante"].Value;
                        PesoRetenido += (float)File.Cells["PesoRetenido"].Value;
                    }

                    pasante = (((Single)e.Value * 100) / Convert.ToSingle(txtCantidadInicial.Text.Trim())) / 100;
                    Debug.WriteLine("Cambio");
                    e.Row.Cells["Pasante"].Value = pasante;
                    e.Row.Cells["Retenido"].Value = pasante;

                    //RetenidoAcumulado += (float)e.Row.Cells["Retenido"].Value;
                    e.Row.Cells["RetenidoAcumulado"].Value = RetenidoAcumulado;
                    txtCantidadFinal.Text = PesoRetenido.ToString();

                }

                

            }
        }
    }
}
