using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Trabajador_asignado
    {
        #region Campos
        private int _id_asginacion;
        private string _responsabilidad;

        #endregion

        #region Propiedades
        public int Id_asginacion
        {
            get
            {
                return _id_asginacion;
            }

            set
            {
                _id_asginacion = value;
            }
        }

        public string Responsabilidad
        {
            get
            {
                return _responsabilidad;
            }

            set
            {
                _responsabilidad = value;
            }
        }
        #endregion

        #region Constructores
        public Trabajador_asignado()
        {
            init();
        }

        public Trabajador_asignado(int id_asig, string respo)
        {
            init();

            this.Id_asginacion = id_asig;
            this.Responsabilidad = respo;

        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Id_asginacion = 0;
            this.Responsabilidad = string.Empty;
        }
        #endregion
    }
}
