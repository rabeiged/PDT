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
//using Vialis.DALC;

namespace Vialis.RRHH.UC.Trabajador
{
    public partial class UCagregar : UserControl
    {
        public UCagregar()
        {
            InitializeComponent();
            RellenarCmbx();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                #region Variables
                
                double porcafp = 0;
                double porcsalud = 0;
                string sexo = string.Empty;
                string flag = string.Empty;
                int comuna = 0;
                int afp = 0;
                int salud = 0;
                string run = string.Empty;
                string nombre = txtNombre.Text.Trim();
                string apellidop = txtApellidoP.Text.Trim();
                string apellidom = txtApellidoM.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                
                string ecivil = string.Empty;
                string ofipro = string.Empty;
                DateTime fec_nac = dtpFecha_nacimiento.Value;

                #endregion

                #region Validaciones
                Validaciones v = new Validaciones();

                //Valida rut.
                if (v.ValidarRun(txtRun.Text.ToString().Trim()))
                {
                    run = txtRun.Text.ToString().Trim();

                }
                else
                {
                    flag = "Rut.";
                }

                //Valida comuna seleccionada.
                if (int.Parse(cmbComuna.SelectedValue.ToString()) < 0)
                {

                    flag = "Comuna.";
                }
                else
                {
                    comuna = int.Parse(cmbComuna.SelectedValue.ToString());
                }

                //Valida sexo seleccionado.
                if (String.IsNullOrEmpty(cmbSexo.SelectedItem.ToString()))
                {

                    flag = "Sexo.";
                }
                else
                {
                    if (cmbSexo.SelectedIndex == 0)
                    {
                        sexo = "M";
                    }
                    else
                    {
                        sexo = "F";
                    }

                }

                //Valida oficio / profesion seleccionada
                if (String.IsNullOrEmpty(cmbOficioprofesion.SelectedItem.ToString()))
                {
                    flag = "Oficio / Profesion.";
                }
                else
                {
                    ofipro = cmbOficioprofesion.SelectedItem.ToString();
                }

                //Valida Estado civil seleccionado
                if (String.IsNullOrEmpty(cmbEstadoCivil.SelectedItem.ToString()))
                {
                    flag = "Estado Civil.";
                }
                else
                { 
                    //Para manipular los datos del cmbx que no esta conectado a la base de datos, se puede tomar el "objeto" completo.
                    ecivil = cmbEstadoCivil.SelectedItem.ToString();
                }

                //Valida AFP seleccionada.
                if (String.IsNullOrEmpty(cmbAfp.SelectedValue.ToString()))
                {
                    flag = "AFP";
                }
                else
                {
                    afp = int.Parse(cmbAfp.SelectedValue.ToString());
                }

                //Valida Salud seleccionada
                if (String.IsNullOrEmpty(cmbSalud.SelectedValue.ToString()))
                {
                    flag = "Salud";
                }
                else
                {
                    salud = int.Parse(cmbSalud.SelectedValue.ToString());
                }

                //Valida que campo % Afp, sea un %.
                if (double.TryParse(txtPorcAFP.Text.ToString(), out porcafp))
                {
                    porcafp = Convert.ToDouble(txtPorcAFP.Text.ToString());
                }
                else
                {
                    flag = "% de descuento AFP [n,n]";
                }

                //Valida que campo % Seguro de salud, sea un %
                if (double.TryParse(txtPorcSalud.Text.ToString(), out porcafp))
                {
                    porcsalud = Convert.ToDouble(txtPorcSalud.Text.ToString());
                }
                else
                {
                    flag = "% de descuento Salud [n,n]";
                }





                #endregion

                
                //flag captura el campo con problemas, si no hay nada en flag, comienza a construir los objetos.
                if (String.IsNullOrEmpty(flag))
                {
                    Persona objPersona = new Persona(run, nombre, apellidop, apellidom, direccion, ecivil, sexo, fec_nac, comuna);

                    if (objPersona.Crear())
                    {
                        Trabajador_empresa objTrab = new Trabajador_empresa(ofipro, "1", objPersona);

                        if (objTrab.Crear())
                        {
                            Descuento objDescuento = new Descuento(porcsalud,porcafp, salud, afp, objTrab);
                            if (objDescuento.Crear())
                            {
                                MessageBox.Show("Trabajador ingresado con exito.");
                            }
                            else
                            {
                                MessageBox.Show("Error en creacion de objeto Descuento");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error en creacion de objeto trabajador");
                        };
                    }

                    else
                    {
                        MessageBox.Show("Error en creacion de objeto persona");
                    }
                }
                else
                {
                    MessageBox.Show("Revise campo: " + flag.ToUpper());
                }
            }
            catch (Exception)
            {
                throw;
            } 
        }


        /// <summary>
        /// Metodo que rellena los comboBox.
        /// </summary>
        /// 

        public void RellenarCmbx()
        {
            //El nombre de los cambios en display y value member debe ser el definido en la clase. 
            Negocio.Region r = new Negocio.Region();
            cmbRegion.DataSource = r.Listar();
            cmbRegion.DisplayMember = "nombre_region";
            cmbRegion.ValueMember = "id_region";


            Negocio.Afp a = new Negocio.Afp();
            cmbAfp.DataSource = a.Listar();
            cmbAfp.DisplayMember = "nombre_afp";
            cmbAfp.ValueMember = "id_AFP";

            Negocio.Seguro_salud s = new Negocio.Seguro_salud();
            cmbSalud.DataSource = s.Listar();
            cmbSalud.DisplayMember = "nombre_seg_sald";
            cmbSalud.ValueMember = "id_seguro_sald";

            cmbEstadoCivil.Items.Add("SOLTERO");
            cmbEstadoCivil.Items.Add("CASADO");
            cmbEstadoCivil.Items.Add("DIVORSIADO");
            cmbEstadoCivil.Items.Add("VIUDO");


            cmbSexo.Items.Add("MASCULINO");
            cmbSexo.Items.Add("FEMENINO");

            cmbOficioprofesion.Items.Add("OBRERO");
            cmbOficioprofesion.Items.Add("OFICINISTA");

        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mando el valor seleccionado en el combx de Region, para mandar el listado de las provincias correspondiendes.
            Negocio.Provincia p = new Negocio.Provincia();
            cmbProvidencia.DataSource = p.Listar(int.Parse(cmbRegion.SelectedValue.ToString()));
            cmbProvidencia.DisplayMember = "nombre_provincia";
            cmbProvidencia.ValueMember = "id_provincia";
        }

        private void cmbProvidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lo mismo de arriba, se manda el valor de provincia.
            Negocio.Comuna c = new Negocio.Comuna();
            cmbComuna.DataSource = c.Listar(int.Parse(cmbProvidencia.SelectedValue.ToString()));
            cmbComuna.DisplayMember = "nombre_comuna";
            cmbComuna.ValueMember = "id_comuna";
        }


    }
}
