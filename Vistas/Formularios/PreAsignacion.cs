using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;

namespace Vistas.Formularios
{
    public partial class PreAsignacion : FormBase
    {
        private DataSet ds;

        private static PreAsignacion Instancia;

        public static PreAsignacion ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new PreAsignacion();

            Instancia.BringToFront();

            return Instancia;
        }

        private PreAsignacion()
        {
            InitializeComponent();
        }



        private void PreAsignacion_Load(object sender, EventArgs e)
        {
            txtFecha.Value = DateTime.Today;
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.ViastaActivoFijoPreAsignacion' Puede moverla o quitarla según sea necesario.
            this.viastaActivoFijoPreAsignacionTableAdapter.Fill(this.matrizDataSet.ViastaActivoFijoPreAsignacion);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaEmpleado' Puede moverla o quitarla según sea necesario.
            this.vistaEmpleadoTableAdapter.Fill(this.matrizDataSet.VistaEmpleado);

            Negocios.Utilidades.Limpiar(this, errorProvider1);

            GroupDescriptor descriptor = new GroupDescriptor();
            descriptor.GroupNames.Add("Empleado", ListSortDirection.Ascending);
            this.dataPreAsignacion.GroupDescriptors.Add(descriptor);

            dataPreAsignacion.DataSource = Negocios.Utilidades.Ejecutar("SELECT * FROM VistaActivoFijosAsignados").Tables[0];

        }

        private void cbbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEmpleado.SelectedIndex != -1)
            {
                txtNombre.Text = cbbEmpleado.EditorControl.Rows[cbbEmpleado.EditorControl.CurrentRow.Index].Cells["Nombre"].Value.ToString();
                txtApellido.Text = cbbEmpleado.EditorControl.Rows[cbbEmpleado.EditorControl.CurrentRow.Index].Cells["Apellido"].Value.ToString();
                txtDepartamento.Text = cbbEmpleado.EditorControl.Rows[cbbEmpleado.EditorControl.CurrentRow.Index].Cells["Departamento"].Value.ToString();
                txtPuesto.Text = cbbEmpleado.EditorControl.Rows[cbbEmpleado.EditorControl.CurrentRow.Index].Cells["Puesto"].Value.ToString();

            }
            else
            {
                txtNombre.Text = null;
                txtApellido.Text = null;
                txtDepartamento.Text = null;
                txtPuesto.Text = null;
            }
        }

        private void cbbEquipo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        public override bool Guardar()
        {
            bool bien = false;

            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                try
                {
                    Negocios.Entidades.PreAsignacion pre = new Negocios.Entidades.PreAsignacion(
                    Convert.ToInt32(cbbEmpleado.EditorControl.Rows[cbbEmpleado.EditorControl.CurrentRow.Index].Cells["IdEmpleado"].Value.ToString()),
                    Convert.ToInt32(cbbEquipo.EditorControl.Rows[cbbEquipo.EditorControl.CurrentRow.Index].Cells["IdActivoFijo"].Value.ToString()),
                    txtFecha.Value.ToShortDateString(),
                    ((chAsignado.Value) ? 1 : 0)
                    );

                    ds = Negocios.Utilidades.Ejecutar(pre.getGuardar());

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        bien = true;
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



        private void cbbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbEquipo.SelectedIndex != -1)
            { 
                txtDescripcion.Text = cbbEquipo.EditorControl.Rows[cbbEquipo.EditorControl.CurrentRow.Index].Cells["ActivoFijo"].Value.ToString();
                txtSubGrupo.Text = cbbEquipo.EditorControl.Rows[cbbEquipo.EditorControl.CurrentRow.Index].Cells["SudGrupo"].Value.ToString();
                txtAnio.Text = cbbEquipo.EditorControl.Rows[cbbEquipo.EditorControl.CurrentRow.Index].Cells["Año"].Value.ToString();
                txtMarca.Text = cbbEquipo.EditorControl.Rows[cbbEquipo.EditorControl.CurrentRow.Index].Cells["Marca"].Value.ToString();
                txtEstado.Text = cbbEquipo.EditorControl.Rows[cbbEquipo.EditorControl.CurrentRow.Index].Cells["Estado"].Value.ToString();
            }
            else
            {
                txtDescripcion.Text = null;
                txtSubGrupo.Text = null;
                txtAnio.Text = null;
                txtMarca.Text = null;
            }
        }

        private void PreAsignacion_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if(Guardar())
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    dataPreAsignacion.DataSource = Negocios.Utilidades.Ejecutar("SELECT * FROM VistaActivoFijosAsignados").Tables[0];
                    cbbEmpleado.Focus();
                    Negocios.Utilidades.Limpiar(this,errorProvider1);
                }
            }
            else if(e.KeyCode == Keys.F2)
            {
                Negocios.Utilidades.Limpiar(this, errorProvider1);
            }
        }

        private void pagePrincipal_SelectedPageChanged(object sender, EventArgs e)
        {
            if(pagePrincipal.SelectedPage.Name == pageCentro.Name)
            {
                if(cbbCentro.SelectedIndex != -1)
                {
                    lbDescripcion.Text = cbbCentro.EditorControl.Rows[cbbCentro.EditorControl.CurrentRow.Index].Cells["Centro"].Value.ToString();
                }
                else
                {
                    lbDescripcion.Text = null;
                }
            }
            else if (pagePrincipal.SelectedPage.Name == pageCentro.Name)
            {
                if (cbbEmpleado.SelectedIndex != -1)
                {
                    lbDescripcion.Text = $"[{txtNombre.Text} {txtApellido.Text.Trim()}]";
                }
                else
                {
                    lbDescripcion.Text = null;
                }
            }
        }
    }
}
