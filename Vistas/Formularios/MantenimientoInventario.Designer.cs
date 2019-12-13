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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoInventario));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.dataProducto = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.toolRegistro = new Telerik.WinControls.UI.RadLabelElement();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolRecargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btBusqueda = new Telerik.WinControls.UI.RadButton();
            this.cbbEstado = new Negocios.Componentes.cbbPersonal();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).BeginInit();
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // textPersonal1
            // 
            this.textPersonal1.Correo = false;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.Limpiar = false;
            this.textPersonal1.Location = new System.Drawing.Point(12, 60);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.NullText = "Informacion a buscar";
            this.textPersonal1.Size = new System.Drawing.Size(384, 24);
            this.textPersonal1.TabIndex = 38;
            this.textPersonal1.ThemeName = "VisualStudio2012Light";
            this.textPersonal1.Validar = false;
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
            this.toolMenu.Location = new System.Drawing.Point(0, 18);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolMenu.Size = new System.Drawing.Size(1091, 39);
            this.toolMenu.TabIndex = 37;
            this.toolMenu.Text = "toolStrip1";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(12, 86);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(1066, 10);
            this.radSeparator1.TabIndex = 35;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // dataProducto
            // 
            this.dataProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataProducto.Location = new System.Drawing.Point(12, 102);
            // 
            // 
            // 
            this.dataProducto.MasterTemplate.AllowAddNewRow = false;
            this.dataProducto.MasterTemplate.AllowColumnChooser = false;
            this.dataProducto.MasterTemplate.AllowColumnReorder = false;
            this.dataProducto.MasterTemplate.AllowDragToGroup = false;
            this.dataProducto.MasterTemplate.AllowRowResize = false;
            this.dataProducto.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dataProducto.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataProducto.MasterTemplate.EnableGrouping = false;
            this.dataProducto.MasterTemplate.EnableSorting = false;
            this.dataProducto.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataProducto.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataProducto.Name = "dataProducto";
            this.dataProducto.ReadOnly = true;
            this.dataProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataProducto.ShowGroupPanel = false;
            this.dataProducto.Size = new System.Drawing.Size(1067, 546);
            this.dataProducto.TabIndex = 32;
            this.dataProducto.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(1091, 18);
            this.radLabel1.TabIndex = 31;
            this.radLabel1.Text = "Mantenimiento de Inventario";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.toolRegistro});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 596);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1091, 23);
            this.radStatusStrip1.TabIndex = 29;
            this.radStatusStrip1.ThemeName = "VisualStudio2012Light";
            // 
            // toolRegistro
            // 
            this.toolRegistro.Name = "toolRegistro";
            this.radStatusStrip1.SetSpring(this.toolRegistro, false);
            this.toolRegistro.Text = "Nuevo Registro";
            this.toolRegistro.TextWrap = true;
            this.toolRegistro.UseCompatibleTextRendering = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btBusqueda.Location = new System.Drawing.Point(402, 60);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(110, 24);
            this.btBusqueda.TabIndex = 36;
            this.btBusqueda.Text = "Busqueda";
            this.btBusqueda.ThemeName = "VisualStudio2012Light";
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.White;
            this.cbbEstado.Correo = false;
            this.cbbEstado.DisplayMember = "Descripcion";
            this.cbbEstado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.Limpiar = true;
            this.cbbEstado.Location = new System.Drawing.Point(911, 63);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(168, 25);
            this.cbbEstado.TabIndex = 39;
            this.cbbEstado.ThemeName = "VisualStudio2012Light";
            this.cbbEstado.Validar = true;
            this.cbbEstado.ValueMember = "IdTipoProducto";
            // 
            // MantenimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 619);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.textPersonal1);
            this.Controls.Add(this.toolMenu);
            this.Controls.Add(this.btBusqueda);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.dataProducto);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyPreview = true;
            this.Name = "MantenimientoInventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).EndInit();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabelElement toolRegistro;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView dataProducto;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadButton btBusqueda;
        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolRecargar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolImprimir;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private Negocios.Componentes.cbbPersonal cbbEstado;
    }
}
