using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Empleado : FormBase
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        public override bool Guardar()
        {
            bool bien = true;
            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                try
                {
                    Negocios.Entidades.Empleado centro = new Negocios.Entidades.Empleado(
                    Convert.ToInt32(lbCodigo.Text.Trim()),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtApodo.Text.Trim(),
                    (int)cbbEstadoCivil.SelectedValue,
                    (int)cbbSexo.SelectedValue,
                    (int)cbbTipoIndentificacion.SelectedValue,
                    txtIdentificacion.Text.Trim(),
                    txtFechNacimiento.Text.Trim(),
                    (int)cbbProvincia.SelectedValue,
                    (int)cbbCiudad.SelectedValue,
                    (int)cbbMunicipio.SelectedValue,
                    (int)cbbSector.SelectedValue,
                    txtDireccion.Text.Trim(),
                    txtFechaIngreso.Text.(),
                    (int)cbbTipoIndentificacion.SelectedValue,
                    (int)cbbNomina.SelectedValue,
                    (int)cbbTurno.SelectedValue,
                    (int)cbbDepartamento.SelectedValue,
                    (int)cbbPuesto.SelectedValue,
                    (int)cbbEstado.SelectedValue);

                    ds = Negocios.Utilidades.Ejecutar(centro.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        Negocios.Utilidades.Limpiar(this, errorProvider1);

                        lbCodigo.Text = string.Format("{0:00000}",Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString()));

                        toolRegistro.Text = "Nuevo Registro";

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

        private void Empleado_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {

            }
        }
    }
}
