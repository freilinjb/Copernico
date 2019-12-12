namespace Vistas.Formularios
{
    partial class Actividad
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
            this.txtActivoFijo = new Negocios.Componentes.TextPersonal();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescripcion = new Negocios.Componentes.TextPersonal();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.cbbSubGrupo = new Negocios.Componentes.cbbPersonal();
            this.cbbGrupo = new Negocios.Componentes.cbbPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSubGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActivoFijo
            // 
            this.txtActivoFijo.Correo = false;
            this.txtActivoFijo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtActivoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivoFijo.Limpiar = false;
            this.txtActivoFijo.Location = new System.Drawing.Point(84, 12);
            this.txtActivoFijo.Name = "txtActivoFijo";
            this.txtActivoFijo.Size = new System.Drawing.Size(138, 24);
            this.txtActivoFijo.TabIndex = 42;
            this.txtActivoFijo.ThemeName = "VisualStudio2012Light";
            this.txtActivoFijo.Validar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(8, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 21);
            this.radLabel1.TabIndex = 41;
            this.radLabel1.Text = "Activo Fijo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Correo = false;
            this.txtDescripcion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(313, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(393, 24);
            this.txtDescripcion.TabIndex = 40;
            this.txtDescripcion.ThemeName = "VisualStudio2012Light";
            this.txtDescripcion.Validar = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radLabel2.Location = new System.Drawing.Point(237, 17);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 19);
            this.radLabel2.TabIndex = 43;
            this.radLabel2.Text = "Descripción";
            this.radLabel2.ThemeName = "VisualStudio2012Light";
            // 
            // cbbSubGrupo
            // 
            this.cbbSubGrupo.BackColor = System.Drawing.Color.White;
            this.cbbSubGrupo.Correo = false;
            this.cbbSubGrupo.DisplayMember = "Descripcion";
            this.cbbSubGrupo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubGrupo.Limpiar = true;
            this.cbbSubGrupo.Location = new System.Drawing.Point(99, 102);
            this.cbbSubGrupo.Name = "cbbSubGrupo";
            this.cbbSubGrupo.NullText = "Tipo de Identificacion";
            this.cbbSubGrupo.Size = new System.Drawing.Size(227, 23);
            this.cbbSubGrupo.TabIndex = 4;
            this.cbbSubGrupo.ThemeName = "VisualStudio2012Light";
            this.cbbSubGrupo.Validar = true;
            this.cbbSubGrupo.ValueMember = "IdGrupoActivoFijo";
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.BackColor = System.Drawing.Color.White;
            this.cbbGrupo.Correo = false;
            this.cbbGrupo.DataMember = null;
            this.cbbGrupo.DisplayMember = "Descripcion";
            this.cbbGrupo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGrupo.Limpiar = true;
            this.cbbGrupo.Location = new System.Drawing.Point(99, 73);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.NullText = "Tipo de Identificacion";
            this.cbbGrupo.Size = new System.Drawing.Size(227, 23);
            this.cbbGrupo.TabIndex = 2;
            this.cbbGrupo.ThemeName = "VisualStudio2012Light";
            this.cbbGrupo.Validar = true;
            this.cbbGrupo.ValueMember = "IdGrupoActivoFijo";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radLabel4.Location = new System.Drawing.Point(31, 106);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 19);
            this.radLabel4.TabIndex = 32;
            this.radLabel4.Text = "SubGrupo";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radLabel3.Location = new System.Drawing.Point(52, 77);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 19);
            this.radLabel3.TabIndex = 36;
            this.radLabel3.Text = "Grupo";
            // 
            // Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 570);
            this.Controls.Add(this.txtActivoFijo);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.cbbGrupo);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.cbbSubGrupo);
            this.Name = "Actividad";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.txtActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSubGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Negocios.Componentes.TextPersonal txtActivoFijo;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Negocios.Componentes.TextPersonal txtDescripcion;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.cbbPersonal cbbSubGrupo;
        private Negocios.Componentes.cbbPersonal cbbGrupo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
