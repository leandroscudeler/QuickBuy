using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Set PK
            builder.HasKey(p => p.Id);

            //Builder utiliza Padrao Fluent
            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Senha)
                .IsRequired()
                .HasMaxLength(400);


            builder.HasMany(p => p.Pedidos)
                .WithOne(p=> p.Usuario);

        }
    }
}
