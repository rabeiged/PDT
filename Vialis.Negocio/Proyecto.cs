using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Proyecto
    {
        #region Campos
        private string _id_proyecto, _nombre_proyecto;

        #endregion

        #region Propiedades
        public string Id_proyecto
        {
            get
            {
                return _id_proyecto;
            }

            set
            {
                _id_proyecto = value;
            }
        }

        public string Nombre_proyecto
        {
            get
            {
                return _nombre_proyecto;
            }

            set
            {
                _nombre_proyecto = value;
            }
        }

        #endregion

        #region Constructores
        public Proyecto()
        {
            init();
        }

        public Proyecto(string id_pro, string nom_pro)
        {
            init(); 

            this.Id_proyecto = id_pro;
            this.Nombre_proyecto = nom_pro;
        }
        #endregion

        #region Metodos
        private void init()
        {
            this.Id_proyecto = string.Empty;
            this.Nombre_proyecto = string.Empty;
        }
        #endregion


    }
}
