namespace Vistas
{
    partial class Centro
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
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.comboPersonal1 = new Negocios.Componentes.ComboPersonal();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.SuspendLayout();
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(129, 110);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox1.TabIndex = 0;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // comboPersonal1
            // 
            this.comboPersonal1.BackColor = System.Drawing.Color.Transparent;
            this.comboPersonal1.BaseColor = System.Drawing.Color.White;
            this.comboPersonal1.BorderColor = System.Drawing.Color.Silver;
            this.comboPersonal1.Correo = false;
            this.comboPersonal1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPersonal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonal1.estados = Negocios.Componentes.ComboPersonal.Estados.Default;
            this.comboPersonal1.FocusedColor = System.Drawing.Color.Empty;
            this.comboPersonal1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPersonal1.ForeColor = System.Drawing.Color.Black;
            this.comboPersonal1.FormattingEnabled = true;
            this.comboPersonal1.Limpiar = false;
            this.comboPersonal1.Location = new System.Drawing.Point(194, 244);
            this.comboPersonal1.Name = "comboPersonal1";
            this.comboPersonal1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboPersonal1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboPersonal1.Size = new System.Drawing.Size(121, 26);
            this.comboPersonal1.TabIndex = 2;
            this.comboPersonal1.Validar = false;
            // 
            // textPersonal1
            // 
            this.textPersonal1.BaseColor = System.Drawing.Color.White;
            this.textPersonal1.BorderColor = System.Drawing.Color.Silver;
            this.textPersonal1.Correo = false;
            this.textPersonal1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.FocusedBaseColor = System.Drawing.Color.White;
            this.textPersonal1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPersonal1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textPersonal1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPersonal1.Limpiar = false;
            this.textPersonal1.Location = new System.Drawing.Point(283, 166);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.PasswordChar = '\0';
            this.textPersonal1.Size = new System.Drawing.Size(160, 30);
            this.textPersonal1.TabIndex = 1;
            this.textPersonal1.Text = "textPersonal1";
            this.textPersonal1.Validar = false;
            // 
            // Centro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboPersonal1);
            this.Controls.Add(this.textPersonal1);
            this.Controls.Add(this.gunaTextBox1);
            this.Name = "Centro";
            this.Text = "Centro";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private Negocios.Componentes.ComboPersonal comboPersonal1;
    }
}