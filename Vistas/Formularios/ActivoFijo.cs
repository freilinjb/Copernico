using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Vistas.Formularios
{
    public partial class ActivoFijo : FormBase
    {
        private RadContextMenu contextMenu;

        private DataSet ds;

        private static ActivoFijo Instancia;


        public static ActivoFijo ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new ActivoFijo();

            Instancia.BringToFront();

            return Instancia;
        }


        public ActivoFijo()
        {
            InitializeComponent();

        }

        private void Proceso1(object sender, EventArgs e)
        {
            ActivoCubicacion activoCubicacion = new ActivoCubicacion(Convert.ToInt32(dataActivoFijo.Rows[dataActivoFijo.CurrentRow.Index].Cells["IdActivoFijo"].Value.ToString()));
            activoCubicacion.ShowDialog();

        }

        private void Proceso2(object sender, EventArgs e)
        {


        }

        private void ActivoFijo_Load(object sender, EventArgs e)
        {


            contextMenu = new RadContextMenu();
            RadMenuItem copyCellItem = new RadMenuItem("Cubicar ActivoFijo");
            copyCellItem.ForeColor = Color.Red;
            copyCellItem.Click += Proceso1;
            RadMenuItem copyRowItem = new RadMenuItem("Asignar Cargos");
            copyRowItem.Click += Proceso2;
            contextMenu.Items.Add(copyCellItem);
            contextMenu.Items.Add(copyRowItem);


            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.VistaMotor' Puede moverla o quitarla según sea necesario.
            this.vistaMotorTableAdapter.Fill(this.matrizDataSet.VistaMotor);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Color' Puede moverla o quitarla según sea necesario.
            this.colorTableAdapter.Fill(this.matrizDataSet.Color);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.matrizDataSet.Modelo);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.matrizDataSet.Marca);
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.GrupoActivoFijo' Puede moverla o quitarla según sea necesario.
            this.grupoActivoFijoTableAdapter.Fill(this.matrizDataSet.GrupoActivoFijo);

            //Negocios.Utilidades.Limpiar(this, errorProvider1);
            RadMessageBox.ThemeName = this.ThemeName;

            dataActivoFijo.DataSource = Negocios.Utilidades.Ejecutar("select AF.IdActivoFijo,T.Nombre,GA.Descripcion AS Grupo,SG.Descripcion AS SubGrupo,EA.Descripcion AS Estado from ActivoFijo AF INNER JOIN GrupoActivoFijo GA ON GA.IdGrupoActivoFijo = AF.IdGrupoActivoFijo INNER JOIN SubGrupoActivoFijo SG ON SG.IdSubGrupoActivoFijo = AF.IdSubGrupoActivoFijo INNER JOIN EstadoActivoFijo EA ON EA.IdEstadoActivoFijo = AF.IdEstadoActivoFijo INNER JOIN Tercero T ON T.IdTercero = AF.IdTercero").Tables[0];
            IdMayor();
            //Negocios.Utilidades.Limpiar(this, errorProvider1);

            for (int i = DateTime.Today.Year; i >= 1985; i--)
                cbbAnio.Items.Add(i.ToString());



        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdActivoFijo)+1 AS Mayor FROM ActivoFijo");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void cbbGrupo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbbGrupo.SelectedIndex != -1)
            {
                cbbSubGrupo.DataSource = Negocios.Utilidades.Ejecutar($"SELECT SG.IdSubGrupoActivoFijo,SG.Descripcion AS SubGrupo FROM SubGrupoActivoFijo SG INNER JOIN GrupoActivoFijo GA ON GA.IdGrupoActivoFijo = SG.IdGrupoActivoFijo WHERE  GA.IdGrupoActivoFijo = {cbbGrupo.SelectedValue}").Tables[0];
                cbbSubGrupo.ValueMember = "IdSubGrupoActivoFijo";
                cbbSubGrupo.DisplayMember = "SubGrupo";


            }
        }

        public override bool Guardar()
        {
            bool bien = false;

            if (pagePrincipal.SelectedPage.Name == pageActivoFijo.Name || pagePrincipal.SelectedPage.Name == pageEspesificacion.Name)
            {
                try
                {
                    if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
                    {
                        //Negocios.Entidades.ActivoFijoGeneral activo = new Negocios.Entidades.ActivoFijoGeneral(
                        //    Convert.ToInt32(txtCodigo.Text.Trim()),
                        //    (int)cbbGrupo.SelectedValue,
                        //    (int)cbbSubGrupo.SelectedValue,
                        //    txtNombre.Text.Trim(),
                        //    1);

                        Negocios.Entidades.ActivoFijoGeneral activo = new Negocios.Entidades.ActivoFijoGeneral(
                            Convert.ToInt32(txtCodigo.Text.Trim()),
                            txtNombre.Text.Trim(),
                            (int)cbbMarca.SelectedValue,
                            (int)cbbModelo.SelectedValue,
                            (int)cbbMotor.SelectedValue,
                            (int)cbbColor.SelectedValue,
                            Convert.ToInt32(cbbAnio.Text.Trim()),
                            1,
                            (int)cbbGrupo.SelectedValue,
                            (int)cbbSubGrupo.SelectedValue);

                        ds = Negocios.Utilidades.Ejecutar(activo.getGuardar2());

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if((int)cbbSubGrupo.SelectedValue == 39)
                                ds = Negocios.Utilidades.Ejecutar($"INSERT INTO Planta(IdLinea,IdActivoFijo) VALUES(14,{ Convert.ToInt32(txtCodigo.Text.Trim())})");
                            RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                            bien = true;
                        }
                    }
                    else if(pagePrincipal.SelectedPage.Name == pageEspesificacion.Name)
                    {

                    }
                }
                catch (Exception ex)
                {
                    bien = false;
                    RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                }
            }
            return bien;
        }

        private void ActivoFijo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if(Guardar())
                {
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    lbEstatus.Text = "Nuevo Registro";
                    dataActivoFijo.DataSource = Negocios.Utilidades.Ejecutar("select AF.IdActivoFijo,T.Nombre,GA.Descripcion AS Grupo,SG.Descripcion AS SubGrupo,EA.Descripcion AS Estado from ActivoFijo AF INNER JOIN GrupoActivoFijo GA ON GA.IdGrupoActivoFijo = AF.IdGrupoActivoFijo INNER JOIN SubGrupoActivoFijo SG ON SG.IdSubGrupoActivoFijo = AF.IdSubGrupoActivoFijo INNER JOIN EstadoActivoFijo EA ON EA.IdEstadoActivoFijo = AF.IdEstadoActivoFijo INNER JOIN Tercero T ON T.IdTercero = AF.IdTercero").Tables[0];
                    IdMayor();
                }
            }
        }

        private void dataActivoFijo_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = contextMenu.DropDown;
        }
    }
}
