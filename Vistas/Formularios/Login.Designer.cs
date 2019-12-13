namespace Vistas.Formularios
{
    partial class Login
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
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtUsuario = new Negocios.Componentes.TextPersonal();
            this.txtClave = new Negocios.Componentes.TextPersonal();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btIniciarSeccion = new Telerik.WinControls.UI.RadButton();
            this.btCancelar = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIniciarSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 80);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 18);
            this.radLabel3.TabIndex = 25;
            this.radLabel3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Correo = false;
            this.txtUsuario.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Limpiar = true;
            this.txtUsuario.Location = new System.Drawing.Point(12, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NullText = "Ingrese el nombrer de usuario";
            this.txtUsuario.Size = new System.Drawing.Size(264, 24);
            this.txtUsuario.TabIndex = 26;
            this.txtUsuario.ThemeName = "VisualStudio2012Light";
            this.txtUsuario.Validar = true;
            // 
            // txtClave
            // 
            this.txtClave.Correo = false;
            this.txtClave.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Limpiar = true;
            this.txtClave.Location = new System.Drawing.Point(12, 158);
            this.txtClave.Name = "txtClave";
            this.txtClave.NullText = "Ingrese la contraseña";
            this.txtClave.PasswordChar = '•';
            this.txtClave.Size = new System.Drawing.Size(264, 24);
            this.txtClave.TabIndex = 26;
            this.txtClave.ThemeName = "VisualStudio2012Light";
            this.txtClave.Validar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 134);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 18);
            this.radLabel1.TabIndex = 25;
            this.radLabel1.Text = "Contraseña";
            // 
            // btIniciarSeccion
            // 
            this.btIniciarSeccion.Location = new System.Drawing.Point(12, 188);
            this.btIniciarSeccion.Name = "btIniciarSeccion";
            this.btIniciarSeccion.Size = new System.Drawing.Size(264, 24);
            this.btIniciarSeccion.TabIndex = 27;
            this.btIniciarSeccion.Text = "Iniciar Sección";
            this.btIniciarSeccion.ThemeName = "VisualStudio2012Light";
            this.btIniciarSeccion.Click += new System.EventHandler(this.btIniciarSeccion_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(12, 218);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(264, 24);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.ThemeName = "VisualStudio2012Light";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(12, 243);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(266, 10);
            this.radSeparator1.TabIndex = 28;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 388);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btIniciarSeccion);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyPreview = true;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIniciarSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Negocios.Componentes.TextPersonal txtUsuario;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Negocios.Componentes.TextPersonal txtClave;
        private Telerik.WinControls.UI.RadButton btCancelar;
        private Telerik.WinControls.UI.RadButton btIniciarSeccion;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
    }
}
