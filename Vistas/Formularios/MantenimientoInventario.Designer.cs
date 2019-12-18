namespace Vistas.Formularios
{
    partial class MantenimientoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoInventario));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.cbbEstado = new Negocios.Componentes.cbbPersonal();
            this.vistaCentroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.txtBusqueda = new Negocios.Componentes.TextPersonal();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolRecargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btBusqueda = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.dataInventario = new Telerik.WinControls.UI.RadGridView();
            this.vistaCentroTableAdapter = new Vistas.MatrizDataSetTableAdapters.VistaCentroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCentroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda)).BeginInit();
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.White;
            this.cbbEstado.Correo = false;
            this.cbbEstado.DataSource = this.vistaCentroBindingSource;
            this.cbbEstado.DisplayMember = "Nombre";
            this.cbbEstado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.Limpiar = true;
            this.cbbEstado.Location = new System.Drawing.Point(911, 45);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(168, 25);
            this.cbbEstado.TabIndex = 45;
            this.cbbEstado.ThemeName = "VisualStudio2012Light";
            this.cbbEstado.Validar = true;
            this.cbbEstado.ValueMember = "IdCentro";
            this.cbbEstado.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // vistaCentroBindingSource
            // 
            this.vistaCentroBindingSource.DataMember = "VistaCentro";
            this.vistaCentroBindingSource.DataSource = this.matrizDataSet;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Correo = false;
            this.txtBusqueda.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtBusqueda.Limpiar = false;
            this.txtBusqueda.Location = new System.Drawing.Point(12, 42);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.NullText = "Informacion a buscar";
            this.txtBusqueda.Size = new System.Drawing.Size(384, 24);
            this.txtBusqueda.TabIndex = 44;
            this.txtBusqueda.ThemeName = "VisualStudio2012Light";
            this.txtBusqueda.Validar = false;
            // 
            // toolMenu
            // 
            this.toolMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolGuardar,
            this.toolImprimir,
            this.toolCancelar,
            this.toolRecargar,
            this.toolStripButton1});
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolMenu.Size = new System.Drawing.Size(1090, 39);
            this.toolMenu.TabIndex = 43;
            this.toolMenu.Text = "toolStrip1";
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevo.Image")));
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(23, 36);
            this.toolNuevo.Text = "Nuevo Cliente";
            // 
            // toolGuardar
            // 
            this.toolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(36, 36);
            this.toolGuardar.Text = "Guardar";
            // 
            // toolImprimir
            // 
            this.toolImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolImprimir.Image")));
            this.toolImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImprimir.Name = "toolImprimir";
            this.toolImprimir.Size = new System.Drawing.Size(36, 36);
            this.toolImprimir.Text = "Imprimir";
            // 
            // toolCancelar
            // 
            this.toolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolCancelar.Image")));
            this.toolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(23, 36);
            this.toolCancelar.Text = "Cancelar";
            // 
            // toolRecargar
            // 
            this.toolRecargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRecargar.Image = ((System.Drawing.Image)(resources.GetObject("toolRecargar.Image")));
            this.toolRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRecargar.Name = "toolRecargar";
            this.toolRecargar.Size = new System.Drawing.Size(23, 36);
            this.toolRecargar.Text = "Recargar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btBusqueda
            // 
            this.btBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btBusqueda.Image")));
            this.btBusqueda.Location = new System.Drawing.Point(402, 42);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(110, 24);
            this.btBusqueda.TabIndex = 42;
            this.btBusqueda.Text = "Busqueda";
            this.btBusqueda.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(12, 68);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(1066, 10);
            this.radSeparator1.TabIndex = 41;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // dataInventario
            // 
            this.dataInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataInventario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataInventario.Location = new System.Drawing.Point(12, 84);
            // 
            // 
            // 
            this.dataInventario.MasterTemplate.AllowAddNewRow = false;
            this.dataInventario.MasterTemplate.AllowColumnChooser = false;
            this.dataInventario.MasterTemplate.AllowColumnReorder = false;
            this.dataInventario.MasterTemplate.AllowDragToGroup = false;
            this.dataInventario.MasterTemplate.AllowRowResize = false;
            this.dataInventario.MasterTemplate.AllowSearchRow = true;
            this.dataInventario.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(int);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "IdInventario";
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "IdInventario";
            gridViewTextBoxColumn1.Width = 143;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Centro";
            gridViewTextBoxColumn2.HeaderText = "Centro";
            gridViewTextBoxColumn2.Name = "Centro";
            gridViewTextBoxColumn2.Width = 171;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Inventario";
            gridViewTextBoxColumn3.HeaderText = "Inventario";
            gridViewTextBoxColumn3.Name = "Inventario";
            gridViewTextBoxColumn3.Width = 184;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Descripcion";
            gridViewTextBoxColumn4.HeaderText = "Descripcion";
            gridViewTextBoxColumn4.Name = "Descripcion";
            gridViewTextBoxColumn4.Width = 298;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Unidad";
            gridViewTextBoxColumn5.HeaderText = "Unidad";
            gridViewTextBoxColumn5.Name = "Unidad";
            gridViewTextBoxColumn5.Width = 72;
            gridViewTextBoxColumn6.DataType = typeof(float);
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Stock";
            gridViewTextBoxColumn6.HeaderText = "Stock";
            gridViewTextBoxColumn6.Name = "Stock";
            gridViewTextBoxColumn6.Width = 92;
            gridViewTextBoxColumn7.DataType = typeof(float);
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "StockPromedio";
            gridViewTextBoxColumn7.HeaderText = "StockPromedio";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "StockPromedio";
            gridViewTextBoxColumn7.Width = 73;
            gridViewTextBoxColumn8.DataType = typeof(float);
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "StockMinimo";
            gridViewTextBoxColumn8.HeaderText = "StockMinimo";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "StockMinimo";
            gridViewTextBoxColumn8.Width = 77;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Estado";
            gridViewTextBoxColumn9.HeaderText = "Estado";
            gridViewTextBoxColumn9.Name = "Estado";
            gridViewTextBoxColumn9.Width = 114;
            this.dataInventario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.dataInventario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataInventario.MasterTemplate.EnableSorting = false;
            this.dataInventario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataInventario.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.ReadOnly = true;
            this.dataInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataInventario.Size = new System.Drawing.Size(1067, 486);
            this.dataInventario.TabIndex = 46;
            this.dataInventario.ThemeName = "VisualStudio2012Light";
            // 
            // vistaCentroTableAdapter
            // 
            this.vistaCentroTableAdapter.ClearBeforeFill = true;
            // 
            // MantenimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 582);
            this.Controls.Add(this.dataInventario);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.toolMenu);
            this.Controls.Add(this.btBusqueda);
            this.Controls.Add(this.radSeparator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MantenimientoInventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MantenimientoInventario";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.MantenimientoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCentroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusqueda)).EndInit();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Negocios.Componentes.cbbPersonal cbbEstado;
        public Negocios.Componentes.TextPersonal txtBusqueda;
        public System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolRecargar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public Telerik.WinControls.UI.RadButton btBusqueda;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGridView dataInventario;
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource vistaCentroBindingSource;
        private MatrizDataSetTableAdapters.VistaCentroTableAdapter vistaCentroTableAdapter;
    }
}
