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
            //this.orbraMantenimientoVentaTableAdapter.Fill(this.matrizDataSet.OrbraMantenimientoVenta);
            this.formaDePagoTableAdapter.Fill(this.matrizDataSet.FormaDePago);
            this.tipoVentaTableAdapter.Fill(this.matrizDataSet.TipoVenta);
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            txtNumOrden.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM OrdenDeVenta").Tables[0].Rows[0]["Mayor"].ToString();

            cbbTipoCredito.DataSource = Negocios.Utilidades.Ejecutar("SELECT * FROM TipoCredito").Tables[0];
            cbbTipoCredito.DisplayMember = "Descripcion";
            cbbTipoCredito.ValueMember = "IdTipoCredito";

            Negocios.Utilidades.Limpiar(this, errorProvider1);

        }

        public override bool Guardar()
        {
            bool bien = false;
            errorProvider1.Clear();
            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {

            }
            return bien;
        }
        

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCliente.SelectedIndex != -1)
            {
                txtCliente.Text = cbbCliente.EditorControl.Rows[cbbCliente.EditorControl.CurrentRow.Index].Cells[3].Value.ToString();
                cbbCliente.Text = string.Format("{0:000000}", Convert.ToInt32(cbbCliente.Text.Trim()));

                ds = Negocios.Utilidades.Ejecutar($"SELECT * FROM VistaMantenimientoObra WHERE IdCliente = {cbbCliente.Text.Trim()} AND Estado = 1");

                if(ds.Tables[0].Rows.Count > 0)
                {
                    cbbObra.Enabled = true;
                    cbbObra.DataSource = ds.Tables[0];
                }
                else
                {
                    cbbObra.Enabled = false;
                    errorProvider1.SetError(cbbObra, "El cliente no contiene ningun proyecto registrado a su nombre");
                    txtObra.Text = null;
                    txtTelefono.Text = null;
                    txtCorreo.Text = null;
                }
            }

            if (string.IsNullOrEmpty(cbbCliente.Text.Trim()))
            {
                txtCliente.Text = null;

                txtTelefono.Text = null;
                txtCorreo.Text = null;
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
            if (cbbTipoVenta.SelectedIndex != -1)
            {
                if (cbbTipoVenta.SelectedIndex == 0)
                {
                    cbbFormaPago.SelectedIndex = -1;
                    cbbFormaPago.Enabled = false;
                    cbbFormaPago.Validar = false;

                    cbbTipoCredito.Enabled = true;
                    cbbTipoCredito.Validar = true;



                }
                else
                {
                    cbbTipoCredito.SelectedIndex = -1;
                    cbbTipoCredito.Enabled = false;
                    cbbTipoCredito.Validar = false;

                    cbbFormaPago.Enabled = true;
                    cbbFormaPago.Validar = true;
                }
            }
        }

        private void cbbObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbObra.SelectedIndex != -1)
            {
                if (cbbObra.EditorControl.Rows.Count > 0)
                {
                    cbbObra.Enabled = true;
                    txtObra.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[1].Value.ToString();
                    txtEncargado.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[5].Value.ToString();
                    txtTelefono.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[6].Value.ToString();
                    txtCorreo.Text = cbbObra.EditorControl.Rows[cbbObra.EditorControl.CurrentRow.Index].Cells[7].Value.ToString();
                    errorProvider1.Clear();
                }
            }
            else
            {
                txtObra.Text = null;
                txtTelefono.Text = null;
                txtCorreo.Text = null;
                txtEncargado.Text = null;
            }
        }
    }
}
