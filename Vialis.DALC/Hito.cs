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
    
    public partial class Hito
    {
        public Hito()
        {
            this.Tarea = new HashSet<Tarea>();
        }
    
        public string id_hito { get; set; }
        public string id_etapa { get; set; }
        public string nombre_hito { get; set; }
        public string descripcion_hito { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_termino { get; set; }
        public Nullable<decimal> nivel_avance { get; set; }
    
        public virtual Etapa Etapa { get; set; }
        public virtual ICollection<Tarea> Tarea { get; set; }
    }
}
