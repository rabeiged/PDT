using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    //REVISAR SI ES QUE CORRESPONDE HERENCIA.
    public class Subcategoria
    {
        #region Campos
        private int _id_categoria;
        private string _nombre_subcategoria, _descripcion;

        #endregion

        #region Propiedades
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

        public int Id_categoria
        {
            get
            {
                return _id_categoria;
            }

            set
            {
                _id_categoria = value;
            }
        }

        public string Nombre_subcategoria
        {
            get
            {
                return _nombre_subcategoria;
            }

            set
            {
                _nombre_subcategoria = value;
            }
        }
        #endregion

        #region Constructores
        public Subcategoria()
        {
            init();
        }
        public Subcategoria(int id_subcate, string nom_subcate, string descrp)
        {
            init();

            this.Id_categoria = id_subcate;
            this.Nombre_subcategoria = nom_subcate;
            this.Descripcion = descrp;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_categoria = 0;
            this.Nombre_subcategoria = string.Empty;
            this.Descripcion = string.Empty;
        }
        #endregion


    }
}
