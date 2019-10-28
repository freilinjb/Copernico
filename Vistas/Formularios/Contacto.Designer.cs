namespace Vistas.Formularios
{
    partial class Contacto
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.chEstado = new Telerik.WinControls.UI.RadToggleSwitch();
            this.cbbPuesto = new Negocios.Componentes.cbbPersonal();
            this.puestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.cbbDepartamento = new Negocios.Componentes.cbbPersonal();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.cbbTipoTelefono = new Negocios.Componentes.cbbPersonal();
            this.tipoTelefonoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtCorreo = new Negocios.Componentes.TextPersonal();
            this.txtTelefono = new Negocios.Componentes.TextPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.puestoTableAdapter = new Vistas.MatrizDataSetTableAdapters.PuestoTableAdapter();
            this.tipoTelefonoTableAdapter = new Vistas.MatrizDataSetTableAdapters.TipoTelefonoTableAdapter();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new Vistas.MatrizDataSetTableAdapters.DepartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTelefonoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radSeparator1);
            this.radGroupBox1.Controls.Add(this.chEstado);
            this.radGroupBox1.Controls.Add(this.cbbPuesto);
            this.radGroupBox1.Controls.Add(this.cbbDepartamento);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.cbbTipoTelefono);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.txtCorreo);
            this.radGroupBox1.Controls.Add(this.txtTelefono);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.txtNombre);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Datos del Cliente";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(341, 240);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Datos del Cliente";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(0, 228);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(349, 10);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // chEstado
            // 
            this.chEstado.Location = new System.Drawing.Point(265, 202);
            this.chEstado.Name = "chEstado";
            this.chEstado.OffText = "Inactivo";
            this.chEstado.OnText = "Activo";
            this.chEstado.Size = new System.Drawing.Size(71, 20);
            this.chEstado.TabIndex = 10;
            this.chEstado.ThemeName = "VisualStudio2012Light";
            this.chEstado.ThumbTickness = 15;
            // 
            // cbbPuesto
            // 
            this.cbbPuesto.BackColor = System.Drawing.Color.White;
            this.cbbPuesto.Correo = false;
            this.cbbPuesto.DataSource = this.puestoBindingSource;
            this.cbbPuesto.DisplayMember = "Descripcion";
            this.cbbPuesto.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPuesto.Limpiar = true;
            this.cbbPuesto.Location = new System.Drawing.Point(106, 82);
            this.cbbPuesto.Name = "cbbPuesto";
            this.cbbPuesto.NullText = "Tipo de Identificacion";
            this.cbbPuesto.Size = new System.Drawing.Size(230, 25);
            this.cbbPuesto.TabIndex = 9;
            this.cbbPuesto.ThemeName = "VisualStudio2012Light";
            this.cbbPuesto.Validar = true;
            this.cbbPuesto.ValueMember = "IdPuesto";
            // 
            // puestoBindingSource
            // 
            this.puestoBindingSource.DataMember = "Puesto";
            this.puestoBindingSource.DataSource = this.matrizDataSet;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.BackColor = System.Drawing.Color.White;
            this.cbbDepartamento.Correo = false;
            this.cbbDepartamento.DataSource = this.departamentoBindingSource;
            this.cbbDepartamento.DisplayMember = "Departamento";
            this.cbbDepartamento.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDepartamento.Limpiar = true;
            this.cbbDepartamento.Location = new System.Drawing.Point(106, 51);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.NullText = "Tipo de Identificacion";
            this.cbbDepartamento.Size = new System.Drawing.Size(230, 25);
            this.cbbDepartamento.TabIndex = 9;
            this.cbbDepartamento.ThemeName = "VisualStudio2012Light";
            this.cbbDepartamento.Validar = true;
            this.cbbDepartamento.ValueMember = "IdDepartamento";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(21, 58);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(79, 18);
            this.radLabel6.TabIndex = 0;
            this.radLabel6.Text = "Departamento";
            // 
            // cbbTipoTelefono
            // 
            this.cbbTipoTelefono.BackColor = System.Drawing.Color.White;
            this.cbbTipoTelefono.Correo = false;
            this.cbbTipoTelefono.DataSource = this.tipoTelefonoBindingSource;
            this.cbbTipoTelefono.DisplayMember = "Descripcion";
            this.cbbTipoTelefono.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbTipoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoTelefono.Limpiar = true;
            this.cbbTipoTelefono.Location = new System.Drawing.Point(106, 112);
            this.cbbTipoTelefono.Name = "cbbTipoTelefono";
            this.cbbTipoTelefono.NullText = "Tipo de Identificacion";
            this.cbbTipoTelefono.Size = new System.Drawing.Size(230, 25);
            this.cbbTipoTelefono.TabIndex = 9;
            this.cbbTipoTelefono.ThemeName = "VisualStudio2012Light";
            this.cbbTipoTelefono.Validar = true;
            this.cbbTipoTelefono.ValueMember = "IdTipoTelefono";
            // 
            // tipoTelefonoBindingSource
            // 
            this.tipoTelefonoBindingSource.DataMember = "TipoTelefono";
            this.tipoTelefonoBindingSource.DataSource = this.matrizDataSet;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(9, 118);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(91, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Tipo de Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Correo = false;
            this.txtCorreo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCorreo.Limpiar = true;
            this.txtCorreo.Location = new System.Drawing.Point(106, 172);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(230, 24);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.ThemeName = "VisualStudio2012Light";
            this.txtCorreo.Validar = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Correo = false;
            this.txtTelefono.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtTelefono.Limpiar = true;
            this.txtTelefono.Location = new System.Drawing.Point(106, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 24);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.ThemeName = "VisualStudio2012Light";
            this.txtTelefono.Validar = true;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(66, 178);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(34, 18);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Corre";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(23, 88);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(77, 18);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Puesto laboral";
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(106, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(50, 149);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(50, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Telefono";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(2, 27);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nombre completo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // puestoTableAdapter
            // 
            this.puestoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoTelefonoTableAdapter
            // 
            this.tipoTelefonoTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.matrizDataSet;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 252);
            this.Controls.Add(this.radGroupBox1);
            this.KeyPreview = true;
            this.Name = "Contacto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Contecto";
            this.Load += new System.EventHandler(this.Conduce_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Contacto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTelefonoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Negocios.Componentes.cbbPersonal cbbTipoTelefono;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadToggleSwitch chEstado;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MatrizDataSet matrizDataSet;
        public Negocios.Componentes.TextPersonal txtCorreo;
        public Negocios.Componentes.TextPersonal txtTelefono;
        public Negocios.Componentes.TextPersonal txtNombre;
        public Negocios.Componentes.cbbPersonal cbbDepartamento;
        public Negocios.Componentes.cbbPersonal cbbPuesto;
        private System.Windows.Forms.BindingSource puestoBindingSource;
        private MatrizDataSetTableAdapters.PuestoTableAdapter puestoTableAdapter;
        private System.Windows.Forms.BindingSource tipoTelefonoBindingSource;
        private MatrizDataSetTableAdapters.TipoTelefonoTableAdapter tipoTelefonoTableAdapter;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private MatrizDataSetTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
    }
}