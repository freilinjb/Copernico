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
    public partial class ActivoCubicacion : FormBase
    {
        private DataSet ds;
        public ActivoCubicacion()
        {
            InitializeComponent();
        }

        private void Activo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaMotor' Puede moverla o quitarla según sea necesario.
            this.vistaMotorTableAdapter.Fill(this.matrizDataSet.VistaMotor);
            RadMessageBox.ThemeName = this.ThemeName;
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.matrizDataSet.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaPropietario' Puede moverla o quitarla según sea necesario.
            this.vistaPropietarioTableAdapter.Fill(this.matrizDataSet.VistaPropietario);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Color' Puede moverla o quitarla según sea necesario.
            this.colorTableAdapter.Fill(this.matrizDataSet.Color);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.matrizDataSet.Modelo);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.matrizDataSet.Marca);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.SubGrupoActivoFijo' Puede moverla o quitarla según sea necesario.
            this.subGrupoActivoFijoTableAdapter.Fill(this.matrizDataSet.SubGrupoActivoFijo);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.GrupoActivoFijo' Puede moverla o quitarla según sea necesario.
            this.grupoActivoFijoTableAdapter.Fill(this.matrizDataSet.GrupoActivoFijo);

            txtActivoFijo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdActivoFijo)+1 AS Mayor FROM ActivoFijo").Tables[0].Rows[0]["Mayor"].ToString();
            cbbEstatus.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoActivoFijo,Descripcion AS Estado FROM EstadoActivoFijo").Tables[0];
            cbbEstatus.ValueMember = "IdEstadoActivoFijo";
            cbbEstatus.DisplayMember = "Estado";

            for (int i = DateTime.Today.Year; i >= 1985; i--)
                cbbAnio.Items.Add(i.ToString());

            Negocios.Utilidades.Limpiar(this, errorProvider1);
        }

        public override bool Guardar()
        {
            bool bien = true;
            validarComponentes();
            errorProvider1.Clear();
            validarComponentes();
            if (Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                try
                {

                    int IdMaquinaria = Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(IdMaquinaria)+1 AS Mayor FROM Maquinaria").Tables[0].Rows[0]["Mayor"].ToString());

                    Negocios.Entidades.ActivoFijoMaquinaria vehiculo = new Negocios.Entidades.ActivoFijoMaquinaria(
                        Convert.ToInt32(txtActivoFijo.Text),
                        IdMaquinaria,
                        txtDescripcion.Text.Trim(),
                        (int)cbbMarca.SelectedValue,
                        (int)cbbModelo.SelectedValue,
                        (int)cbbMotor.SelectedValue,
                        (int)cbbColor.SelectedValue,
                        Convert.ToInt32(cbbAnio.Text),
                        (int)cbbPropietario.SelectedValue,
                        txtPlaca.Text.Trim(),
                        1,
                        (int)cbbEstatus.SelectedValue,
                        (int)cbbGrupo.SelectedValue,
                        (int)cbbSubGrupo.SelectedValue);

                    ds = Negocios.Utilidades.Ejecutar(vehiculo.getGuardar());

                    if(ds.Tables[0].Rows.Count > 0)
                    {

                        RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                        Negocios.Utilidades.Limpiar(this, errorProvider1);
                        txtActivoFijo.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdActivoFijo)+1 AS Mayor FROM ActivoFijo").Tables[0].Rows[0]["Mayor"].ToString();
                    }
                }
                catch(Exception ex)
                {
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                }
            }

            return bien;
        }

        private bool validarComponentes()
        {
            bool bien = true;
            if(((string.IsNullOrEmpty(txtCajonAlto.Text) && string.IsNullOrEmpty(txtCajonAncho.Text)) && string.IsNullOrEmpty(txtCajonLargo.Text)) && (!string.IsNullOrEmpty(txtCajonAlto.Text) && (!string.IsNullOrEmpty(txtCajonAncho.Text) && !string.IsNullOrEmpty(txtCajonLargo.Text))))
            {
                errorProvider1.SetError(txtCajon, "Datos incompletos");
            }

            if (((string.IsNullOrEmpty(txtTablonAlto.Text) && string.IsNullOrEmpty(txtTablonAncho.Text)) && string.IsNullOrEmpty(txtTablonLargo.Text)) && (!string.IsNullOrEmpty(txtTablonAlto.Text) && (!string.IsNullOrEmpty(txtTablonAncho.Text) && !string.IsNullOrEmpty(txtTablonLargo.Text))))
            {
                errorProvider1.SetError(txtTablon, "Datos incompletos");
            }

            if (((string.IsNullOrEmpty(txtBotellaAlto.Text) && string.IsNullOrEmpty(txtBotellaAncho.Text)) && string.IsNullOrEmpty(txtBotellaLargo.Text)) && (!string.IsNullOrEmpty(txtBotellaAlto.Text) && (!string.IsNullOrEmpty(txtBotellaAncho.Text) && !string.IsNullOrEmpty(txtBotellaLargo.Text))))
            {
                errorProvider1.SetError(txtBotella, "Datos incompletos");
            }

            return bien;
        }

        private void ActivoFijoMaquinaria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Guardar();
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtBotellaAlto_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                if (!string.IsNullOrEmpty(txtBotellaAlto.Text.Trim()) && !string.IsNullOrEmpty(txtBotellaAncho.Text.Trim()) && !string.IsNullOrEmpty(txtBotellaLargo.Text.Trim()))
                {
                    txtBotella.Text = Convert.ToSingle(Convert.ToSingle(txtBotellaLargo.Text.Trim()) * Convert.ToSingle(txtBotellaAncho.Text.Trim()) * Convert.ToSingle(txtBotellaAlto.Text.Trim())).ToString();
                    VericarStatusCalculado();
                }
            }
        }

        private void txtTablonAlto_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                if (!string.IsNullOrEmpty(txtTablonAlto.Text.Trim()) && !string.IsNullOrEmpty(txtTablonAncho.Text.Trim()) && !string.IsNullOrEmpty(txtTablonLargo.Text.Trim()))
                {
                    txtTablon.Text = Convert.ToSingle(Convert.ToSingle(txtTablonAlto.Text.Trim()) * Convert.ToSingle(txtTablonAncho.Text.Trim()) * Convert.ToSingle(txtTablonLargo.Text.Trim())).ToString();
                    VericarStatusCalculado();
                }
            }
        }

        private void VericarStatusCalculado()
        {
            float botella = 0, tablon = 0;

            if (!string.IsNullOrEmpty(txtCajonAlto.Text.Trim()) && !string.IsNullOrEmpty(txtCajonAncho.Text.Trim()) && !string.IsNullOrEmpty(txtCajonLargo.Text.Trim()))
            {
                if(!string.IsNullOrEmpty(txtTablonAlto.Text.Trim()) && !string.IsNullOrEmpty(txtTablonAncho.Text.Trim()) && !string.IsNullOrEmpty(txtTablonLargo.Text.Trim()))
                {
                   tablon = Convert.ToSingle(Convert.ToSingle(txtTablonAlto.Text.Trim()) * Convert.ToSingle(txtTablonAncho.Text.Trim()) * Convert.ToSingle(txtTablonLargo.Text.Trim()));
                   txtTablon.Text = tablon.ToString();
                }

                if (!string.IsNullOrEmpty(txtBotellaAlto.Text.Trim()) && !string.IsNullOrEmpty(txtBotellaAncho.Text.Trim()) && !string.IsNullOrEmpty(txtBotellaLargo.Text.Trim()))
                {
                    botella = Convert.ToSingle(Convert.ToSingle(txtBotellaAlto.Text.Trim()) * Convert.ToSingle(txtBotellaAncho.Text.Trim()) * Convert.ToSingle(txtBotellaLargo.Text.Trim()));
                    txtBotella.Text = botella.ToString();
                }

                txtCapacidad.Text = Convert.ToSingle((Convert.ToSingle(txtCajonAlto.Text.Trim()) * Convert.ToSingle(txtCajonAncho.Text.Trim()) * Convert.ToSingle(txtCajonLargo.Text.Trim()))+tablon-botella).ToString();
            }

            if (!string.IsNullOrEmpty(txtCajon.Text.Trim()) && !string.IsNullOrEmpty(txtTablon.Text.Trim()) && !string.IsNullOrEmpty(txtBotella.Text.Trim()))
            {
                txtCapacidad.Text = (Convert.ToSingle(Convert.ToSingle(txtCajon.Text.Trim()) + Convert.ToSingle(txtTablon.Text.Trim()) - Convert.ToSingle(txtBotella.Text.Trim())).ToString()).ToString();              
            }
        }

        private void txtCajonAlto_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                if (!string.IsNullOrEmpty(txtCajonAlto.Text.Trim()) && !string.IsNullOrEmpty(txtCajonAncho.Text.Trim()) && !string.IsNullOrEmpty(txtCajonLargo.Text.Trim()))
                {
                    txtCajon.Text = Convert.ToSingle(Convert.ToSingle(txtCajonAlto.Text.Trim()) * Convert.ToSingle(txtCajonAncho.Text.Trim()) * Convert.ToSingle(txtCajonLargo.Text.Trim())).ToString();
                    VericarStatusCalculado();
                }
            }
        }
    }
}
