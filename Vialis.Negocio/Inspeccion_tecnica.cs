using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Inspeccion_tecnica
    {
        #region Campos
        private int _id_inspeccion_tec;
        private string _detalle_inspeccion_t, _nivel_avance;

        #endregion

        #region Propiedades
        public int Id_inspeccion_tec
        {
            get
            {
                return _id_inspeccion_tec;
            }

            set
            {
                _id_inspeccion_tec = value;
            }
        }

        public string Detalle_inspeccion_t
        {
            get
            {
                return _detalle_inspeccion_t;
            }

            set
            {
                _detalle_inspeccion_t = value;
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
        #endregion

        #region Constructores
        public Inspeccion_tecnica()
        {
            init();
        }

        public Inspeccion_tecnica(int id_insp, string detalle_ins, string nivel_avan)
        {
            init();

            this.Id_inspeccion_tec = id_insp;
            this.Detalle_inspeccion_t = detalle_ins;
            this.Nivel_avance = nivel_avan;
        }
        #endregion

        #region Metodos
        public void init()
        {
            this.Id_inspeccion_tec = 0;
            this.Detalle_inspeccion_t = string.Empty;
            this.Nivel_avance = string.Empty;
        }
        #endregion


    }
}
