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
        private DataSet ds;

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dataInventario.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoInventario,Descripcion AS Inventario FROM TipoInventario").Tables[0];

            cbbTipoInventario.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoInventario,Descripcion AS Inventario FROM TipoInventario").Tables[0];
            cbbTipoInventario.ValueMember = "IdTipoInventario";
            cbbTipoInventario.DisplayMember = "Inventario";


        }

        public override bool Guardar()
        {
            bool bien = true;

            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                try
                {
                    ds = Negocios.Utilidades.Ejecutar($"EXEC RegistroTipoInventarioPorAlmacen {(int)cbbAlmacen.SelectedValue},{(int)cbbTipoInventario.SelectedValue}");

                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    bien = false;
                }
            }
            return bien;
        }

        private void Inventario_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {

            }
            else if(e.KeyCode == Keys.F2)
            {
                Negocios.Utilidades.Limpiar(this, errorProvider1);
            }
        }
    }
}
