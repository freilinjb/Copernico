namespace Vistas.Formularios
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.horizontalToolStrip = new Telerik.WinControls.UI.RadMenuItem();
            this.vertocalTooltrip = new Telerik.WinControls.UI.RadMenuItem();
            this.cascadaToolTrip = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolButton = new System.Windows.Forms.ToolStripButton();
            this.cbbPersonal1 = new Negocios.Componentes.cbbPersonal();
            this.menuProducto = new Telerik.WinControls.UI.RadMenuItem();
            this.menuExploradorProducto = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Cliente";
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5,
            this.radMenuItem6});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Ventana";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Lista ->";
            this.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem4.UseCompatibleTextRendering = false;
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Ventana activa";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.horizontalToolStrip,
            this.vertocalTooltrip,
            this.cascadaToolTrip});
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Ordenar ->";
            // 
            // horizontalToolStrip
            // 
            this.horizontalToolStrip.Name = "horizontalToolStrip";
            this.horizontalToolStrip.Text = "Horizontal";
            this.horizontalToolStrip.Click += new System.EventHandler(this.horizontalToolStrip_Click);
            // 
            // vertocalTooltrip
            // 
            this.vertocalTooltrip.Name = "vertocalTooltrip";
            this.vertocalTooltrip.Text = "Vertical";
            this.vertocalTooltrip.Click += new System.EventHandler(this.vertocalTooltrip_Click);
            // 
            // cascadaToolTrip
            // 
            this.cascadaToolTrip.Name = "cascadaToolTrip";
            this.cascadaToolTrip.Text = "Cascada";
            this.cascadaToolTrip.Click += new System.EventHandler(this.cascadaToolTrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolButton
            // 
            this.toolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButton.Image = ((System.Drawing.Image)(resources.GetObject("toolButton.Image")));
            this.toolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButton.Name = "toolButton";
            this.toolButton.Size = new System.Drawing.Size(23, 22);
            this.toolButton.Text = "toolStripButton2";
            this.toolButton.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // cbbPersonal1
            // 
            this.cbbPersonal1.BackColor = System.Drawing.Color.White;
            this.cbbPersonal1.Correo = false;
            this.cbbPersonal1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Habilidado";
            radListDataItem2.Text = "Desabilitado";
            this.cbbPersonal1.Items.Add(radListDataItem1);
            this.cbbPersonal1.Items.Add(radListDataItem2);
            this.cbbPersonal1.Limpiar = false;
            this.cbbPersonal1.Location = new System.Drawing.Point(271, 135);
            this.cbbPersonal1.Name = "cbbPersonal1";
            this.cbbPersonal1.Size = new System.Drawing.Size(121, 25);
            this.cbbPersonal1.TabIndex = 8;
            this.cbbPersonal1.ThemeName = "VisualStudio2012Light";
            this.cbbPersonal1.Validar = false;
            this.cbbPersonal1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbbPersonal1_SelectedIndexChanged);
            // 
            // menuProducto
            // 
            this.menuProducto.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuExploradorProducto,
            this.radMenuSeparatorItem1,
            this.radMenuItem8,
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuSeparatorItem2,
            this.radMenuItem11,
            this.radMenuSeparatorItem3,
            this.radMenuItem7});
            this.menuProducto.Name = "menuProducto";
            this.menuProducto.Text = "Explorador de Rubros";
            // 
            // menuExploradorProducto
            // 
            this.menuExploradorProducto.Name = "menuExploradorProducto";
            this.menuExploradorProducto.Text = "Explorador de Productos";
            this.menuExploradorProducto.Click += new System.EventHandler(this.menuExploradorProducto_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Actualizaciones Precios y Costos";
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Importar o actualizar productos desde Excel";
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Exportar Productos a Excel";
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Reportes";
            this.radMenuItem11.Click += new System.EventHandler(this.radMenuItem11_Click);
            // 
            // radMenuSeparatorItem3
            // 
            this.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Explorador de Rubro";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            // 
            // radMenu1
            // 
            this.radMenu1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem3,
            this.menuProducto});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(800, 23);
            this.radMenu1.TabIndex = 5;
            this.radMenu1.ThemeName = "VisualStudio2012Light";
            this.Controls.Add(this.cbbPersonal1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.radMenu1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private System.Windows.Forms.ToolStripButton toolButton;
        private Negocios.Componentes.cbbPersonal cbbPersonal1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem horizontalToolStrip;
        private Telerik.WinControls.UI.RadMenuItem vertocalTooltrip;
        private Telerik.WinControls.UI.RadMenuItem cascadaToolTrip;
        private Telerik.WinControls.UI.RadMenuItem menuProducto;
        private Telerik.WinControls.UI.RadMenuItem menuExploradorProducto;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem3;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
    }
}