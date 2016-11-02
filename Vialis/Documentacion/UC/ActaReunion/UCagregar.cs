using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.Documentacion.UC.ActaReunion
{
    public partial class UCagregar : UserControl
    {
        public UCagregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date;
            string nombreParticipante = txtNombreParticipante.Text;
            string detalle = txtDetalle.Text;
            string run = txtRun.Text;
        }
    }
}
