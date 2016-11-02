using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.RRFF.UC.Maquinaria
{
    public partial class UCeliminar : UserControl
    {
        public UCeliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            //Lo mismo, que el anterior buscar se carga la informacion, y se da la posibilidad
            //de eliminarlo.
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //en base al btnBuscar.
        }
    }
}
