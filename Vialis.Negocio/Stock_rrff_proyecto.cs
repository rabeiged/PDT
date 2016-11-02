using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Stock_rrff_proyecto
    {
        #region Campos
        private int _id_material, _cantidad;
        private string _marca, _nombre_producto;

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

        public int Id_material
        {
            get
            {
                return _id_material;
            }

            set
            {
                _id_material = value;
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

        #endregion

        #region Constructores
        public Stock_rrff_proyecto()
        {
            init();
        }
        public Stock_rrff_proyecto(int id_mate, int canti, string marc, string nom_pro)
        {
            init();

            this.Id_material = id_mate;
            this.Cantidad = canti;
            this.Marca = marc;
            this.Nombre_producto = nom_pro;
        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_material = 0;
            this.Cantidad = 0;
            this.Marca = string.Empty;
            this.Nombre_producto = string.Empty;
        }
        #endregion
    }
}
