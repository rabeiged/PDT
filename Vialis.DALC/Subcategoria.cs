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
    
    public partial class Subcategoria
    {
        public decimal id_subcategoria { get; set; }
        public string nombre_subcategoria { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> id_categoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}
