namespace Vistas.Formularios
{
    partial class Conduce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
       //     Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
         //   this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.qRCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
         //   reportDataSource4.Name = "DataSet1";
        //    reportDataSource4.Value = this.qRCodeBindingSource;
        //    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
         //   this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vistas.Informes.Conduce.rdlc";
        //    this.reportViewer1.Location = new System.Drawing.Point(80, 107);
        //    this.reportViewer1.Name = "reportViewer1";
        //    this.reportViewer1.ServerReport.BearerToken = null;
        //    this.reportViewer1.Size = new System.Drawing.Size(573, 354);
          //  this.reportViewer1.TabIndex = 0;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qRCodeBindingSource
            // 
            this.qRCodeBindingSource.DataMember = "QRCode";
            this.qRCodeBindingSource.DataSource = this.matrizDataSet;
            // 
            // textPersonal1
            // 
            this.textPersonal1.Correo = false;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.Limpiar = false;
            this.textPersonal1.Location = new System.Drawing.Point(80, 68);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.Size = new System.Drawing.Size(307, 24);
            this.textPersonal1.TabIndex = 1;
            this.textPersonal1.ThemeName = "VisualStudio2012Light";
            this.textPersonal1.Validar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPersonal1);
         //   this.Controls.Add(this.reportViewer1);
            this.Name = "Conduce";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Conduce";
            this.Load += new System.EventHandler(this.Conduce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qRCodeBindingSource;
        private MatrizDataSet matrizDataSet;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private System.Windows.Forms.Button button1;
    }
}
