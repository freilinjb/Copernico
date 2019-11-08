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
    public partial class OrdenDeVenta : FormBase
    {
        public OrdenDeVenta()
        {
            InitializeComponent();
        }

        private void OrdenDeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCliente' Puede moverla o quitarla según sea necesario.
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

        }
    }
}
