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
    public partial class TipoInventario : FormBase
    {
        private DataSet ds;

        public TipoInventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdTipoInventario)+1 Mayor FROM TipoInventario").Tables[0].Rows[0]["Mayor"].ToString();
            dataInventario.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoInventario,Descripcion AS Inventario FROM TipoInventario").Tables[0];
        }

        public override bool Guardar()
        {
            bool bien = true;

            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                try
                {
                    ds = Negocios.Utilidades.Ejecutar($"EXEC RegistrarTipoInventario {txtCodigo.Text},'{txtTipoInventario.Text.Trim().ToUpper()}'");

                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        txtCodigo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdTipoInventario)+1 Mayor FROM TipoInventario").Tables[0].Rows[0]["Mayor"].ToString();
                        dataInventario.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoInventario,Descripcion AS Inventario FROM TipoInventario").Tables[0];
                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                        txtTipoInventario.Text = null;
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
                if(Guardar())
                    lbEstatus.Text = "Nuevo registro";
            }
            else if(e.KeyCode == Keys.F2)
            {
                Negocios.Utilidades.Limpiar(this, errorProvider1);
            }
        }

        private void dataInventario_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataInventario.Rows.Count > 0)
            {
                if (RadMessageBox.Show($"Desea editar el Almacen {dataInventario.Rows[dataInventario.CurrentRow.Index].Cells["Inventario"].Value.ToString()}", "INFORMACION DEL SISTEMA", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    txtCodigo.Text = dataInventario.Rows[dataInventario.CurrentRow.Index].Cells["IdTipoInventario"].Value.ToString();
                    txtTipoInventario.Text = dataInventario.Rows[dataInventario.CurrentRow.Index].Cells["Inventario"].Value.ToString();
                    lbEstatus.Text = "Modo edicion";
                }
            }
        }
    }
}
