using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCasos.Constantes
{
    class Formato
    {
        public static void DarFormatoDataGridView(DataGridView dataGrid)
        {
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            dataGrid.DefaultCellStyle.Font = new Font("Montserrat", 10);
        }
    }
}
