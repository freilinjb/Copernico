using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Diagnostics;
using Telerik.WinControls.UI;
using Telerik.Charting;

namespace Vistas.Formularios
{
    public partial class Analisis : FormBase
    {
        private List<Negocios.Entidades.Analisis.ResumenProducto>ListProducto;

        private void CargarProductos()
        {
            ListProducto = new List<Negocios.Entidades.Analisis.ResumenProducto>();

            foreach(DataRow File in Negocios.Utilidades.Ejecutar("SELECT F.IdFiltro,P.IdProducto,P.Descripcion AS Producto,F.NumMallaInicial,F.NumMallaFinal FROM Filtro F INNER JOIN Producto P ON P.IdProducto = F.IdProducto").Tables[0].Rows)
            {
                ListProducto.Add(new Negocios.Entidades.Analisis.ResumenProducto(
                    Convert.ToInt32(File["IdProducto"].ToString()),
                    File["Producto"].ToString(),
                    Convert.ToInt32(File["NumMallaInicial"].ToString()),
                    Convert.ToInt32(File["NumMallaFinal"].ToString())));

                Debug.WriteLine($"Agregado a Lista { File["Producto"].ToString()},{File["Producto"].ToString()},{Convert.ToInt32(File["NumMallaInicial"].ToString())},{Convert.ToInt32(File["NumMallaFinal"].ToString())}");
            }
        }
        private static Analisis Instancia;
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


            txtFecha.Value = DateTime.Today;
            cbbTipoAnalisis.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoAnalisis,Descripcion AS TipoAnalisis FROM TipoAnalisis").Tables[0];
            cbbTipoAnalisis.ValueMember = "IdTipoAnalisis";
            cbbTipoAnalisis.DisplayMember = "TipoAnalisis";

            cbbMina.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdMina,T.Nombre AS Mina FROM Mina M INNER JOIN Tercero T ON T.IdTercero = M.IdTercero INNER JOIN EstadoMina EM ON EM.IdEstadoMina = M.IdEstadoMina WHERE EM.IdEstadoMina = 1").Tables[0];
            cbbMina.ValueMember = "IdMina";
            cbbMina.DisplayMember = "Mina";

            cbbTipoMaterial.DataSource = Negocios.Utilidades.Ejecutar("SELECT IdTipoMateriaPrima,Descripcion AS TipoMateriaPrima FROM TipoMateriaPrima").Tables[0];
            cbbTipoMaterial.ValueMember = "IdTipoMateriaPrima";
            cbbTipoMaterial.DisplayMember = "TipoMateriaPrima";


            ds = Negocios.Utilidades.Ejecutar("SELECT NumMalla,Apertura FROM Tamiz");
            float aleatorio = 0;
            float pasante = 0;
            float acumulado = 0;
            Random random = new Random();
            foreach(DataRow File in ds.Tables[0].Rows)
            {
                aleatorio = Convert.ToSingle(random.Next(30, 359) + "." + random.Next(0, 9999));
                pasante = ((((Single)aleatorio * 100) / Convert.ToSingle(txtCantidadInicial.Text.Trim())) / 100);
                acumulado += pasante;
                dataTamiz.Rows.Add(Convert.ToSingle(File["NumMalla"].ToString()), Convert.ToSingle(File["Apertura"].ToString()), aleatorio, pasante, acumulado, (1 - acumulado));
            }

            Negocios.Utilidades.Limpiar(this, errorProvider1);
            txtCantidadInicial.Text = "7000";

            IdMayor();

            CargarProductos();
        }

