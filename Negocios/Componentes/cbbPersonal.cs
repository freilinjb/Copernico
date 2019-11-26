using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Negocios.Componentes
{
    public partial class cbbPersonal : Telerik.WinControls.UI.RadDropDownList
    {
        public cbbPersonal()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Validar == true)
            {
                base.OnKeyPress(e);
                this.Refresh();
            }
        }
        public Boolean Limpiar { set; get; }
        public Boolean Validar { set; get; }
        public Boolean Correo { set; get; }
    }
}