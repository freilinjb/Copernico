namespace Negocios.Componentes
{
    partial class MultiCbbPersonal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControl.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // MultiCbbPersonal
            // 
            // 
            // 
            // 
            this.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.EditorControl.Name = "";
            this.EditorControl.ReadOnly = true;
            this.EditorControl.ShowGroupPanel = false;
            this.EditorControl.TabIndex = 0;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
