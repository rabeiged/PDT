using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Hito
    {
        #region Campos
        private int _id_hito;
        string _nombre_hit, _descrp_hit, _nivel_avan;
        DateTime _fec_ini, _fec_term;



        #endregion

        #region Propieades
        public int Id_hito
        {
            get
            {
                return _id_hito;
            }

            set
            {
                _id_hito = value;
            }
        }

        public string Nombre_hit
        {
            get
            {
                return _nombre_hit;
            }

            set
            {
                _nombre_hit = value;
            }
        }

        public string Descrp_hit
        {
            get
            {
                return _descrp_hit;
            }

            set
            {
                _descrp_hit = value;
            }
        }

        public string Nivel_avan
        {
            get
            {
                return _nivel_avan;
            }

            set
            {
                _nivel_avan = value;
            }
        }

        public DateTime Fec_ini
        {
            get
            {
                return _fec_ini;
            }

            set
            {
                _fec_ini = value;
            }
        }

        public DateTime Fec_term
        {
            get
            {
                return _fec_term;
            }

            set
            {
                _fec_term = value;
            }
        }

        #endregion

        #region Constructores
        public Hito()
        {
            init();
        }

        public Hito(int id_hito, string nom_hit, string desc_hit, string nivel_avan,
            DateTime fec_ini, DateTime fec_term)
        {
            init();

            this.Id_hito = id_hito;
            this.Nombre_hit = nom_hit;
            this.Descrp_hit = desc_hit;
            this.Nivel_avan = nivel_avan;
            this.Fec_ini = fec_ini;
            this.Fec_term = fec_term;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_hito = 0;
            this.Nombre_hit = string.Empty;
            this.Descrp_hit = string.Empty;
            this.Nivel_avan = string.Empty;
            this.Fec_ini = DateTime.Now;
            this.Fec_term = DateTime.Now;
        }

        #endregion

    }
}
