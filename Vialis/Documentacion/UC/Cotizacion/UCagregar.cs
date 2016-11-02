using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.Documentacion.UC.Cotizacion
{
    public partial class UCagregar : UserControl
    {




        public UCagregar()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //rescatamos y recorrimos el arreglo y lo vamos creando en la bdd            


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_cotizacion = txtCodigoCotizacion.Text;
                string run_prov = txtRunProveedor.Text;
                string nombre_prov = txtNombreProveedor.Text;
                string proveedor = txtNombreProveedor.Text;
                string categoria = cmbCategoria.SelectedItem.ToString();
                string subcategoria = cmbSubCategoria.SelectedItem.ToString();
                string codigoitem = txtCodigoItem.Text;
                string nombre = txtNombreProd.Text;
                string marca = txtMarca.Text;
                int precio = 0;
                bool resulto = int.TryParse(txtPrecio.Text, out precio);
                if (resulto)
                {

                }
                else
                {

                }

                int cantidad = 0;
                bool result = int.TryParse(txtCantidad.Text, out cantidad);
                if (result)
                {


                }
                else
                {
                    //Agregar mensaje de validacion.
                }
                string descripcion = txtDescripcion.Text;




                // instanciamos objeto
                // agrego a un arreglo para que sean rescatados en el finalizar
            }
            catch (Exception)
            {

               //mensaje error
            }
        }
    }
}
