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
    
    public partial class Comuna
    {
        public Comuna()
        {
            this.Persona = new HashSet<Persona>();
        }
    
        public decimal id_comuna { get; set; }
        public string nombre_comuna { get; set; }
        public Nullable<decimal> id_provincia { get; set; }
    
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
