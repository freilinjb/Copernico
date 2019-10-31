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
    public partial class Proveedor : FormBase
    {
        private int IdCliente;
        private int IdTercero;
        private DataSet ds;

        private static Proveedor Instancia;

        public static Proveedor ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Proveedor();

            Instancia.BringToFront();

            return Instancia;
        }

        private List<Negocios.Entidades.Contacto> ContactoGuardar = new List<Negocios.Entidades.Contacto>();


        //Acuerdate de prueba cambialo a privado
        public Proveedor()
        {
            InitializeComponent();
            IdCliente = Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(IdCliente)+1 AS Mayor FROM Cliente").Tables[0].Rows[0]["Mayor"].ToString());
        }

        public Proveedor(int IdCliente)
        {
            InitializeComponent();

            //Clientes_Load(this, null);

            ds = Utilidades.Ejecutar($"SELECT * FROM VistaCliente WHERE IdCliente = {IdCliente}");
            IdCliente = Convert.ToInt32(ds.Tables[0].Rows[0]["IdCliente"].ToString());
            this.IdCliente = IdCliente;
            IdTercero = Convert.ToInt32(ds.Tables[0].Rows[0]["IdTercero"].ToString().Trim());
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

            ds = Negocios.Utilidades.Ejecutar($"SELECT CV.IdContacto,CV.IdTercero,CV.Nombre,CV.Departamento,CV.Puesto,CV.Telefono,CV.Correo,CV.Estado FROM VistaContacto CV INNER JOIN Contacto_vs_Tercero CT ON CT.IdContacto = CV.IdContacto INNER JOIN Tercero T ON T.IdTercero = CT.IdTercero WHERE T.IdTercero = {IdTercero}");

            foreach(DataRow x in ds.Tables[0].Rows)
            {
                dataContacto.Rows.Add(x[0].ToString(), x[2].ToString(), x[3].ToString(), x[4].ToString(), x[5].ToString(), x[6].ToString());
            }

            this.Text += $"\t\t::.. Codigo:{IdCliente} \t {txtRasonSocial.Text.Trim()}  ..::";


        }

        public override bool Guardar()
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

                if (ds.Tables[0].Rows.Count > 0)
                {
                    IdTercero = Convert.ToInt32(ds.Tables[0].Rows[0]["IdTercero"].ToString().Trim());

                    if (ContactoGuardar.Count > 0)
                    {
                        for (int i = 0; i < ContactoGuardar.Count; i++)
                        {
                            ContactoGuardar[i].IdTerceroClienteProveedor = IdTercero;
                            Debug.WriteLine("Registro Cliente");
                            Utilidades.Ejecutar(ContactoGuardar[i].getGuardar());

                        }
                    }

                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                    Utilidades.Limpiar(this, errorProvider1);
                    dataContacto.Rows.Clear();

                    IdCliente = Convert.ToInt32(Negocios.Utilidades.Ejecutar("SELECT MAX(IdCliente)+1 AS Mayor FROM Cliente").Tables[0].Rows[0]["Mayor"].ToString());
                    this.Text = "Cliente \t\t Codigo:" + Utilidades.Ejecutar("SELECT MAX(IdCliente)+1 AS IdCliente FROM Cliente").Tables[0].Rows[0]["IdCliente"].ToString().Trim();
                    this.DialogResult = DialogResult.OK;
                }
            }
            return true;
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

            if(IdCliente != 0)
            {

                //cbbProvincia.SelectedIndex = -1;
                //cbbMunicipio.SelectedIndex = -1;
                //cbbSector.SelectedIndex = -1;
                //cbbTipoIdentificacion.SelectedIndex = -1;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbIngresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contacto contacto = new Contacto(IdTercero);
            if(contacto.ShowDialog() == DialogResult.OK)
            {
                contacto.ct.IdContacto = 0;
                ContactoGuardar.Add(contacto.ct);
                dataContacto.Rows.Add(
                    0,
                    contacto.txtNombre.Text.Trim(),
                    contacto.cbbDepartamento.Text.Trim(),
                    contacto.cbbPuesto.Text.Trim(),
                    contacto.txtCorreo.Text.Trim(),
                    contacto.txtTelefono.Text.Trim());
            }
        }

        private void Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btGuardar_Click(this, null);
            }
        }
    }
}
