﻿using Microsoft.Reporting.WinForms;
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
    public partial class Imprimir : Telerik.WinControls.UI.RadForm
    {
        private Informes.Informe Informe;
        public Imprimir()
        {
            InitializeComponent();
        }

        public Imprimir(string NombreDataSetInforme, string NombreInforme, DataSet ds)
        {
            InitializeComponent();

            ReportDataSource reportDat = new ReportDataSource(NombreDataSetInforme, ds.Tables[0]);

            Informe = new Informes.Informe();

            Informe.reportViewer.LocalReport.ReportEmbeddedResource = $"Vistas.Informes.{NombreInforme}.rdlc";
            Informe.reportViewer.LocalReport.DataSources.Add(reportDat);
            Informe.reportViewer.LocalReport.Refresh();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(rdVisualizar.CheckState == CheckState.Checked)
            {
                Informe.ShowDialog();
            }
            if (rdImpresora.CheckState == CheckState.Checked)
            {
                //MessageBox.Show("Vlidado");
                Impresor impresor = new Impresor();

                impresor.Imprime(Informe.reportViewer.LocalReport);
            }
        }
    }
}
