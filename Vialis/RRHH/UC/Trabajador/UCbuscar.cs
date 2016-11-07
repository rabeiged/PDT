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
    public partial class UCbuscar : UserControl
    {
        public UCbuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarTrabajador_Click(object sender, EventArgs e)
        {
            
            try
            {
                string run = txtRunBusqueda.Text;
                Persona per = new Persona();
                per.Run = run;
                if (per.Buscar())
                {
                    Comuna co = new Comuna();
                    co.Id_comuna = per.Comuna;
                    co.Buscar();

                    Provincia pro = new Provincia();
                    pro.Id_provincia = co.Provincia;
                    pro.Buscar();

                    Trabajador_empresa tra = new Trabajador_empresa();
                    tra.Per = per;
                    tra.Buscar();


                    Descuento des = new Descuento();
                    des.Run = per.Run;
                    des.Buscar();

                    Afp af = new Afp();
                    af.Id_afp = des.Id_afp;
                    af.Buscar();

                    Seguro_salud sal = new Seguro_salud();
                    sal.Id_seguro_sald = des.Id_seguro_salud;
                    sal.Buscar();


                    Negocio.Region re = new Negocio.Region();
                    re.Id_region = re.Id_region;
                    re.Listar_region_por_idprov(pro.Id_provincia);


                    
                    txtRun.Text = per.Run;
                    txtNombre.Text = per.Nombre;
                    txtApellidoP.Text = per.Apellido_paterno;
                    txtApellidoM.Text = per.Apellido_materno;
                    txtAFP.Text = af.Nombre_afp;
                    txtSalud.Text = sal.Nombre_seg_sald;
                    txtDireccion.Text = per.Direccion;
                    txtComuna.Text = co.Nombre_comuna;


                    //Lo mande como listado y no como string por si usamos el metodo de nuevo
                    txtRegion.Text = re.Listar_region_por_idprov(pro.Id_provincia).Last().Nombre_region;
                    txtEcivil.Text = per.Estado_civil;
                    txtProvincia.Text = pro.Nombre_provincia;
                    txtPorcAFP.Text = des.Porcentaje_descuento_afp.ToString();
                    txtPorcSalud.Text = des.Porcentaje_descuento_salud.ToString();



                    if(per.Sexo == "F")
                    {
                        txtSexo.Text = "FEMENINO";
                    }
                    else
                    {
                        txtSexo.Text = "MASCULINO";
                    }
                    


                    txtFecnac.Text = per.Fecha_nacimiento.ToShortDateString();
                    

                    
                }else
                {
                    MessageBox.Show("Trabajador no encuentrado.");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
