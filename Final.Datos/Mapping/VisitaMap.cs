using System;
using System.Collections.Generic;
using System.Text;
using Final.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final.Datos.Mapping
{
    public class VisitaMap : IEntityTypeConfiguration<Visita>
    {
        public void Configure(EntityTypeBuilder<Visita> builder)
        {
            builder.ToTable("visita")
                .HasKey(v => v.idvisita);
            builder.Property(v => v.fecha)
                .HasDefaultValueSql("getdate()"); 
        }
    }
}
