using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios.Componentes
{
    public partial class MultiCbbPersonal : Telerik.WinControls.UI.RadMultiColumnComboBox
    {
        public MultiCbbPersonal()
        {
            InitializeComponent();
        }

        public Boolean Limpiar { get; set; }
        public Boolean Validar { get; set; }
    }
}
