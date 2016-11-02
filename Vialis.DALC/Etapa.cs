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
    
    public partial class Etapa
    {
        public Etapa()
        {
            this.Acta_reunion = new HashSet<Acta_reunion>();
            this.Hito = new HashSet<Hito>();
        }
    
        public string id_etapa { get; set; }
        public string id_proyecto { get; set; }
        public string nombre_etapa { get; set; }
        public string descripcion_etapa { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_termino { get; set; }
        public Nullable<decimal> nivel_avance { get; set; }
        public decimal id_factura { get; set; }
    
        public virtual ICollection<Acta_reunion> Acta_reunion { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual ICollection<Hito> Hito { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
