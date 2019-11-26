namespace Vistas.Formularios
{
    partial class Empleado
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbbTipoIdentificacion = new Negocios.Componentes.cbbPersonal();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdentificacion = new Negocios.Componentes.TextPersonal();
            this.txtRasonSocial = new Negocios.Componentes.TextPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRasonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.cbbTipoIdentificacion);
            this.radGroupBox1.Controls.Add(this.pictureBox1);
            this.radGroupBox1.Controls.Add(this.txtIdentificacion);
            this.radGroupBox1.Controls.Add(this.txtRasonSocial);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.txtNombre);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Datos del Cliente";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(395, 154);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Datos del Cliente";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // cbbTipoIdentificacion
            // 
            this.cbbTipoIdentificacion.BackColor = System.Drawing.Color.White;
            this.cbbTipoIdentificacion.Correo = false;
            this.cbbTipoIdentificacion.DisplayMember = "Descripcion";
            this.cbbTipoIdentificacion.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbTipoIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoIdentificacion.Limpiar = true;
            this.cbbTipoIdentificacion.Location = new System.Drawing.Point(88, 90);
            this.cbbTipoIdentificacion.Name = "cbbTipoIdentificacion";
            this.cbbTipoIdentificacion.NullText = "Tipo de Identificacion";
            this.cbbTipoIdentificacion.Size = new System.Drawing.Size(142, 25);
            this.cbbTipoIdentificacion.TabIndex = 9;
            this.cbbTipoIdentificacion.ThemeName = "VisualStudio2012Light";
            this.cbbTipoIdentificacion.Validar = true;
            this.cbbTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Correo = false;
            this.txtIdentificacion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtIdentificacion.Limpiar = true;
            this.txtIdentificacion.Location = new System.Drawing.Point(88, 120);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(142, 24);
            this.txtIdentificacion.TabIndex = 1;
            this.txtIdentificacion.ThemeName = "VisualStudio2012Light";
            this.txtIdentificacion.Validar = true;
            // 
            // txtRasonSocial
            // 
            this.txtRasonSocial.Correo = false;
            this.txtRasonSocial.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtRasonSocial.Limpiar = true;
            this.txtRasonSocial.Location = new System.Drawing.Point(88, 60);
            this.txtRasonSocial.Name = "txtRasonSocial";
            this.txtRasonSocial.Size = new System.Drawing.Size(142, 24);
            this.txtRasonSocial.TabIndex = 1;
            this.txtRasonSocial.ThemeName = "VisualStudio2012Light";
            this.txtRasonSocial.Validar = true;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(9, 126);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(73, 18);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Identificación";
            // 
            // txtNombre
            // 
            this.txtNombre.Correo = false;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.Limpiar = true;
            this.txtNombre.Location = new System.Drawing.Point(88, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.ThemeName = "VisualStudio2012Light";
            this.txtNombre.Validar = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(34, 96);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(42, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Tipo ID";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 66);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(69, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Razon Social";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(34, 36);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(48, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nombre";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Empleado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRasonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Negocios.Componentes.cbbPersonal cbbTipoIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Negocios.Componentes.TextPersonal txtIdentificacion;
        private Negocios.Componentes.TextPersonal txtRasonSocial;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}