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
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radStatusStrip2 = new Telerik.WinControls.UI.RadStatusStrip();
            this.toolRegistro = new Telerik.WinControls.UI.RadLabelElement();
            this.dataInventario = new Telerik.WinControls.UI.RadGridView();
            this.panelInformacion = new Telerik.WinControls.UI.RadPanel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformacion)).BeginInit();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(11, 109);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(412, 10);
            this.radSeparator1.TabIndex = 46;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(11, 9);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 18);
            this.radLabel2.TabIndex = 41;
            this.radLabel2.Text = "Codigo";
            // 
            // radStatusStrip2
            // 
            this.radStatusStrip2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.toolRegistro});
            this.radStatusStrip2.Location = new System.Drawing.Point(0, 398);
            this.radStatusStrip2.Name = "radStatusStrip2";
            this.radStatusStrip2.Size = new System.Drawing.Size(411, 26);
            this.radStatusStrip2.TabIndex = 45;
            this.radStatusStrip2.ThemeName = "VisualStudio2012Light";
            // 
            // toolRegistro
            // 
            this.toolRegistro.Name = "toolRegistro";
            this.radStatusStrip2.SetSpring(this.toolRegistro, false);
            this.toolRegistro.Text = "Nuevo Registro";
            this.toolRegistro.TextWrap = true;
            this.toolRegistro.UseCompatibleTextRendering = false;
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
            this.dataInventario.Location = new System.Drawing.Point(12, 125);
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
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "IdTipoInventario";
            gridViewTextBoxColumn1.Width = 78;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Inventario";
            gridViewTextBoxColumn2.HeaderText = "Inventario";
            gridViewTextBoxColumn2.Name = "Inventario";
            gridViewTextBoxColumn2.Width = 311;
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
            this.dataInventario.Size = new System.Drawing.Size(387, 261);
            this.dataInventario.TabIndex = 43;
            this.dataInventario.ThemeName = "VisualStudio2012Light";
            this.dataInventario.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dataInventario_CellDoubleClick);
            // 
            // panelInformacion
            // 
            this.panelInformacion.Controls.Add(this.radLabel3);
            this.panelInformacion.Controls.Add(this.txtNombre);
            this.panelInformacion.Location = new System.Drawing.Point(12, 33);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(387, 70);
            this.panelInformacion.TabIndex = 44;
            this.panelInformacion.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 9);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(54, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(72, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 24);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = false;
            this.txtCodigo.Location = new System.Drawing.Point(71, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 24);
            this.txtCodigo.TabIndex = 42;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TipoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 424);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radStatusStrip2);
            this.Controls.Add(this.dataInventario);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 457);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 457);
            this.Name = "TipoInventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(419, 457);
            this.Text = "Tipo de inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Inventario_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformacion)).EndInit();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip2;
        private Telerik.WinControls.UI.RadLabelElement toolRegistro;
        private Telerik.WinControls.UI.RadGridView dataInventario;
        private Telerik.WinControls.UI.RadPanel panelInformacion;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Negocios.Componentes.TextPersonal txtCodigo;
    }
}
