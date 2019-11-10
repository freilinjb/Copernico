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
    public partial class Obra : FormBase
    {
        private int IdObra;

        public Obra()
        {
            InitializeComponent();
        }
        public Obra(int IdObra)
        {
            this.IdObra = IdObra;

            
        }
        public override bool Guardar()
        {
            return true;
        }

        private void Obra_Load(object sender, EventArgs e)
        {
            //Validar tema
            RadMessageBox.ThemeName = this.ThemeName;
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.matrizDataSet.Municipio);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.matrizDataSet.Provincia);

        }
    }
}
