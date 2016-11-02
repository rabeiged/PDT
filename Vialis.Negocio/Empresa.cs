using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Empresa
    {
        #region Campos
        private string _rol_unico_tributario, _nombre_empresa;

        #endregion

        #region Propiedades
        public string Rol_unico_tributario
        {
            get
            {
                return _rol_unico_tributario;
            }

            set
            {
                _rol_unico_tributario = value;
            }
        }

        public string Nombre_empresa
        {
            get
            {
                return _nombre_empresa;
            }

            set
            {
                _nombre_empresa = value;
            }
        }

        

        #endregion

        #region Constructores
        public Empresa()
        {
            init();
        }

        public Empresa(string rol, string nom_empre)
        {
            init();

            this.Rol_unico_tributario = rol;
            this.Nombre_empresa = nom_empre;
        }

        #endregion

        #region Metodos
        private void init()
        {
            this.Rol_unico_tributario = string.Empty;
            this.Nombre_empresa = string.Empty;
        }
        #endregion

    }
}
