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
    
    public partial class Trabajador_asignado
    {
        public Trabajador_asignado()
        {
            this.Sueldo = new HashSet<Sueldo>();
        }
    
        public decimal id_asignacion { get; set; }
        public string responsabilidad { get; set; }
        public string id_contrato { get; set; }
        public string id_proyecto { get; set; }
        public string Persona_run { get; set; }
        public Nullable<int> id_trabajador { get; set; }
    
        public virtual Contrato Contrato { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        public virtual ICollection<Sueldo> Sueldo { get; set; }
        public virtual Trabajador_empresa Trabajador_empresa { get; set; }
    }
}