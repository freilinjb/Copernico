namespace Vistas.Formularios
{
    partial class Ordenes
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dataProducto = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProducto
            // 
            this.dataProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dataProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataProducto.Location = new System.Drawing.Point(63, 253);
            // 
            // 
            // 
            this.dataProducto.MasterTemplate.AllowAddNewRow = false;
            this.dataProducto.MasterTemplate.AllowColumnReorder = false;
            this.dataProducto.MasterTemplate.AllowDragToGroup = false;
            this.dataProducto.MasterTemplate.AllowRowResize = false;
            this.dataProducto.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.Width = 94;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Descripción";
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.Width = 293;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Unidad";
            gridViewTextBoxColumn3.Name = "Unidad";
            gridViewTextBoxColumn3.Width = 151;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Cantidad";
            gridViewTextBoxColumn4.Name = "Cantidad";
            gridViewTextBoxColumn4.Width = 123;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Precio";
            gridViewTextBoxColumn5.Name = "Precio";
            gridViewTextBoxColumn5.Width = 119;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Importe";
            gridViewTextBoxColumn6.Name = "Importe";
            gridViewTextBoxColumn6.Width = 107;
            this.dataProducto.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dataProducto.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataProducto.MasterTemplate.EnableGrouping = false;
            this.dataProducto.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataProducto.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataProducto.Name = "dataProducto";
            this.dataProducto.ReadOnly = true;
            this.dataProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataProducto.Size = new System.Drawing.Size(881, 207);
            this.dataProducto.TabIndex = 17;
            this.dataProducto.ThemeName = "VisualStudio2012Light";
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 712);
            this.Controls.Add(this.dataProducto);
            this.Name = "Ordenes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dataProducto;
    }
}
