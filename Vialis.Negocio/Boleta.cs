using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Boleta
    {
        #region Campos
        private int _id_boleta;
        private DateTime _fecha;

        #endregion

        #region Propiedades
        public int Id_boleta
        {
            get
            {
                return _id_boleta;
            }

            set
            {
                _id_boleta = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        #endregion

        #region Constructores
        public Boleta()
        {
            init();
        }

        public Boleta(int id_bol, DateTime fec)
        {
            init();

            this.Id_boleta = id_bol;
            this.Fecha = fec;
        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_boleta = 0;
            this.Fecha = DateTime.Now;
        }
        #endregion

    }
}
