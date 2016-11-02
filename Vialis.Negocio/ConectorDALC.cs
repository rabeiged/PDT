using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vialis.DALC;

namespace Vialis.Negocio
{
    class ConectorDALC
    {
        private static VialisEntities _modeloVialis;

        public static VialisEntities ModeloVialis
        {
            get
            {
                if (_modeloVialis == null)
                {
                    _modeloVialis = new VialisEntities();
                }
                return _modeloVialis;
            }
        }

        public ConectorDALC()
        {

        }
    }
}
