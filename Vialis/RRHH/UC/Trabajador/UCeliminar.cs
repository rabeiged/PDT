using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.RRHH.UC.Trabajador
{
    public partial class UCeliminar : UserControl
    {
        public UCeliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string run = txtRut.Text;

                //llamamos metodo read
                //llenamos con lo retornado
                //txtResultado.Text = 
            }
            catch (Exception ex)
            {
                txtResultado.Text = ex.Message;
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string run = txtRut.Text;
            //le enviamos la variable con el run al metodo DELETE
        }
    }
}
