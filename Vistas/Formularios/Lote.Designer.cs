namespace Vistas.Formularios
{
    partial class Lote
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pagePrincipal = new Telerik.WinControls.UI.RadPageView();
            this.pageLote = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.trackFino = new Telerik.WinControls.UI.RadTrackBar();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.radSeparator3 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.trackDesperdicio = new Telerik.WinControls.UI.RadTrackBar();
            this.lbPorcentajeGrueso = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lbPorcentajeFijo = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.chEstado = new Telerik.WinControls.UI.RadToggleSwitch();
            this.pageInventario = new Telerik.WinControls.UI.RadPageViewPage();
            this.dataInventario = new Telerik.WinControls.UI.RadGridView();
            this.radSeparator4 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator5 = new Telerik.WinControls.UI.RadSeparator();
            this.cbbCentro = new Negocios.Componentes.cbbPersonal();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.dataLote = new Telerik.WinControls.UI.RadGridView();
            this.trackGrueso = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).BeginInit();
            this.pagePrincipal.SuspendLayout();
            this.pageLote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDesperdicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPorcentajeGrueso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPorcentajeFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            this.pageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLote.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGrueso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(8, 55);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Material Fino";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Controls.Add(this.pageLote);
            this.pagePrincipal.Controls.Add(this.pageInventario);
            this.pagePrincipal.DefaultPage = this.pageLote;
            this.pagePrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pagePrincipal.Location = new System.Drawing.Point(12, 12);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.SelectedPage = this.pageLote;
            this.pagePrincipal.Size = new System.Drawing.Size(459, 360);
            this.pagePrincipal.TabIndex = 41;
            this.pagePrincipal.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // pageLote
            // 
            this.pageLote.Controls.Add(this.radLabel5);
            this.pageLote.Controls.Add(this.txtCodigo);
            this.pageLote.Controls.Add(this.trackGrueso);
            this.pageLote.Controls.Add(this.trackFino);
            this.pageLote.Controls.Add(this.txtNombre);
            this.pageLote.Controls.Add(this.radSeparator3);
            this.pageLote.Controls.Add(this.radLabel4);
            this.pageLote.Controls.Add(this.trackDesperdicio);
            this.pageLote.Controls.Add(this.lbPorcentajeGrueso);
            this.pageLote.Controls.Add(this.radLabel2);
            this.pageLote.Controls.Add(this.lbPorcentajeFijo);
            this.pageLote.Controls.Add(this.radLabel1);
            this.pageLote.Controls.Add(this.radSeparator1);
            this.pageLote.Controls.Add(this.chEstado);
            this.pageLote.ItemSize = new System.Drawing.SizeF(224F, 27F);
            this.pageLote.Location = new System.Drawing.Point(5, 33);
            this.pageLote.Name = "pageLote";
            this.pageLote.Size = new System.Drawing.Size(449, 322);
            this.pageLote.Text = "Informacion General de Lote";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(9, 9);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(49, 18);
            this.radLabel5.TabIndex = 40;
            this.radLabel5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = false;
            this.txtCodigo.Location = new System.Drawing.Point(64, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 24);
            this.txtCodigo.TabIndex = 41;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
            // 
            // trackFino
            // 
            this.trackFino.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft;
            this.trackFino.LargeChange = 5;
            this.trackFino.LargeTickFrequency = 10;
            this.trackFino.Location = new System.Drawing.Point(11, 82);
            this.trackFino.Maximum = 100F;
            this.trackFino.Name = "trackFino";
            this.trackFino.Size = new System.Drawing.Size(424, 43);
            this.trackFino.TabIndex = 39;
            this.trackFino.ThemeName = "VisualStudio2012Light";
            this.trackFino.TickStyle = Telerik.WinControls.Enumerations.TickStyles.TopLeft;
            this.trackFino.ValueChanged += new System.EventHandler(this.trackFino_ValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(8, 274);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NullText = "Descripcion";
            this.txtNombre.Size = new System.Drawing.Size(250, 24);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // radSeparator3
            // 
            this.radSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator3.Location = new System.Drawing.Point(3, 313);
            this.radSeparator3.Name = "radSeparator3";
            this.radSeparator3.Size = new System.Drawing.Size(433, 10);
            this.radSeparator3.TabIndex = 37;
            this.radSeparator3.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(8, 201);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(79, 21);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Desperdicio";
            this.radLabel4.ThemeName = "VisualStudio2012Light";
            // 
            // trackDesperdicio
            // 
            this.trackDesperdicio.Enabled = false;
            this.trackDesperdicio.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.trackDesperdicio.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft;
            this.trackDesperdicio.LargeTickFrequency = 10;
            this.trackDesperdicio.Location = new System.Drawing.Point(8, 225);
            this.trackDesperdicio.Maximum = 100F;
            this.trackDesperdicio.Name = "trackDesperdicio";
            this.trackDesperdicio.Size = new System.Drawing.Size(424, 43);
            this.trackDesperdicio.TabIndex = 0;
            this.trackDesperdicio.ThemeName = "VisualStudio2012Light";
            this.trackDesperdicio.TickStyle = Telerik.WinControls.Enumerations.TickStyles.TopLeft;
            this.trackDesperdicio.TrackBarMode = Telerik.WinControls.UI.TrackBarRangeMode.Range;
            // 
            // lbPorcentajeGrueso
            // 
            this.lbPorcentajeGrueso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPorcentajeGrueso.Location = new System.Drawing.Point(361, 125);
            this.lbPorcentajeGrueso.Name = "lbPorcentajeGrueso";
            this.lbPorcentajeGrueso.Size = new System.Drawing.Size(71, 21);
            this.lbPorcentajeGrueso.TabIndex = 1;
            this.lbPorcentajeGrueso.Text = "Porcentaje";
            this.lbPorcentajeGrueso.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(8, 128);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(86, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Material Fino";
            this.radLabel2.ThemeName = "VisualStudio2012Light";
            // 
            // lbPorcentajeFijo
            // 
            this.lbPorcentajeFijo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPorcentajeFijo.Location = new System.Drawing.Point(361, 55);
            this.lbPorcentajeFijo.Name = "lbPorcentajeFijo";
            this.lbPorcentajeFijo.Size = new System.Drawing.Size(71, 21);
            this.lbPorcentajeFijo.TabIndex = 1;
            this.lbPorcentajeFijo.Text = "Porcentaje";
            this.lbPorcentajeFijo.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(8, 33);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(431, 10);
            this.radSeparator1.TabIndex = 35;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // chEstado
            // 
            this.chEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chEstado.Location = new System.Drawing.Point(343, 278);
            this.chEstado.Name = "chEstado";
            this.chEstado.OffText = "Inactivo";
            this.chEstado.OnText = "Activo";
            this.chEstado.Size = new System.Drawing.Size(96, 20);
            this.chEstado.TabIndex = 34;
            this.chEstado.ThemeName = "VisualStudio2012Light";
            this.chEstado.ThumbTickness = 15;
            this.chEstado.ToggleStateMode = Telerik.WinControls.UI.ToggleStateMode.Click;
            // 
            // pageInventario
            // 
            this.pageInventario.Controls.Add(this.dataInventario);
            this.pageInventario.Controls.Add(this.radSeparator4);
            this.pageInventario.Controls.Add(this.radSeparator5);
            this.pageInventario.Controls.Add(this.cbbCentro);
            this.pageInventario.Controls.Add(this.radLabel3);
            this.pageInventario.ItemSize = new System.Drawing.SizeF(235F, 27F);
            this.pageInventario.Location = new System.Drawing.Point(5, 33);
            this.pageInventario.Name = "pageInventario";
            this.pageInventario.Size = new System.Drawing.Size(449, 322);
            this.pageInventario.Text = "Registro de Tipo de Inventario";
            // 
            // dataInventario
            // 
            this.dataInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataInventario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataInventario.Location = new System.Drawing.Point(3, 64);
            // 
            // 
            // 
            this.dataInventario.MasterTemplate.AllowAddNewRow = false;
            this.dataInventario.MasterTemplate.AllowColumnChooser = false;
            this.dataInventario.MasterTemplate.AllowColumnReorder = false;
            this.dataInventario.MasterTemplate.AllowDragToGroup = false;
            this.dataInventario.MasterTemplate.AllowRowResize = false;
            this.dataInventario.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "IdLote";
            gridViewTextBoxColumn1.HeaderText = "IdTipoInventario";
            gridViewTextBoxColumn1.Name = "IdLote";
            gridViewTextBoxColumn1.Width = 153;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Mina";
            gridViewTextBoxColumn2.HeaderText = "Inventario";
            gridViewTextBoxColumn2.Name = "Mina";
            gridViewTextBoxColumn2.Width = 291;
            this.dataInventario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dataInventario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataInventario.MasterTemplate.EnableSorting = false;
            this.dataInventario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataInventario.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.ReadOnly = true;
            this.dataInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataInventario.Size = new System.Drawing.Size(442, 223);
            this.dataInventario.TabIndex = 36;
            this.dataInventario.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator4
            // 
            this.radSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator4.Location = new System.Drawing.Point(4, 0);
            this.radSeparator4.Name = "radSeparator4";
            this.radSeparator4.Size = new System.Drawing.Size(441, 10);
            this.radSeparator4.TabIndex = 35;
            this.radSeparator4.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator5
            // 
            this.radSeparator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator5.Location = new System.Drawing.Point(3, 48);
            this.radSeparator5.Name = "radSeparator5";
            this.radSeparator5.Size = new System.Drawing.Size(443, 10);
            this.radSeparator5.TabIndex = 35;
            this.radSeparator5.ThemeName = "VisualStudio2012Light";
            // 
            // cbbCentro
            // 
            this.cbbCentro.BackColor = System.Drawing.Color.White;
            this.cbbCentro.Correo = false;
            this.cbbCentro.DisplayMember = "Descripcion";
            this.cbbCentro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCentro.Limpiar = true;
            this.cbbCentro.Location = new System.Drawing.Point(104, 17);
            this.cbbCentro.Name = "cbbCentro";
            this.cbbCentro.Size = new System.Drawing.Size(168, 25);
            this.cbbCentro.TabIndex = 29;
            this.cbbCentro.ThemeName = "VisualStudio2012Light";
            this.cbbCentro.Validar = true;
            this.cbbCentro.ValueMember = "IdTipoProducto";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(3, 23);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(95, 18);
            this.radLabel3.TabIndex = 24;
            this.radLabel3.Text = "Tipo Inventario";
            // 
            // dataLote
            // 
            this.dataLote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataLote.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataLote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataLote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataLote.Location = new System.Drawing.Point(12, 378);
            // 
            // 
            // 
            this.dataLote.MasterTemplate.AllowAddNewRow = false;
            this.dataLote.MasterTemplate.AllowColumnChooser = false;
            this.dataLote.MasterTemplate.AllowColumnReorder = false;
            this.dataLote.MasterTemplate.AllowDragToGroup = false;
            this.dataLote.MasterTemplate.AllowRowResize = false;
            this.dataLote.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn3.DataType = typeof(int);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "IdLote";
            gridViewTextBoxColumn3.HeaderText = "Codigo";
            gridViewTextBoxColumn3.Name = "IdLote";
            gridViewTextBoxColumn3.Width = 96;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Lote";
            gridViewTextBoxColumn4.HeaderText = "Lote";
            gridViewTextBoxColumn4.Name = "Lote";
            gridViewTextBoxColumn4.Width = 365;
            this.dataLote.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dataLote.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataLote.MasterTemplate.EnableGrouping = false;
            this.dataLote.MasterTemplate.EnableSorting = false;
            this.dataLote.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataLote.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dataLote.Name = "dataLote";
            this.dataLote.ReadOnly = true;
            this.dataLote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataLote.ShowGroupPanel = false;
            this.dataLote.Size = new System.Drawing.Size(459, 289);
            this.dataLote.TabIndex = 42;
            this.dataLote.ThemeName = "VisualStudio2012Light";
            // 
            // trackGrueso
            // 
            this.trackGrueso.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft;
            this.trackGrueso.LargeChange = 5;
            this.trackGrueso.LargeTickFrequency = 10;
            this.trackGrueso.Location = new System.Drawing.Point(8, 155);
            this.trackGrueso.Maximum = 100F;
            this.trackGrueso.Name = "trackGrueso";
            this.trackGrueso.Size = new System.Drawing.Size(424, 43);
            this.trackGrueso.TabIndex = 39;
            this.trackGrueso.ThemeName = "VisualStudio2012Light";
            this.trackGrueso.TickStyle = Telerik.WinControls.Enumerations.TickStyles.TopLeft;
            this.trackGrueso.ValueChanged += new System.EventHandler(this.trackGrueso_ValueChanged);
            // 
            // Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 701);
            this.Controls.Add(this.dataLote);
            this.Controls.Add(this.pagePrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyPreview = true;
            this.Name = "Lote";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Lote";
            this.Load += new System.EventHandler(this.Lote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).EndInit();
            this.pagePrincipal.ResumeLayout(false);
            this.pageLote.ResumeLayout(false);
            this.pageLote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDesperdicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPorcentajeGrueso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPorcentajeFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            this.pageInventario.ResumeLayout(false);
            this.pageInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLote.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGrueso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageView pagePrincipal;
        private Telerik.WinControls.UI.RadPageViewPage pageLote;
        private Telerik.WinControls.UI.RadSeparator radSeparator3;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadToggleSwitch chEstado;
        private Telerik.WinControls.UI.RadPageViewPage pageInventario;
        private Telerik.WinControls.UI.RadGridView dataInventario;
        private Telerik.WinControls.UI.RadSeparator radSeparator4;
        private Telerik.WinControls.UI.RadSeparator radSeparator5;
        private Negocios.Componentes.cbbPersonal cbbCentro;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTrackBar trackDesperdicio;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lbPorcentajeGrueso;
        private Telerik.WinControls.UI.RadLabel lbPorcentajeFijo;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Telerik.WinControls.UI.RadTrackBar trackFino;
        private Telerik.WinControls.UI.RadGridView dataLote;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Negocios.Componentes.TextPersonal txtCodigo;
        private Telerik.WinControls.UI.RadTrackBar trackGrueso;
    }
}
