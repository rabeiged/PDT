using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Cotizacion
    {
        #region Campos
        private string _id_cotizacion;
        private DateTime _fecha;

        #endregion

        #region Propiedades
        public string Id_cotizacion
        {
            get
            {
                return _id_cotizacion;
            }

            set
            {
                _id_cotizacion = value;
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
        public Cotizacion()
        {
            init();

        }

        public Cotizacion(string id_coti, DateTime fec)
        {
            init();

            this.Id_cotizacion = id_coti;
            this.Fecha = fec;
        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_cotizacion = string.Empty;
            this.Fecha = DateTime.Now;

        }
        #endregion



    }
}
