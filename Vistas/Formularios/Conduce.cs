
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Conduce : FormBase
    {
        public Conduce()
        {
            InitializeComponent();
        }

        private void Conduce_Load(object sender, EventArgs e)
        {

         //   this.reportViewer1.RefreshReport();
          //  this.reportViewer1.LocalReport.EnableExternalImages = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(textPersonal1.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qRCode = new QRCoder.QRCode(qRCodeData);

            Bitmap bmp = qRCode.GetGraphic(7);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                MatrizDataSet reportData = new MatrizDataSet();
                MatrizDataSet.QRCodeRow qRCodeRow = reportData.QRCode.NewQRCodeRow();
                qRCodeRow.Imagen = ms.ToArray();
                reportData.QRCode.AddQRCodeRow(qRCodeRow);

               // ReportDataSource reportDataSource = new ReportDataSource();
             //   reportDataSource.Name = "DataSet1";
             //   reportDataSource.Value = reportData.QRCode;
              //  reportViewer1.LocalReport.DataSources.Clear();
              //  reportViewer1.LocalReport.DataSources.Add(reportDataSource);
             //   reportViewer1.RefreshReport();

            }
        }
    }
}
