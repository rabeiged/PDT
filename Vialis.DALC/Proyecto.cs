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
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Acta_reunion = new HashSet<Acta_reunion>();
            this.Asistencia = new HashSet<Asistencia>();
            this.Cotizacion = new HashSet<Cotizacion>();
            this.Etapa = new HashSet<Etapa>();
            this.Stock_RRFF_PROYECTO = new HashSet<Stock_RRFF_PROYECTO>();
            this.Trabajador_asignado = new HashSet<Trabajador_asignado>();
        }
    
        public string id_proyecto { get; set; }
        public string rol { get; set; }
        public string nombre_proyecto { get; set; }
    
        public virtual ICollection<Acta_reunion> Acta_reunion { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Etapa> Etapa { get; set; }
        public virtual ICollection<Stock_RRFF_PROYECTO> Stock_RRFF_PROYECTO { get; set; }
        public virtual ICollection<Trabajador_asignado> Trabajador_asignado { get; set; }
    }
}
