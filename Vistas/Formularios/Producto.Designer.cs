namespace Vistas.Formularios
{
    partial class Producto
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.pagePrincipal = new Telerik.WinControls.UI.RadPageView();
            this.pageProductio = new Telerik.WinControls.UI.RadPageViewPage();
            this.cbbUnidades = new Negocios.Componentes.cbbCheckPersonal();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.chItbis = new Telerik.WinControls.UI.RadToggleSwitch();
            this.cbbEstado = new Negocios.Componentes.cbbPersonal();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.cbbFamilia = new Negocios.Componentes.cbbPersonal();
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTipoProducto = new Negocios.Componentes.cbbPersonal();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNota = new Negocios.Componentes.TextPersonal();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageCentro = new Telerik.WinControls.UI.RadPageViewPage();
            this.btSiguiente = new Telerik.WinControls.UI.RadButton();
            this.btRegresar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtIdProducto = new Negocios.Componentes.TextPersonal();
            this.unidadTableAdapter = new Vistas.MatrizDataSetTableAdapters.UnidadTableAdapter();
            this.familiaTableAdapter = new Vistas.MatrizDataSetTableAdapters.FamiliaTableAdapter();
            this.tipoProductoTableAdapter = new Vistas.MatrizDataSetTableAdapters.TipoProductoTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).BeginInit();
            this.pagePrincipal.SuspendLayout();
            this.pageProductio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chItbis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePrincipal.Controls.Add(this.pageProductio);
            this.pagePrincipal.Controls.Add(this.radPageViewPage4);
            this.pagePrincipal.Controls.Add(this.radPageViewPage1);
            this.pagePrincipal.Controls.Add(this.radPageViewPage2);
            this.pagePrincipal.Controls.Add(this.pageCentro);
            this.pagePrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pagePrincipal.Location = new System.Drawing.Point(12, 40);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.SelectedPage = this.pageProductio;
            this.pagePrincipal.Size = new System.Drawing.Size(713, 362);
            this.pagePrincipal.TabIndex = 0;
            this.pagePrincipal.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // pageProductio
            // 
            this.pageProductio.Controls.Add(this.cbbUnidades);
            this.pageProductio.Controls.Add(this.chItbis);
            this.pageProductio.Controls.Add(this.cbbEstado);
            this.pageProductio.Controls.Add(this.radSeparator1);
            this.pageProductio.Controls.Add(this.cbbFamilia);
            this.pageProductio.Controls.Add(this.cbbTipoProducto);
            this.pageProductio.Controls.Add(this.txtNota);
            this.pageProductio.Controls.Add(this.txtNombre);
            this.pageProductio.Controls.Add(this.radLabel7);
            this.pageProductio.Controls.Add(this.radLabel6);
            this.pageProductio.Controls.Add(this.radLabel5);
            this.pageProductio.Controls.Add(this.radLabel3);
            this.pageProductio.Controls.Add(this.radLabel4);
            this.pageProductio.Controls.Add(this.radLabel1);
            this.pageProductio.ItemSize = new System.Drawing.SizeF(178F, 27F);
            this.pageProductio.Location = new System.Drawing.Point(5, 33);
            this.pageProductio.Name = "pageProductio";
            this.pageProductio.Size = new System.Drawing.Size(703, 324);
            this.pageProductio.Text = "Informacion general";
            // 
            // cbbUnidades
            // 
            this.cbbUnidades.DataSource = this.unidadBindingSource;
            this.cbbUnidades.DisplayMember = "Descripcion";
            this.cbbUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUnidades.Limpiar = true;
            this.cbbUnidades.Location = new System.Drawing.Point(120, 33);
            this.cbbUnidades.Name = "cbbUnidades";
            this.cbbUnidades.Size = new System.Drawing.Size(567, 24);
            this.cbbUnidades.TabIndex = 14;
            this.cbbUnidades.ThemeName = "VisualStudio2012Light";
            this.cbbUnidades.Validar = true;
            this.cbbUnidades.ValueMember = "IdUnidad";
            // 
            // unidadBindingSource
            // 
            this.unidadBindingSource.DataMember = "Unidad";
            this.unidadBindingSource.DataSource = this.matrizDataSet;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chItbis
            // 
            this.chItbis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chItbis.Location = new System.Drawing.Point(120, 125);
            this.chItbis.Name = "chItbis";
            this.chItbis.OffText = "No";
            this.chItbis.OnText = "Si";
            this.chItbis.Size = new System.Drawing.Size(142, 20);
            this.chItbis.TabIndex = 13;
            this.chItbis.ThemeName = "VisualStudio2012Light";
            this.chItbis.ThumbTickness = 15;
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.White;
            this.cbbEstado.Correo = false;
            this.cbbEstado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Disponible";
            this.cbbEstado.Items.Add(radListDataItem1);
            this.cbbEstado.Limpiar = false;
            this.cbbEstado.Location = new System.Drawing.Point(120, 154);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(142, 25);
            this.cbbEstado.TabIndex = 7;
            this.cbbEstado.ThemeName = "VisualStudio2012Light";
            this.cbbEstado.Validar = false;
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(4, 185);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(704, 10);
            this.radSeparator1.TabIndex = 6;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // cbbFamilia
            // 
            this.cbbFamilia.BackColor = System.Drawing.Color.White;
            this.cbbFamilia.Correo = false;
            this.cbbFamilia.DataSource = this.familiaBindingSource;
            this.cbbFamilia.DisplayMember = "Descripcion";
            this.cbbFamilia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFamilia.Limpiar = true;
            this.cbbFamilia.Location = new System.Drawing.Point(120, 94);
            this.cbbFamilia.Name = "cbbFamilia";
            this.cbbFamilia.Size = new System.Drawing.Size(142, 25);
            this.cbbFamilia.TabIndex = 4;
            this.cbbFamilia.ThemeName = "VisualStudio2012Light";
            this.cbbFamilia.Validar = false;
            this.cbbFamilia.ValueMember = "IdFamilia";
            // 
            // familiaBindingSource
            // 
            this.familiaBindingSource.DataMember = "Familia";
            this.familiaBindingSource.DataSource = this.matrizDataSet;
            // 
            // cbbTipoProducto
            // 
            this.cbbTipoProducto.BackColor = System.Drawing.Color.White;
            this.cbbTipoProducto.Correo = false;
            this.cbbTipoProducto.DataSource = this.tipoProductoBindingSource;
            this.cbbTipoProducto.DisplayMember = "Descripcion";
            this.cbbTipoProducto.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoProducto.Limpiar = true;
            this.cbbTipoProducto.Location = new System.Drawing.Point(120, 63);
            this.cbbTipoProducto.Name = "cbbTipoProducto";
            this.cbbTipoProducto.Size = new System.Drawing.Size(142, 25);
            this.cbbTipoProducto.TabIndex = 4;
            this.cbbTipoProducto.ThemeName = "VisualStudio2012Light";
            this.cbbTipoProducto.Validar = true;
            this.cbbTipoProducto.ValueMember = "IdTipoProducto";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "TipoProducto";
            this.tipoProductoBindingSource.DataSource = this.matrizDataSet;
            // 
            // txtNota
            // 
            this.txtNota.Correo = false;
            this.txtNota.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Limpiar = true;
            this.txtNota.Location = new System.Drawing.Point(268, 63);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.NullText = "Nota";
            // 
            // 
            // 
            this.txtNota.RootElement.StretchVertically = true;
            this.txtNota.Size = new System.Drawing.Size(419, 116);
            this.txtNota.TabIndex = 3;
            this.txtNota.ThemeName = "VisualStudio2012Light";
            this.txtNota.Validar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(120, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(567, 24);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(63, 100);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(50, 18);
            this.radLabel7.TabIndex = 2;
            this.radLabel7.Text = "Familia";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(3, 69);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(111, 19);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "Tipo de Producto";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(51, 39);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(63, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Unidades";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(60, 9);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(54, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Nombre";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(65, 161);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(49, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Estado";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(36, 125);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(78, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Incluye Itbis";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(99F, 27F);
            this.radPageViewPage4.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(703, 324);
            this.radPageViewPage4.Text = "Precios";
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(158F, 27F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(703, 324);
            this.radPageViewPage1.Text = "Stock por Centro";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(155F, 27F);
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(703, 226);
            this.radPageViewPage2.Text = "Inventario Inicial";
            // 
            // pageCentro
            // 
            this.pageCentro.ItemSize = new System.Drawing.SizeF(122F, 27F);
            this.pageCentro.Location = new System.Drawing.Point(5, 33);
            this.pageCentro.Name = "pageCentro";
            this.pageCentro.Size = new System.Drawing.Size(703, 226);
            this.pageCentro.Text = "Asignacion";
            // 
            // btSiguiente
            // 
            this.btSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btSiguiente.Location = new System.Drawing.Point(600, 408);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(125, 40);
            this.btSiguiente.TabIndex = 1;
            this.btSiguiente.Text = "Siguente";
            this.btSiguiente.ThemeName = "VisualStudio2012Light";
            // 
            // btRegresar
            // 
            this.btRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRegresar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btRegresar.Location = new System.Drawing.Point(469, 408);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(125, 40);
            this.btRegresar.TabIndex = 1;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(17, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(51, 21);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Codigo";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Correo = false;
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Limpiar = true;
            this.txtIdProducto.Location = new System.Drawing.Point(74, 9);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(118, 24);
            this.txtIdProducto.TabIndex = 3;
            this.txtIdProducto.ThemeName = "VisualStudio2012Light";
            this.txtIdProducto.Validar = true;
            // 
            // unidadTableAdapter
            // 
            this.unidadTableAdapter.ClearBeforeFill = true;
            // 
            // familiaTableAdapter
            // 
            this.familiaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Producto
            // 
            this.AcceptButton = this.btSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRegresar;
            this.ClientSize = new System.Drawing.Size(737, 460);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.pagePrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyPreview = true;
            this.Name = "Producto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Producto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).EndInit();
            this.pagePrincipal.ResumeLayout(false);
            this.pageProductio.ResumeLayout(false);
            this.pageProductio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chItbis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPageView pagePrincipal;
        private Telerik.WinControls.UI.RadPageViewPage pageProductio;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage pageCentro;
        private Telerik.WinControls.UI.RadButton btSiguiente;
        private Telerik.WinControls.UI.RadButton btRegresar;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.TextPersonal txtIdProducto;
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private MatrizDataSetTableAdapters.UnidadTableAdapter unidadTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Negocios.Componentes.cbbPersonal cbbFamilia;
        private Negocios.Componentes.cbbPersonal cbbTipoProducto;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Negocios.Componentes.cbbPersonal cbbEstado;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadToggleSwitch chItbis;
        private Negocios.Componentes.TextPersonal txtNota;
        private System.Windows.Forms.BindingSource familiaBindingSource;
        private MatrizDataSetTableAdapters.FamiliaTableAdapter familiaTableAdapter;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private MatrizDataSetTableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private Negocios.Componentes.cbbCheckPersonal cbbUnidades;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
