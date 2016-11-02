using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Registro_avance
    {
        #region Campos
        private int _id_reg_avance;
        private string _nivel_avance, _detalle;
        private DateTime _fecha_registro;



        #endregion

        #region Propiedades
        public int Id_reg_avance
        {
            get
            {
                return _id_reg_avance;
            }

            set
            {
                _id_reg_avance = value;
            }
        }

        public string Nivel_avance
        {
            get
            {
                return _nivel_avance;
            }

            set
            {
                _nivel_avance = value;
            }
        }

        public string Detalle
        {
            get
            {
                return _detalle;
            }

            set
            {
                _detalle = value;
            }
        }

        public DateTime Fecha_registro
        {
            get
            {
                return _fecha_registro;
            }

            set
            {
                _fecha_registro = value;
            }
        }

        #endregion

        #region Constructores
        public Registro_avance()
        {
            init();
        }

        

        public Registro_avance(int id_reg, string nivel_av, string detall, DateTime fec_reg)
        {
            init();

            this.Id_reg_avance = id_reg;
            this.Nivel_avance = nivel_av;
            this.Detalle = detall;
            this.Fecha_registro = fec_reg;

        }
        #endregion

        #region Metodos
        private void init()
        {
            this.Id_reg_avance = 0;
            this.Nivel_avance = string.Empty;
            this.Detalle = string.Empty;
            this.Fecha_registro = DateTime.Now;
        }
        #endregion


    }
}
