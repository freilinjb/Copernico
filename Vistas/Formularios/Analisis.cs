﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Diagnostics;

namespace Vistas.Formularios
{
    public partial class Analisis : FormBase
    {
        private static Analisis Instancia;

        private float RetenidoAcumulado = 0;
        float PesoRetenido = 0;

        private DataSet ds;


        public static Analisis ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed)
                Instancia = new Analisis();

            Instancia.BringToFront();

            return Instancia;
        }

        private Analisis()
        {
            InitializeComponent();
        }


        private void Analisis_Load(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;

            IdMayor();

            ds = Negocios.Utilidades.Ejecutar("SELECT NumMalla,Apertura FROM Tamiz");

            foreach(DataRow File in ds.Tables[0].Rows)
            {
                dataTamiz.Rows.Add(Convert.ToSingle(File["NumMalla"].ToString()), Convert.ToSingle(File["Apertura"].ToString()), 0, 0, 0, 0);
            }
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdAnalisis)+1 AS Mayor FROM Analisis");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void MasterTemplate_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            float retenido = 0;
            float porcentajePasante = 0;
            float porcentajeAcumulado = 0;
            if(e.Column.Name == "PesoRetenido")
            {
                retenido = (((Single)e.Value * 100) / Convert.ToSingle(txtCantidadInicial.Text.Trim())) / 100;
                Debug.WriteLine("Cambio");
                e.Row.Cells["Pasante"].Value = retenido;
                e.Row.Cells["Retenido"].Value = retenido;

                //RetenidoAcumulado += (float)e.Row.Cells["Retenido"].Value;
                //e.Row.Cells["RetenidoAcumulado"].Value = RetenidoAcumulado;
                txtCantidadFinal.Text = PesoRetenido.ToString();

                for(int i = 0; i <= e.RowIndex; i++)
                {
                    porcentajeAcumulado += (float)dataTamiz.Rows[i].Cells["Retenido"].Value;
                }
                e.Row.Cells["Pasante"].Value = (1-porcentajeAcumulado);
                e.Row.Cells["RetenidoAcumulado"].Value = porcentajeAcumulado;



                //int index = 0;
                //foreach (var File in dataTamiz.Rows)
                //{
                //    porcentajePasante += (float)File.Cells["Pasante"].Value;
                //    PesoRetenido += (float)File.Cells["PesoRetenido"].Value;
                //    porcentajeAcumulado += (float)File.Cells["Pasante"].Value;
                //    dataTamiz.Rows[index].Cells["RetenidoAcumulado"].Value = porcentajeAcumulado;
                //    dataTamiz.Rows[index].Cells["Pasante"].Value = porcentajeAcumulado;
                //}

                //if (porcentajePasante > 1)
                //{
                //    RadMessageBox.Show("REVISAR EL PORCENTAJE GRANULOMETRICO, SOBREPASA LA CANTIDAD INICIAL!!", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
                //}
            }
        }

        public override bool Guardar()
        {
            bool bien = true;

            try
            {
                if (pagePrincipal.SelectedPage.Name == pageInformacionGeneral.Name)
                {
                    Negocios.Entidades.Analisis analisis = new Negocios.Entidades.Analisis(
                        Convert.ToInt32(txtCodigo.Text.Trim()),
                        txtFecha.Text,
                        (int)cbbTipoAnalisis.SelectedValue,
                        (int)cbbMina.SelectedValue,
                        txtBanqueta.Text.Trim(),
                        Convert.ToSingle(txtHumedad.Text.Trim()),
                        Convert.ToSingle(txtCantidadFinal.Text.Trim()));

                    ds = Negocios.Utilidades.Ejecutar(analisis.getGuardar());
                }

                else if(pageInformacionGeneral.Name == pageEstadistica.Name)
                {

                }
            }

            catch (Exception ex)
            {
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                bien = false;
            }
            return bien;
        }

        private void Analisis_KeyUp(object sender, KeyEventArgs e)
        {
            if(Guardar())
            {
                RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                Negocios.Utilidades.Limpiar(this, errorProvider1);
                toolRegistro.Text = "Nuevo Registro";
            }
        }
    }
}
