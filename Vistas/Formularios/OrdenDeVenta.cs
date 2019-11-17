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
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.FormaDePago' Puede moverla o quitarla según sea necesario.
            this.formaDePagoTableAdapter.Fill(this.matrizDataSet.FormaDePago);
            this.estadoOrdenTableAdapter.Fill(this.matrizDataSet.EstadoOrden);
            this.tipoVentaTableAdapter.Fill(this.matrizDataSet.TipoVenta);
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM OrdenDeVenta").Tables[0].Rows[0]["Mayor"].ToString();

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

        private void radSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void lbObra_Click(object sender, EventArgs e)
        {

        }

        private void lbCliente_Click(object sender, EventArgs e)
        {

        }

        private void radLabel13_Click(object sender, EventArgs e)
        {

        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCliente.EditorControl.Rows.Count > 0)
            {
                if(cbbCliente.SelectedIndex >= 0  || !string.IsNullOrEmpty(cbbCliente.Text))
                {

                }
            }
        }

        private void OrdenDeVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Guardar();
            }
        }

        private void cbbTipoCredito_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
        }

        private void cbbTipoVenta_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbbTipoVenta.SelectedIndex >= 0)
            {
                if (cbbTipoVenta.Text.Trim() == "Credito")
                {
                    cbbFormaPago.SelectedIndex = -1;
                    cbbFormaPago.Enabled = false;

                    cbbTipoCredito.Enabled = true;

                }
                else if(cbbTipoVenta.Text.Trim() == "Contado")
                {
                    cbbTipoCredito.SelectedIndex = -1;
                    cbbTipoCredito.Enabled = false;

                    cbbFormaPago.Enabled = true;
                }
            }
        }
    }
}
