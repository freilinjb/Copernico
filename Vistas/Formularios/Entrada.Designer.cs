namespace Vistas.Formularios
{
    partial class Entrada
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pagePrincipal = new Telerik.WinControls.UI.RadPageView();
            this.pageAlmacen = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtFechaIngreso = new Telerik.WinControls.UI.RadDateTimePicker();
            this.Fecha = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator3 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.cbbPersonal2 = new Negocios.Componentes.cbbPersonal();
            this.cbbPersonal1 = new Negocios.Componentes.cbbPersonal();
            this.cbbCentro = new Negocios.Componentes.cbbPersonal();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.txtDescripcion = new Negocios.Componentes.TextPersonal();
            this.pageInventario = new Telerik.WinControls.UI.RadPageViewPage();
            this.dataInventario = new Telerik.WinControls.UI.RadGridView();
            this.radSeparator4 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator5 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.cbbTipoInventario = new Negocios.Componentes.cbbPersonal();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.cbbPersonal3 = new Negocios.Componentes.cbbPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).BeginInit();
            this.pagePrincipal.SuspendLayout();
            this.pageAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            this.pageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Controls.Add(this.pageAlmacen);
            this.pagePrincipal.Controls.Add(this.pageInventario);
            this.pagePrincipal.DefaultPage = this.pageAlmacen;
            this.pagePrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pagePrincipal.Location = new System.Drawing.Point(12, 12);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.SelectedPage = this.pageAlmacen;
            this.pagePrincipal.Size = new System.Drawing.Size(743, 390);
            this.pagePrincipal.TabIndex = 41;
            this.pagePrincipal.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // pageAlmacen
            // 
            this.pageAlmacen.Controls.Add(this.txtFechaIngreso);
            this.pageAlmacen.Controls.Add(this.Fecha);
            this.pageAlmacen.Controls.Add(this.radSeparator3);
            this.pageAlmacen.Controls.Add(this.radSeparator2);
            this.pageAlmacen.Controls.Add(this.radSeparator1);
            this.pageAlmacen.Controls.Add(this.radLabel4);
            this.pageAlmacen.Controls.Add(this.radLabel11);
            this.pageAlmacen.Controls.Add(this.radLabel10);
            this.pageAlmacen.Controls.Add(this.radLabel8);
            this.pageAlmacen.Controls.Add(this.radLabel13);
            this.pageAlmacen.Controls.Add(this.radLabel3);
            this.pageAlmacen.Controls.Add(this.cbbPersonal2);
            this.pageAlmacen.Controls.Add(this.cbbPersonal1);
            this.pageAlmacen.Controls.Add(this.cbbPersonal3);
            this.pageAlmacen.Controls.Add(this.cbbCentro);
            this.pageAlmacen.Controls.Add(this.textPersonal1);
            this.pageAlmacen.Controls.Add(this.txtCodigo);
            this.pageAlmacen.Controls.Add(this.txtNombre);
            this.pageAlmacen.Controls.Add(this.txtDescripcion);
            this.pageAlmacen.ItemSize = new System.Drawing.SizeF(341F, 27F);
            this.pageAlmacen.Location = new System.Drawing.Point(5, 33);
            this.pageAlmacen.Name = "pageAlmacen";
            this.pageAlmacen.Size = new System.Drawing.Size(733, 352);
            this.pageAlmacen.Text = "Registro de almacen";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaIngreso.Location = new System.Drawing.Point(103, 49);
            this.txtFechaIngreso.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.txtFechaIngreso.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(168, 24);
            this.txtFechaIngreso.TabIndex = 39;
            this.txtFechaIngreso.TabStop = false;
            this.txtFechaIngreso.Text = "12/12/2019";
            this.txtFechaIngreso.ThemeName = "VisualStudio2012Light";
            this.txtFechaIngreso.Value = new System.DateTime(2019, 12, 12, 7, 26, 16, 824);
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(18, 50);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(44, 18);
            this.Fecha.TabIndex = 38;
            this.Fecha.Text = "Fecha";
            // 
            // radSeparator3
            // 
            this.radSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator3.Location = new System.Drawing.Point(13, 339);
            this.radSeparator3.Name = "radSeparator3";
            this.radSeparator3.Size = new System.Drawing.Size(717, 10);
            this.radSeparator3.TabIndex = 37;
            this.radSeparator3.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator2
            // 
            this.radSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator2.Location = new System.Drawing.Point(13, 290);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(717, 10);
            this.radSeparator2.TabIndex = 36;
            this.radSeparator2.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(13, 3);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(566, 10);
            this.radSeparator1.TabIndex = 35;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel11
            // 
            this.radLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel11.Location = new System.Drawing.Point(18, 148);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(66, 18);
            this.radLabel11.TabIndex = 19;
            this.radLabel11.Text = "Inventario";
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel10.Location = new System.Drawing.Point(18, 111);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(59, 18);
            this.radLabel10.TabIndex = 19;
            this.radLabel10.Text = "Almacen";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(18, 80);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(47, 18);
            this.radLabel8.TabIndex = 19;
            this.radLabel8.Text = "Centro";
            // 
            // radLabel13
            // 
            this.radLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel13.Location = new System.Drawing.Point(300, 88);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(81, 18);
            this.radLabel13.TabIndex = 19;
            this.radLabel13.Text = "Chequeador";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(18, 19);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(54, 18);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "Numero";
            // 
            // cbbPersonal2
            // 
            this.cbbPersonal2.BackColor = System.Drawing.Color.White;
            this.cbbPersonal2.Correo = false;
            this.cbbPersonal2.DisplayMember = "Descripcion";
            this.cbbPersonal2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbPersonal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPersonal2.Limpiar = true;
            this.cbbPersonal2.Location = new System.Drawing.Point(103, 110);
            this.cbbPersonal2.Name = "cbbPersonal2";
            this.cbbPersonal2.Size = new System.Drawing.Size(168, 25);
            this.cbbPersonal2.TabIndex = 32;
            this.cbbPersonal2.ThemeName = "VisualStudio2012Light";
            this.cbbPersonal2.Validar = true;
            this.cbbPersonal2.ValueMember = "IdTipoProducto";
            // 
            // cbbPersonal1
            // 
            this.cbbPersonal1.BackColor = System.Drawing.Color.White;
            this.cbbPersonal1.Correo = false;
            this.cbbPersonal1.DisplayMember = "Descripcion";
            this.cbbPersonal1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPersonal1.Limpiar = true;
            this.cbbPersonal1.Location = new System.Drawing.Point(103, 79);
            this.cbbPersonal1.Name = "cbbPersonal1";
            this.cbbPersonal1.Size = new System.Drawing.Size(168, 25);
            this.cbbPersonal1.TabIndex = 32;
            this.cbbPersonal1.ThemeName = "VisualStudio2012Light";
            this.cbbPersonal1.Validar = true;
            this.cbbPersonal1.ValueMember = "IdTipoProducto";
            // 
            // cbbCentro
            // 
            this.cbbCentro.BackColor = System.Drawing.Color.White;
            this.cbbCentro.Correo = false;
            this.cbbCentro.DisplayMember = "Descripcion";
            this.cbbCentro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCentro.Limpiar = true;
            this.cbbCentro.Location = new System.Drawing.Point(103, 141);
            this.cbbCentro.Name = "cbbCentro";
            this.cbbCentro.Size = new System.Drawing.Size(168, 25);
            this.cbbCentro.TabIndex = 32;
            this.cbbCentro.ThemeName = "VisualStudio2012Light";
            this.cbbCentro.Validar = true;
            this.cbbCentro.ValueMember = "IdTipoProducto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = true;
            this.txtCodigo.Location = new System.Drawing.Point(103, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 24);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(387, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NullText = "Numero de Conduce";
            this.txtNombre.Size = new System.Drawing.Size(168, 24);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Correo = false;
            this.txtDescripcion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(28, 306);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NullText = "Descripción";
            // 
            // 
            // 
            this.txtDescripcion.RootElement.StretchVertically = true;
            this.txtDescripcion.Size = new System.Drawing.Size(702, 27);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.ThemeName = "VisualStudio2012Light";
            this.txtDescripcion.Validar = false;
            // 
            // pageInventario
            // 
            this.pageInventario.Controls.Add(this.dataInventario);
            this.pageInventario.Controls.Add(this.radSeparator4);
            this.pageInventario.Controls.Add(this.radSeparator5);
            this.pageInventario.Controls.Add(this.radLabel2);
            this.pageInventario.Controls.Add(this.cbbTipoInventario);
            this.pageInventario.ItemSize = new System.Drawing.SizeF(401F, 27F);
            this.pageInventario.Location = new System.Drawing.Point(5, 33);
            this.pageInventario.Name = "pageInventario";
            this.pageInventario.Size = new System.Drawing.Size(733, 352);
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
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "IdTipoInventario";
            gridViewTextBoxColumn5.HeaderText = "IdTipoInventario";
            gridViewTextBoxColumn5.Name = "IdTipoInventario";
            gridViewTextBoxColumn5.Width = 251;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Inventario";
            gridViewTextBoxColumn6.HeaderText = "Inventario";
            gridViewTextBoxColumn6.Name = "Inventario";
            gridViewTextBoxColumn6.Width = 477;
            this.dataInventario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dataInventario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataInventario.MasterTemplate.EnableGrouping = false;
            this.dataInventario.MasterTemplate.EnableSorting = false;
            this.dataInventario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataInventario.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.ReadOnly = true;
            this.dataInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataInventario.ShowGroupPanel = false;
            this.dataInventario.Size = new System.Drawing.Size(726, 285);
            this.dataInventario.TabIndex = 36;
            this.dataInventario.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator4
            // 
            this.radSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator4.Location = new System.Drawing.Point(4, 0);
            this.radSeparator4.Name = "radSeparator4";
            this.radSeparator4.Size = new System.Drawing.Size(725, 10);
            this.radSeparator4.TabIndex = 35;
            this.radSeparator4.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator5
            // 
            this.radSeparator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator5.Location = new System.Drawing.Point(3, 48);
            this.radSeparator5.Name = "radSeparator5";
            this.radSeparator5.Size = new System.Drawing.Size(727, 10);
            this.radSeparator5.TabIndex = 35;
            this.radSeparator5.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(3, 23);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(95, 18);
            this.radLabel2.TabIndex = 24;
            this.radLabel2.Text = "Tipo Inventario";
            // 
            // cbbTipoInventario
            // 
            this.cbbTipoInventario.BackColor = System.Drawing.Color.White;
            this.cbbTipoInventario.Correo = false;
            this.cbbTipoInventario.DisplayMember = "Descripcion";
            this.cbbTipoInventario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbTipoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoInventario.Limpiar = true;
            this.cbbTipoInventario.Location = new System.Drawing.Point(104, 17);
            this.cbbTipoInventario.Name = "cbbTipoInventario";
            this.cbbTipoInventario.Size = new System.Drawing.Size(168, 25);
            this.cbbTipoInventario.TabIndex = 29;
            this.cbbTipoInventario.ThemeName = "VisualStudio2012Light";
            this.cbbTipoInventario.Validar = true;
            this.cbbTipoInventario.ValueMember = "IdTipoProducto";
            // 
            // textPersonal1
            // 
            this.textPersonal1.Correo = false;
            this.textPersonal1.Enabled = false;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPersonal1.Limpiar = true;
            this.textPersonal1.Location = new System.Drawing.Point(387, 80);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.Size = new System.Drawing.Size(166, 24);
            this.textPersonal1.TabIndex = 26;
            this.textPersonal1.ThemeName = "VisualStudio2012Light";
            this.textPersonal1.Validar = true;
            // 
            // cbbPersonal3
            // 
            this.cbbPersonal3.BackColor = System.Drawing.Color.White;
            this.cbbPersonal3.Correo = false;
            this.cbbPersonal3.DisplayMember = "Descripcion";
            this.cbbPersonal3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbPersonal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPersonal3.Limpiar = true;
            this.cbbPersonal3.Location = new System.Drawing.Point(387, 110);
            this.cbbPersonal3.Name = "cbbPersonal3";
            this.cbbPersonal3.Size = new System.Drawing.Size(168, 25);
            this.cbbPersonal3.TabIndex = 32;
            this.cbbPersonal3.ThemeName = "VisualStudio2012Light";
            this.cbbPersonal3.Validar = true;
            this.cbbPersonal3.ValueMember = "IdTipoProducto";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(345, 117);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(36, 18);
            this.radLabel4.TabIndex = 19;
            this.radLabel4.Text = "Mina";
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 570);
            this.Controls.Add(this.pagePrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Entrada";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).EndInit();
            this.pagePrincipal.ResumeLayout(false);
            this.pageAlmacen.ResumeLayout(false);
            this.pageAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            this.pageInventario.ResumeLayout(false);
            this.pageInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pagePrincipal;
        private Telerik.WinControls.UI.RadPageViewPage pageAlmacen;
        private Telerik.WinControls.UI.RadSeparator radSeparator3;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Negocios.Componentes.cbbPersonal cbbCentro;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Negocios.Componentes.TextPersonal txtDescripcion;
        private Telerik.WinControls.UI.RadPageViewPage pageInventario;
        private Telerik.WinControls.UI.RadGridView dataInventario;
        private Telerik.WinControls.UI.RadSeparator radSeparator4;
        private Telerik.WinControls.UI.RadSeparator radSeparator5;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.cbbPersonal cbbTipoInventario;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Negocios.Componentes.TextPersonal txtCodigo;
        private Telerik.WinControls.UI.RadDateTimePicker txtFechaIngreso;
        private Telerik.WinControls.UI.RadLabel Fecha;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Negocios.Componentes.cbbPersonal cbbPersonal1;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Negocios.Componentes.cbbPersonal cbbPersonal2;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Negocios.Componentes.cbbPersonal cbbPersonal3;
    }
}
