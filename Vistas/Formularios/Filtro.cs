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
    public partial class Filtro : FormBase
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Tamiz' Puede moverla o quitarla según sea necesario.
            this.tamizTableAdapter.Fill(this.matrizDataSet.Tamiz);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Tamiz' Puede moverla o quitarla según sea necesario.
            this.tamizTableAdapter.Fill(this.matrizDataSet.Tamiz);
            cbbUnidad.SelectedIndex = 0;
        }
    }
}
