﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plano.Carreira.Infra;

#nullable disable

namespace Plano.Carreira.Infra.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211216140757_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Plano.Carreira.Domain.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Gabinete Presidência"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Procuradoria Legislativa"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Comunicação Social"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Administrativo e de Documentação"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Financeiro"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Legislativo"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Controladoria Interna"
                        });
                });

            modelBuilder.Entity("Plano.Carreira.Domain.Referencia", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<decimal>("Valor")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Codigo");

                    b.ToTable("Referencias");
                });

            modelBuilder.Entity("Plano.Carreira.Domain.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Setores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentoId = 3,
                            Nome = "Jornalismo"
                        },
                        new
                        {
                            Id = 2,
                            DepartamentoId = 3,
                            Nome = "Produção"
                        },
                        new
                        {
                            Id = 3,
                            DepartamentoId = 3,
                            Nome = "Cerimonial"
                        },
                        new
                        {
                            Id = 4,
                            DepartamentoId = 4,
                            Nome = "Compras e Contratos"
                        },
                        new
                        {
                            Id = 5,
                            DepartamentoId = 4,
                            Nome = "Infraestrutura e Logística"
                        },
                        new
                        {
                            Id = 6,
                            DepartamentoId = 4,
                            Nome = "Recursos Humanos"
                        },
                        new
                        {
                            Id = 7,
                            DepartamentoId = 4,
                            Nome = "Gestão de Documentação e Arquivo"
                        },
                        new
                        {
                            Id = 8,
                            DepartamentoId = 5,
                            Nome = "Finanças"
                        },
                        new
                        {
                            Id = 9,
                            DepartamentoId = 5,
                            Nome = "Contabilidade e de Patrimônio"
                        },
                        new
                        {
                            Id = 10,
                            DepartamentoId = 6,
                            Nome = "Gestão de Projetos Legislativos"
                        },
                        new
                        {
                            Id = 11,
                            DepartamentoId = 6,
                            Nome = "Gestão de Instrumentos Legislativos"
                        },
                        new
                        {
                            Id = 12,
                            DepartamentoId = 6,
                            Nome = "Atividades Plenárias"
                        },
                        new
                        {
                            Id = 13,
                            DepartamentoId = 6,
                            Nome = "Escola do Legislativo"
                        },
                        new
                        {
                            Id = 14,
                            DepartamentoId = 6,
                            Nome = "Escola do Legislativo"
                        },
                        new
                        {
                            Id = 15,
                            DepartamentoId = 7,
                            Nome = "Suporte de Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 16,
                            DepartamentoId = 7,
                            Nome = "Desenvolvimento de Sistemas"
                        },
                        new
                        {
                            Id = 17,
                            DepartamentoId = 7,
                            Nome = "Infraestrutura de Tecnologia da Informação"
                        });
                });

            modelBuilder.Entity("Plano.Carreira.Domain.Setor", b =>
                {
                    b.HasOne("Plano.Carreira.Domain.Departamento", "Departamento")
                        .WithMany("Setores")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Plano.Carreira.Domain.Departamento", b =>
                {
                    b.Navigation("Setores");
                });
#pragma warning restore 612, 618
        }
    }
}
