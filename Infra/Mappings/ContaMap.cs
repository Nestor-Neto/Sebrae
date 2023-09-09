using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class ContaMap: IEntityTypeConfiguration<ContaDTO>
    {
        public void Configure(EntityTypeBuilder<ContaDTO> builder)
        {
            builder.ToTable("Conta");

            builder.Property(p => p.ID)
                .ValueGeneratedNever();

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

        }
    }
}