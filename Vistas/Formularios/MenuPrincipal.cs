using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Centro instancia = Centro.ObtenerInstancia();
            instancia.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((FormBase)this.ActiveMdiChild).Guardar();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObtenerInstancia();
            cliente.MdiParent = this;
            cliente.Show();
        }
    }
}
