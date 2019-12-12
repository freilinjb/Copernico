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
    public partial class Mina : FormBase
    {

        private DataSet ds;

        private static Mina Instancia;

        public static Mina ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Mina();

            Instancia.BringToFront();

            return Instancia;
        }

        private Mina()
        {
            InitializeComponent();
        }


        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdMina)+1 AS Mayor FROM Mina");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }
        private void Mina_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;

            IdMayor();


            cbbEstado.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoMina,Descripcion AS Estado FROM EstadoMina").Tables[0];
            cbbEstado.DisplayMember = "Estado";
            cbbEstado.ValueMember = "IdEstadoMina";

            cbbProveedor.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdCentro,Nombre AS Centro FROM VistaCentro WHERE Estado = 1").Tables[0];
            cbbEstado.DisplayMember = "Centro";
            cbbEstado.ValueMember = "IdCentro";

            toolRegistro.Text = "Nuevo Registro";

            cbbProveedor.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdProveedor,RazonSocial FROM VistaProveedor").Tables[0];
            cbbProveedor.ValueMember = "IdProveedor";
            cbbProveedor.DisplayMember = "RazonSocial";

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

            cbbProducto.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdProducto,Descripcion AS Producto FROM Producto WHERE IdFamilia = 4").Tables[0];
            cbbProducto.ValueMember = "IdProducto";
            cbbProducto.DisplayMember = "Producto";

            cbbEstado.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdEstadoMina,Descripcion AS Estado FROM EstadoMina").Tables[0];
            cbbEstado.ValueMember = "IdEstadoMina";
            cbbEstado.DisplayMember = "Estado";

            cbbEstado.SelectedIndex = 0;

            Negocios.Utilidades.Limpiar(this, errorProvider1);
        }

        public override bool Guardar()
        {
            bool bien = true;

            try
            {

                if (pagePrincipal.SelectedPage.Name == pageMina.Name)
                {
                    if (Negocios.Utilidades.Validar(pageMina, errorProvider1) == false)
                    {
                        Negocios.Entidades.Mina mina = new Negocios.Entidades.Mina(
                            Convert.ToInt32(txtCodigo.Text.Trim()),
                            (int)cbbProveedor.SelectedValue,
                            (int)cbbProducto.SelectedValue,
                            Convert.ToSingle(txtPrecio.Text.Trim()),
                            txtNombre.Text.Trim(),
                            txtDescripcion.Text.Trim(),
                            (int)cbbProvincia.SelectedValue,
                            (int)cbbCiudad.SelectedValue,
                            (int)cbbMunicipio.SelectedValue,
                            (int)cbbSector.SelectedValue,
                            txtDireccion.Text.Trim(),
                            (int)cbbEstado.SelectedValue);

                        ds = Negocios.Utilidades.Ejecutar(mina.getGuardar());


                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                            Negocios.Utilidades.Limpiar(this, errorProvider1);

                            toolRegistro.Text = "Nuevo Registro";
                            IdMayor();
                            //this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                bien = false;
            }

            return bien;
        }

        private void Mina_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if(pagePrincipal.SelectedPage.Name == pageMina.Name)
                {
                    Guardar();
                }
            }

            else if(e.KeyCode == Keys.F2)
            {
                Negocios.Utilidades.Limpiar(this, errorProvider1);
                ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdMina)+1 AS Mayor FROM Mina");
                txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
            }
        }
    }
}
