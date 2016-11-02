using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Afp
    {
        #region Campos
        private string _nombre_afp;
        private int _id_afp;

        #endregion

        #region Propiedades


        public string Nombre_afp
        {
            get
            {
                return _nombre_afp;
            }

            set
            {
                _nombre_afp = value;
            }
        }

        public int Id_afp
        {
            get
            {
                return _id_afp;
            }

            set
            {
                _id_afp = value;
            }
        }
        #endregion

        #region Constructores
        public Afp()
        {
            init();
        }
        public Afp(int id_afp, string nom_afp)
        {
            init();

            this.Id_afp = id_afp;
            this.Nombre_afp = nom_afp;
        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_afp = 0;
            this.Nombre_afp = string.Empty;
        }

        public IList<Afp> Listar()
        {
            List<Afp> resultado = new List<Afp>();
            foreach (Vialis.DALC.AFP af in ConectorDALC.ModeloVialis.AFP.ToList())
            {
                Afp a = new Negocio.Afp();
                a.Id_afp = (int)af.id_AFP;
                a.Nombre_afp = af.nombre_afp;
                resultado.Add(a);
                
            }
            return resultado;
        }
        #endregion

    }
}
