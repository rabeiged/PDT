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
    public partial class UCagregar : UserControl
    {
        public UCagregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem.ToString();
            string subcategoria = cmbSubCategoria.SelectedItem.ToString();
            string nombre = txtNombre.Text;
            string detalle = txtDetalle.Text;
        }
    }
}
