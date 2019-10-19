using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Centro : Form
    {
        private static Centro Instancia;

        public static Centro ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Centro();

            Instancia.BringToFront();

            return Instancia;
        }
        private Centro()
        {
            InitializeComponent();
        }
    }   
}