        private void IdMayor()
        {
            ds = Negocios.Utilidades.Ejecutar("SELECT MAX(IdAnalisis)+1 AS Mayor FROM Analisis");
            txtCodigo.Text = (ds.Tables[0].Rows[0]["Mayor"] == DBNull.Value) ? "1" : ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void MasterTemplate_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                float retenido = 0;
                float porcentajeAcumulado = 0;
                if (e.Column.Name == "PesoRetenido")
                {
                    ///Distribulle el porcentaje granulometrico por Tamiz
                    retenido = (((Single)e.Value * 100) / Convert.ToSingle(txtCantidadInicial.Text.Trim())) / 100;
                    Debug.WriteLine("Cambio");
                    e.Row.Cells["Pasante"].Value = retenido;
                    e.Row.Cells["Retenido"].Value = retenido;

                    //RetenidoAcumulado += (float)e.Row.Cells["Retenido"].Value;
                    //e.Row.Cells["RetenidoAcumulado"].Value = RetenidoAcumulado;

                    for (int i = 0; i <= e.RowIndex; i++)
                    {
                        porcentajeAcumulado += (float)dataTamiz.Rows[i].Cells["Retenido"].Value;
                    }
                    e.Row.Cells["Pasante"].Value = (1 - porcentajeAcumulado);
                    e.Row.Cells["RetenidoAcumulado"].Value = porcentajeAcumulado;

                    txtCantidadFinal.Text = porcentajeAcumulado.ToString();
                    toolPorcentaje.Text = (porcentajeAcumulado * 100).ToString();


                    //Comparacion de los materiales

                    if (porcentajeAcumulado > 1)
                    {
                        RadMessageBox.Show("REVISAR EL PORCENTAJE GRANULOMETRICO, SOBREPASA LA CANTIDAD INICIAL!!", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

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
            catch(Exception ex)
            {
                RadMessageBox.Show("Ha ocurrido un error", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
            }
        }

        public override bool Guardar()
        {
            bool bien = false;

            try
            {
                if (pagePrincipal.SelectedPage.Name == pageInformacionGeneral.Name)
                {
                    if(Negocios.Utilidades.Validar(pageInformacionGeneral,errorProvider1) == false)
                    {
                        Negocios.Entidades.Analisis analisis = new Negocios.Entidades.Analisis(
                            Convert.ToInt32(txtCodigo.Text.Trim()),
                            txtFecha.Text,
                            (int)cbbTipoAnalisis.SelectedValue,
                            (int)cbbMina.SelectedValue,
                            txtBanqueta.Text.Trim(),
                            Convert.ToSingle(txtHumedad.Text.Trim()),
                            Convert.ToSingle(txtCantidadInicial.Text.Trim()),
                            txtObservacion.Text.Trim());

                        Debug.WriteLine("ANALISIS DEPURACION: "+analisis.getGuardar());
                        if (Negocios.Utilidades.Ejecutar(analisis.getGuardar()).Tables[0].Rows.Count > 0)
                        {
                            Negocios.Utilidades.Ejecutar($"DELETE FROM Analisis_VS_Tamiz WHERE IdAnalisis={txtCodigo.Text.Trim()}");
                            foreach (var Fila in dataTamiz.Rows)
                            {
                                Negocios.Utilidades.Ejecutar($"EXEC [RegistrarAnalizisPorTamiz] {txtCodigo.Text.Trim()},{Fila.Cells["NumMalla"].Value.ToString()},{Fila.Cells["PesoRetenido"].Value.ToString()};");
                            }
                        }

                        if(Negocios.Utilidades.Ejecutar(analisis.getGuardar()).Tables[0].Rows.Count > 0)
                        {
                            bien = true;
                        }
                    }
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
            if(e.KeyCode == Keys.F1)
            {
                if (Guardar())
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    txtCantidadInicial.Text = "0";
                    IdMayor();
                    toolRegistro.Text = "Nuevo Registro";

                    for (int i = 0; i < dataTamiz.Rows.Count; i++)
                    {
                        dataTamiz.Rows[i].Cells["PesoRetenido"].Value = 0;
                    }
                }
            }
        }

        private void pagePrincipal_SelectedPageChanged(object sender, EventArgs e)
        {
            if(pagePrincipal.SelectedPage.Name == pageEstadistica.Name)
            {
                Negocios.Utilidades.LimpiarRadDataGridView(dataMaterialPorcentaje);
                foreach(var File in dataTamiz.Rows)
                {
                    for(int i = 0; i < ListProducto.Count; i++)
                    {
                        if((ListProducto[i].NumMallaInicial >= (int)File.Cells["NumMalla"].Value) && (int)File.Cells["NumMalla"].Value <= (ListProducto[i].NumMallaFinal ))
                        {
                            ListProducto[i].Porcentaje += (float)File.Cells["Retenido"].Value;
                        }
                    }
                }
                BarSeries barSeries1 = new BarSeries("Porcentaje", "Producto");
                PieSeries seriesCircular1 = new PieSeries();

                seriesCircular1.Name = "Productos";
                barSeries1.Name = "Productos";

                seriesCircular1.ShowLabels = true;
                barSeries1.ShowLabels = true;

                barSeries1.LegendTitle = "Producto";

                seriesCircular1.LabelFormat = "{0:P3}";
                barSeries1.LabelFormat = "{0:P3}";

                foreach (var producto in ListProducto)
                {
                    if(producto.Porcentaje != 0)
                    {

                        if(producto.Producto == "GRUESO" || producto.Producto == "FINO")
                        {
                            seriesCircular1.DataPoints.Add(new PieDataPoint(producto.Porcentaje, producto.Producto));
                        }
                        else
                        {
                            barSeries1.DataPoints.Add(new CategoricalDataPoint(producto.Porcentaje, producto.Producto));
                            dataMaterialPorcentaje.Rows.Add(producto.IdProducto, producto.Producto, producto.Porcentaje);
                        }
                    }
                }
                this.charBarras.Series.Clear();
                this.charBarras.Area.View.Palette = KnownPalette.Arctic;
                this.charCircular.Area.View.Palette = KnownPalette.Arctic;
                this.charBarras.Series.Add(barSeries1);
                this.charCircular.Series.Clear();
                this.charCircular.Series.Add(seriesCircular1);
            }
        }
    }
}
