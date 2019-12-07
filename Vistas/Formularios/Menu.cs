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
    public partial class Menu : FormBase
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            Centro instancia = Centro.ObtenerInstancia();
            instancia.MdiParent = this;
            instancia.Show();
        }

        private void btObra_Click(object sender, EventArgs e)
        {
            Obra obra = Obra.ObtenerInstancia();
            obra.MdiParent = this;
            obra.Show();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObtenerInstancia();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void btMina_Click(object sender, EventArgs e)
        {
            Mina mina = Mina.ObtenerInstancia();
            mina.MdiParent = this;
            mina.Show();
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            OrdenDeVenta venta = OrdenDeVenta.ObtenerInstancia();
            venta.MdiParent = this;
            venta.Show();
        }

        private void btAnalisis_Click(object sender, EventArgs e)
        {
            Analisis analisis = Analisis.ObtenerInstancia();
            analisis.MdiParent = this;
            analisis.Show();
        }
    }
}
