using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class Orden : Telerik.WinControls.UI.RadForm
    {
        private int NumOrden;
        private int IdUsuario;
        private int IdTercero;
        private DataSet ds;

        public Orden()
        {
            InitializeComponent();
            NumOrden = Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(NumOrden)+1 AS Mayor FROM Cliente").Tables[0].Rows[0]["Mayor"].ToString());
        }
    }
}
