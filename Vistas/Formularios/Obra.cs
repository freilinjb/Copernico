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
            if(Utilidades.Validar(this,errorProvider1) == false)
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
            }
            return true;
        }

        private void Obra_Load(object sender, EventArgs e)
        {

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
        }
    }
}
