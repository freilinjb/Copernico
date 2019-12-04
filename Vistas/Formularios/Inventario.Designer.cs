namespace Vistas.Formularios
{
    partial class Inventario
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.cbbAlmacen = new Negocios.Componentes.cbbPersonal();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.cbbTipoInventario = new Negocios.Componentes.cbbPersonal();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.pageAsignacion = new Telerik.WinControls.UI.RadPageView();
            this.pageInventario = new Telerik.WinControls.UI.RadPageViewPage();
            this.pagePrecio = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtPrecioVenta = new Negocios.Componentes.TextPersonal();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator4 = new Telerik.WinControls.UI.RadSeparator();
            this.cbbCentro = new Negocios.Componentes.cbbPersonal();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.dataInventario = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageAsignacion)).BeginInit();
            this.pageAsignacion.SuspendLayout();
            this.pageInventario.SuspendLayout();
            this.pagePrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(4, 0);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(333, 10);
            this.radSeparator1.TabIndex = 35;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel13
            // 
            this.radLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel13.Location = new System.Drawing.Point(40, 17);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(59, 18);
            this.radLabel13.TabIndex = 19;
            this.radLabel13.Text = "Almacen";
            // 
            // cbbAlmacen
            // 
            this.cbbAlmacen.BackColor = System.Drawing.Color.White;
            this.cbbAlmacen.Correo = false;
            this.cbbAlmacen.DisplayMember = "Descripcion";
            this.cbbAlmacen.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAlmacen.Limpiar = true;
            this.cbbAlmacen.Location = new System.Drawing.Point(105, 10);
            this.cbbAlmacen.Name = "cbbAlmacen";
            this.cbbAlmacen.Size = new System.Drawing.Size(168, 25);
            this.cbbAlmacen.TabIndex = 32;
            this.cbbAlmacen.ThemeName = "VisualStudio2012Light";
            this.cbbAlmacen.Validar = true;
            this.cbbAlmacen.ValueMember = "IdTipoProducto";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(4, 47);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(95, 18);
            this.radLabel5.TabIndex = 24;
            this.radLabel5.Text = "Tipo Inventario";
            // 
            // cbbTipoInventario
            // 
            this.cbbTipoInventario.BackColor = System.Drawing.Color.White;
            this.cbbTipoInventario.Correo = false;
            this.cbbTipoInventario.DisplayMember = "Descripcion";
            this.cbbTipoInventario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbTipoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoInventario.Limpiar = true;
            this.cbbTipoInventario.Location = new System.Drawing.Point(105, 41);
            this.cbbTipoInventario.Name = "cbbTipoInventario";
            this.cbbTipoInventario.Size = new System.Drawing.Size(168, 25);
            this.cbbTipoInventario.TabIndex = 29;
            this.cbbTipoInventario.ThemeName = "VisualStudio2012Light";
            this.cbbTipoInventario.Validar = true;
            this.cbbTipoInventario.ValueMember = "IdTipoProducto";
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(4, 87);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(333, 10);
            this.radSeparator2.TabIndex = 35;
            this.radSeparator2.ThemeName = "VisualStudio2012Light";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pageAsignacion
            // 
            this.pageAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageAsignacion.Controls.Add(this.pageInventario);
            this.pageAsignacion.Controls.Add(this.pagePrecio);
            this.pageAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pageAsignacion.Location = new System.Drawing.Point(12, 12);
            this.pageAsignacion.Name = "pageAsignacion";
            this.pageAsignacion.SelectedPage = this.pagePrecio;
            this.pageAsignacion.Size = new System.Drawing.Size(356, 380);
            this.pageAsignacion.TabIndex = 39;
            this.pageAsignacion.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageAsignacion.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageAsignacion.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageAsignacion.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // pageInventario
            // 
            this.pageInventario.Controls.Add(this.dataInventario);
            this.pageInventario.Controls.Add(this.radSeparator1);
            this.pageInventario.Controls.Add(this.radSeparator2);
            this.pageInventario.Controls.Add(this.cbbTipoInventario);
            this.pageInventario.Controls.Add(this.radLabel5);
            this.pageInventario.Controls.Add(this.radLabel13);
            this.pageInventario.Controls.Add(this.cbbAlmacen);
            this.pageInventario.ItemSize = new System.Drawing.SizeF(248F, 27F);
            this.pageInventario.Location = new System.Drawing.Point(5, 33);
            this.pageInventario.Name = "pageInventario";
            this.pageInventario.Size = new System.Drawing.Size(346, 342);
            this.pageInventario.Text = "Registro de Tipo de Inventario";
            // 
            // pagePrecio
            // 
            this.pagePrecio.Controls.Add(this.txtPrecioVenta);
            this.pagePrecio.Controls.Add(this.radLabel10);
            this.pagePrecio.Controls.Add(this.radSeparator4);
            this.pagePrecio.Controls.Add(this.cbbCentro);
            this.pagePrecio.Controls.Add(this.radLabel8);
            this.pagePrecio.ItemSize = new System.Drawing.SizeF(108F, 27F);
            this.pagePrecio.Location = new System.Drawing.Point(5, 33);
            this.pagePrecio.Name = "pagePrecio";
            this.pagePrecio.Size = new System.Drawing.Size(346, 342);
            this.pagePrecio.Text = "Precios";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Correo = false;
            this.txtPrecioVenta.estados = Negocios.Componentes.TextPersonal.Estados.Numeros;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Limpiar = true;
            this.txtPrecioVenta.Location = new System.Drawing.Point(110, 48);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(65, 24);
            this.txtPrecioVenta.TabIndex = 3;
            this.txtPrecioVenta.ThemeName = "VisualStudio2012Light";
            this.txtPrecioVenta.Validar = false;
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel10.Location = new System.Drawing.Point(4, 51);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(100, 21);
            this.radLabel10.TabIndex = 2;
            this.radLabel10.Text = "Precio de venta";
            // 
            // radSeparator4
            // 
            this.radSeparator4.Location = new System.Drawing.Point(4, 35);
            this.radSeparator4.Name = "radSeparator4";
            this.radSeparator4.Size = new System.Drawing.Size(700, 10);
            this.radSeparator4.TabIndex = 3;
            this.radSeparator4.ThemeName = "VisualStudio2012Light";
            // 
            // cbbCentro
            // 
            this.cbbCentro.BackColor = System.Drawing.Color.White;
            this.cbbCentro.Correo = false;
            this.cbbCentro.DisplayMember = "Nombre";
            this.cbbCentro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCentro.Limpiar = false;
            this.cbbCentro.Location = new System.Drawing.Point(57, 3);
            this.cbbCentro.Name = "cbbCentro";
            this.cbbCentro.Size = new System.Drawing.Size(121, 25);
            this.cbbCentro.TabIndex = 0;
            this.cbbCentro.ThemeName = "VisualStudio2012Light";
            this.cbbCentro.Validar = false;
            this.cbbCentro.ValueMember = "IdCentro";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel8.Location = new System.Drawing.Point(0, 7);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(48, 21);
            this.radLabel8.TabIndex = 2;
            this.radLabel8.Text = "Centro";
            // 
            // dataInventario
            // 
            this.dataInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataInventario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataInventario.Location = new System.Drawing.Point(4, 103);
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
            gridViewTextBoxColumn1.FieldName = "IdTipoInventario";
            gridViewTextBoxColumn1.HeaderText = "IdTipoInventario";
            gridViewTextBoxColumn1.Name = "IdTipoInventario";
            gridViewTextBoxColumn1.Width = 118;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Inventario";
            gridViewTextBoxColumn2.HeaderText = "Inventario";
            gridViewTextBoxColumn2.Name = "Inventario";
            gridViewTextBoxColumn2.Width = 223;
            this.dataInventario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dataInventario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataInventario.MasterTemplate.EnableGrouping = false;
            this.dataInventario.MasterTemplate.EnableSorting = false;
            this.dataInventario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataInventario.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.ReadOnly = true;
            this.dataInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataInventario.ShowGroupPanel = false;
            this.dataInventario.Size = new System.Drawing.Size(339, 236);
            this.dataInventario.TabIndex = 36;
            this.dataInventario.ThemeName = "VisualStudio2012Light";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 404);
            this.Controls.Add(this.pageAsignacion);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 381);
            this.Name = "Inventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Registro de tipo de inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Inventario_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageAsignacion)).EndInit();
            this.pageAsignacion.ResumeLayout(false);
            this.pageInventario.ResumeLayout(false);
            this.pageInventario.PerformLayout();
            this.pagePrecio.ResumeLayout(false);
            this.pagePrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Negocios.Componentes.cbbPersonal cbbAlmacen;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Negocios.Componentes.cbbPersonal cbbTipoInventario;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPageView pageAsignacion;
        private Telerik.WinControls.UI.RadPageViewPage pageInventario;
        private Telerik.WinControls.UI.RadPageViewPage pagePrecio;
        private Negocios.Componentes.TextPersonal txtPrecioVenta;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadSeparator radSeparator4;
        private Negocios.Componentes.cbbPersonal cbbCentro;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadGridView dataInventario;
    }
}
