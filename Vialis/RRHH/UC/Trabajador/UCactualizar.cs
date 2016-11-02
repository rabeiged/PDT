using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vialis.Negocio;

namespace Vialis.RRHH.UC.Trabajador
{
    public partial class UCactualizar : UserControl
    {
        public UCactualizar()
        {
            InitializeComponent();           
        }


        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string runBusqueda = txtRunBusqueda.Text;
                Persona per = new Persona();
                per.Run = runBusqueda;
                per.Buscar();

                txtRun.Text = per.Run;
                txtNombre.Text = per.Nombre;
                txtApellidoP.Text = per.Apellido_paterno;
                txtApellidoM.Text = per.Apellido_materno;
                cmbSexo.ValueMember = per.Sexo.ToString();
                cmbEstadoCivil.ValueMember = per.Estado_civil.ToString();
                txtDireccion.Text = per.Direccion;

                rellenar_cmb_ubicacion_por_busqueda(per);

                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int sueldo = 0, porcafp = 0, porcsalud = 0;

                string nombre = txtNombre.Text;
                string apellidop = txtApellidoP.Text;
                string apellidom = txtApellidoM.Text;
                string direccion = txtDireccion.Text;

                string region = cmbRegion_.SelectedValue.ToString();
                string provincia = cmbProvidencia.SelectedValue.ToString();
                string comuna = cmbComuna.SelectedValue.ToString();
                string ecivil = cmbEstadoCivil.SelectedValue.ToString();
                string ofiprof = cmbOficioprofesion.SelectedValue.ToString();
                string tipocontrato = cmbTipocontrato.SelectedValue.ToString();


                string afp = cmbAfp.SelectedValue.ToString();

                if (int.TryParse(txtPorcAFP.Text, out porcafp))
                {

                }
                else
                {
                    //mensaje de validacion
                    return;
                }

                string salud = cmbSalud.SelectedValue.ToString();
                if (int.TryParse(txtPorcSalud.Text, out porcsalud))
                {

                }
                else
                {
                    //mensaje de validacion
                    return;
                }


                //llamamos el metodo update

            }
            catch (Exception)
            {

                throw;
            }

        }



        private void cmbProvidencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Lo mismo de arriba, se manda el valor de provincia.
            Negocio.Comuna c = new Negocio.Comuna();
            cmbComuna.DataSource = c.Listar(int.Parse(cmbProvidencia.SelectedValue.ToString()));
            cmbComuna.DisplayMember = "nombre_comuna";
            cmbComuna.ValueMember = "id_comuna";

        }

        private void cmbRegion__SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mando el valor seleccionado en el combx de Region, para mandar el listado de las provincias correspondiendes.
            Negocio.Provincia p = new Negocio.Provincia();
            cmbProvidencia.DataSource = p.Listar(int.Parse(cmbRegion_.SelectedValue.ToString()));
            cmbProvidencia.DisplayMember = "nombre_provincia";
            cmbProvidencia.ValueMember = "id_provincia";
        }

        private void cmb_region_click(object sender, EventArgs e)
        {
            //si el usuario desea cambiar la ubicacion geo. tendra que hacerle click al combobox
            //por lo tanto se resetearan los datos para que los ingrese y pueda actualizar
            //El nombre de los cambios en display y value member debe ser el definido en la clase.

            Negocio.Region r = new Negocio.Region();
            cmbRegion_.DataSource = r.Listar();
            cmbRegion_.DisplayMember = "nombre_region";
            cmbRegion_.ValueMember = "id_region";


            Negocio.Afp a = new Negocio.Afp();
            cmbAfp.DataSource = a.Listar();
            cmbAfp.DisplayMember = "nombre_afp";
            cmbAfp.ValueMember = "id_AFP";

            Negocio.Seguro_salud s = new Negocio.Seguro_salud();
            cmbSalud.DataSource = s.Listar();
            cmbSalud.DisplayMember = "nombre_seg_sald";
            cmbSalud.ValueMember = "id_seguro_sald";
        }

        #endregion




        #region Metodos
        private void rellenar_cmb_ubicacion_por_busqueda(Persona per)
        {
            Negocio.Region reg = new Negocio.Region();
            cmbRegion_.DataSource = reg.Listar_region_por_idcomuna(per.Comuna);
            cmbRegion_.DisplayMember = "nombre_region";
            cmbRegion_.ValueMember = "id_region";

            Provincia prov = new Provincia();
            cmbProvidencia.DataSource = prov.Listar_provincia_por_idcomuna(per.Comuna);
            cmbProvidencia.DisplayMember = "nombre_provincia";
            cmbProvidencia.ValueMember = "id_provincia";

            Comuna com = new Comuna();
            cmbComuna.DataSource = com.listar_comuna_por_id(per.Comuna);
            cmbComuna.DisplayMember = "nombre_comuna";
            cmbComuna.ValueMember = "id_comuna";
        }

        public void RellenarCmbx()
        {
            //despues hay que separar estos rellenos de cmb, para cada click que se le haga cuando desee cambiar los
            //datos originales
            cmbEstadoCivil.Items.Add("SOLTERO");
            cmbEstadoCivil.Items.Add("CASADO");
            cmbEstadoCivil.Items.Add("DIVORSIADO");
            cmbEstadoCivil.Items.Add("VIUDO");


            cmbSexo.Items.Add("MASCULINO");
            cmbSexo.Items.Add("FEMENINO");

            cmbOficioprofesion.Items.Add("OBRERO");
            cmbOficioprofesion.Items.Add("OFICINISTA");
        }

        #endregion



















    }
}
