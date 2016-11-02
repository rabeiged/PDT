using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Proveedor
    {
        #region Campos
        private int _id_proveedor;
        private string _nom_proveedor;

        #endregion

        #region Propiedades
        public int Id_proveedor
        {
            get
            {
                return _id_proveedor;
            }

            set
            {
                _id_proveedor = value;
            }
        }

        public string Nom_proveedor
        {
            get
            {
                return _nom_proveedor;
            }

            set
            {
                _nom_proveedor = value;
            }
        }

        #endregion

        #region Constructores
        public Proveedor()
        {
            init();
        }
        public Proveedor(int id_pro, string nom_pro)
        {
            this.Id_proveedor = id_pro;
            this.Nom_proveedor = nom_pro;
        }
        #endregion

        #region Metodos
        private void init()
        {
            this.Id_proveedor = 0;
            this.Nom_proveedor = string.Empty;
        }
        #endregion

    }
}
