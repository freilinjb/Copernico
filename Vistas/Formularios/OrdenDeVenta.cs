using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class OrdenDeVenta : FormBase
    {
        private DataSet ds;
        public OrdenDeVenta()
        {
            InitializeComponent();

            
        }

        private void OrdenDeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.TipoVenta' Puede moverla o quitarla según sea necesario.
            this.tipoVentaTableAdapter.Fill(this.matrizDataSet.TipoVenta);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentro' Puede moverla o quitarla según sea necesario.
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCliente' Puede moverla o quitarla según sea necesario.
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT COUNT(NumCotizacion)+1 AS Mayor FROM OrdenDeVenta").Tables[0].Rows[0]["Mayor"].ToString();
            
        }
    }
}
