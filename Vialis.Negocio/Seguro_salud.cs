using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Seguro_salud
    {
        #region Campos
        private string _nombre_seg_sald;
        private int _id_seguro_sald;


        #endregion

        #region Propiedades
        public string Nombre_seg_sald
        {
            get
            {
                return _nombre_seg_sald;
            }

            set
            {
                _nombre_seg_sald = value;
            }
        }

        public int Id_seguro_sald
        {
            get
            {
                return _id_seguro_sald;
            }

            set
            {
                _id_seguro_sald = value;
            }
        }


        #endregion

        #region Constructores
        public Seguro_salud()
        {

        }


        public Seguro_salud(int id_ss, string nom_ss)
        {
            this.Id_seguro_sald = id_ss;
            this.Nombre_seg_sald = nom_ss;
        }
        #endregion

        #region Metodos

        public IList<Seguro_salud> Listar()
        {
            List<Seguro_salud> resultado = new List<Seguro_salud>();
            foreach (Vialis.DALC.Seguro_salud seg in ConectorDALC.ModeloVialis.Seguro_salud.ToList())
            {
                Seguro_salud s = new Negocio.Seguro_salud();
                s.Id_seguro_sald = (int)seg.id_seguro_sald;
                s.Nombre_seg_sald = seg.nombre_seg_sald.ToUpper();
                resultado.Add(s);

            }
            return resultado;
        }

        public IList<Seguro_salud> Listar_segursalud_por_id(string run)
        {
            List<Seguro_salud> resultado = new List<Seguro_salud>();
            foreach (Vialis.DALC.Descuento de in ConectorDALC.ModeloVialis.Descuento.ToList())
            {

                if (de.Persona_run.CompareTo(run) == 0)
                {
                    Seguro_salud ss = new Negocio.Seguro_salud();
                    ss.Id_seguro_sald = (int)de.id_seguro_sald;
                    ss.Nombre_seg_sald = de.Seguro_salud.nombre_seg_sald.ToUpper();
                    resultado.Add(ss);
                    break;
                }

            }
            return resultado;
        }

        public bool Buscar()
        {
            try
            {
                Vialis.DALC.Seguro_salud ss = ConectorDALC.ModeloVialis.Seguro_salud.First
                    (
                        s => s.id_seguro_sald == this.Id_seguro_sald
                    );

                this.Id_seguro_sald = ss.id_seguro_sald;
                this.Nombre_seg_sald = ss.nombre_seg_sald;


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
