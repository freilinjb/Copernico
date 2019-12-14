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
        private DataSet ds;

        public Empleado()
        {
            InitializeComponent();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            IdMayor();

            toolRegistro.Text = "Nuevo Registro";

            cbbTipoIndentificacion.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoIdentificacion,Descripcion AS TipoIdentificacio FROM TipoIdentificacion").Tables[0];
            cbbTipoIndentificacion.ValueMember = "IdTipoIdentificacion";
            cbbTipoIndentificacion.DisplayMember = "TipoIdentificacio";

            cbbSexo.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdSexo, Descripcion AS Sexo FROM Sexo").Tables[0];
            cbbSexo.ValueMember = "IdSexo";
            cbbSexo.DisplayMember = "Sexo";

            cbbEstadoCivil.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoCivil, Descripcion AS EstadoCivil FROM EstadoCivil ").Tables[0];
            cbbEstadoCivil.ValueMember = "IdEstadoCivil";
            cbbEstadoCivil.DisplayMember = "EstadoCivil";

            cbbEstado.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoEmpleado,Descripcion AS Estado FROM EstadoEmpleado").Tables[0];
            cbbEstado.ValueMember = "IdEstadoEmpleado";
            cbbEstado.DisplayMember = "Estado";

            cbbPuesto.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdPuesto,IdDepartamento,Descripcion AS Puesto FROM Puesto").Tables[0];
            cbbPuesto.ValueMember = "IdPuesto";
            cbbPuesto.DisplayMember = "Puesto";

            cbbTipoContrato.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoContrato,Descripcion AS TipoContrato FROM TipoContrato").Tables[0];
            cbbTipoContrato.ValueMember = "IdTipoContrato";
            cbbTipoContrato.DisplayMember = "TipoContrato";

            cbbNomina.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoNomina,Descripcion AS TipoNomina FROM TipoNomina").Tables[0];
            cbbNomina.ValueMember = "IdTipoNomina";
            cbbNomina.DisplayMember = "TipoNomina";

            cbbDepartamento.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdDepartamento,T.Nombre AS Departamento FROM Departamento D INNER JOIN Tercero T ON T.IdTercero = D.IdTercero").Tables[0];
            cbbDepartamento.ValueMember = "IdDepartamento";
            cbbDepartamento.DisplayMember = "Departamento";

            cbbTurno.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoTurno,Descripcion AS TipoTurno from TipoTurno").Tables[0];
            cbbTurno.ValueMember = "IdTipoTurno";
            cbbTurno.DisplayMember = "TipoTurno";

            cbbProvincia.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdProvincia,Descripcion AS Provincia FROM Provincia").Tables[0];
            cbbProvincia.ValueMember = "IdProvincia";
            cbbProvincia.DisplayMember = "Provincia";

            cbbCiudad.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdCiudad,IdProvincia,Descripcion AS Ciudad FROM Ciudad").Tables[0];
            cbbCiudad.ValueMember = "IdCiudad";
            cbbCiudad.DisplayMember = "Ciudad";

            cbbMunicipio.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdMunicipio,IdProvincia,Descripcion AS Municipio FROM Municipio").Tables[0];
            cbbMunicipio.ValueMember = "IdMunicipio";
            cbbMunicipio.DisplayMember = "Municipio";

            cbbSector.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdSector,Descripcion AS Sector FROM Sector").Tables[0];
            cbbSector.ValueMember = "IdSector";
            cbbSector.DisplayMember = "Sector";

        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdEmpleado)+1 AS Mayor FROM Empleado");
            lbCodigo.Text = string.Format("{0:00000}",Convert.ToInt32((ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString()));
        }

        public override bool Guardar()
        {
            bool bien = false;

            if (Negocios.Utilidades.Validar(radPanel1, errorProvider1) == false)
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
                    txtFechaIngreso.Text.Trim(),
                    (int)cbbTipoIndentificacion.SelectedValue,
                    (int)cbbNomina.SelectedValue,
                    (int)cbbTurno.SelectedValue,
                    (int)cbbDepartamento.SelectedValue,
                    (int)cbbPuesto.SelectedValue,
                    (int)cbbEstado.SelectedValue);

                    ds = Negocios.Utilidades.Ejecutar(centro.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        bien = true;
                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

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
                if (Guardar())
                {

                    Negocios.Utilidades.Limpiar(this, errorProvider1);

                    lbCodigo.Text = string.Format("{0:00000}", Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(IdCentro)+1 AS Mayor FROM Centro").Tables[0].Rows[0]["Mayor"].ToString()));

                    toolRegistro.Text = "Nuevo Registro";
                }
            }
        }
    }
}
