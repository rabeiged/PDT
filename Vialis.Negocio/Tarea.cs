using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Tarea
    {
        #region Campos
        private int _id_tarea, _costo;
        private string _nombre_tarea, _descripcion_tarea, _nivel_avance;
        private DateTime _fecha_inicio, _fecha_termino;




        #endregion

        #region Propiedades
        public int Id_tarea
        {
            get
            {
                return _id_tarea;
            }

            set
            {
                _id_tarea = value;
            }
        }

        public int Costo
        {
            get
            {
                return _costo;
            }

            set
            {
                _costo = value;
            }
        }

        public string Nombre_tarea
        {
            get
            {
                return _nombre_tarea;
            }

            set
            {
                _nombre_tarea = value;
            }
        }

        public string Descripcion_tarea
        {
            get
            {
                return _descripcion_tarea;
            }

            set
            {
                _descripcion_tarea = value;
            }
        }

        public string Nivel_avance
        {
            get
            {
                return _nivel_avance;
            }

            set
            {
                _nivel_avance = value;
            }
        }

        public DateTime Fecha_inicio
        {
            get
            {
                return _fecha_inicio;
            }

            set
            {
                _fecha_inicio = value;
            }
        }

        public DateTime Fecha_termino
        {
            get
            {
                return _fecha_termino;
            }

            set
            {
                _fecha_termino = value;
            }
        }

        #endregion

        #region Constructores
        public Tarea()
        {
            init();
        }


        public Tarea(int id_tar, int cost, string nom_tar, string descrp_tar, 
            string nivel_ava, DateTime fec_ini, DateTime fec_ter)
        {
            init();

            this.Id_tarea = id_tar;
            this.Costo = cost;
            this.Nombre_tarea = nom_tar;
            this.Descripcion_tarea = descrp_tar;
            this.Nivel_avance = nivel_ava;
            this.Fecha_inicio = fec_ini;
            this.Fecha_termino = fec_ter;
        }
        #endregion

        #region Metodos

        public void init()
        {
            this.Id_tarea = 0;
            this.Costo = 0;
            this.Nombre_tarea = string.Empty;
            this.Descripcion_tarea = string.Empty;
            this.Nivel_avance = string.Empty;
            this.Fecha_inicio = DateTime.Now;
        }
        #endregion

    }
}
