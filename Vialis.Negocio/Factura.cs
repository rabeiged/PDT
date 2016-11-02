using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Factura
    {
        #region Campos
        private int _id_factura, _costo;
        private string _detalle_factura;
        private DateTime _fecha_emision;

        #endregion

        #region Propiedades
        public int Id_factura
        {
            get
            {
                return _id_factura;
            }

            set
            {
                _id_factura = value;
            }
        }

        public int Costo
        {
            get
            {
                return _costo;
            }

            set
            {
                _costo = value;
            }
        }

        public string Detalle_factura
        {
            get
            {
                return _detalle_factura;
            }

            set
            {
                _detalle_factura = value;
            }
        }

        public DateTime Fecha_emision
        {
            get
            {
                return _fecha_emision;
            }

            set
            {
                _fecha_emision = value;
            }
        }

        #endregion

        #region Constructores
        public Factura()
        {
            init();

        }

        
        public Factura(int id_fac, int cost, string detall_fact, DateTime fec_emi)
        {
            init();

            this.Id_factura = id_fac;
            this.Costo = cost;
            this.Detalle_factura = detall_fact;
            this.Fecha_emision = fec_emi;
        }
        #endregion

        #region Metodos
        private void init()
        {
            this.Id_factura = 0;
            this.Costo = 0;
            this.Detalle_factura = string.Empty;
            this.Fecha_emision = DateTime.Now;
        }
        #endregion


    }
}
