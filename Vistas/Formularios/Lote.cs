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
    public partial class Lote : FormBase
    {
        public Lote()
        {
            InitializeComponent();
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            Centro instancia = Centro.ObtenerInstancia();
            instancia.MdiParent = this;
            instancia.Show();
        }
    }
}
