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
    
    public partial class Boleta
    {
        public Boleta()
        {
            this.Detalle_boleta = new HashSet<Detalle_boleta>();
            this.Stock_RRFF_EMPRESA = new HashSet<Stock_RRFF_EMPRESA>();
            this.Stock_RRFF_PROYECTO = new HashSet<Stock_RRFF_PROYECTO>();
        }
    
        public string id_boleta { get; set; }
        public string id_proveedor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual ICollection<Detalle_boleta> Detalle_boleta { get; set; }
        public virtual ICollection<Stock_RRFF_EMPRESA> Stock_RRFF_EMPRESA { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual ICollection<Stock_RRFF_PROYECTO> Stock_RRFF_PROYECTO { get; set; }
    }
}
