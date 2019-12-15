namespace Vistas.Formularios
{
    partial class PermisoAmbiental
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.toolRegistro = new Telerik.WinControls.UI.RadLabelElement();
            this.dataPermisoMedioAmbiente = new Telerik.WinControls.UI.RadGridView();
            this.panelInformacion = new Telerik.WinControls.UI.RadPanel();
            this.txtFechaVencimiento = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtFechaEmitida = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.cbbTipoPermisoAmbiental = new Negocios.Componentes.cbbPersonal();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cbbEstado = new Negocios.Componentes.cbbPersonal();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.cbbMina = new Negocios.Componentes.cbbPersonal();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.txtDireccion = new Negocios.Componentes.TextPersonal();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPermisoMedioAmbiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPermisoMedioAmbiente.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformacion)).BeginInit();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaEmitida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoPermisoAmbiental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(12, 218);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(579, 10);
            this.radSeparator2.TabIndex = 25;
            this.radSeparator2.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(24, 18);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(54, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Nombre";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.toolRegistro});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 513);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(603, 26);
            this.radStatusStrip1.TabIndex = 23;
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
            // dataPermisoMedioAmbiente
            // 
            this.dataPermisoMedioAmbiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPermisoMedioAmbiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataPermisoMedioAmbiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataPermisoMedioAmbiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataPermisoMedioAmbiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataPermisoMedioAmbiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataPermisoMedioAmbiente.Location = new System.Drawing.Point(12, 234);
            // 
            // 
            // 
            this.dataPermisoMedioAmbiente.MasterTemplate.AllowAddNewRow = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.AllowColumnChooser = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.AllowColumnReorder = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.AllowDragToGroup = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.AllowRowResize = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dataPermisoMedioAmbiente.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataPermisoMedioAmbiente.MasterTemplate.EnableGrouping = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.EnableSorting = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataPermisoMedioAmbiente.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataPermisoMedioAmbiente.Name = "dataPermisoMedioAmbiente";
            this.dataPermisoMedioAmbiente.ReadOnly = true;
            this.dataPermisoMedioAmbiente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataPermisoMedioAmbiente.ShowGroupPanel = false;
            this.dataPermisoMedioAmbiente.Size = new System.Drawing.Size(579, 273);
            this.dataPermisoMedioAmbiente.TabIndex = 21;
            this.dataPermisoMedioAmbiente.ThemeName = "VisualStudio2012Light";
            // 
            // panelInformacion
            // 
            this.panelInformacion.Controls.Add(this.txtFechaVencimiento);
            this.panelInformacion.Controls.Add(this.txtFechaEmitida);
            this.panelInformacion.Controls.Add(this.radLabel13);
            this.panelInformacion.Controls.Add(this.radLabel3);
            this.panelInformacion.Controls.Add(this.cbbTipoPermisoAmbiental);
            this.panelInformacion.Controls.Add(this.textPersonal1);
            this.panelInformacion.Controls.Add(this.radLabel4);
            this.panelInformacion.Controls.Add(this.radLabel1);
            this.panelInformacion.Controls.Add(this.cbbEstado);
            this.panelInformacion.Controls.Add(this.radLabel9);
            this.panelInformacion.Controls.Add(this.radLabel12);
            this.panelInformacion.Controls.Add(this.cbbMina);
            this.panelInformacion.Controls.Add(this.radLabel11);
            this.panelInformacion.Controls.Add(this.txtDireccion);
            this.panelInformacion.Location = new System.Drawing.Point(12, 42);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(579, 170);
            this.panelInformacion.TabIndex = 22;
            this.panelInformacion.ThemeName = "VisualStudio2012Light";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(114, 63);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(168, 24);
            this.txtFechaVencimiento.TabIndex = 14;
            this.txtFechaVencimiento.TabStop = false;
            this.txtFechaVencimiento.Text = "14/12/2019";
            this.txtFechaVencimiento.ThemeName = "VisualStudio2012Light";
            this.txtFechaVencimiento.Value = new System.DateTime(2019, 12, 14, 23, 24, 32, 716);
            // 
            // txtFechaEmitida
            // 
            this.txtFechaEmitida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFechaEmitida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaEmitida.Location = new System.Drawing.Point(114, 33);
            this.txtFechaEmitida.Name = "txtFechaEmitida";
            this.txtFechaEmitida.Size = new System.Drawing.Size(168, 24);
            this.txtFechaEmitida.TabIndex = 14;
            this.txtFechaEmitida.TabStop = false;
            this.txtFechaEmitida.Text = "14/12/2019";
            this.txtFechaEmitida.ThemeName = "VisualStudio2012Light";
            this.txtFechaEmitida.Value = new System.DateTime(2019, 12, 14, 23, 24, 32, 716);
            // 
            // radLabel13
            // 
            this.radLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel13.Location = new System.Drawing.Point(12, 39);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(67, 18);
            this.radLabel13.TabIndex = 2;
            this.radLabel13.Text = "F. Emitida";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 10);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(33, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "TPA";
            // 
            // cbbTipoPermisoAmbiental
            // 
            this.cbbTipoPermisoAmbiental.BackColor = System.Drawing.Color.White;
            this.cbbTipoPermisoAmbiental.Correo = false;
            this.cbbTipoPermisoAmbiental.DisplayMember = "Descripcion";
            this.cbbTipoPermisoAmbiental.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbTipoPermisoAmbiental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoPermisoAmbiental.Limpiar = true;
            this.cbbTipoPermisoAmbiental.Location = new System.Drawing.Point(114, 3);
            this.cbbTipoPermisoAmbiental.Name = "cbbTipoPermisoAmbiental";
            this.cbbTipoPermisoAmbiental.Size = new System.Drawing.Size(168, 25);
            this.cbbTipoPermisoAmbiental.TabIndex = 4;
            this.cbbTipoPermisoAmbiental.ThemeName = "VisualStudio2012Light";
            this.cbbTipoPermisoAmbiental.Validar = true;
            this.cbbTipoPermisoAmbiental.ValueMember = "IdTipoProducto";
            // 
            // textPersonal1
            // 
            this.textPersonal1.Correo = false;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Numeros;
            this.textPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPersonal1.Limpiar = true;
            this.textPersonal1.Location = new System.Drawing.Point(449, 62);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.Size = new System.Drawing.Size(127, 24);
            this.textPersonal1.TabIndex = 3;
            this.textPersonal1.ThemeName = "VisualStudio2012Light";
            this.textPersonal1.Validar = true;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(315, 68);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(128, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Cantidad Autorizada";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(315, 99);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.White;
            this.cbbEstado.Correo = false;
            this.cbbEstado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Disponible";
            this.cbbEstado.Items.Add(radListDataItem1);
            this.cbbEstado.Limpiar = true;
            this.cbbEstado.Location = new System.Drawing.Point(449, 92);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(127, 25);
            this.cbbEstado.TabIndex = 7;
            this.cbbEstado.ThemeName = "VisualStudio2012Light";
            this.cbbEstado.Validar = true;
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel9.Location = new System.Drawing.Point(12, 69);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(96, 18);
            this.radLabel9.TabIndex = 2;
            this.radLabel9.Text = "F. Vencimiento";
            // 
            // radLabel12
            // 
            this.radLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel12.Location = new System.Drawing.Point(6, 130);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(64, 19);
            this.radLabel12.TabIndex = 2;
            this.radLabel12.Text = "Dirección";
            // 
            // cbbMina
            // 
            this.cbbMina.BackColor = System.Drawing.Color.White;
            this.cbbMina.Correo = false;
            this.cbbMina.DisplayMember = "Descripcion";
            this.cbbMina.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbMina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMina.Limpiar = true;
            this.cbbMina.Location = new System.Drawing.Point(114, 93);
            this.cbbMina.Name = "cbbMina";
            this.cbbMina.Size = new System.Drawing.Size(168, 25);
            this.cbbMina.TabIndex = 4;
            this.cbbMina.ThemeName = "VisualStudio2012Light";
            this.cbbMina.Validar = true;
            this.cbbMina.ValueMember = "IdTipoProducto";
            // 
            // radLabel11
            // 
            this.radLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel11.Location = new System.Drawing.Point(7, 99);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(36, 18);
            this.radLabel11.TabIndex = 2;
            this.radLabel11.Text = "Mina";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Correo = false;
            this.txtDireccion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Limpiar = true;
            this.txtDireccion.Location = new System.Drawing.Point(117, 124);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            // 
            // 
            // 
            this.txtDireccion.RootElement.StretchVertically = true;
            this.txtDireccion.Size = new System.Drawing.Size(459, 25);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.ThemeName = "VisualStudio2012Light";
            this.txtDireccion.Validar = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = true;
            this.txtCodigo.Location = new System.Drawing.Point(84, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 24);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PermisoAmbiental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 539);
            this.Controls.Add(this.radSeparator2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.dataPermisoMedioAmbiente);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyPreview = true;
            this.Name = "PermisoAmbiental";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "PermisoAmbiental";
            this.Load += new System.EventHandler(this.PermisoAmbiental_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PermisoAmbiental_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPermisoMedioAmbiente.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPermisoMedioAmbiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInformacion)).EndInit();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaEmitida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoPermisoAmbiental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dataPermisoMedioAmbiente;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement toolRegistro;
        private Telerik.WinControls.UI.RadPanel panelInformacion;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Negocios.Componentes.cbbPersonal cbbTipoPermisoAmbiental;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Negocios.Componentes.cbbPersonal cbbMina;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Negocios.Componentes.TextPersonal txtDireccion;
        private Negocios.Componentes.TextPersonal txtCodigo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker txtFechaVencimiento;
        private Telerik.WinControls.UI.RadDateTimePicker txtFechaEmitida;
        private Negocios.Componentes.cbbPersonal cbbEstado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
    }
}
