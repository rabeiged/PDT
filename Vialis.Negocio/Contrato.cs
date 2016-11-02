using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Contrato
    {
        #region Campos
        private string _id_contrato, _nombre_contrato, _descripcion;
        private DateTime _fecha_ini, _fecha_term;
        private int _sueldo_b, _dias_men_req, _valor_dia;
        #endregion


        #region Propiedades
        public string Id_contrato
        {
            get
            {
                return _id_contrato;
            }

            set
            {
                _id_contrato = value;
            }
        }

        public string Nombre_contrato
        {
            get
            {
                return _nombre_contrato;
            }

            set
            {
                _nombre_contrato = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public DateTime Fecha_ini
        {
            get
            {
                return _fecha_ini;
            }

            set
            {
                _fecha_ini = value;
            }
        }

        public DateTime Fecha_term
        {
            get
            {
                return _fecha_term;
            }

            set
            {
                _fecha_term = value;
            }
        }

        public int Sueldo_b
        {
            get
            {
                return _sueldo_b;
            }

            set
            {
                _sueldo_b = value;
            }
        }

        public int Dias_men_req
        {
            get
            {
                return _dias_men_req;
            }

            set
            {
                _dias_men_req = value;
            }
        }

        public int Valor_dia
        {
            get
            {
                return _valor_dia;
            }

            set
            {
                _valor_dia = value;
            }
        }
        #endregion

        #region Constructores
        public Contrato()
        {
            init();
        }

        public Contrato(string id_cont, string nom_cont, string descrp, DateTime fec_ini, 
            DateTime fec_ter, int suel_b, int dias_men, int valor_d)
        {
            init();

            this.Id_contrato = id_cont;
            this.Nombre_contrato = nom_cont;
            this.Descripcion = descrp;
            this.Fecha_ini = fec_ini;
            this.Fecha_term = fec_ter;
            this.Sueldo_b = suel_b;
            this.Dias_men_req = dias_men;
            this.Valor_dia = valor_d;

        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_contrato = string.Empty;
            this.Nombre_contrato = string.Empty;
            this.Descripcion = string.Empty;
            this.Fecha_ini = DateTime.Now;
            this.Fecha_term = DateTime.Now;
            this.Sueldo_b = 0;
            this.Dias_men_req = 0;
            this.Valor_dia = 0;
        }
        #endregion

    }
}
