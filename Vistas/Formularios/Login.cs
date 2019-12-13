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
                //ds = Negocios.Utilidades.Ejecutar("")
            }
        }
    }
}
