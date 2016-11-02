using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Pago
    {
        #region Campos
        private int _id_pago, costo;
        private string _estado_pago;
        private DateTime _fecha_pago;

        #endregion

        #region Propiedades
        public int Id_pago
        {
            get
            {
                return _id_pago;
            }

            set
            {
                _id_pago = value;
            }
        }

        public int Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public string Estado_pago
        {
            get
            {
                return _estado_pago;
            }

            set
            {
                _estado_pago = value;
            }
        }

        public DateTime Fecha_pago
        {
            get
            {
                return _fecha_pago;
            }

            set
            {
                _fecha_pago = value;
            }
        }
        #endregion

        #region Constructores
        public Pago()
        {
            init();
        }
        public Pago(int id_pag, string estado_pag, DateTime fec_pag)
        {
            init();

            this.Id_pago = id_pag;
            this.Estado_pago = estado_pag;
            this.Fecha_pago = fec_pag;
            
        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_pago = 0;
            this.costo = 0;
            this.Estado_pago = string.Empty;
            this.Fecha_pago = DateTime.Now;
        }
        #endregion



    }
}
