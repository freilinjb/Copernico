namespace Vistas.Formularios
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lbAgregarContacto = new Guna.UI.WinForms.GunaLinkLabel();
            this.dataContacto = new Guna.UI.WinForms.GunaDataGridView();
            this.Contacto = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btGuardar = new Guna.UI.WinForms.GunaButton();
            this.btAyuda = new Guna.UI.WinForms.GunaButton();
            this.btCancelar = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.txtTelefono = new Negocios.Componentes.TextPersonal();
            this.txtCorreo = new Negocios.Componentes.TextPersonal();
            this.cbbEstado = new Negocios.Componentes.ComboPersonal();
            this.txtDireccion = new Negocios.Componentes.TextPersonal();
            this.cbbSector = new Negocios.Componentes.ComboPersonal();
            this.sectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new Vistas.MatrizDataSet();
            this.cbbMunicipio = new Negocios.Componentes.ComboPersonal();
            this.cbbProvincia = new Negocios.Componentes.ComboPersonal();
            this.cbbID = new Negocios.Componentes.ComboPersonal();
            this.tipoIdentificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdentificacion = new Negocios.Componentes.TextPersonal();
            this.txtRasonSocial = new Negocios.Componentes.TextPersonal();
            this.txtNombre = new Negocios.Componentes.TextPersonal();
            this.textPersonal1 = new Negocios.Componentes.TextPersonal();
            this.sectorTableAdapter = new Vistas.MatrizDataSetTableAdapters.SectorTableAdapter();
            this.tipoIdentificacionTableAdapter = new Vistas.MatrizDataSetTableAdapters.TipoIdentificacionTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacto)).BeginInit();
            this.gunaGradient2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdentificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(48, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Codigo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(42, 84);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(59, 19);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Nombre";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(17, 120);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(84, 19);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Razon Social";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.Location = new System.Drawing.Point(29, 152);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(72, 19);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Tipo de ID";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.Location = new System.Drawing.Point(12, 188);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(89, 19);
            this.gunaLabel5.TabIndex = 0;
            this.gunaLabel5.Text = "Identificacion";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(21, 281);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(607, 10);
            this.gunaSeparator1.TabIndex = 3;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel6.Location = new System.Drawing.Point(257, 124);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(64, 19);
            this.gunaLabel6.TabIndex = 4;
            this.gunaLabel6.Text = "Provincia";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel7.Location = new System.Drawing.Point(257, 156);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(69, 19);
            this.gunaLabel7.TabIndex = 6;
            this.gunaLabel7.Text = "Municipio";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel8.Location = new System.Drawing.Point(279, 188);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(47, 19);
            this.gunaLabel8.TabIndex = 8;
            this.gunaLabel8.Text = "Sector";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel9.Location = new System.Drawing.Point(261, 256);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(65, 19);
            this.gunaLabel9.TabIndex = 10;
            this.gunaLabel9.Text = "Dirección";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPictureBox1.Location = new System.Drawing.Point(459, 73);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(161, 163);
            this.gunaPictureBox1.TabIndex = 12;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel11.Location = new System.Drawing.Point(271, 217);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(50, 19);
            this.gunaLabel11.TabIndex = 16;
            this.gunaLabel11.Text = "Estado";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.Controls.Add(this.lbAgregarContacto);
            this.gunaGroupBox1.Controls.Add(this.dataContacto);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.LightGray;
            this.gunaGroupBox1.Location = new System.Drawing.Point(16, 297);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(607, 175);
            this.gunaGroupBox1.TabIndex = 18;
            this.gunaGroupBox1.Text = "DATOS DE CONTACTOS DE LA EMPRESA";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lbAgregarContacto
            // 
            this.lbAgregarContacto.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lbAgregarContacto.AutoSize = true;
            this.lbAgregarContacto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbAgregarContacto.Location = new System.Drawing.Point(485, 8);
            this.lbAgregarContacto.Name = "lbAgregarContacto";
            this.lbAgregarContacto.Size = new System.Drawing.Size(119, 19);
            this.lbAgregarContacto.TabIndex = 1;
            this.lbAgregarContacto.TabStop = true;
            this.lbAgregarContacto.Text = "Ingresar Contacto";
            this.lbAgregarContacto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbAgregarContacto_LinkClicked);
            // 
            // dataContacto
            // 
            this.dataContacto.AllowUserToAddRows = false;
            this.dataContacto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataContacto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataContacto.BackgroundColor = System.Drawing.Color.White;
            this.dataContacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataContacto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataContacto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataContacto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataContacto.ColumnHeadersHeight = 20;
            this.dataContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contacto,
            this.Telefono,
            this.Nombre,
            this.Cargo,
            this.Departamento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataContacto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataContacto.EnableHeadersVisualStyles = false;
            this.dataContacto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataContacto.Location = new System.Drawing.Point(0, 35);
            this.dataContacto.Name = "dataContacto";
            this.dataContacto.ReadOnly = true;
            this.dataContacto.RowHeadersVisible = false;
            this.dataContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataContacto.Size = new System.Drawing.Size(607, 137);
            this.dataContacto.TabIndex = 0;
            this.dataContacto.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dataContacto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataContacto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataContacto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataContacto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataContacto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataContacto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataContacto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataContacto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dataContacto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataContacto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataContacto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataContacto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataContacto.ThemeStyle.HeaderStyle.Height = 20;
            this.dataContacto.ThemeStyle.ReadOnly = true;
            this.dataContacto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataContacto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataContacto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataContacto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataContacto.ThemeStyle.RowsStyle.Height = 22;
            this.dataContacto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataContacto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Correo";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(587, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 25);
            this.gunaControlBox1.TabIndex = 19;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaControlBox1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(635, 32);
            this.gunaGradient2Panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registro de cliente::..";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel12.Location = new System.Drawing.Point(50, 224);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(51, 19);
            this.gunaLabel12.TabIndex = 21;
            this.gunaLabel12.Text = "Correo";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel13.Location = new System.Drawing.Point(42, 256);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(60, 19);
            this.gunaLabel13.TabIndex = 23;
            this.gunaLabel13.Text = "Telefono";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAyuda, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 478);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 42);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // btGuardar
            // 
            this.btGuardar.AnimationHoverSpeed = 0.07F;
            this.btGuardar.AnimationSpeed = 0.03F;
            this.btGuardar.BaseColor = System.Drawing.Color.Gray;
            this.btGuardar.BorderColor = System.Drawing.Color.Black;
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btGuardar.Image")));
            this.btGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btGuardar.Location = new System.Drawing.Point(459, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btGuardar.OnHoverImage = null;
            this.btGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btGuardar.Size = new System.Drawing.Size(149, 36);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btAyuda
            // 
            this.btAyuda.AnimationHoverSpeed = 0.07F;
            this.btAyuda.AnimationSpeed = 0.03F;
            this.btAyuda.BaseColor = System.Drawing.Color.Gray;
            this.btAyuda.BorderColor = System.Drawing.Color.Black;
            this.btAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAyuda.FocusedColor = System.Drawing.Color.Empty;
            this.btAyuda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btAyuda.ForeColor = System.Drawing.Color.White;
            this.btAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btAyuda.Image")));
            this.btAyuda.ImageSize = new System.Drawing.Size(20, 20);
            this.btAyuda.Location = new System.Drawing.Point(3, 3);
            this.btAyuda.Name = "btAyuda";
            this.btAyuda.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btAyuda.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAyuda.OnHoverForeColor = System.Drawing.Color.White;
            this.btAyuda.OnHoverImage = null;
            this.btAyuda.OnPressedColor = System.Drawing.Color.Black;
            this.btAyuda.Size = new System.Drawing.Size(146, 36);
            this.btAyuda.TabIndex = 1;
            this.btAyuda.Text = "Ayuda";
            // 
            // btCancelar
            // 
            this.btCancelar.AnimationHoverSpeed = 0.07F;
            this.btCancelar.AnimationSpeed = 0.03F;
            this.btCancelar.BaseColor = System.Drawing.Color.Gray;
            this.btCancelar.BorderColor = System.Drawing.Color.Black;
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btCancelar.Location = new System.Drawing.Point(307, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btCancelar.OnHoverImage = null;
            this.btCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btCancelar.Size = new System.Drawing.Size(146, 36);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.gunaGradient2Panel1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BaseColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColor = System.Drawing.Color.Silver;
            this.txtTelefono.Correo = false;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtTelefono.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.txtTelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.Limpiar = false;
            this.txtTelefono.Location = new System.Drawing.Point(107, 249);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.Size = new System.Drawing.Size(121, 30);
            this.txtTelefono.TabIndex = 24;
            this.txtTelefono.Text = "849-966-8555";
            this.txtTelefono.Validar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BaseColor = System.Drawing.Color.White;
            this.txtCorreo.BorderColor = System.Drawing.Color.Silver;
            this.txtCorreo.Correo = false;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.txtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Limpiar = false;
            this.txtCorreo.Location = new System.Drawing.Point(107, 213);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.Size = new System.Drawing.Size(121, 30);
            this.txtCorreo.TabIndex = 22;
            this.txtCorreo.Text = "solucionesmt@gonzalo.com";
            this.txtCorreo.Validar = false;
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbbEstado.BaseColor = System.Drawing.Color.White;
            this.cbbEstado.BorderColor = System.Drawing.Color.Silver;
            this.cbbEstado.Correo = false;
            this.cbbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.estados = Negocios.Componentes.ComboPersonal.Estados.Default;
            this.cbbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cbbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbEstado.ForeColor = System.Drawing.Color.Black;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbbEstado.Limpiar = false;
            this.cbbEstado.Location = new System.Drawing.Point(332, 213);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.cbbEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbEstado.Size = new System.Drawing.Size(121, 26);
            this.cbbEstado.TabIndex = 17;
            this.cbbEstado.Validar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BaseColor = System.Drawing.Color.White;
            this.txtDireccion.BorderColor = System.Drawing.Color.Silver;
            this.txtDireccion.Correo = false;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.txtDireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccion.Limpiar = false;
            this.txtDireccion.Location = new System.Drawing.Point(332, 245);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.Size = new System.Drawing.Size(291, 30);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.Text = "Al lado de la casa de Juan de los palote";
            this.txtDireccion.Validar = false;
            // 
            // cbbSector
            // 
            this.cbbSector.BackColor = System.Drawing.Color.Transparent;
            this.cbbSector.BaseColor = System.Drawing.Color.White;
            this.cbbSector.BorderColor = System.Drawing.Color.Silver;
            this.cbbSector.Correo = false;
            this.cbbSector.DataSource = this.sectorBindingSource;
            this.cbbSector.DisplayMember = "Descripcion";
            this.cbbSector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSector.estados = Negocios.Componentes.ComboPersonal.Estados.Default;
            this.cbbSector.FocusedColor = System.Drawing.Color.Empty;
            this.cbbSector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSector.ForeColor = System.Drawing.Color.Black;
            this.cbbSector.FormattingEnabled = true;
            this.cbbSector.Limpiar = false;
            this.cbbSector.Location = new System.Drawing.Point(332, 181);
            this.cbbSector.Name = "cbbSector";
            this.cbbSector.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.cbbSector.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbSector.Size = new System.Drawing.Size(121, 26);
            this.cbbSector.TabIndex = 9;
            this.cbbSector.Validar = false;
            this.cbbSector.ValueMember = "IdSector";
            // 
            // sectorBindingSource
            // 
            this.sectorBindingSource.DataMember = "Sector";
            this.sectorBindingSource.DataSource = this.matrizDataSetBindingSource;
            // 
            // matrizDataSetBindingSource
            // 
            this.matrizDataSetBindingSource.DataSource = this.matrizDataSet;
            this.matrizDataSetBindingSource.Position = 0;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMunicipio
            // 
            this.cbbMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.cbbMunicipio.BaseColor = System.Drawing.Color.White;
            this.cbbMunicipio.BorderColor = System.Drawing.Color.Silver;
            this.cbbMunicipio.Correo = false;
            this.cbbMunicipio.DataSource = this.matrizDataSetBindingSource;
            this.cbbMunicipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMunicipio.estados = Negocios.Componentes.ComboPersonal.Estados.Default;
            this.cbbMunicipio.FocusedColor = System.Drawing.Color.Empty;
            this.cbbMunicipio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMunicipio.ForeColor = System.Drawing.Color.Black;
            this.cbbMunicipio.FormattingEnabled = true;
            this.cbbMunicipio.Limpiar = false;
            this.cbbMunicipio.Location = new System.Drawing.Point(332, 149);
            this.cbbMunicipio.Name = "cbbMunicipio";
            this.cbbMunicipio.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.cbbMunicipio.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbMunicipio.Size = new System.Drawing.Size(121, 26);
            this.cbbMunicipio.TabIndex = 7;
            this.cbbMunicipio.Validar = false;
            // 
            // cbbProvincia
            // 
            this.cbbProvincia.BackColor = System.Drawing.Color.Transparent;
            this.cbbProvincia.BaseColor = System.Drawing.Color.White;
            this.cbbProvincia.BorderColor = System.Drawing.Color.Silver;
            this.cbbProvincia.Correo = false;
            this.cbbProvincia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProvincia.estados = Negocios.Componentes.ComboPersonal.Estados.Default;
            this.cbbProvincia.FocusedColor = System.Drawing.Color.Empty;
            this.cbbProvincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbProvincia.ForeColor = System.Drawing.Color.Black;
            this.cbbProvincia.FormattingEnabled = true;
            this.cbbProvincia.Items.AddRange(new object[] {
            "Santiago"});
            this.cbbProvincia.Limpiar = false;
            this.cbbProvincia.Location = new System.Drawing.Point(332, 117);
            this.cbbProvincia.Name = "cbbProvincia";
            this.cbbProvincia.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.cbbProvincia.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbProvincia.Size = new System.Drawing.Size(121, 26);
            this.cbbProvincia.TabIndex = 5;
            this.cbbProvincia.Validar = false;
            // 
            // cbbID
            // 
            this.cbbID.BackColor = System.Drawing.Color.Transparent;
            this.cbbID.BaseColor = System.Drawing.Color.White;
            this.cbbID.BorderColor = System.Drawing.Color.Silver;
            this.cbbID.Correo = false;
            this.cbbID.DataSource = this.tipoIdentificacionBindingSource;
            this.cbbID.DisplayMember = "Descripcion";
            this.cbbID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbID.estados = Negocios.Componentes.ComboPersonal.Estados.Default;
            this.cbbID.FocusedColor = System.Drawing.Color.Empty;
            this.cbbID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbID.ForeColor = System.Drawing.Color.Black;
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Limpiar = false;
            this.cbbID.Location = new System.Drawing.Point(107, 145);
            this.cbbID.Name = "cbbID";
            this.cbbID.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.cbbID.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbID.Size = new System.Drawing.Size(121, 26);
            this.cbbID.TabIndex = 2;
            this.cbbID.Validar = false;
            this.cbbID.ValueMember = "IdTipoIdentificacion";
            this.cbbID.SelectedIndexChanged += new System.EventHandler(this.comboPersonal1_SelectedIndexChanged);
            // 
            // tipoIdentificacionBindingSource
            // 
            this.tipoIdentificacionBindingSource.DataMember = "TipoIdentificacion";
            this.tipoIdentificacionBindingSource.DataSource = this.matrizDataSetBindingSource;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BaseColor = System.Drawing.Color.White;
            this.txtIdentificacion.BorderColor = System.Drawing.Color.Silver;
            this.txtIdentificacion.Correo = false;
            this.txtIdentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentificacion.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtIdentificacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdentificacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.txtIdentificacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdentificacion.Limpiar = false;
            this.txtIdentificacion.Location = new System.Drawing.Point(107, 177);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.Size = new System.Drawing.Size(121, 30);
            this.txtIdentificacion.TabIndex = 1;
            this.txtIdentificacion.Text = "031-0598455-9";
            this.txtIdentificacion.Validar = false;
            // 
            // txtRasonSocial
            // 
            this.txtRasonSocial.BaseColor = System.Drawing.Color.White;
            this.txtRasonSocial.BorderColor = System.Drawing.Color.Silver;
            this.txtRasonSocial.Correo = false;
            this.txtRasonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRasonSocial.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtRasonSocial.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRasonSocial.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.txtRasonSocial.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRasonSocial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRasonSocial.Limpiar = false;
            this.txtRasonSocial.Location = new System.Drawing.Point(107, 109);
            this.txtRasonSocial.Name = "txtRasonSocial";
            this.txtRasonSocial.PasswordChar = '\0';
            this.txtRasonSocial.Size = new System.Drawing.Size(121, 30);
            this.txtRasonSocial.TabIndex = 1;
            this.txtRasonSocial.Text = "Soluciones Gonsalo";
            this.txtRasonSocial.Validar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.Correo = false;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Limpiar = false;
            this.txtNombre.Location = new System.Drawing.Point(107, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Size = new System.Drawing.Size(121, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Juan Gonzales";
            this.txtNombre.Validar = false;
            // 
            // textPersonal1
            // 
            this.textPersonal1.BaseColor = System.Drawing.Color.Gainsboro;
            this.textPersonal1.BorderColor = System.Drawing.Color.Silver;
            this.textPersonal1.Correo = false;
            this.textPersonal1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPersonal1.estados = Negocios.Componentes.TextPersonal.Estados.Default;
            this.textPersonal1.FocusedBaseColor = System.Drawing.Color.White;
            this.textPersonal1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(126)))), ((int)(((byte)(35)))));
            this.textPersonal1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textPersonal1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textPersonal1.Limpiar = false;
            this.textPersonal1.Location = new System.Drawing.Point(107, 37);
            this.textPersonal1.Name = "textPersonal1";
            this.textPersonal1.PasswordChar = '\0';
            this.textPersonal1.Size = new System.Drawing.Size(68, 30);
            this.textPersonal1.TabIndex = 1;
            this.textPersonal1.Text = "0001";
            this.textPersonal1.Validar = false;
            // 
            // sectorTableAdapter
            // 
            this.sectorTableAdapter.ClearBeforeFill = true;
            // 
            // tipoIdentificacionTableAdapter
            // 
            this.tipoIdentificacionTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.cbbSector);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.cbbMunicipio);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.cbbProvincia);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.cbbID);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtRasonSocial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.textPersonal1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacto)).EndInit();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdentificacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Negocios.Componentes.TextPersonal textPersonal1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Negocios.Componentes.TextPersonal txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Negocios.Componentes.TextPersonal txtRasonSocial;
        private Negocios.Componentes.ComboPersonal cbbID;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Negocios.Componentes.TextPersonal txtIdentificacion;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Negocios.Componentes.ComboPersonal cbbProvincia;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Negocios.Componentes.ComboPersonal cbbMunicipio;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Negocios.Componentes.ComboPersonal cbbSector;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Negocios.Componentes.TextPersonal txtDireccion;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Negocios.Componentes.ComboPersonal cbbEstado;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Negocios.Componentes.TextPersonal txtTelefono;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Negocios.Componentes.TextPersonal txtCorreo;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaButton btGuardar;
        private Guna.UI.WinForms.GunaButton btAyuda;
        private Guna.UI.WinForms.GunaButton btCancelar;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDataGridView dataContacto;
        private Guna.UI.WinForms.GunaLinkLabel lbAgregarContacto;
        private System.Windows.Forms.DataGridViewLinkColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource matrizDataSetBindingSource;
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource sectorBindingSource;
        private MatrizDataSetTableAdapters.SectorTableAdapter sectorTableAdapter;
        private System.Windows.Forms.BindingSource tipoIdentificacionBindingSource;
        private MatrizDataSetTableAdapters.TipoIdentificacionTableAdapter tipoIdentificacionTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}