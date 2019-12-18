using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;

namespace Vistas.Formularios
{
    public partial class ProyeccionProduccion : FormBase
    {
        private static ProyeccionProduccion Instancia;

        public static ProyeccionProduccion ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new ProyeccionProduccion();

            Instancia.BringToFront();

            return Instancia;
        }

        public ProyeccionProduccion()
        {
            InitializeComponent();
        }

        private void ProyeccionProduccion_Load(object sender, EventArgs e)
        {
            dataProyeccion.DataSource = Negocios.Utilidades.Ejecutar("SELECT * FROM VistaProyeccion").Tables[0];


            GroupDescriptor descriptor2 = new GroupDescriptor();
            GroupDescriptor descriptor3 = new GroupDescriptor();
            GroupDescriptor descriptor4 = new GroupDescriptor();

            descriptor2.GroupNames.Add("Centro", ListSortDirection.Ascending);
            descriptor3.GroupNames.Add("Mes", ListSortDirection.Ascending);
            //descriptor4.GroupNames.Add("Inventario", ListSortDirection.Ascending);


            this.dataProyeccion.GroupDescriptors.Add(descriptor2);
            this.dataProyeccion.GroupDescriptors.Add(descriptor3);
            this.dataProyeccion.GroupDescriptors.Add(descriptor4);

        }
    }
}
