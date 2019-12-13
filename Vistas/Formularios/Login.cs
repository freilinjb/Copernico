using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Login : FormBase
    {
        public static int Centro;
        public static int IdUsuario;
        public static int IdEmpleado;
        public static string Usuario;

        DataSet ds;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btIniciarSeccion_Click(object sender, EventArgs e)
        {
            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                ds = Negocios.Utilidades.Ejecutar($"SELECT IdUsuario,IdEmpleado,Usuario,Clave,Estado FROM Usuario WHERE Usuario='{txtUsuario.Text.Trim().ToLower()}' AND Clave='{txtClave.Text.Trim()}'");

                if(ds.Tables[0].Rows.Count > 0)
                {
                    if (RadMessageBox.Show("Se ha logueado correctamente!! Bienvenido Sr", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        Vistas.Formularios.Menu menu = new Menu();
                        if(menu.ShowDialog() == DialogResult.OK) ;
                        this.Hide();
                    }
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
