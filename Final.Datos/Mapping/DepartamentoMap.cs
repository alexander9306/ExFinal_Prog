using System;
using System.Collections.Generic;
using System.Text;
using Final.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final.Datos.Mapping
{
    public class DepartamentoMap : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("departamento")
                .HasKey(d => d.iddepartamento);
        }
    }
}
