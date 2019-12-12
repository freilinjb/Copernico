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
    public partial class Inventario : FormBase
    {

        private static Inventario Instancia;

        public static Inventario ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Inventario();

            Instancia.BringToFront();

            return Instancia;
        }

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaCentro' Puede moverla o quitarla según sea necesario.
            this.vistaCentroTableAdapter.Fill(this.matrizDataSet.VistaCentro);
            //cbbCentro.DataSource = Negocios.Utilidades.Ejecutar("SELECT C.IdCentro,T.Nombre FROM Centro C INNER JOIN Tercero T ON C.IdTercero = T.IdTercero").Tables[0];
            //cbbCentro.ValueMember = "IdCentro";
            //cbbCentro.DisplayMember = "Centro";

            //cbbCentro.SelectedIndex = 0;


            //cbbAlmacen.DataSource = Negocios.Utilidades.Ejecutar($"SELECT A.IdAlmacen,A.Descripcion AS Almacen FROM Almacen A INNER JOIN Centro C ON C.IdCentro = A.IdCentro WHERE C.IdCentro = {cbbCentro.SelectedValue}").Tables[0];
            //cbbAlmacen.ValueMember = "IdAlmacen";
            //cbbAlmacen.DisplayMember = "Almacen";

            //cbbAlmacen.SelectedIndex = 0;

            //cbbCentro.DataSource = Negocios.Utilidades.Ejecutar($"SELECT I.IdInventario,TI.Descripcion AS Inventario FROM Inventario I INNER JOIN Almacen A ON A.IdAlmacen = I.IdAlmacen INNER JOIN TipoInventario TI ON TI.IdTipoInventario = I.IdTipoInventario WHERE A.IdAlmacen = {cbbAlmacen.SelectedValue}").Tables[0];
            //cbbCentro.ValueMember = "IdInventario";
            //cbbCentro.DisplayMember = "Inventario";
        }

        private void cbbCentro_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(cbbCentro.SelectedIndex != -1)
            {
                cbbAlmacen.DataSource = Negocios.Utilidades.Ejecutar($"SELECT A.IdAlmacen,A.Descripcion AS Almacen FROM Almacen A INNER JOIN Centro C ON C.IdCentro = A.IdCentro WHERE C.IdCentro = {cbbCentro.SelectedValue}").Tables[0];
                cbbAlmacen.ValueMember = "IdAlmacen";
                cbbAlmacen.DisplayMember = "Almacen";
            }
        }
    }
}
