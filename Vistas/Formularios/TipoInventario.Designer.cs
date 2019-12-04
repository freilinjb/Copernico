namespace Vistas.Formularios
{
    partial class TipoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoInventario));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.pageInventario = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtTipoInventario = new Negocios.Componentes.TextPersonal();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.dataInventario = new Telerik.WinControls.UI.RadGridView();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.pageAsignacion = new Telerik.WinControls.UI.RadPageView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lbEstatus = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageAsignacion)).BeginInit();
            this.pageAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pageInventario
            // 
            this.pageInventario.Controls.Add(this.txtTipoInventario);
            this.pageInventario.Controls.Add(this.txtCodigo);
            this.pageInventario.Controls.Add(this.dataInventario);
            this.pageInventario.Controls.Add(this.radSeparator1);
            this.pageInventario.Controls.Add(this.radSeparator2);
            this.pageInventario.Controls.Add(this.radLabel5);
            this.pageInventario.Controls.Add(this.radLabel13);
            this.pageInventario.ItemSize = new System.Drawing.SizeF(408F, 27F);
            this.pageInventario.Location = new System.Drawing.Point(5, 33);
            this.pageInventario.Name = "pageInventario";
            this.pageInventario.Size = new System.Drawing.Size(398, 342);
            this.pageInventario.Text = "Registro de Tipo de Inventario";
            // 
            // txtTipoInventario
            // 
            this.txtTipoInventario.Correo = false;
            this.txtTipoInventario.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtTipoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoInventario.Limpiar = false;
            this.txtTipoInventario.Location = new System.Drawing.Point(105, 44);
            this.txtTipoInventario.Name = "txtTipoInventario";
            this.txtTipoInventario.Size = new System.Drawing.Size(277, 24);
            this.txtTipoInventario.TabIndex = 37;
            this.txtTipoInventario.ThemeName = "VisualStudio2012Light";
            this.txtTipoInventario.Validar = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = false;
            this.txtCodigo.Location = new System.Drawing.Point(105, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(66, 24);
            this.txtCodigo.TabIndex = 37;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
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
            gridViewTextBoxColumn1.Width = 131;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Inventario";
            gridViewTextBoxColumn2.HeaderText = "Inventario";
            gridViewTextBoxColumn2.Name = "Inventario";
            gridViewTextBoxColumn2.Width = 249;
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
            this.dataInventario.Size = new System.Drawing.Size(378, 236);
            this.dataInventario.TabIndex = 36;
            this.dataInventario.ThemeName = "VisualStudio2012Light";
            this.dataInventario.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dataInventario_CellDoubleClick);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(4, 0);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(378, 10);
            this.radSeparator1.TabIndex = 35;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(4, 87);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(378, 10);
            this.radSeparator2.TabIndex = 35;
            this.radSeparator2.ThemeName = "VisualStudio2012Light";
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
            // radLabel13
            // 
            this.radLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel13.Location = new System.Drawing.Point(40, 17);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(49, 18);
            this.radLabel13.TabIndex = 19;
            this.radLabel13.Text = "Codigo";
            // 
            // pageAsignacion
            // 
            this.pageAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageAsignacion.Controls.Add(this.pageInventario);
            this.pageAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pageAsignacion.Location = new System.Drawing.Point(12, 12);
            this.pageAsignacion.Name = "pageAsignacion";
            this.pageAsignacion.SelectedPage = this.pageInventario;
            this.pageAsignacion.Size = new System.Drawing.Size(408, 380);
            this.pageAsignacion.TabIndex = 39;
            this.pageAsignacion.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageAsignacion.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageAsignacion.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageAsignacion.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lbEstatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 398);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(411, 26);
            this.radStatusStrip1.TabIndex = 40;
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
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 424);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.pageAsignacion);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 457);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 457);
            this.Name = "Inventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(419, 457);
            this.Text = "Tipo de inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Inventario_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pageInventario.ResumeLayout(false);
            this.pageInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageAsignacion)).EndInit();
            this.pageAsignacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPageView pageAsignacion;
        private Telerik.WinControls.UI.RadPageViewPage pageInventario;
        private Telerik.WinControls.UI.RadGridView dataInventario;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Negocios.Componentes.TextPersonal txtTipoInventario;
        private Negocios.Componentes.TextPersonal txtCodigo;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lbEstatus;
    }
}
