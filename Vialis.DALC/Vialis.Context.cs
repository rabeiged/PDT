﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VialisEntities : DbContext
    {
        public VialisEntities()
            : base("name=VialisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Acta_reunion> Acta_reunion { get; set; }
        public DbSet<AFP> AFP { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Boleta> Boleta { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Comuna> Comuna { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }
        public DbSet<Descuento> Descuento { get; set; }
        public DbSet<Detalle_boleta> Detalle_boleta { get; set; }
        public DbSet<Detalle_cotizacion> Detalle_cotizacion { get; set; }
        public DbSet<Detalle_participacion> Detalle_participacion { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Etapa> Etapa { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Hito> Hito { get; set; }
        public DbSet<Inspeccion_tecnica> Inspeccion_tecnica { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<Participante> Participante { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Registro_avance> Registro_avance { get; set; }
        public DbSet<Seguro_salud> Seguro_salud { get; set; }
        public DbSet<Stock_RRFF_EMPRESA> Stock_RRFF_EMPRESA { get; set; }
        public DbSet<Stock_RRFF_PROYECTO> Stock_RRFF_PROYECTO { get; set; }
        public DbSet<Subcategoria> Subcategoria { get; set; }
        public DbSet<Sueldo> Sueldo { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Trabajador_asignado> Trabajador_asignado { get; set; }
        public DbSet<Trabajador_empresa> Trabajador_empresa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
