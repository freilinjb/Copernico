namespace Vistas.Formularios
{
    partial class Ordenes
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtNota = new Negocios.Componentes.TextPersonal();
            this.dataProducto = new Telerik.WinControls.UI.RadGridView();
            this.txtTotal = new Negocios.Componentes.TextPersonal();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtItbis = new Negocios.Componentes.TextPersonal();
            this.cbbCliente = new Negocios.Componentes.cbbPersonal();
            this.txtSubTotal = new Negocios.Componentes.TextPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.textPersonal6 = new Negocios.Componentes.TextPersonal();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.cbbPersonal1 = new Negocios.Componentes.cbbPersonal();
            this.txtNumOrden = new Negocios.Componentes.TextPersonal();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cbbCentro = new Negocios.Componentes.cbbPersonal();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItbis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.Correo = false;
            this.txtNota.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNota.Limpiar = false;
            this.txtNota.Location = new System.Drawing.Point(672, 50);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.NullText = "Nota";
            // 
            // 
            // 
            this.txtNota.RootElement.StretchVertically = true;
            this.txtNota.Size = new System.Drawing.Size(280, 104);
            this.txtNota.TabIndex = 41;
            this.txtNota.ThemeName = "VisualStudio2012Light";
            this.txtNota.Validar = true;
            // 
            // dataProducto
            // 
            this.dataProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dataProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataProducto.Location = new System.Drawing.Point(31, 186);
            // 
            // 
            // 
            this.dataProducto.MasterTemplate.AllowAddNewRow = false;
            this.dataProducto.MasterTemplate.AllowColumnReorder = false;
            this.dataProducto.MasterTemplate.AllowDragToGroup = false;
            this.dataProducto.MasterTemplate.AllowRowResize = false;
            this.dataProducto.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.Width = 98;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Descripción";
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.Width = 306;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Unidad";
            gridViewTextBoxColumn3.Name = "Unidad";
            gridViewTextBoxColumn3.Width = 158;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Cantidad";
            gridViewTextBoxColumn4.Name = "Cantidad";
            gridViewTextBoxColumn4.Width = 129;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Precio";
            gridViewTextBoxColumn5.Name = "Precio";
            gridViewTextBoxColumn5.Width = 124;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "Importe";
            gridViewTextBoxColumn6.Name = "Importe";
            gridViewTextBoxColumn6.Width = 112;
            this.dataProducto.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dataProducto.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataProducto.MasterTemplate.EnableGrouping = false;
            this.dataProducto.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataProducto.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataProducto.Name = "dataProducto";
            this.dataProducto.ReadOnly = true;
            this.dataProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataProducto.Size = new System.Drawing.Size(921, 153);
            this.dataProducto.TabIndex = 51;
            this.dataProducto.ThemeName = "VisualStudio2012Light";
            // 
            // txtTotal
            // 
            this.txtTotal.Correo = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTotal.Limpiar = false;
            this.txtTotal.Location = new System.Drawing.Point(855, 408);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 27);
            this.txtTotal.TabIndex = 48;
            this.txtTotal.ThemeName = "VisualStudio2012Light";
            this.txtTotal.Validar = false;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Location = new System.Drawing.Point(434, 129);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.radDateTimePicker1.TabIndex = 44;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "lunes, 11 de noviembre de 2019";
            this.radDateTimePicker1.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // txtItbis
            // 
            this.txtItbis.Correo = false;
            this.txtItbis.Enabled = false;
            this.txtItbis.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtItbis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtItbis.Limpiar = false;
            this.txtItbis.Location = new System.Drawing.Point(855, 375);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(97, 27);
            this.txtItbis.TabIndex = 49;
            this.txtItbis.ThemeName = "VisualStudio2012Light";
            this.txtItbis.Validar = false;
            // 
            // cbbCliente
            // 
            this.cbbCliente.BackColor = System.Drawing.Color.White;
            this.cbbCliente.Correo = false;
            this.cbbCliente.DisplayMember = "Descripcion";
            this.cbbCliente.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCliente.Limpiar = true;
            this.cbbCliente.Location = new System.Drawing.Point(434, 89);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.NullText = "Tipo de Identificacion";
            this.cbbCliente.Size = new System.Drawing.Size(211, 25);
            this.cbbCliente.TabIndex = 43;
            this.cbbCliente.ThemeName = "VisualStudio2012Light";
            this.cbbCliente.Validar = true;
            this.cbbCliente.ValueMember = "IdTipoIdentificacion";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Correo = false;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSubTotal.Limpiar = false;
            this.txtSubTotal.Location = new System.Drawing.Point(855, 345);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(97, 27);
            this.txtSubTotal.TabIndex = 50;
            this.txtSubTotal.ThemeName = "VisualStudio2012Light";
            this.txtSubTotal.Validar = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(382, 95);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(46, 18);
            this.radLabel4.TabIndex = 42;
            this.radLabel4.Text = "Clientes";
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel6.Location = new System.Drawing.Point(814, 372);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(35, 21);
            this.radLabel6.TabIndex = 45;
            this.radLabel6.Text = "Itbis";
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel7.Location = new System.Drawing.Point(809, 408);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(40, 21);
            this.radLabel7.TabIndex = 46;
            this.radLabel7.Text = "Total";
            // 
            // textPersonal6
            // 
            this.textPersonal6.Correo = false;
            this.textPersonal6.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal6.Limpiar = true;
            this.textPersonal6.Location = new System.Drawing.Point(434, 49);
            this.textPersonal6.Name = "textPersonal6";
            this.textPersonal6.Size = new System.Drawing.Size(211, 24);
            this.textPersonal6.TabIndex = 37;
            this.textPersonal6.ThemeName = "VisualStudio2012Light";
            this.textPersonal6.Validar = true;
            // 
            // radLabel8
            // 
            this.radLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel8.Location = new System.Drawing.Point(784, 345);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(65, 21);
            this.radLabel8.TabIndex = 47;
            this.radLabel8.Text = "SubTotal";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(313, 54);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(115, 18);
            this.radLabel9.TabIndex = 36;
            this.radLabel9.Text = "Nmero de Cotizacion ";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(393, 131);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(35, 18);
            this.radLabel5.TabIndex = 40;
            this.radLabel5.Text = "Fecha";
            // 
            // cbbPersonal1
            // 
            this.cbbPersonal1.BackColor = System.Drawing.Color.White;
            this.cbbPersonal1.Correo = false;
            this.cbbPersonal1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPersonal1.Limpiar = false;
            this.cbbPersonal1.Location = new System.Drawing.Point(155, 88);
            this.cbbPersonal1.Name = "cbbPersonal1";
            this.cbbPersonal1.Size = new System.Drawing.Size(142, 25);
            this.cbbPersonal1.TabIndex = 39;
            this.cbbPersonal1.ThemeName = "VisualStudio2012Light";
            this.cbbPersonal1.Validar = false;
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.Correo = false;
            this.txtNumOrden.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNumOrden.Limpiar = true;
            this.txtNumOrden.Location = new System.Drawing.Point(155, 54);
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Size = new System.Drawing.Size(142, 24);
            this.txtNumOrden.TabIndex = 35;
            this.txtNumOrden.ThemeName = "VisualStudio2012Light";
            this.txtNumOrden.Validar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(51, 60);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 18);
            this.radLabel1.TabIndex = 34;
            this.radLabel1.Text = "Numero de Orden";
            // 
            // cbbCentro
            // 
            this.cbbCentro.BackColor = System.Drawing.Color.White;
            this.cbbCentro.Correo = false;
            this.cbbCentro.DisplayMember = "Descripcion";
            this.cbbCentro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCentro.Limpiar = true;
            this.cbbCentro.Location = new System.Drawing.Point(157, 129);
            this.cbbCentro.Name = "cbbCentro";
            this.cbbCentro.NullText = "Tipo de Identificacion";
            this.cbbCentro.Size = new System.Drawing.Size(142, 25);
            this.cbbCentro.TabIndex = 38;
            this.cbbCentro.ThemeName = "VisualStudio2012Light";
            this.cbbCentro.Validar = true;
            this.cbbCentro.ValueMember = "IdTipoIdentificacion";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(109, 129);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(40, 18);
            this.radLabel3.TabIndex = 33;
            this.radLabel3.Text = "Centro";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(86, 90);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 32;
            this.radLabel2.Text = "Tipo Orden";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1007, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ordenes ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.dataProducto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.txtItbis);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.textPersonal6);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.cbbPersonal1);
            this.Controls.Add(this.txtNumOrden);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cbbCentro);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Name = "Ordenes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.txtNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItbis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Negocios.Componentes.TextPersonal txtNota;
        private Telerik.WinControls.UI.RadGridView dataProducto;
        private Negocios.Componentes.TextPersonal txtTotal;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Negocios.Componentes.TextPersonal txtItbis;
        private Negocios.Componentes.cbbPersonal cbbCliente;
        private Negocios.Componentes.TextPersonal txtSubTotal;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Negocios.Componentes.TextPersonal textPersonal6;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Negocios.Componentes.cbbPersonal cbbPersonal1;
        private Negocios.Componentes.TextPersonal txtNumOrden;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Negocios.Componentes.cbbPersonal cbbCentro;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Label label4;
    }
}
