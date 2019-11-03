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
    public partial class Activo : FormBase
    {
        public Activo()
        {
            InitializeComponent();
        }

        private void Activo_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Today.Year; i >= 1950; i--)
                cbbAnio.Items.Add(i.ToString());
        }

        public override bool Guardar()
        {
            bool bien = true;

            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                try
                {
                    
                }
                catch(Exception ex)
                {
                    
                }
            }

            return bien;
        }
    }
}
