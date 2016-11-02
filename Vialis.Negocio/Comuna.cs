using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Comuna
    {
        #region Campos
        private int _id_comuna;
        private string _nombre_comuna;
        int _provincia;

        #endregion

        #region Propiedades
        public int Id_comuna
        {
            get
            {
                return _id_comuna;
            }

            set
            {
                _id_comuna = value;
            }
        }

        public string Nombre_comuna
        {
            get
            {
                return _nombre_comuna;
            }

            set
            {
                _nombre_comuna = value;
            }
        }

        public int Provincia
        {
            get
            {
                return _provincia;
            }

            set
            {
                _provincia = value;
            }
        }
        #endregion

        #region Constructores
        public Comuna()
        {
            init();
        }

        public Comuna(int id_com, string nom_com)
        {
            init();

            this.Id_comuna = id_com;
            this.Nombre_comuna = nom_com;

        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_comuna = 0;
            this.Nombre_comuna = string.Empty;
        }

        
        public bool Buscar()
        {
            try
            {
                Vialis.DALC.Comuna comu = ConectorDALC.ModeloVialis.Comuna.First
                    (
                        c => c.id_comuna == this.Id_comuna
                    );

                this.Nombre_comuna = comu.nombre_comuna;
                this.Provincia = (int)comu.Provincia.id_provincia;
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }



        public IList<Comuna> Listar(int idPro)
        {
            List<Comuna> resultado = new List<Comuna>();
            foreach (Vialis.DALC.Comuna com in ConectorDALC.ModeloVialis.Comuna.ToList())
            {
                if (com.id_provincia == idPro)
                {
                    Comuna c = new Negocio.Comuna();
                    c.Id_comuna = (int)com.id_comuna;
                    c.Nombre_comuna = com.nombre_comuna;
                    resultado.Add(c);
                }
            }
            return resultado;
        }
        public IList<Comuna> listar_comuna_por_id(int comId)
        {
            List<Comuna> resultado = new List<Comuna>();
            foreach (Vialis.DALC.Comuna com in ConectorDALC.ModeloVialis.Comuna.ToList())
            {
                if (com.id_comuna == comId)
                {
                    Comuna c = new Negocio.Comuna();
                    c.Id_comuna = (int)com.id_comuna;
                    c.Nombre_comuna = com.nombre_comuna;
                    resultado.Add(c);
                    break;
                }
            }
            return resultado;
        }


        #endregion



    }
}
