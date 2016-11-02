using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.RRFF.UC.Material
{
    public partial class UCactualizar : UserControl
    {
        public UCactualizar()
        {
            InitializeComponent();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // enviar datos. 
        }
    }
}
