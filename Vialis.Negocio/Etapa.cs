using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Etapa
    {
        #region Campos
        private int _id_etapa;
        private string _nombre_etapa, _descripcion_etap, _nivel_avan;
        private DateTime _fec_inicio, _fec_termino;

        #endregion

        #region Propiedades
        public int Id_etapa
        {
            get
            {
                return _id_etapa;
            }

            set
            {
                _id_etapa = value;
            }
        }

        public string Nombre_etapa
        {
            get
            {
                return _nombre_etapa;
            }

            set
            {
                _nombre_etapa = value;
            }
        }

        public string Descripcion_etap
        {
            get
            {
                return _descripcion_etap;
            }

            set
            {
                _descripcion_etap = value;
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

        public DateTime Fec_inicio
        {
            get
            {
                return _fec_inicio;
            }

            set
            {
                _fec_inicio = value;
            }
        }

        public DateTime Fec_termino
        {
            get
            {
                return _fec_termino;
            }

            set
            {
                _fec_termino = value;
            }
        }

        #endregion

        #region Constructores
        public Etapa()
        {
            init();
        }

        public Etapa(int id_etap, string nom_etap, string descrp, string nivel_avanc,
            DateTime fec_ini, DateTime fec_term)
        {
            init();

            this.Id_etapa = id_etap;
            this.Nombre_etapa = nom_etap;
            this.Descripcion_etap = descrp;
            this.Nivel_avan = nivel_avanc;
            this.Fec_inicio = fec_ini;
            this.Fec_termino = fec_term;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_etapa = 0;
            this.Nombre_etapa = string.Empty;
            this.Descripcion_etap = string.Empty;
            this.Nivel_avan = string.Empty;
            this.Fec_inicio = DateTime.Now;
            this.Fec_termino = DateTime.Now;
        }
        #endregion




    }
}
