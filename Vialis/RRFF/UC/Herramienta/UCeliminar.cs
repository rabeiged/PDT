using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.RRFF.UC.Herramienta
{
    public partial class UCeliminar : UserControl
    {
        public UCeliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProducto.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //tomar el valor de la busqueda para llamar el metdo
        }
    }
}
