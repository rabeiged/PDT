using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.Documentacion.UC.EDT
{
    public partial class UCagregar : UserControl
    {
        public UCagregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //AGREGAR IF PARA DESPLIEGUE DE JERARQUIA SEGUN CORRESPONDA
            //item 0: Etapa
            //Item 1: Hito
            //Item 2: Tarea
            string etap_tar_hit = cmbEtapTarHit.SelectedItem.ToString();
            int num = cmbEtapTarHit.SelectedIndex;



            string nombre = txtNombre.Text;
            DateTime fec_ini = dtpFechaInicio.Value.Date;
            DateTime fec_term = dtpFechaTermino.Value.Date;



            if (num > 2 || num < 0)
            {
                //mensaje error
                return;
            }else
            {
                if (num == 0)
                {

                    //no olvidar validar que sus hijo quepan en el rango de fecha
                    //instanciamos como etapa
                }

                if (num == 1 || num == 2)
                {
                    string jerarquia = cmbJerarquia.SelectedItem.ToString();
                    if (num == 1)
                    {
                        //inst anciamos como hito
                    }
                    if (num == 2)
                    {
                        //instanciamos como tarea
                    }
                }
            }
        }

        private void cmbEtapTarHit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
