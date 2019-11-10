namespace Vistas.Formularios
{
    partial class Orden
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.textPersonal2 = new Negocios.Componentes.TextPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cbbCentro = new Negocios.Componentes.cbbPersonal();
            this.txttipoOrden = new Negocios.Componentes.TextPersonal();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dataContacto = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttipoOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacto.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.dataContacto);
            this.radGroupBox1.Controls.Add(this.textPersonal2);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.textPersonal1);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.cbbCentro);
            this.radGroupBox1.Controls.Add(this.txttipoOrden);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.HeaderText = "Datos de las Orden";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 22);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(952, 425);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Datos de las Orden";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // textPersonal2
            // 
            this.textPersonal2.Correo = false;
            this.textPersonal2.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal2.Limpiar = true;
            this.textPersonal2.Location = new System.Drawing.Point(80, 92);
            this.textPersonal2.Name = "textPersonal2";
            this.textPersonal2.Size = new System.Drawing.Size(142, 24);
            this.textPersonal2.TabIndex = 3;
            this.textPersonal2.ThemeName = "VisualStudio2012Light";
            this.textPersonal2.Validar = true;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(25, 98);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(47, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Usuario ";
            // 
            // textPersonal1
            // 
            this.textPersonal1.Correo = false;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.Limpiar = true;
            this.textPersonal1.Location = new System.Drawing.Point(80, 31);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.Size = new System.Drawing.Size(142, 24);
            this.textPersonal1.TabIndex = 3;
            this.textPersonal1.ThemeName = "VisualStudio2012Light";
            this.textPersonal1.Validar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(25, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Orden #";
            // 
            // cbbCentro
            // 
            this.cbbCentro.BackColor = System.Drawing.Color.White;
            this.cbbCentro.Correo = false;
            this.cbbCentro.DisplayMember = "Descripcion";
            this.cbbCentro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCentro.Limpiar = true;
            this.cbbCentro.Location = new System.Drawing.Point(80, 122);
            this.cbbCentro.Name = "cbbCentro";
            this.cbbCentro.NullText = "Tipo de Identificacion";
            this.cbbCentro.Size = new System.Drawing.Size(142, 25);
            this.cbbCentro.TabIndex = 9;
            this.cbbCentro.ThemeName = "VisualStudio2012Light";
            this.cbbCentro.Validar = true;
            this.cbbCentro.ValueMember = "IdTipoIdentificacion";
            // 
            // txttipoOrden
            // 
            this.txttipoOrden.Correo = false;
            this.txttipoOrden.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txttipoOrden.Limpiar = true;
            this.txttipoOrden.Location = new System.Drawing.Point(80, 61);
            this.txttipoOrden.Name = "txttipoOrden";
            this.txttipoOrden.Size = new System.Drawing.Size(142, 24);
            this.txttipoOrden.TabIndex = 1;
            this.txttipoOrden.ThemeName = "VisualStudio2012Light";
            this.txttipoOrden.Validar = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(32, 129);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(40, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Centro";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(11, 67);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Tipo Orden";
            // 
            // dataContacto
            // 
            this.dataContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataContacto.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataContacto.EnableHotTracking = false;
            this.dataContacto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataContacto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataContacto.Location = new System.Drawing.Point(11, 234);
            // 
            // 
            // 
            this.dataContacto.MasterTemplate.AllowAddNewRow = false;
            this.dataContacto.MasterTemplate.AllowColumnReorder = false;
            this.dataContacto.MasterTemplate.AllowDragToGroup = false;
            this.dataContacto.MasterTemplate.AllowEditRow = false;
            this.dataContacto.MasterTemplate.AllowRowResize = false;
            this.dataContacto.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Producto";
            gridViewTextBoxColumn1.Name = "idProducto";
            gridViewTextBoxColumn1.Width = 102;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Descripcion ";
            gridViewTextBoxColumn2.Name = "Descripcion ";
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn2.Width = 387;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Unidad";
            gridViewTextBoxColumn3.Name = "Unidad";
            gridViewTextBoxColumn3.Width = 111;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Cantidad";
            gridViewTextBoxColumn4.Name = "Cantidad";
            gridViewTextBoxColumn4.Width = 102;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Precio";
            gridViewTextBoxColumn5.Name = "Precio";
            gridViewTextBoxColumn5.Width = 89;
            this.dataContacto.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dataContacto.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataContacto.MasterTemplate.ShowGroupedColumns = true;
            this.dataContacto.MasterTemplate.ShowRowHeaderColumn = false;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Descripcion ";
            this.dataContacto.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dataContacto.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataContacto.Name = "dataContacto";
            this.dataContacto.ReadOnly = true;
            this.dataContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataContacto.ShowGroupPanel = false;
            this.dataContacto.Size = new System.Drawing.Size(786, 120);
            this.dataContacto.TabIndex = 10;
            this.dataContacto.ThemeName = "VisualStudio2012Light";
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 441);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Orden";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Orden";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttipoOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacto.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Negocios.Componentes.cbbPersonal cbbCentro;
        private Negocios.Componentes.TextPersonal txttipoOrden;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.TextPersonal textPersonal2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView dataContacto;
    }
}