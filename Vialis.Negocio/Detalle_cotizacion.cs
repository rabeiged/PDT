using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Detalle_cotizacion
    {
        #region Campos
        private string _id_detalle_cotizacion;
        private int _cantidad, _precio;

        #endregion

        #region Propiedades
        public string Id_detalle_cotizacion
        {
            get
            {
                return _id_detalle_cotizacion;
            }

            set
            {
                _id_detalle_cotizacion = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public int Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
        }


        #endregion

        #region Constructores
        public Detalle_cotizacion()
        {
            init();
        }

        public Detalle_cotizacion(string id_detall_coti, int canti, int preci)
        {
            init();

            this.Id_detalle_cotizacion = id_detall_coti;
            this.Cantidad = canti;
            this.Precio = preci;

        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_detalle_cotizacion = string.Empty;
            this.Cantidad = 0;
            this.Precio = 0;
        }
        #endregion


    }
}
