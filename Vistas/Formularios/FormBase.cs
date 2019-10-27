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
    public partial class FormBase : Telerik.WinControls.UI.RadForm
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public bool guardar;
        public bool imprimir;
        public bool desactivar;
        public bool cancelar;

        public virtual bool Guardar()
        {
            return true;
        }

        public virtual bool Imprimir()
        {
            return true;
        }
        public virtual bool Desactivar()
        {
            return true;
        }

        public virtual bool Cancelar()
        {
            return true;
        }
    }
}
