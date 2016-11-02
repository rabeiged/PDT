using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Provincia
    {
        #region Campos
        private int _id_provincia;
        private string _nombre_provincia;
        int region;

        #endregion

        #region Propieades
        public int Id_provincia
        {
            get
            {
                return _id_provincia;
            }

            set
            {
                _id_provincia = value;
            }
        }

        public string Nombre_provincia
        {
            get
            {
                return _nombre_provincia;
            }

            set
            {
                _nombre_provincia = value;
            }
        }

        public int Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }


        #endregion

        #region Constructores
        public Provincia()
        {

        }

        public Provincia(int id_pro, string nom_pro)
        {

            this.Id_provincia = id_pro;
            this.Nombre_provincia = nom_pro;
        }



        #endregion

        #region Metodos

        public IList<Provincia> Listar(int idRegion)
        {
           
            List<Provincia> resultado = new List<Provincia>();
            foreach (Vialis.DALC.Provincia pro in ConectorDALC.ModeloVialis.Provincia.ToList())
            {
                if (pro.id_region == idRegion)
                {
                    Provincia p = new Negocio.Provincia();
                    p.Id_provincia = (int)pro.id_provincia;
                    p.Nombre_provincia = pro.nombre_provincia;
                    resultado.Add(p);
                }
            }
            return resultado;
        }

        public IList<Provincia> Listar_provincia_por_idcomuna(int id_comuna)
        {
            Comuna com = new Comuna();
            com.Id_comuna = id_comuna;
            com.Buscar();

            List<Provincia> resultado = new List<Provincia>();
            foreach (Vialis.DALC.Provincia pro in ConectorDALC.ModeloVialis.Provincia.ToList())
            {
                if (pro.id_provincia == com.Provincia)
                {
                    Provincia p = new Negocio.Provincia();
                    p.Id_provincia = (int)pro.id_provincia;
                    p.Nombre_provincia = pro.nombre_provincia;
                    resultado.Add(p);
                    break;
                }
            }
            return resultado;
        }


        #endregion

    }
}
