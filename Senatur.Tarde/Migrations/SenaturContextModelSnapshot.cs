﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senatur.Tarde.Context;

namespace Senatur.Tarde.Migrations
{
    [DbContext(typeof(SenaturContext))]
    partial class SenaturContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senatur.Tarde.Domains.PacoteDomain", b =>
                {
                    b.Property<int>("PacoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .IsRequired();

                    b.Property<DateTime>("DataIda");

                    b.Property<DateTime>("DataVolta");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("NomeCidade")
                        .IsRequired();

                    b.Property<string>("NomePacote")
                        .IsRequired();

                    b.Property<decimal>("Valor");

                    b.HasKey("PacoteId");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("Senatur.Tarde.Domains.UsuarioDomain", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("TipoUsuario")
                        .IsRequired();

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
