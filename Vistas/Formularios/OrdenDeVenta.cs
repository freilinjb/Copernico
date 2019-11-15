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
            this.estadoOrdenTableAdapter.Fill(this.matrizDataSet.EstadoOrden);
            this.tipoVentaTableAdapter.Fill(this.matrizDataSet.TipoVenta);
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT COUNT(NumCotizacion)+1 AS Mayor FROM OrdenDeVenta").Tables[0].Rows[0]["Mayor"].ToString();
            
        }

        public override bool Guardar()
        {
            bool bien = false;
            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {

            }
            return bien;
        }

        private void cbbPersonal1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }
    }
}
