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
    public partial class Ordenes : FormBase
    {
        private DataSet ds;
        public Ordenes()
        {
            InitializeComponent();
        }

        private void OrdenDeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.FormaDePago' Puede moverla o quitarla según sea necesario.
            //this.formaDePagoTableAdapter.Fill(this.matrizDataSet.FormaDePago);
           // this.estadoOrdenTableAdapter.Fill(this.matrizDataSet.EstadoOrden);
          //  this.tipoVentaTableAdapter.Fill(this.matrizDataSet.TipoVenta);
         //   this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
          //  this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

         //   Negocios.Utilidades.Limpiar(this, ErrorProvider1);
            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM Orden").Tables[0].Rows[0]["Mayor"].ToString();
        }

        public override bool Guardar()
        {
            bool bien = false;
          //  if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {

            }
            return bien;
        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   if (cbbCliente.EditorControl.Rows.Count > 0)
            {
                if (cbbCliente.SelectedIndex >= 0 || !string.IsNullOrEmpty(cbbCliente.Text))
                {

                }
            }
        }
    }
}
