using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map.Bing;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls;
using Negocios;

namespace Vistas.Formularios
{
    public partial class Cliente : Telerik.WinControls.UI.RadForm
    {
        private int IdCliente;
        private DataSet ds;
        public Cliente()
        {
            InitializeComponent();
        }

        public Cliente(int IdCliente)
        {
            InitializeComponent();

            Clientes_Load(this, null);

            ds = Utilidades.Ejecutar($"SELECT * FROM VistaCliente WHERE IdCliente = {IdCliente}");
            IdCliente = Convert.ToInt32(ds.Tables[0].Rows[0]["IdCliente"].ToString());
            this.IdCliente = IdCliente;

            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtRasonSocial.Text = ds.Tables[0].Rows[0]["RazonSocial"].ToString();
            txtNota.Text = ds.Tables[0].Rows[0]["Observacion"].ToString();
            cbbTipoIdentificacion.Text = ds.Tables[0].Rows[0]["TipoIdentificacion"].ToString();
            txtIdentificacion.Text = ds.Tables[0].Rows[0]["Identificacion"].ToString();
            txtCorreo.Text = ds.Tables[0].Rows[0]["Correo"].ToString();
            txtTelefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
            txtDireccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString();
            cbbMunicipio.Text = ds.Tables[0].Rows[0]["Municipio"].ToString();
            cbbProvincia.Text = ds.Tables[0].Rows[0]["Provincia"].ToString();
            cbbSector.Text = ds.Tables[0].Rows[0]["Sector"].ToString();

            this.Text += $"\t\t::.. Codigo:{IdCliente} \t {txtRasonSocial.Text.Trim()}  ..::";
        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName("VisualStudio2012Light");

            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.matrizDataSet.Provincia);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Sector' Puede moverla o quitarla según sea necesario.
            this.sectorTableAdapter.Fill(this.matrizDataSet.Sector);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.matrizDataSet.Municipio);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.TipoIdentificacion' Puede moverla o quitarla según sea necesario.
            this.tipoIdentificacionTableAdapter.Fill(this.matrizDataSet.TipoIdentificacion);

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                Negocios.Cliente cliente = new Negocios.Cliente(
                    IdCliente,
                    txtNombre.Text.Trim(),
                    txtRasonSocial.Text.Trim(),
                    txtNota.Text.Trim(),
                    Convert.ToInt32(cbbTipoIdentificacion.SelectedValue.ToString()),
                    txtIdentificacion.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    Convert.ToInt32(cbbMunicipio.SelectedValue.ToString()),
                    Convert.ToInt32(cbbProvincia.SelectedValue.ToString()),
                    Convert.ToInt32(cbbSector.SelectedValue.ToString()),
                    txtDireccion.Text.Trim(),
                    1,
                    1);
                Debug.WriteLine("Creacion del cliente");
                Debug.WriteLine(cliente.getGuardar());

                ds = Utilidades.Ejecutar(cliente.getGuardar());
                if(ds.Tables[0].Rows.Count > 0)
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    Utilidades.Limpiar(this, errorProvider1);
                    this.Text = "Cliente \t\t Codigo:" + Utilidades.Ejecutar("SELECT MAX(IdCliente)+1 AS IdCliente FROM Cliente").Tables[0].Rows[0]["IdCliente"].ToString().Trim();
                }
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbIngresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
