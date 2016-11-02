using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Region
    {
        #region Campos
        private int _id_region;
        private string _nombre_region;

        #endregion


        #region Propiedades
        public int Id_region
        {
            get
            {
                return _id_region;
            }

            set
            {
                _id_region = value;
            }
        }

        public string Nombre_region
        {
            get
            {
                return _nombre_region;
            }

            set
            {
                _nombre_region = value;
            }
        }

        #endregion

        #region Constructores
        public Region()
        {
            init();
        }

        public Region(int id_reg, string nom_reg)
        {
            init();

            this.Id_region = id_reg;
            this.Nombre_region = nom_reg;
        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_region = 0;
            this.Nombre_region = string.Empty;
        }

        public IList<Region> Listar()
        {
            List<Region> resultado = new List<Region>();
            foreach (Vialis.DALC.Region reg in ConectorDALC.ModeloVialis.Region.ToList())
            {
                Region r = new Negocio.Region();
                r.Id_region = (int)reg.id_region;
                r.Nombre_region = reg.nombre_region;
                resultado.Add(r);
            }
            return resultado;
        }



        public IList<Region> Listar_region_por_idcomuna(int id_comuna)
        {
            Comuna com = new Comuna();
            com.Id_comuna = id_comuna;
            com.Buscar();

            List<Region> resultado = new List<Region>();
            foreach (Vialis.DALC.Provincia pro in ConectorDALC.ModeloVialis.Provincia.ToList())
            {
                if (pro.id_provincia == com.Provincia)
                {
                    Provincia p = new Negocio.Provincia();
                    p.Id_provincia = (int)pro.id_provincia;
                    p.Nombre_provincia = pro.nombre_provincia;
                    p.Region = (int)pro.id_region;

                    
                    foreach (Vialis.DALC.Region reg in ConectorDALC.ModeloVialis.Region.ToList())
                    {
                        if (reg.id_region == p.Region)
                        {
                            Region r = new Negocio.Region();
                            r.Id_region = (int)reg.id_region;
                            r.Nombre_region = reg.nombre_region;
                            resultado.Add(r);
                            return resultado;

                        }                        
                    }  
                }
            }
            return resultado;
        }

        #endregion

    }
}
