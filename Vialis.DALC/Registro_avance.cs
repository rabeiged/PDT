//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vialis.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro_avance
    {
        public decimal id_reg_avance { get; set; }
        public string id_tarea { get; set; }
        public Nullable<decimal> nivel_avance { get; set; }
        public string detalle { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
    
        public virtual Tarea Tarea { get; set; }
    }
}
