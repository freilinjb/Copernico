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
    }
}
