using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Negocios
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            return Datos.Consultar.Ejecutar(cmd);
        }

        public static Task<DataSet> EjecutarAsync(string cmd)
        {
            return Datos.Consultar.EjecutarAsync(cmd);
        }

        private static Font fuente = new Font(new FontFamily("Arial"), 11.0f);
        public static void dataFormatoCelda(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Font =  fuente;
        }
        public static void LimpiarDataGridView(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0)
            {
                for (int i = dataGrid.Rows.Count - 1; i >= 0; i--)
                {
                    dataGrid.Rows.RemoveAt(i);
                }
            }
        }

        public static Boolean Limpiar(Control control, ErrorProvider error)
        {
            error.Clear();
            bool bien = true;
            foreach (Control obj in control.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    if (Limpiar(obj, error))
                        bien = false;
                }
                foreach (Control item in control.Controls)
                {
                    if (item is Componentes.TextPersonal txt)
                    {
                        if (txt.Limpiar)
                            txt.Text = null;
                    }

                    else if (item is Componentes.cbbPersonal cbb)
                    {
                        if (cbb.Limpiar)
                            cbb.SelectedIndex = -1;
                    }
                    else if (item is Componentes.ComboPersonal cbb2)
                    {
                        if (cbb2.Limpiar)
                            cbb2.SelectedIndex = -1;
                    }

                    else if (item is Componentes.MultiCbbPersonal cbbM)
                    {
                        if (cbbM.Limpiar)
                            cbbM.SelectedIndex = -1;
                    }
                }
            }
            return bien;
        }
        public static Boolean Validar2(Control control, ErrorProvider error)
        {
            bool hayerror = false;
            foreach (Control obj in control.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    if (Validar2(obj, error))
                    {
                        hayerror = true;
                    }
                    if (obj is Componentes.TextPersonal txt)
                    {
                        if (txt.Validar)
                        {
                            if (string.IsNullOrEmpty(txt.Text.Trim()) || string.IsNullOrWhiteSpace(txt.Text.Trim()))
                            {
                                error.SetError(txt, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                    }

                    if (obj is Componentes.MultiCbbPersonal cbbM)
                    {
                        if (cbbM.Validar)
                        {
                            if (string.IsNullOrEmpty(cbbM.Text.Trim()) || string.IsNullOrWhiteSpace(cbbM.Text.Trim()))
                            {
                                error.SetError(cbbM, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                    }
                    if (obj is Componentes.ComboPersonal cbb)
                    {

                        if (cbb.Validar)
                        {
                            if (string.IsNullOrEmpty(cbb.Text) || string.IsNullOrWhiteSpace(cbb.Text))
                            {
                                MessageBox.Show("verdadero");
                                error.SetError(cbb, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                        if (cbb.SelectedIndex == -1)
                        {
                            error.SetError(cbb, "Compo obligatorio");
                            hayerror = true;
                        }
                    }
                    if (obj is Componentes.cbbPersonal cbb2)
                    {

                        if (cbb2.Validar)
                        {
                            if (string.IsNullOrEmpty(cbb2.Text) || string.IsNullOrWhiteSpace(cbb2.Text))
                            {
                                MessageBox.Show("verdadero");
                                error.SetError(cbb2, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                        if (cbb2.SelectedIndex == -1)
                        {
                            error.SetError(cbb2, "Compo obligatorio");
                            hayerror = true;
                        }
                    }
                }
            }
            return hayerror;
        }
        public static Boolean Validar(Control control, ErrorProvider error)
        {
            bool hayerror = false;
            foreach (Control obj in control.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    if (Validar(obj, error))
                    {
                        hayerror = true;
                    }
                    if (obj is Componentes.TextPersonal txt)
                    {
                        if (txt.Validar == true)
                        {
                            if (string.IsNullOrEmpty(txt.Text.Trim()) || string.IsNullOrWhiteSpace(txt.Text.Trim()))
                            {
                                error.SetError(txt, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                    }
                    if (obj is Componentes.cbbPersonal cbb)
                    {

                        if (cbb.Validar)
                        {
                            if (string.IsNullOrEmpty(cbb.Text.Trim()) || string.IsNullOrWhiteSpace(cbb.Text.Trim()))
                            {
                                error.SetError(cbb, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                        //if (cbb.SelectedIndex == -1)
                        //{
                        //    error.SetError(cbb, "Compo obligatorio");
                        //    hayerror = true;
                        //}
                    }
                    if (obj is Componentes.ComboPersonal cbb2)
                    {

                        if (cbb2.Validar)
                        {
                            if (string.IsNullOrEmpty(cbb2.Text.Trim()) || string.IsNullOrWhiteSpace(cbb2.Text.Trim()))
                            {
                                error.SetError(cbb2, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                    }

                    if (obj is Componentes.MultiCbbPersonal cbbM)
                    {

                        if (cbbM.Validar)
                        {
                            if (string.IsNullOrEmpty(cbbM.Text.Trim()) || string.IsNullOrWhiteSpace(cbbM.Text.Trim()))
                            {
                                error.SetError(cbbM, "Compo obligatorio");
                                hayerror = true;
                            }
                        }
                    }
                }
            }
            return hayerror;
        }
    }
}
