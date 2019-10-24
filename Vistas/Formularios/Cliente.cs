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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            //Guna.UI.Lib.GraphicsHelper.DrawBorder(,);
        }

        private Cliente(int n)
        {

        }

        private void comboPersonal1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            dataContacto.Rows.Add("soluciones@rtcocoa.com","849-847-99984", "Raul martes","FACTURACION");
            dataContacto.Rows.Add("raulrt@hotmail.com","847-963-8525", "Endy Metralla","CUENTAS POR COBRAR");
            dataContacto.Rows.Add("freilinjb@mail.com","741-958-9654", "Freilin Jose","ELECTRICIDAD");
        }
    }
}
