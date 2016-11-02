using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    //REVISAR SI CORRESPONDE HACER HERENCIA.
    public class Categoria
    {
        #region Campos
        private int _id_categoria;
        private string _nombre_categoria, _descripcion;

        #endregion

        #region Propiedades
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

        public string Nombre_categoria
        {
            get
            {
                return _nombre_categoria;
            }

            set
            {
                _nombre_categoria = value;
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
        public Categoria()
        {
            init();
        }
        public Categoria(int id_cate, string nom_cate, string descrp)
        {
            init();

            this.Id_categoria = id_cate;
            this.Nombre_categoria = nom_cate;
            this.Descripcion = descrp;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_categoria = 0;
            this.Nombre_categoria = string.Empty;
            this.Descripcion = string.Empty;
      
        }
        #endregion


    }
}
