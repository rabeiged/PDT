using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vialis.RRHH;

namespace Vialis
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Para cambiar arranque del form. 
            //Application.Run(new frmRRHH());
            Application.Run(new RRHH.frmRRHH());
            



        }



    }
}
