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
    
    public partial class Detalle_cotizacion
    {
        public string id_detalle_cotizacion { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string id_cotizacion1 { get; set; }
        public string id_producto { get; set; }
    
        public virtual Cotizacion Cotizacion { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
