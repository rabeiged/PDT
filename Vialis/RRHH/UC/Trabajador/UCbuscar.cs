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
    public partial class UCbuscar : UserControl
    {
        public UCbuscar()
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
            catch (Exception ex )
            {
                txtResultado.Text = ex.Message;
                throw;
            }

        }
    }
}
