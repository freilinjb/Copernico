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
            //Centro instancia = Centro.ObtenerInstancia();
            //instancia.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((FormBase)this.ActiveMdiChild).Guardar();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            Obra obra = Obra.ObtenerInstancia();
            obra.MdiParent = this;
            obra.Show();
        }

        private void toolButton_Click(object sender, EventArgs e)
        {
            //((FormBase)this.ActiveMdiChild).Guardar();


        }

        private void cbbPersonal1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            MessageBox.Show(((FormBase)this.ActiveMdiChild).Text);
            //if(cbbPersonal1.SelectedIndex == 1)
            //{
            //    if (((FormBase)this.ActiveMdiChild).guardar)
            //        toolButton.Enabled = true;

            //}
            //else
            //    toolButton.Enabled = false;
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void horizontalToolStrip_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vertocalTooltrip_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void cascadaToolTrip_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        
        }

        private void menuExploradorProducto_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void menuObra_Click(object sender, EventArgs e)
        {
            Obra instancia = Obra.ObtenerInstancia();
            instancia.MdiParent = this;
            instancia.Show();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            Cliente instancia = Cliente.ObtenerInstancia();
            instancia.MdiParent = this;
            instancia.Show();
        }

        private void menuFiltro_Click(object sender, EventArgs e)
        {
            Filtro instancia = Filtro.ObtenerInstancia();
            instancia.MdiParent = this;
            instancia.Show();
        }

        private void MenuPrincipal_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void menuActivoFijo_Click(object sender, EventArgs e)
        {
            ActivoCubicacion instancia = ActivoCubicacion
        }
    }
}
