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
    
    public partial class Proveedor
    {
        public Proveedor()
        {
            this.Boleta = new HashSet<Boleta>();
            this.Cotizacion = new HashSet<Cotizacion>();
        }
    
        public string id_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
    
        public virtual ICollection<Boleta> Boleta { get; set; }
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
    }
}
