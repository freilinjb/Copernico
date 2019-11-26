using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Negocios;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace Vistas.Formularios
{
    public partial class Obra : FormBase
    {
        private int IdObra;
        private DataSet ds;

        public Obra()
        {
            InitializeComponent();

            IdObra = Convert.ToInt32(Utilidades.Ejecutar("SELECT MAX(IdObra)+1 AS Mayor FROM Obra").Tables[0].Rows[0]["Mayor"].ToString());
        }
        public Obra(int IdObra)
        {
            this.IdObra = IdObra;

        }
        public override bool Guardar()
        {
            bool bien = true;

            try
            {
                if (Utilidades.Validar(this, errorProvider1) == false)
                {
                    Negocios.Entidades.Obra obra = new Negocios.Entidades.Obra(
                        IdObra,
                        Convert.ToInt32(cbbCliente.EditorControl.Rows[cbbCliente.EditorControl.CurrentRow.Index].Cells[0].Value.ToString()),
                        txtObra.Text.Trim(),
                        (int)cbbEncargado.SelectedValue,
                        (int)cbbProvincia.SelectedValue,
                        (int)cbbCiudad.SelectedValue,
                        (int)cbbMunicipio.SelectedValue,
                        (int)cbbSector.SelectedValue,
                        txtDireccion.Text.Trim(),
                        txtNota.Text.Trim(),
                        chEstado.ToggleStateMode == ToggleStateMode.Click ? true : false);

                    ds = Utilidades.Ejecutar(obra.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Algo ha pasado", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch(Exception ex)
            {
                bien = false;
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
            }
            return bien;
        }

        private void Obra_Load(object sender, EventArgs e)
        {


            //this.cbbCliente.AutoFilter = true;

            //FilterDescriptor filter = new FilterDescriptor();
            //filter.PropertyName = this.cbbCliente.DisplayMember;
            //filter.Operator = FilterOperator.Contains;
            //this.cbbCliente.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            //cbbCliente.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = true;


            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaContactoEncargado' Puede moverla o quitarla según sea necesario.
            this.vistaContactoEncargadoTableAdapter.Fill(this.matrizDataSet.VistaContactoEncargado);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCliente' Puede moverla o quitarla según sea necesario.
            this.vistaClienteTableAdapter.Fill(this.matrizDataSet.VistaCliente);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaContactoEncargado' Puede moverla o quitarla según sea necesario.
            this.vistaContactoEncargadoTableAdapter.Fill(this.matrizDataSet.VistaContactoEncargado);

            imprimir = false;

            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Sector' Puede moverla o quitarla según sea necesario.
            this.sectorTableAdapter.Fill(this.matrizDataSet.Sector);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.matrizDataSet.Ciudad);
            //Validar tema
            RadMessageBox.ThemeName = this.ThemeName;
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.matrizDataSet.Municipio);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.matrizDataSet.Provincia);

            Utilidades.Limpiar(this, errorProvider1);
        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCliente.SelectedIndex >= 0)
            {
                if (cbbCliente.EditorControl.Rows.Count > 0)
                {
                    if (cbbCliente.Text != null)
                        lbCliente.Text = cbbCliente.EditorControl.Rows[cbbCliente.EditorControl.CurrentRow.Index].Cells[3].Value.ToString();

                    else
                        cbbCliente.Text = null;
                }
            }
        }

        private void Obra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Guardar();
            }
        }
    }
}
