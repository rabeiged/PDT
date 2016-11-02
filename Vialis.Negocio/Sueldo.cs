using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Sueldo
    {
        #region Campos

        private int _id_sueldo, _dias_trabajados, _valor_dia, _total;




        #endregion

        #region Propiedades
        public int Dias_trabajados
        {
            get
            {
                return _dias_trabajados;
            }

            set
            {
                _dias_trabajados = value;
            }
        }

        public int Id_sueldo
        {
            get
            {
                return _id_sueldo;
            }

            set
            {
                _id_sueldo = value;
            }
        }

        public int Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        public int Valor_dia
        {
            get
            {
                return _valor_dia;
            }

            set
            {
                _valor_dia = value;
            }
        }
        #endregion

        #region Constructores
        public Sueldo()
        {
            init();
        }

        public Sueldo(int id_suel, int dia_trab, int valor_d, int tot)
        {
            init();

            this.Id_sueldo = id_suel;
            this.Dias_trabajados = dia_trab;
            this.Valor_dia = valor_d;
            this.Total = tot;
        }

        #endregion

        #region Metodos
        private void init()
        {
            
        }
        #endregion
    }
}
