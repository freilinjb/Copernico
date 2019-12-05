namespace Vistas.Formularios
{
    partial class Analisis
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dataCentro = new Telerik.WinControls.UI.RadGridView();
            this.radSeparator3 = new Telerik.WinControls.UI.RadSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCentro.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCentro
            // 
            this.dataCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataCentro.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataCentro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataCentro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataCentro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataCentro.Location = new System.Drawing.Point(12, 293);
            // 
            // 
            // 
            this.dataCentro.MasterTemplate.AllowAddNewRow = false;
            this.dataCentro.MasterTemplate.AllowColumnChooser = false;
            this.dataCentro.MasterTemplate.AllowColumnReorder = false;
            this.dataCentro.MasterTemplate.AllowDragToGroup = false;
            this.dataCentro.MasterTemplate.AllowRowResize = false;
            this.dataCentro.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "No. Tamiz";
            gridViewTextBoxColumn1.Name = "NumMalla";
            gridViewTextBoxColumn1.Width = 103;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Tamiz mm";
            gridViewTextBoxColumn2.Name = "TamizApertura";
            gridViewTextBoxColumn2.Width = 102;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Peso Retenido (Gr.)";
            gridViewTextBoxColumn3.Name = "PeroRetenido";
            gridViewTextBoxColumn3.Width = 106;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Retenido %";
            gridViewTextBoxColumn4.Name = "Retenido";
            gridViewTextBoxColumn4.Width = 114;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Retenido Acumulado";
            gridViewTextBoxColumn5.Name = "RetenidoAcumulado";
            gridViewTextBoxColumn5.Width = 118;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Pasante (%)";
            gridViewTextBoxColumn6.Name = "Pasante";
            gridViewTextBoxColumn6.Width = 125;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "column7";
            gridViewTextBoxColumn7.Name = "column7";
            gridViewTextBoxColumn7.Width = 135;
            this.dataCentro.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.dataCentro.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataCentro.MasterTemplate.EnableGrouping = false;
            this.dataCentro.MasterTemplate.EnableSorting = false;
            this.dataCentro.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataCentro.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataCentro.Name = "dataCentro";
            this.dataCentro.ReadOnly = true;
            this.dataCentro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataCentro.ShowGroupPanel = false;
            this.dataCentro.Size = new System.Drawing.Size(796, 365);
            this.dataCentro.TabIndex = 20;
            this.dataCentro.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator3
            // 
            this.radSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator3.Location = new System.Drawing.Point(12, 277);
            this.radSeparator3.Name = "radSeparator3";
            this.radSeparator3.Size = new System.Drawing.Size(796, 10);
            this.radSeparator3.TabIndex = 38;
            this.radSeparator3.ThemeName = "VisualStudio2012Light";
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 670);
            this.Controls.Add(this.radSeparator3);
            this.Controls.Add(this.dataCentro);
            this.Name = "Analisis";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Analisis";
            ((System.ComponentModel.ISupportInitialize)(this.dataCentro.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dataCentro;
        private Telerik.WinControls.UI.RadSeparator radSeparator3;
    }
}
