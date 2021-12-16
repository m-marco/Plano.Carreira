using Microsoft.EntityFrameworkCore;
using Plano.Carreira.Domain;

namespace Plano.Carreira.Infra
{
    public class Context : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Referencia> Referencias { get; set; }

        public Context(DbContextOptions<Context> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>(x =>
            {
                x.HasData(
                    new List<Departamento>
                    {
                        new Departamento {
                            Id = 1,
                            Nome = "Gabinete Presidência"
                        },
                        new Departamento {
                            Id = 2,
                            Nome = "Procuradoria Legislativa"
                        },
                        new Departamento {
                            Id = 3,
                            Nome = "Comunicação Social"
                        },
                        new Departamento {
                            Id = 4,
                            Nome = "Administrativo e de Documentação"
                        },
                        new Departamento {
                            Id = 5,
                            Nome = "Financeiro"
                        },
                        new Departamento {
                            Id = 6,
                            Nome = "Legislativo"
                        },
                        new Departamento {
                            Id = 7,
                            Nome = "Tecnologia da Informação"
                        },
                        new Departamento {
                            Id = 8,
                            Nome = "Controladoria Interna"
                        }
                    });
            });

            modelBuilder.Entity<Setor>(x =>
            {
                x.HasData(
                    new List<Setor>
                    {
                        new Setor { Id = 1, Nome = "Jornalismo", DepartamentoId = 3 },
                        new Setor { Id = 2, Nome = "Produção", DepartamentoId = 3 },
                        new Setor { Id = 3, Nome = "Cerimonial", DepartamentoId = 3 },
                        new Setor { Id = 4, Nome = "Compras e Contratos", DepartamentoId = 4 },
                        new Setor { Id = 5, Nome = "Infraestrutura e Logística", DepartamentoId = 4 },
                        new Setor { Id = 6, Nome = "Recursos Humanos", DepartamentoId = 4 },
                        new Setor { Id = 7, Nome = "Gestão de Documentação e Arquivo", DepartamentoId = 4 },
                        new Setor { Id = 8, Nome = "Finanças", DepartamentoId = 5 },
                        new Setor { Id = 9, Nome = "Contabilidade e de Patrimônio", DepartamentoId = 5 },
                        new Setor { Id = 10, Nome = "Gestão de Projetos Legislativos", DepartamentoId = 6 },
                        new Setor { Id = 11, Nome = "Gestão de Instrumentos Legislativos", DepartamentoId = 6 },
                        new Setor { Id = 12, Nome = "Atividades Plenárias", DepartamentoId = 6 },
                        new Setor { Id = 13, Nome = "Escola do Legislativo", DepartamentoId = 6 },
                        new Setor { Id = 14, Nome = "Escola do Legislativo", DepartamentoId = 6 },
                        new Setor { Id = 15, Nome = "Suporte de Tecnologia da Informação", DepartamentoId = 7 },
                        new Setor { Id = 16, Nome = "Desenvolvimento de Sistemas", DepartamentoId = 7 },
                        new Setor { Id = 17, Nome = "Infraestrutura de Tecnologia da Informação", DepartamentoId = 7 }
                    });
            });

            modelBuilder.Entity<Referencia>(x =>
            {
                x.HasKey(y => y.Codigo);
            });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<string>().HaveMaxLength(250);
            configurationBuilder.Properties<decimal>().HavePrecision(8, 2);
        }
    }
}