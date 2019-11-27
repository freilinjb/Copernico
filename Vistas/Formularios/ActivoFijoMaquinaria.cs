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
    public partial class ActivoFijoMaquinaria : FormBase
    {
        public ActivoFijoMaquinaria()
        {
            InitializeComponent();
        }

        private void Activo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.matrizDataSet.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaPropietario' Puede moverla o quitarla según sea necesario.
            this.vistaPropietarioTableAdapter.Fill(this.matrizDataSet.VistaPropietario);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Color' Puede moverla o quitarla según sea necesario.
            this.colorTableAdapter.Fill(this.matrizDataSet.Color);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.matrizDataSet.Modelo);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.matrizDataSet.Marca);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.SubGrupoActivoFijo' Puede moverla o quitarla según sea necesario.
            this.subGrupoActivoFijoTableAdapter.Fill(this.matrizDataSet.SubGrupoActivoFijo);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.GrupoActivoFijo' Puede moverla o quitarla según sea necesario.
            this.grupoActivoFijoTableAdapter.Fill(this.matrizDataSet.GrupoActivoFijo);

            txtActivoFijo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdActivoFijo)+1 AS Mayor FROM ActivoFijo").Tables[0].Rows[0]["Mayor"].ToString();

            for (int i = DateTime.Today.Year; i >= 1985; i--)
                cbbAnio.Items.Add(i.ToString());

            Negocios.Utilidades.Limpiar(this, errorProvider1);
        }

        public override bool Guardar()
        {
            bool bien = true;

            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                try
                {
                    Negocios.Entidades.Maquinaria vehiculo = new Negocios.Entidades.Maquinaria(
                        Convert.ToInt32(txtActivoFijo.Text),
                        txtDescripcion.Text.Trim(),
                        (int)cbbMarca.SelectedValue,
                        (int)cbbModelo.SelectedValue,
                        (int)cbbMotor.SelectedValue,
                       (int)cbbColor.SelectedValue,
                        Convert.ToInt32(cbbAnio.Text),
                        txtPlaca.Text,
                        (int)cbbPropietario.SelectedValue,
                        (int)cbbEstatus.SelectedValue);
                }
                catch(Exception ex)
                {
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                }
            }

            return bien;
        }

        private void ActivoFijoMaquinaria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Guardar();
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
