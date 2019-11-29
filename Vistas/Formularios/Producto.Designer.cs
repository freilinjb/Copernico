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
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.pagePrincipal = new Telerik.WinControls.UI.RadPageView();
            this.pageProductio = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageCentro = new Telerik.WinControls.UI.RadPageViewPage();
            this.btSiguiente = new Telerik.WinControls.UI.RadButton();
            this.btRegresar = new Telerik.WinControls.UI.RadButton();
            this.txtRasonSocial = new Negocios.Componentes.TextPersonal();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtProductoLb = new Negocios.Componentes.TextPersonal();
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).BeginInit();
            this.pagePrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRasonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoLb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pagePrincipal
            // 
            this.pagePrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePrincipal.Controls.Add(this.pageProductio);
            this.pagePrincipal.Controls.Add(this.radPageViewPage3);
            this.pagePrincipal.Controls.Add(this.radPageViewPage4);
            this.pagePrincipal.Controls.Add(this.radPageViewPage1);
            this.pagePrincipal.Controls.Add(this.radPageViewPage2);
            this.pagePrincipal.Controls.Add(this.pageCentro);
            this.pagePrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pagePrincipal.Location = new System.Drawing.Point(12, 40);
            this.pagePrincipal.Name = "pagePrincipal";
            this.pagePrincipal.SelectedPage = this.pageProductio;
            this.pagePrincipal.Size = new System.Drawing.Size(1016, 537);
            this.pagePrincipal.TabIndex = 0;
            this.pagePrincipal.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pagePrincipal.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            // 
            // pageProductio
            // 
            this.pageProductio.ItemSize = new System.Drawing.SizeF(197F, 27F);
            this.pageProductio.Location = new System.Drawing.Point(5, 33);
            this.pageProductio.Name = "pageProductio";
            this.pageProductio.Size = new System.Drawing.Size(1006, 499);
            this.pageProductio.Text = "Informacion general";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(207F, 27F);
            this.radPageViewPage3.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(1006, 499);
            this.radPageViewPage3.Text = "Costos de produccion";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(118F, 27F);
            this.radPageViewPage4.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(1006, 527);
            this.radPageViewPage4.Text = "Precios";
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(177F, 27F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(1006, 527);
            this.radPageViewPage1.Text = "Stock por Centro";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(174F, 27F);
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 33);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(1006, 527);
            this.radPageViewPage2.Text = "Inventario Inicial";
            // 
            // pageCentro
            // 
            this.pageCentro.ItemSize = new System.Drawing.SizeF(141F, 27F);
            this.pageCentro.Location = new System.Drawing.Point(5, 33);
            this.pageCentro.Name = "pageCentro";
            this.pageCentro.Size = new System.Drawing.Size(1006, 527);
            this.pageCentro.Text = "Asignacion";
            // 
            // btSiguiente
            // 
            this.btSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btSiguiente.Location = new System.Drawing.Point(903, 583);
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
            this.btRegresar.Location = new System.Drawing.Point(772, 583);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(125, 40);
            this.btRegresar.TabIndex = 1;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.ThemeName = "VisualStudio2012Light";
            // 
            // txtRasonSocial
            // 
            this.txtRasonSocial.Correo = false;
            this.txtRasonSocial.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtRasonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRasonSocial.Limpiar = true;
            this.txtRasonSocial.Location = new System.Drawing.Point(80, 9);
            this.txtRasonSocial.Name = "txtRasonSocial";
            this.txtRasonSocial.Size = new System.Drawing.Size(142, 24);
            this.txtRasonSocial.TabIndex = 3;
            this.txtRasonSocial.ThemeName = "VisualStudio2012Light";
            this.txtRasonSocial.Validar = true;
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
            // txtProductoLb
            // 
            this.txtProductoLb.Correo = false;
            this.txtProductoLb.Enabled = false;
            this.txtProductoLb.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtProductoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoLb.Limpiar = true;
            this.txtProductoLb.Location = new System.Drawing.Point(228, 9);
            this.txtProductoLb.Name = "txtProductoLb";
            this.txtProductoLb.Size = new System.Drawing.Size(373, 24);
            this.txtProductoLb.TabIndex = 3;
            this.txtProductoLb.ThemeName = "VisualStudio2012Light";
            this.txtProductoLb.Validar = true;
            // 
            // Producto
            // 
            this.AcceptButton = this.btSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRegresar;
            this.ClientSize = new System.Drawing.Size(1040, 635);
            this.Controls.Add(this.txtProductoLb);
            this.Controls.Add(this.txtRasonSocial);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.pagePrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Producto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Producto";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.pagePrincipal)).EndInit();
            this.pagePrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRasonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductoLb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPageView pagePrincipal;
        private Telerik.WinControls.UI.RadPageViewPage pageProductio;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage pageCentro;
        private Telerik.WinControls.UI.RadButton btSiguiente;
        private Telerik.WinControls.UI.RadButton btRegresar;
        private Negocios.Componentes.TextPersonal txtRasonSocial;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.TextPersonal txtProductoLb;
    }
}
