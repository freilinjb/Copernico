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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.txtDescripcion = new Negocios.Componentes.TextPersonal();
            this.cbbCentro = new Negocios.Componentes.cbbPersonal();
            this.txttipoOrden = new Negocios.Componentes.TextPersonal();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttipoOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radCheckBox1);
            this.radGroupBox1.Controls.Add(this.txtDescripcion);
            this.radGroupBox1.Controls.Add(this.cbbCentro);
            this.radGroupBox1.Controls.Add(this.txttipoOrden);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.HeaderText = "Datos de las Orden";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 22);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(407, 346);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Datos de las Orden";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(186, 267);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(91, 18);
            this.radCheckBox1.TabIndex = 11;
            this.radCheckBox1.Text = "radCheckBox1";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Correo = false;
            this.txtDescripcion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtDescripcion.Limpiar = false;
            this.txtDescripcion.Location = new System.Drawing.Point(106, 112);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.NullText = "Descripcion";
            // 
            // 
            // 
            this.txtDescripcion.RootElement.StretchVertically = true;
            this.txtDescripcion.Size = new System.Drawing.Size(211, 124);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.ThemeName = "VisualStudio2012Light";
            this.txtDescripcion.Validar = true;
            // 
            // cbbCentro
            // 
            this.cbbCentro.BackColor = System.Drawing.Color.White;
            this.cbbCentro.Correo = false;
            this.cbbCentro.DisplayMember = "Descripcion";
            this.cbbCentro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCentro.Limpiar = true;
            this.cbbCentro.Location = new System.Drawing.Point(175, 68);
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
            this.txttipoOrden.Location = new System.Drawing.Point(175, 39);
            this.txttipoOrden.Name = "txttipoOrden";
            this.txttipoOrden.Size = new System.Drawing.Size(142, 24);
            this.txttipoOrden.TabIndex = 1;
            this.txttipoOrden.ThemeName = "VisualStudio2012Light";
            this.txttipoOrden.Validar = true;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(106, 267);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(74, 18);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Estado Orden";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(127, 75);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(40, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Centro";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(106, 45);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Tipo Orden";
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttipoOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Negocios.Componentes.cbbPersonal cbbCentro;
        private Negocios.Componentes.TextPersonal txttipoOrden;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.TextPersonal txtDescripcion;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}