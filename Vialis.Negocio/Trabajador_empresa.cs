using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//para el increment
using System.Data;

namespace Vialis.Negocio
{
    //Trabajador empresa hereda los camnpos/metodos de Persona
    public class Trabajador_empresa
    {


        #region Campos
        private int _id_descuento, _id_trabajador_empre;
        private string _oficio_profesion, _rol;
        private Persona _per;
        private Descuento _des;
  

  

        #endregion

        #region Propiedades
           public string Oficio_profesion
        {
            get
            {
                return _oficio_profesion;
            }

            set
            {
                _oficio_profesion = value;
            }
        }

        public string Rol
        {
            get
            {
                return _rol;
            }

            set
            {
                _rol = value;
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

        public Persona Per
        {
            get
            {
                return _per;
            }

            set
            {
                _per = value;
            }
        }

        public Descuento Des
        {
            get
            {
                return _des;
            }

            set
            {
                _des = value;
            }
        }

        public int Id_trabajador_empre
        {
            get
            {
                return _id_trabajador_empre;
            }

            set
            {
                _id_trabajador_empre = value;
            }
        }


        #endregion


        #region Constructores


        public Trabajador_empresa(string ofi_prof, string ro, Persona p)
        {
            init();
            
            this.Oficio_profesion = ofi_prof;
            this.Rol = ro;
            this.Per = p;
        }
        public Trabajador_empresa()
        {
            init();
        }

        #endregion

        #region Metodos
        private void init()
        {

            this.Oficio_profesion = string.Empty; 
            this.Rol = string.Empty;
        }

        public bool Crear()
        {
            try
            {
                Vialis.DALC.Trabajador_empresa trabEmpre = new Vialis.DALC.Trabajador_empresa();
                
                trabEmpre.Persona_run = this.Per.Run;
                trabEmpre.oficio_profesion = this.Oficio_profesion;
                trabEmpre.rol = this.Rol;               
                ConectorDALC.ModeloVialis.Trabajador_empresa.Add(trabEmpre);
                ConectorDALC.ModeloVialis.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


            #endregion

        }

        /*
        public bool Buscar()
        {
            try
            {
                Vialis.DALC.Trabajador_empresa tra_emp = ConectorDALC.ModeloVialis.Trabajador_empresa.First
                    (
                        p => p.id_trabajador == this.Id_trabajador
                    );

                this



                return true;

            }
            catch (Exception)
            {

                return false;
            }
            
        }
    */
    }
}
