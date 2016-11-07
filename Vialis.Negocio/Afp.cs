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
        private int _id_afp, _id_descuento;
        private Descuento _des;
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

        public int Id_descuento
        {
            get
            {
                return _id_descuento;
            }

            set
            {
                _id_descuento = value;
            }
        }

        public Descuento Des
        {
            get
            {
                return _des;
            }

            set
            {
                _des = value;
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
                a.Nombre_afp = af.nombre_afp.ToUpper();
                resultado.Add(a);
                
            }
            return resultado;
        }

        public IList<Afp> Listar_afp_por_id(string run)
        {
            List<Afp> resultado = new List<Afp>();
            foreach (Vialis.DALC.Descuento de in ConectorDALC.ModeloVialis.Descuento.ToList())
            {
                
                if (de.Persona_run.CompareTo(run) == 0)
                {
                    Afp a = new Negocio.Afp();
                    a.Id_afp = (int)de.id_AFP;
                    a.Nombre_afp = de.AFP.nombre_afp.ToUpper();
                    resultado.Add(a);
                    break;
                }

            }
            return resultado;
        }

        public bool Buscar()
        {
            try
            {
                Vialis.DALC.AFP af = ConectorDALC.ModeloVialis.AFP.First
                    (
                        a => a.id_AFP == this.Id_afp
                    );

                this.Id_afp = af.id_AFP;
                this.Nombre_afp = af.nombre_afp;

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion

    }
}
