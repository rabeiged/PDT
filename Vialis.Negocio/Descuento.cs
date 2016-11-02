using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Vialis.Negocio
{
    public class Descuento
    {
        #region Campos
        private int _id_seguro_salud, _id_afp, _id_descuento;
        private double _porcentaje_descuento_salud;
        private double _porcentaje_descuento_afp;
        private Trabajador_empresa _trabEmpre;



        #endregion

        #region Propiedades
        

        public int Id_seguro_salud
        {
            get
            {
                return _id_seguro_salud;
            }

            set
            {
                _id_seguro_salud = value;
            }
        }

        public int Id_afp
        {
            get
            {
                return _id_afp;
            }

            set
            {
                _id_afp = value;
            }
        }

        public int Id_descuento
        {
            get
            {
                return _id_descuento;
            }

            set
            {
                _id_descuento = value;
            }
        }

        public double Porcentaje_descuento_salud
        {
            get
            {
                return _porcentaje_descuento_salud;
            }

            set
            {
                _porcentaje_descuento_salud = value;
            }
        }

        public Trabajador_empresa TrabEmpre
        {
            get
            {
                return _trabEmpre;
            }

            set
            {
                _trabEmpre = value;
            }
        }

        public double Porcentaje_descuento_afp
        {
            get
            {
                return _porcentaje_descuento_afp;
            }

            set
            {
                _porcentaje_descuento_afp = value;
            }
        }

        #endregion


        #region Constructores

        public Descuento()
        {
            init();
        }

        public Descuento(double porc_desc_salud,double porc_desc_afp, int id_ss, int id_af, Trabajador_empresa tre)
        {
            init();
            this.Porcentaje_descuento_salud = porc_desc_salud;
            this.Porcentaje_descuento_afp = porc_desc_afp;
            this.Id_seguro_salud = id_ss;
            this.Id_afp = id_af;
            this.TrabEmpre = tre;

        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Porcentaje_descuento_salud = 0;
            this.Porcentaje_descuento_afp = 0;
        }

        public bool Crear()
        {
            try
            {
                
                Vialis.DALC.Descuento desc = new Vialis.DALC.Descuento();
                
                //Consulta para recuperar ultimo trabajador  asignado. 
                DALC.Trabajador_empresa t = ConectorDALC.ModeloVialis.Trabajador_empresa.SqlQuery("select * from dbo.Trabajador_empresa tre where tre.Persona_run = @p0;", this.TrabEmpre.Per.Run).Last();
                desc.id_AFP = this.Id_afp;
                desc.id_seguro_sald = this.Id_seguro_salud;
                desc.porc_descto_salud = (float)this.Porcentaje_descuento_salud;
                desc.porc_descto_AFP = (float)this._porcentaje_descuento_afp;
                desc.Persona_run = this.TrabEmpre.Per.Run;
                desc.id_trabajador = t.id_trabajador;                

                ConectorDALC.ModeloVialis.Descuento.Add(desc);
                ConectorDALC.ModeloVialis.SaveChanges();
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }

         

        }

        public bool Buscar()
        {
            try
            {
                Vialis.DALC.Descuento desc = ConectorDALC.ModeloVialis.Descuento.First
                    (
                        d => d.Persona_run == this.TrabEmpre.Per.Run
                    );

                this.Id_descuento = desc.id_descto;
                this.Id_seguro_salud = (int) desc.id_seguro_sald;
                this.Porcentaje_descuento_afp = (float)desc.porc_descto_AFP;
                this.Porcentaje_descuento_salud = (float)desc.porc_descto_salud;
                this.Id_afp = (int)desc.id_AFP;
                this.Id_seguro_salud = (int)desc.id_seguro_sald;
                this.TrabEmpre.Per.Run = desc.Trabajador_empresa.Persona_run;
                this.TrabEmpre.Id_trabajador_empre = desc.Trabajador_empresa.id_trabajador;

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion
    }
}
