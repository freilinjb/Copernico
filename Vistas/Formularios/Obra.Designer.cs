namespace Vistas.Formularios
{
    partial class Obra
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtObra = new Negocios.Componentes.TextPersonal();
            this.cbbCliente = new Negocios.Componentes.MultiCbbPersonal();
            this.dataObra = new Telerik.WinControls.UI.RadGridView();
            this.txtNota = new Negocios.Componentes.TextPersonal();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtDireccion = new Negocios.Componentes.TextPersonal();
            this.cbbProvincia = new Negocios.Componentes.cbbPersonal();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.cbbCiudad = new Negocios.Componentes.cbbPersonal();
            this.cbbMunicipio = new Negocios.Componentes.cbbPersonal();
            this.municipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbSector = new Negocios.Componentes.cbbPersonal();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator3 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator4 = new Telerik.WinControls.UI.RadSeparator();
            this.provinciaTableAdapter = new Vistas.MatrizDataSetTableAdapters.ProvinciaTableAdapter();
            this.municipioTableAdapter = new Vistas.MatrizDataSetTableAdapters.MunicipioTableAdapter();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTableAdapter = new Vistas.MatrizDataSetTableAdapters.CiudadTableAdapter();
            this.sectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorTableAdapter = new Vistas.MatrizDataSetTableAdapters.SectorTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbEncargado = new Negocios.Componentes.cbbPersonal();
            this.chEstado = new Telerik.WinControls.UI.RadToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.txtObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObra.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEncargado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObra
            // 
            this.txtObra.Correo = false;
            this.txtObra.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObra.Limpiar = true;
            this.txtObra.Location = new System.Drawing.Point(77, 75);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(216, 24);
            this.txtObra.TabIndex = 20;
            this.txtObra.ThemeName = "VisualStudio2012Light";
            this.txtObra.Validar = true;
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoFilter = true;
            this.cbbCliente.AutoSizeDropDownToBestFit = true;
            this.cbbCliente.DisplayMember = "IdCliente";
            // 
            // cbbCliente.NestedRadGridView
            // 
            this.cbbCliente.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cbbCliente.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbCliente.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbbCliente.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbCliente.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbCliente.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.cbbCliente.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cbbCliente.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cbbCliente.EditorControl.MasterTemplate.AllowColumnChooser = false;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "IdCliente";
            gridViewDecimalColumn3.HeaderText = "Codigo";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "IdCliente";
            gridViewDecimalColumn3.Width = 60;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "IdTercero";
            gridViewDecimalColumn4.HeaderText = "IdTercero";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "IdTercero";
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "Nombre";
            gridViewTextBoxColumn18.HeaderText = "Nombre";
            gridViewTextBoxColumn18.IsAutoGenerated = true;
            gridViewTextBoxColumn18.IsVisible = false;
            gridViewTextBoxColumn18.Name = "Nombre";
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "RazonSocial";
            gridViewTextBoxColumn19.HeaderText = "Razon Social";
            gridViewTextBoxColumn19.IsAutoGenerated = true;
            gridViewTextBoxColumn19.Name = "RazonSocial";
            gridViewTextBoxColumn19.Width = 187;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "Observacion";
            gridViewTextBoxColumn20.HeaderText = "Observacion";
            gridViewTextBoxColumn20.IsAutoGenerated = true;
            gridViewTextBoxColumn20.IsVisible = false;
            gridViewTextBoxColumn20.Name = "Observacion";
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.FieldName = "TipoIdentificacion";
            gridViewTextBoxColumn21.HeaderText = "TipoIdentificacion";
            gridViewTextBoxColumn21.IsAutoGenerated = true;
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "TipoIdentificacion";
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "Identificacion";
            gridViewTextBoxColumn22.HeaderText = "Identificacion";
            gridViewTextBoxColumn22.IsAutoGenerated = true;
            gridViewTextBoxColumn22.IsVisible = false;
            gridViewTextBoxColumn22.Name = "Identificacion";
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "Telefono";
            gridViewTextBoxColumn23.HeaderText = "Telefono";
            gridViewTextBoxColumn23.IsAutoGenerated = true;
            gridViewTextBoxColumn23.Name = "Telefono";
            gridViewTextBoxColumn23.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn23.Width = 92;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "Correo";
            gridViewTextBoxColumn24.HeaderText = "Correo";
            gridViewTextBoxColumn24.IsAutoGenerated = true;
            gridViewTextBoxColumn24.Name = "Correo";
            gridViewTextBoxColumn24.Width = 116;
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.FieldName = "Provincia";
            gridViewTextBoxColumn25.HeaderText = "Provincia";
            gridViewTextBoxColumn25.IsAutoGenerated = true;
            gridViewTextBoxColumn25.IsVisible = false;
            gridViewTextBoxColumn25.Name = "Provincia";
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.FieldName = "Municipio";
            gridViewTextBoxColumn26.HeaderText = "Municipio";
            gridViewTextBoxColumn26.IsAutoGenerated = true;
            gridViewTextBoxColumn26.IsVisible = false;
            gridViewTextBoxColumn26.Name = "Municipio";
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.FieldName = "Sector";
            gridViewTextBoxColumn27.HeaderText = "Sector";
            gridViewTextBoxColumn27.IsAutoGenerated = true;
            gridViewTextBoxColumn27.Name = "Sector";
            gridViewTextBoxColumn27.Width = 131;
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.FieldName = "Direccion";
            gridViewTextBoxColumn28.HeaderText = "Direccion";
            gridViewTextBoxColumn28.IsAutoGenerated = true;
            gridViewTextBoxColumn28.IsVisible = false;
            gridViewTextBoxColumn28.Name = "Direccion";
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "Estado";
            gridViewCheckBoxColumn2.HeaderText = "Estado";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.IsVisible = false;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "Estado";
            this.cbbCliente.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewCheckBoxColumn2});
            this.cbbCliente.EditorControl.MasterTemplate.EnableAlternatingRowColor = true;
            this.cbbCliente.EditorControl.MasterTemplate.EnableFiltering = true;
            this.cbbCliente.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cbbCliente.EditorControl.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor2.PropertyName = "Telefono";
            this.cbbCliente.EditorControl.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.cbbCliente.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.cbbCliente.EditorControl.Name = "NestedRadGridView";
            this.cbbCliente.EditorControl.ReadOnly = true;
            this.cbbCliente.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbCliente.EditorControl.ShowGroupPanel = false;
            this.cbbCliente.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.cbbCliente.EditorControl.TabIndex = 0;
            this.cbbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCliente.Limpiar = false;
            this.cbbCliente.Location = new System.Drawing.Point(77, 46);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(58, 23);
            this.cbbCliente.TabIndex = 18;
            this.cbbCliente.TabStop = false;
            this.cbbCliente.ThemeName = "VisualStudio2012Light";
            this.cbbCliente.Validar = false;
            this.cbbCliente.ValueMember = "IdCliente";
            // 
            // dataObra
            // 
            this.dataObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataObra.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataObra.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dataObra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataObra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataObra.Location = new System.Drawing.Point(10, 375);
            // 
            // 
            // 
            this.dataObra.MasterTemplate.AllowAddNewRow = false;
            this.dataObra.MasterTemplate.AllowColumnReorder = false;
            this.dataObra.MasterTemplate.AllowDragToGroup = false;
            this.dataObra.MasterTemplate.AllowRowResize = false;
            this.dataObra.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn29.EnableExpressionEditor = false;
            gridViewTextBoxColumn29.HeaderText = "Codigo";
            gridViewTextBoxColumn29.Name = "Codigo";
            gridViewTextBoxColumn29.Width = 61;
            gridViewTextBoxColumn30.EnableExpressionEditor = false;
            gridViewTextBoxColumn30.HeaderText = "Descripción";
            gridViewTextBoxColumn30.Name = "Descripcion";
            gridViewTextBoxColumn30.Width = 191;
            gridViewTextBoxColumn31.EnableExpressionEditor = false;
            gridViewTextBoxColumn31.HeaderText = "Unidad";
            gridViewTextBoxColumn31.Name = "Unidad";
            gridViewTextBoxColumn31.Width = 98;
            gridViewTextBoxColumn32.EnableExpressionEditor = false;
            gridViewTextBoxColumn32.HeaderText = "Cantidad";
            gridViewTextBoxColumn32.Name = "Cantidad";
            gridViewTextBoxColumn32.Width = 81;
            gridViewTextBoxColumn33.EnableExpressionEditor = false;
            gridViewTextBoxColumn33.HeaderText = "Precio";
            gridViewTextBoxColumn33.Name = "Precio";
            gridViewTextBoxColumn33.Width = 78;
            gridViewTextBoxColumn34.EnableExpressionEditor = false;
            gridViewTextBoxColumn34.HeaderText = "Importe";
            gridViewTextBoxColumn34.Name = "Importe";
            gridViewTextBoxColumn34.Width = 71;
            this.dataObra.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn29,
            gridViewTextBoxColumn30,
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34});
            this.dataObra.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataObra.MasterTemplate.EnableGrouping = false;
            this.dataObra.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataObra.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.dataObra.Name = "dataObra";
            this.dataObra.ReadOnly = true;
            this.dataObra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataObra.Size = new System.Drawing.Size(574, 193);
            this.dataObra.TabIndex = 21;
            this.dataObra.ThemeName = "VisualStudio2012Light";
            // 
            // txtNota
            // 
            this.txtNota.Correo = false;
            this.txtNota.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNota.Limpiar = false;
            this.txtNota.Location = new System.Drawing.Point(9, 288);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.NullText = "Nota";
            // 
            // 
            // 
            this.txtNota.RootElement.StretchVertically = true;
            this.txtNota.Size = new System.Drawing.Size(574, 65);
            this.txtNota.TabIndex = 19;
            this.txtNota.ThemeName = "VisualStudio2012Light";
            this.txtNota.Validar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(22, 43);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 21);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(595, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Registro de Obra/Proyecto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(24, 79);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(37, 21);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "Obra";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(24, 109);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(76, 21);
            this.radLabel4.TabIndex = 17;
            this.radLabel4.Text = "Ing. Acargo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(141, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 23);
            this.label1.TabIndex = 23;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(10, 359);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(574, 10);
            this.radSeparator2.TabIndex = 24;
            this.radSeparator2.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(10, 574);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(574, 10);
            this.radSeparator1.TabIndex = 24;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.chEstado);
            this.radGroupBox3.Controls.Add(this.txtDireccion);
            this.radGroupBox3.Controls.Add(this.cbbProvincia);
            this.radGroupBox3.Controls.Add(this.cbbCiudad);
            this.radGroupBox3.Controls.Add(this.cbbMunicipio);
            this.radGroupBox3.Controls.Add(this.cbbSector);
            this.radGroupBox3.Controls.Add(this.radLabel8);
            this.radGroupBox3.Controls.Add(this.radLabel5);
            this.radGroupBox3.Controls.Add(this.radLabel9);
            this.radGroupBox3.Controls.Add(this.radLabel10);
            this.radGroupBox3.HeaderText = "Localidad";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 136);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(572, 134);
            this.radGroupBox3.TabIndex = 25;
            this.radGroupBox3.Text = "Localidad";
            this.radGroupBox3.ThemeName = "VisualStudio2012Light";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Correo = false;
            this.txtDireccion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Limpiar = true;
            this.txtDireccion.Location = new System.Drawing.Point(10, 81);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NullText = "Direcicon";
            this.txtDireccion.Size = new System.Drawing.Size(546, 24);
            this.txtDireccion.TabIndex = 26;
            this.txtDireccion.ThemeName = "VisualStudio2012Light";
            this.txtDireccion.Validar = true;
            // 
            // cbbProvincia
            // 
            this.cbbProvincia.BackColor = System.Drawing.Color.White;
            this.cbbProvincia.Correo = false;
            this.cbbProvincia.DataSource = this.provinciaBindingSource;
            this.cbbProvincia.DisplayMember = "Descripcion";
            this.cbbProvincia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProvincia.Limpiar = true;
            this.cbbProvincia.Location = new System.Drawing.Point(75, 21);
            this.cbbProvincia.Name = "cbbProvincia";
            this.cbbProvincia.Size = new System.Drawing.Size(196, 23);
            this.cbbProvincia.TabIndex = 13;
            this.cbbProvincia.ThemeName = "VisualStudio2012Light";
            this.cbbProvincia.Validar = true;
            this.cbbProvincia.ValueMember = "IdProvincia";
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataMember = "Provincia";
            this.provinciaBindingSource.DataSource = this.matrizDataSet;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbCiudad
            // 
            this.cbbCiudad.BackColor = System.Drawing.Color.White;
            this.cbbCiudad.Correo = false;
            this.cbbCiudad.DataSource = this.ciudadBindingSource;
            this.cbbCiudad.DisplayMember = "Descripcion";
            this.cbbCiudad.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCiudad.Limpiar = true;
            this.cbbCiudad.Location = new System.Drawing.Point(360, 18);
            this.cbbCiudad.Name = "cbbCiudad";
            this.cbbCiudad.Size = new System.Drawing.Size(196, 23);
            this.cbbCiudad.TabIndex = 14;
            this.cbbCiudad.ThemeName = "VisualStudio2012Light";
            this.cbbCiudad.Validar = true;
            this.cbbCiudad.ValueMember = "IdCiudad";
            // 
            // cbbMunicipio
            // 
            this.cbbMunicipio.BackColor = System.Drawing.Color.White;
            this.cbbMunicipio.Correo = false;
            this.cbbMunicipio.DataSource = this.municipioBindingSource;
            this.cbbMunicipio.DisplayMember = "Descripcion";
            this.cbbMunicipio.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMunicipio.Limpiar = true;
            this.cbbMunicipio.Location = new System.Drawing.Point(75, 52);
            this.cbbMunicipio.Name = "cbbMunicipio";
            this.cbbMunicipio.Size = new System.Drawing.Size(196, 23);
            this.cbbMunicipio.TabIndex = 15;
            this.cbbMunicipio.ThemeName = "VisualStudio2012Light";
            this.cbbMunicipio.Validar = true;
            this.cbbMunicipio.ValueMember = "IdMunicipio";
            // 
            // municipioBindingSource
            // 
            this.municipioBindingSource.DataMember = "Municipio";
            this.municipioBindingSource.DataSource = this.matrizDataSet;
            // 
            // cbbSector
            // 
            this.cbbSector.BackColor = System.Drawing.Color.White;
            this.cbbSector.Correo = false;
            this.cbbSector.DataSource = this.sectorBindingSource;
            this.cbbSector.DisplayMember = "Descripcion";
            this.cbbSector.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSector.Limpiar = true;
            this.cbbSector.Location = new System.Drawing.Point(360, 47);
            this.cbbSector.Name = "cbbSector";
            this.cbbSector.Size = new System.Drawing.Size(196, 23);
            this.cbbSector.TabIndex = 16;
            this.cbbSector.ThemeName = "VisualStudio2012Light";
            this.cbbSector.Validar = true;
            this.cbbSector.ValueMember = "IdSector";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(312, 53);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(42, 17);
            this.radLabel8.TabIndex = 12;
            this.radLabel8.Text = "Sector";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(308, 24);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(46, 17);
            this.radLabel5.TabIndex = 10;
            this.radLabel5.Text = "Ciudad";
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel9.Location = new System.Drawing.Point(10, 58);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(59, 17);
            this.radLabel9.TabIndex = 11;
            this.radLabel9.Text = "Municipio";
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel10.Location = new System.Drawing.Point(12, 27);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(57, 17);
            this.radLabel10.TabIndex = 9;
            this.radLabel10.Text = "Provincia";
            // 
            // radSeparator3
            // 
            this.radSeparator3.Location = new System.Drawing.Point(4, 27);
            this.radSeparator3.Name = "radSeparator3";
            this.radSeparator3.Size = new System.Drawing.Size(582, 10);
            this.radSeparator3.TabIndex = 24;
            this.radSeparator3.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator4
            // 
            this.radSeparator4.Location = new System.Drawing.Point(10, 278);
            this.radSeparator4.Name = "radSeparator4";
            this.radSeparator4.Size = new System.Drawing.Size(574, 10);
            this.radSeparator4.TabIndex = 24;
            this.radSeparator4.ThemeName = "VisualStudio2012Light";
            // 
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // municipioTableAdapter
            // 
            this.municipioTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.matrizDataSet;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // sectorBindingSource
            // 
            this.sectorBindingSource.DataMember = "Sector";
            this.sectorBindingSource.DataSource = this.matrizDataSet;
            // 
            // sectorTableAdapter
            // 
            this.sectorTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbbEncargado
            // 
            this.cbbEncargado.BackColor = System.Drawing.Color.White;
            this.cbbEncargado.Correo = false;
            this.cbbEncargado.DisplayMember = "Descripcion";
            this.cbbEncargado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEncargado.Limpiar = true;
            this.cbbEncargado.Location = new System.Drawing.Point(106, 105);
            this.cbbEncargado.Name = "cbbEncargado";
            this.cbbEncargado.Size = new System.Drawing.Size(187, 23);
            this.cbbEncargado.TabIndex = 13;
            this.cbbEncargado.ThemeName = "VisualStudio2012Light";
            this.cbbEncargado.Validar = true;
            this.cbbEncargado.ValueMember = "IdProvincia";
            // 
            // chEstado
            // 
            this.chEstado.Location = new System.Drawing.Point(485, 111);
            this.chEstado.Name = "chEstado";
            this.chEstado.OffText = "Inactivo";
            this.chEstado.OnText = "Activo";
            this.chEstado.Size = new System.Drawing.Size(71, 20);
            this.chEstado.TabIndex = 27;
            this.chEstado.ThemeName = "VisualStudio2012Light";
            this.chEstado.ThumbTickness = 15;
            // 
            // Obra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 593);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.cbbEncargado);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.radSeparator4);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.radSeparator3);
            this.Controls.Add(this.radSeparator2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObra);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.dataObra);
            this.KeyPreview = true;
            this.Name = "Obra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Obra";
            this.Load += new System.EventHandler(this.Obra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObra.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEncargado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Negocios.Componentes.TextPersonal txtObra;
        private Negocios.Componentes.MultiCbbPersonal cbbCliente;
        private Telerik.WinControls.UI.RadGridView dataObra;
        private Negocios.Componentes.TextPersonal txtNota;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Negocios.Componentes.cbbPersonal cbbProvincia;
        private Negocios.Componentes.cbbPersonal cbbCiudad;
        private Negocios.Componentes.cbbPersonal cbbMunicipio;
        private Negocios.Componentes.cbbPersonal cbbSector;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Negocios.Componentes.TextPersonal txtDireccion;
        private Telerik.WinControls.UI.RadSeparator radSeparator3;
        private Telerik.WinControls.UI.RadSeparator radSeparator4;
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private MatrizDataSetTableAdapters.ProvinciaTableAdapter provinciaTableAdapter;
        private System.Windows.Forms.BindingSource municipioBindingSource;
        private MatrizDataSetTableAdapters.MunicipioTableAdapter municipioTableAdapter;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private MatrizDataSetTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.BindingSource sectorBindingSource;
        private MatrizDataSetTableAdapters.SectorTableAdapter sectorTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Negocios.Componentes.cbbPersonal cbbEncargado;
        private Telerik.WinControls.UI.RadToggleSwitch chEstado;
    }
}
