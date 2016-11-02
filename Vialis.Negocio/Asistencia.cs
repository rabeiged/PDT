using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Asistencia
    {
        #region Campos
        private int _id_asistencia;
        private DateTime _fecha_asistencia;

        #endregion

        #region Propiedades
        public int Id_asistencia
        {
            get
            {
                return _id_asistencia;
            }

            set
            {
                _id_asistencia = value;
            }
        }

        public DateTime Fecha_asistencia
        {
            get
            {
                return _fecha_asistencia;
            }

            set
            {
                _fecha_asistencia = value;
            }
        }
        #endregion

        #region Constructores
        public Asistencia()
        {
            init();
        }

        public Asistencia(int id_asis, DateTime fec_asis)
        {
            init();

            this.Id_asistencia = id_asis;
            this.Fecha_asistencia = fec_asis;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_asistencia = 0;
            this.Fecha_asistencia = DateTime.Now;
        }
        #endregion


    }
}
