using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class PermisoAmbiental : FormBase
    {
        private DataSet ds;
        private static PermisoAmbiental Instancia;

        public static PermisoAmbiental ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new PermisoAmbiental();

            Instancia.BringToFront();

            return Instancia;
        }

        private PermisoAmbiental()
        {
            InitializeComponent();
        }

        public override bool Guardar()
        {
            bool bien = false;
            try

            {
                if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
                {
                    Negocios.Entidades.PermisoAmbiental permiso = new Negocios.Entidades.PermisoAmbiental(
                        Convert.ToInt32(txtCodigo.Text.Trim()),
                        (int)cbbTipoPermisoAmbiental.SelectedValue,
                        txtFechaEmitida.Value.ToShortDateString(),
                        txtFechaEmitida.Value.ToShortDateString(),
                        (int)cbbMina.SelectedValue,
                        (int)cbbMina.SelectedValue,
                        (int)cbbEstado.SelectedValue);

                    ds = Negocios.Utilidades.Ejecutar(permiso.getGuardar());
                    if (ds.Tables[0].Rows.Count > 0)
                        bien = true;
                }
            }
            catch (Exception ex)
            {
                bien = false;
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
            }
            return bien;
        }



        private void PermisoAmbiental_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;

            cbbMina.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdMina,Mina FROM VistaMina WHERE Estado = 'Abierta'").Tables[0];
            cbbMina.ValueMember = "IdMina";
            cbbMina.DisplayMember = "Mina";

            cbbTipoPermisoAmbiental.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoPermisoAmbiental,Descripcion AS TipoPermiso FROM TipoPermisoAmbiental").Tables[0];
            cbbTipoPermisoAmbiental.ValueMember = "IdTipoPermisoAmbiental";
            cbbTipoPermisoAmbiental.DisplayMember = "TipoPermiso";


            cbbEstado.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoPermiso,Descripcion AS Estado FROM EstadoPermisoAmbiental").Tables[0];
            cbbEstado.ValueMember = "IdEstadoPermiso";
            cbbEstado.DisplayMember = "Estado";

            

        }

        private void PermisoAmbiental_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (Guardar())
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    txtCodigo.Focus();
                }
            }
        }
    }
}
