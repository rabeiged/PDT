using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Detalle_boleta
    {
        #region Campos
        private int _id_detalle_boleta, _cantidad, _precio;

        #endregion

        #region Propiedades
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

        public int Id_detalle_boleta
        {
            get
            {
                return _id_detalle_boleta;
            }

            set
            {
                _id_detalle_boleta = value;
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
        public Detalle_boleta()
        {
            init();
        }

       
        public Detalle_boleta(int id_detall_bol, int cant, int prec)
        {
            init();

            this.Id_detalle_boleta = id_detall_bol;
            this.Cantidad = cant;
            this.Precio = prec;
        }
        #endregion

        #region Metodos
        private void init()
        {
            this.Id_detalle_boleta = 0;
            this.Cantidad = 0;
            this.Precio = 0;
        }

        #endregion


    }
}
