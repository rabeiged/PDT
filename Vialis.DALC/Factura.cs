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
    
    public partial class Factura
    {
        public Factura()
        {
            this.Etapa = new HashSet<Etapa>();
        }
    
        public decimal id_factura { get; set; }
        public string detalle_factura { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<System.DateTime> fecha_emision { get; set; }
        public string id_pago { get; set; }
    
        public virtual ICollection<Etapa> Etapa { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
