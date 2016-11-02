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
    public partial class UCactualizar : UserControl
    {
        public UCactualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // enviar valores a modificar.
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            //al buscar un producto ya existente, rescata los valores
            //y permite al usuario modificar.
        }
    }
}
