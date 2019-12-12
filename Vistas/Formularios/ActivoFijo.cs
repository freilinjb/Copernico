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
    public partial class ActivoFijo : FormBase
    {
        private DataSet ds;

        public ActivoFijo()
        {
            InitializeComponent();

        }

        private void ActivoFijo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matrizDataSet.GrupoActivoFijo' Puede moverla o quitarla según sea necesario.
            this.grupoActivoFijoTableAdapter.Fill(this.matrizDataSet.GrupoActivoFijo);

            //Negocios.Utilidades.Limpiar(this, errorProvider1);
            RadMessageBox.ThemeName = this.ThemeName;

            dataActivoFijo.DataSource = Negocios.Utilidades.Ejecutar("select AF.IdActivoFijo,T.Nombre,GA.Descripcion AS Grupo,SG.Descripcion AS SubGrupo,EA.Descripcion AS Estado from ActivoFijo AF INNER JOIN GrupoActivoFijo GA ON GA.IdGrupoActivoFijo = AF.IdGrupoActivoFijo INNER JOIN SubGrupoActivoFijo SG ON SG.IdSubGrupoActivoFijo = AF.IdSubGrupoActivoFijo INNER JOIN EstadoActivoFijo EA ON EA.IdEstadoActivoFijo = AF.IdEstadoActivoFijo INNER JOIN Tercero T ON T.IdTercero = AF.IdTercero").Tables[0];
            IdMayor();
            //Negocios.Utilidades.Limpiar(this, errorProvider1);
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
            bool bien = true;

            if (pagePrincipal.SelectedPage.Name == pageActivoFijo.Name)
            {
                try
                {
                    if (Negocios.Utilidades.Validar(pageActivoFijo, errorProvider1) == false)
                    {
                        Negocios.Entidades.ActivoFijoGeneral activo = new Negocios.Entidades.ActivoFijoGeneral(
                            Convert.ToInt32(txtCodigo.Text.Trim()),
                            (int)cbbGrupo.SelectedValue,
                            (int)cbbSubGrupo.SelectedValue,
                            txtNombre.Text.Trim(),
                            1);

                        ds = Negocios.Utilidades.Ejecutar(activo.getGuardar());

                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                            Negocios.Utilidades.Limpiar(this, errorProvider1);

                            lbEstatus.Text = "Nuevo Registro";
                            //this.vistaCentroMantenimientoTableAdapter.Fill(this.matrizDataSet.VistaCentroMantenimiento);
                            dataActivoFijo.DataSource = Negocios.Utilidades.Ejecutar("select AF.IdActivoFijo,T.Nombre,GA.Descripcion AS Grupo,SG.Descripcion AS SubGrupo,EA.Descripcion AS Estado from ActivoFijo AF INNER JOIN GrupoActivoFijo GA ON GA.IdGrupoActivoFijo = AF.IdGrupoActivoFijo INNER JOIN SubGrupoActivoFijo SG ON SG.IdSubGrupoActivoFijo = AF.IdSubGrupoActivoFijo INNER JOIN EstadoActivoFijo EA ON EA.IdEstadoActivoFijo = AF.IdEstadoActivoFijo INNER JOIN Tercero T ON T.IdTercero = AF.IdTercero").Tables[0];

                            IdMayor();
                        }
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

            }
        }
    }
}
