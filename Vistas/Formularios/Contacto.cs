using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Telerik.WinControls;

namespace Vistas.Formularios
{
    public partial class Contacto : FormBase
    {
        private DataSet ds;
        public Negocios.Entidades.Contacto ct;

        public Contacto()
        {
            InitializeComponent();
        }

        public Contacto(int IdTerceroClienteProveedor)
        {
            InitializeComponent();
            ct = new Negocios.Entidades.Contacto();
            ct.IdTerceroClienteProveedor = IdTerceroClienteProveedor;
        }


        private void Conduce_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.matrizDataSet.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.TipoTelefono' Puede moverla o quitarla según sea necesario.
            this.tipoTelefonoTableAdapter.Fill(this.matrizDataSet.TipoTelefono);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Puesto' Puede moverla o quitarla según sea necesario.
            this.puestoTableAdapter.Fill(this.matrizDataSet.Puesto);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.matrizDataSet.Departamento);
            RadMessageBox.SetThemeName("VisualStudio2012Light");

            cbbDepartamento.SelectedIndex = -1;
            cbbPuesto.SelectedIndex = -1;
            cbbTipoTelefono.SelectedIndex = -1;
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Contacto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if(Utilidades.Validar(this,errorProvider1) == false)
                {
                    ct.IdContacto = Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(IdContacto)+1 Mayor FROM Contacto").Tables[0].Rows[0]["Mayor"].ToString().Trim());
                    ct.Nombre = txtNombre.Text.Trim();
                    ct.IdDepartamento = Convert.ToInt32(cbbDepartamento.SelectedValue.ToString().Trim());
                    ct.IdPuesto = Convert.ToInt32(cbbPuesto.SelectedValue.ToString().Trim());
                    ct.Telefono = txtTelefono.Text.Trim();
                    ct.Correo = txtCorreo.Text.Trim();
                    ct.IdTipoTelefono = Convert.ToInt32(cbbTipoTelefono.SelectedValue.ToString().Trim());
                    ct.Estado = (chEstado.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click) ? 1 : 0;
                    try
                    {
                        //if (Utilidades.Ejecutar(ct.getGuardar()).Tables[0].Rows.Count > 0)
                        //{
                        //    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        //    Utilidades.Limpiar(this, errorProvider1);
                        //    this.DialogResult = DialogResult.OK;
                        //}
                        this.DialogResult = DialogResult.OK;
                    }
                    catch(Exception ex)
                    {
                        RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    }
                }
            }

            if (e.KeyCode == Keys.Escape)
                this.Dispose();
        }
    }
}
