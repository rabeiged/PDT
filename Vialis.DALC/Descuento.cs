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
    
    public partial class Descuento
    {
        public int id_descto { get; set; }
        public Nullable<int> id_seguro_sald { get; set; }
        public Nullable<float> porc_descto_salud { get; set; }
        public Nullable<float> porc_descto_AFP { get; set; }
        public Nullable<int> id_AFP { get; set; }
        public string Persona_run { get; set; }
        public Nullable<int> id_trabajador { get; set; }
    
        public virtual AFP AFP { get; set; }
        public virtual Trabajador_empresa Trabajador_empresa { get; set; }
        public virtual Seguro_salud Seguro_salud { get; set; }
    }
}
