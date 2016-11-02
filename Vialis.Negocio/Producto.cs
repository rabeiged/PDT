using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Producto
    {
        #region Campos
        private int _id_producto;
        private string _nombre_producto, _descripcion, _marca;

        #endregion

        #region Propiedades
        public int Id_producto
        {
            get
            {
                return _id_producto;
            }

            set
            {
                _id_producto = value;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string Nombre_producto
        {
            get
            {
                return _nombre_producto;
            }

            set
            {
                _nombre_producto = value;
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

        #endregion

        #region Constructores
        public Producto()
        {
            init();
        }
        public Producto(int id_pro, string nom_pro, string descrip, string marc)
        {
            init();

            this.Id_producto = id_pro;
            this.Nombre_producto = nom_pro;
            this.Descripcion = descrip;
            this.Marca = marc;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_producto = 0;
            this.Nombre_producto = string.Empty;
            this.Descripcion = string.Empty;
            this.Marca = string.Empty;
        }
        #endregion


    }
}
