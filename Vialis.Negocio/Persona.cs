using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Vialis.Negocio
{
    public class Persona
    {
        #region Campos
        private string _run, _nombre, _apellido_paterno, _apellido_materno, _direccion, _estado_civil, _sexo;
        private int _comuna, _id_trab_empre;
        private DateTime _fecha_nacimiento;


        #endregion

        #region Propiedades
        public string Run
        {
            get
            {
                return _run;
            }

            set
            {
                _run = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellido_paterno
        {
            get
            {
                return _apellido_paterno;
            }

            set
            {
                _apellido_paterno = value;
            }
        }

        public string Apellido_materno
        {
            get
            {
                return _apellido_materno;
            }

            set
            {
                _apellido_materno = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Estado_civil
        {
            get
            {
                return _estado_civil;
            }

            set
            {
                _estado_civil = value;
            }
        }



        public DateTime Fecha_nacimiento
        {
            get
            {
                return _fecha_nacimiento;
            }

            set
            {
                _fecha_nacimiento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }

        public int Comuna
        {
            get
            {
                return _comuna;
            }

            set
            {
                _comuna = value;
            }
        }

        public int Id_trab_empre
        {
            get
            {
                return _id_trab_empre;
            }

            set
            {
                _id_trab_empre = value;
            }
        }


        #endregion

        #region Constructores
        public Persona()
        {
            init();
        }



        public Persona(string run, string nom, string ap_paterno, string ap_materno, string dir, string ecivil, string sex, 
            DateTime fec_nac, int comuna)
        {
            init();
            this.Run = run;
            this.Nombre = nom;
            this.Apellido_paterno = ap_paterno;
            this.Apellido_materno = ap_materno;
            this.Direccion = dir;
            this.Estado_civil = ecivil;
            this.Sexo = sex;
            this.Fecha_nacimiento = fec_nac.Date;
            this.Comuna = comuna;

  
        }
        #endregion

        #region Metodos
        private void init()
        {
            this.Run = string.Empty;
            this.Nombre = string.Empty;
            this.Apellido_paterno = string.Empty;
            this.Apellido_materno = string.Empty;
            this.Direccion = string.Empty;
            this.Estado_civil = string.Empty;
            this.Sexo = string.Empty;
            this.Fecha_nacimiento = DateTime.Now;
            this.Comuna = 0;
            
        }

        public bool Crear()
        {
            
            try
            {
                Vialis.DALC.Persona perso = new Vialis.DALC.Persona();
                
                perso.Persona_run = this.Run;
                perso.Persona_nombre = this.Nombre;
                perso.Persona_apellido_paterno = this.Apellido_paterno;
                perso.Persona_apellido_materno = this.Apellido_materno;
                perso.Persona_sexo = this.Sexo;
                perso.Persona_fecha_nacimiento = this.Fecha_nacimiento;
                perso.Persona_direccion = this.Direccion;
                perso.Persona_estado_civil = this.Estado_civil;
                perso.Persona_id_comuna = this.Comuna;
                ConectorDALC.ModeloVialis.Persona.Add(perso);
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
                Vialis.DALC.Persona perso = ConectorDALC.ModeloVialis.Persona.First
                    (
                        p => p.Persona_run == this.Run
                    );
                this.Run = perso.Persona_run;
                this.Nombre = perso.Persona_nombre;
                this.Apellido_paterno = perso.Persona_apellido_paterno;
                this.Apellido_materno = perso.Persona_apellido_materno;
                this.Sexo = perso.Persona_sexo;
                this.Fecha_nacimiento = (DateTime)perso.Persona_fecha_nacimiento;
                this.Direccion = perso.Persona_direccion;
                this.Estado_civil = perso.Persona_estado_civil;
                this.Comuna = (int)perso.Comuna.id_comuna;
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool Actualizar()
        {
            try
            {
                Vialis.DALC.Persona perso = ConectorDALC.ModeloVialis.Persona.First
                    (
                        p => p.Persona_run == this.Run
                    );

                perso.Persona_run = this.Run;
                perso.Persona_nombre = this.Nombre;
                perso.Persona_apellido_paterno = this.Apellido_paterno;
                perso.Persona_apellido_materno = this.Apellido_materno;
                perso.Persona_sexo = this.Sexo;
                perso.Persona_fecha_nacimiento = this.Fecha_nacimiento;
                perso.Persona_direccion = this.Direccion;
                perso.Persona_estado_civil = this.Estado_civil;
                //perso.Persona_id_comuna = this.Comuna;
                //perso.Trabajador_empresa = null;

                ConectorDALC.ModeloVialis.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Eliminar()
        {
            try
            {
                Vialis.DALC.Persona perso = ConectorDALC.ModeloVialis.Persona.First
                    (
                        p => p.Persona_run == this.Run
                    );

                ConectorDALC.ModeloVialis.Persona.Remove(perso);
                ConectorDALC.ModeloVialis.SaveChanges();

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
