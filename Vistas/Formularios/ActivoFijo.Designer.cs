namespace Vistas.Formularios
{
    partial class ActivoFijo
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pagePrincipal = new Telerik.WinControls.UI.RadPageView();
            this.pageActivoFijo = new Telerik.WinControls.UI.RadPageViewPage();
            this.cbbSubGrupo = new Negocios.Componentes.cbbPersonal();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.cbbGrupo = new Negocios.Componentes.cbbPersonal();
            this.grupoActivoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.pageInventario = new Telerik.WinControls.UI.RadPageViewPage();
            this.radSeparator4 = new Telerik.WinControls.UI.RadSeparator();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dataActivoFijo = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grupoActivoFijoTableAdapter = new Vistas.MatrizDataSetTableAdapters.GrupoActivoFijoTableAdapter();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lbEstatus = new Telerik.WinControls.UI.RadLabelElement();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).BeginInit();
            this.pagePrincipal.SuspendLayout();
            this.pageActivoFijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSubGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoActivoFijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.pageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivoFijo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Controls.Add(this.pageActivoFijo);
            this.pagePrincipal.Controls.Add(this.pageInventario);
            this.pagePrincipal.DefaultPage = this.pageActivoFijo;
            this.pagePrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pagePrincipal.Location = new System.Drawing.Point(12, 42);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.SelectedPage = this.pageActivoFijo;
            this.pagePrincipal.Size = new System.Drawing.Size(564, 187);
            this.pagePrincipal.TabIndex = 41;
            this.pagePrincipal.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // pageActivoFijo
            // 
            this.pageActivoFijo.Controls.Add(this.cbbSubGrupo);
            this.pageActivoFijo.Controls.Add(this.radLabel5);
            this.pageActivoFijo.Controls.Add(this.textPersonal1);
            this.pageActivoFijo.Controls.Add(this.txtNombre);
            this.pageActivoFijo.Controls.Add(this.cbbGrupo);
            this.pageActivoFijo.Controls.Add(this.radSeparator2);
            this.pageActivoFijo.Controls.Add(this.radLabel4);
            this.pageActivoFijo.Controls.Add(this.radSeparator1);
            this.pageActivoFijo.Controls.Add(this.radLabel1);
            this.pageActivoFijo.Controls.Add(this.radLabel3);
            this.pageActivoFijo.ItemSize = new System.Drawing.SizeF(251F, 27F);
            this.pageActivoFijo.Location = new System.Drawing.Point(5, 33);
            this.pageActivoFijo.Name = "pageActivoFijo";
            this.pageActivoFijo.Size = new System.Drawing.Size(554, 149);
            this.pageActivoFijo.Text = "Informacion general";
            // 
            // cbbSubGrupo
            // 
            this.cbbSubGrupo.BackColor = System.Drawing.Color.White;
            this.cbbSubGrupo.Correo = false;
            this.cbbSubGrupo.DisplayMember = "Descripcion";
            this.cbbSubGrupo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubGrupo.Limpiar = true;
            this.cbbSubGrupo.Location = new System.Drawing.Point(79, 73);
            this.cbbSubGrupo.Name = "cbbSubGrupo";
            this.cbbSubGrupo.NullText = "Tipo de Identificacion";
            this.cbbSubGrupo.Size = new System.Drawing.Size(222, 23);
            this.cbbSubGrupo.TabIndex = 41;
            this.cbbSubGrupo.ThemeName = "VisualStudio2012Light";
            this.cbbSubGrupo.Validar = true;
            this.cbbSubGrupo.ValueMember = "IdGrupoActivoFijo";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radLabel5.Location = new System.Drawing.Point(3, 19);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(70, 19);
            this.radLabel5.TabIndex = 45;
            this.radLabel5.Text = "Descripción";
            this.radLabel5.ThemeName = "VisualStudio2012Light";
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(79, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 24);
            this.txtNombre.TabIndex = 42;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.BackColor = System.Drawing.Color.White;
            this.cbbGrupo.Correo = false;
            this.cbbGrupo.DataSource = this.grupoActivoFijoBindingSource;
            this.cbbGrupo.DisplayMember = "Descripcion";
            this.cbbGrupo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGrupo.Limpiar = true;
            this.cbbGrupo.Location = new System.Drawing.Point(79, 44);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.NullText = "Tipo de Identificacion";
            this.cbbGrupo.Size = new System.Drawing.Size(222, 23);
            this.cbbGrupo.TabIndex = 40;
            this.cbbGrupo.ThemeName = "VisualStudio2012Light";
            this.cbbGrupo.Validar = true;
            this.cbbGrupo.ValueMember = "IdGrupoActivoFijo";
            this.cbbGrupo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbbGrupo_SelectedIndexChanged);
            // 
            // grupoActivoFijoBindingSource
            // 
            this.grupoActivoFijoBindingSource.DataMember = "GrupoActivoFijo";
            this.grupoActivoFijoBindingSource.DataSource = this.matrizDataSet;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radSeparator2
            // 
            this.radSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator2.Location = new System.Drawing.Point(13, 142);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(538, 10);
            this.radSeparator2.TabIndex = 36;
            this.radSeparator2.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radLabel4.Location = new System.Drawing.Point(8, 77);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 19);
            this.radLabel4.TabIndex = 42;
            this.radLabel4.Text = "SubGrupo";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(8, 3);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(566, 10);
            this.radSeparator1.TabIndex = 35;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 102);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 18);
            this.radLabel1.TabIndex = 22;
            this.radLabel1.Text = "Estado";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radLabel3.Location = new System.Drawing.Point(8, 48);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 19);
            this.radLabel3.TabIndex = 43;
            this.radLabel3.Text = "Grupo";
            // 
            // pageInventario
            // 
            this.pageInventario.Controls.Add(this.radSeparator4);
            this.pageInventario.ItemSize = new System.Drawing.SizeF(312F, 27F);
            this.pageInventario.Location = new System.Drawing.Point(5, 33);
            this.pageInventario.Name = "pageInventario";
            this.pageInventario.Size = new System.Drawing.Size(559, 261);
            this.pageInventario.Text = "Registro de Tipo de Inventario";
            // 
            // radSeparator4
            // 
            this.radSeparator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator4.Location = new System.Drawing.Point(4, 0);
            this.radSeparator4.Name = "radSeparator4";
            this.radSeparator4.Size = new System.Drawing.Size(375, 10);
            this.radSeparator4.TabIndex = 35;
            this.radSeparator4.ThemeName = "VisualStudio2012Light";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = false;
            this.txtCodigo.Location = new System.Drawing.Point(88, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 24);
            this.txtCodigo.TabIndex = 44;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(12, 15);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 21);
            this.radLabel2.TabIndex = 43;
            this.radLabel2.Text = "Activo Fijo";
            // 
            // dataActivoFijo
            // 
            this.dataActivoFijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataActivoFijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataActivoFijo.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataActivoFijo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataActivoFijo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataActivoFijo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataActivoFijo.Location = new System.Drawing.Point(12, 244);
            // 
            // 
            // 
            this.dataActivoFijo.MasterTemplate.AllowAddNewRow = false;
            this.dataActivoFijo.MasterTemplate.AllowColumnChooser = false;
            this.dataActivoFijo.MasterTemplate.AllowColumnReorder = false;
            this.dataActivoFijo.MasterTemplate.AllowDragToGroup = false;
            this.dataActivoFijo.MasterTemplate.AllowRowResize = false;
            this.dataActivoFijo.MasterTemplate.AllowSearchRow = true;
            this.dataActivoFijo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "IdActivoFijo";
            gridViewTextBoxColumn16.HeaderText = "Codigo";
            gridViewTextBoxColumn16.Name = "IdActivoFijo";
            gridViewTextBoxColumn16.Width = 60;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "Nombre";
            gridViewTextBoxColumn17.HeaderText = "Nombre";
            gridViewTextBoxColumn17.Name = "Nombre";
            gridViewTextBoxColumn17.Width = 139;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "Grupo";
            gridViewTextBoxColumn18.HeaderText = "Grupo";
            gridViewTextBoxColumn18.Name = "Grupo";
            gridViewTextBoxColumn18.Width = 161;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "SubGrupo";
            gridViewTextBoxColumn19.HeaderText = "SubGrupo";
            gridViewTextBoxColumn19.Name = "SubGrupo";
            gridViewTextBoxColumn19.Width = 145;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "Estado";
            gridViewTextBoxColumn20.HeaderText = "Estado";
            gridViewTextBoxColumn20.Name = "Estado";
            gridViewTextBoxColumn20.Width = 64;
            this.dataActivoFijo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20});
            this.dataActivoFijo.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataActivoFijo.MasterTemplate.EnableSorting = false;
            this.dataActivoFijo.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataActivoFijo.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.dataActivoFijo.Name = "dataActivoFijo";
            this.dataActivoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataActivoFijo.Size = new System.Drawing.Size(564, 294);
            this.dataActivoFijo.TabIndex = 65;
            this.dataActivoFijo.ThemeName = "VisualStudio2012Light";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grupoActivoFijoTableAdapter
            // 
            this.grupoActivoFijoTableAdapter.ClearBeforeFill = true;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lbEstatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 544);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(588, 26);
            this.radStatusStrip1.TabIndex = 66;
            this.radStatusStrip1.ThemeName = "VisualStudio2012Light";
            // 
            // lbEstatus
            // 
            this.lbEstatus.Name = "lbEstatus";
            this.radStatusStrip1.SetSpring(this.lbEstatus, false);
            this.lbEstatus.Text = "Nuevo almacen";
            this.lbEstatus.TextWrap = true;
            this.lbEstatus.UseCompatibleTextRendering = false;
            // 
            // textPersonal1
            // 
            this.textPersonal1.Correo = false;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPersonal1.Limpiar = true;
            this.textPersonal1.Location = new System.Drawing.Point(79, 102);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.Size = new System.Drawing.Size(222, 24);
            this.textPersonal1.TabIndex = 42;
            this.textPersonal1.ThemeName = "VisualStudio2012Light";
            this.textPersonal1.Validar = true;
            // 
            // ActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 570);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.dataActivoFijo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.pagePrincipal);
            this.KeyPreview = true;
            this.Name = "ActivoFijo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ActivoFijo";
            this.Load += new System.EventHandler(this.ActivoFijo_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ActivoFijo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).EndInit();
            this.pagePrincipal.ResumeLayout(false);
            this.pageActivoFijo.ResumeLayout(false);
            this.pageActivoFijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSubGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoActivoFijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.pageInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivoFijo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pagePrincipal;
        private Telerik.WinControls.UI.RadPageViewPage pageActivoFijo;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage pageInventario;
        private Telerik.WinControls.UI.RadSeparator radSeparator4;
        private Negocios.Componentes.cbbPersonal cbbSubGrupo;
        private Negocios.Componentes.cbbPersonal cbbGrupo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Negocios.Componentes.TextPersonal txtCodigo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadGridView dataActivoFijo;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource grupoActivoFijoBindingSource;
        private MatrizDataSetTableAdapters.GrupoActivoFijoTableAdapter grupoActivoFijoTableAdapter;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lbEstatus;
        private Negocios.Componentes.TextPersonal textPersonal1;
    }
}
