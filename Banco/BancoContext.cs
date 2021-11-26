using Microsoft.EntityFrameworkCore;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents.Banco
{
    public class BancoContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<HorarioEvento> HorariosEventos { get; set; }
        public DbSet<TipoEvento> TiposEventos { get; set; }
        public DbSet<Requisito> Requisitos { get; set; }
        public DbSet<RequisitoEvento> RequisitoEventos { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<EnderecoLocal> EnderecosLocal { get; set; }
        public DbSet<Participante> Participantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=aula-banco-senac-2021.ce9eq7mml3ie.sa-east-1.rds.amazonaws.com,1433;Database=db_thalya;User Id=thalya;Password=thalya1071;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                .ToTable("Empresa")
                .HasKey(e => e.Codigo);


            modelBuilder.Entity<Evento>()
                .ToTable("Evento")
                .HasKey(e => e.Codigo);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Empresa)
                .WithMany().HasForeignKey(e => e.CodigoEmpresa);
            modelBuilder.Entity<Evento>()
                .HasOne(e => e.EnderecoLocal)
                .WithMany().HasForeignKey(e => e.CodigoEnderecoLocal);
            modelBuilder.Entity<Evento>()
                .HasOne(e => e.HorarioEvento)
                .WithOne(e => e.Evento).HasForeignKey<HorarioEvento>(h => h.CodigoEvento);
            modelBuilder.Entity<Evento>()
                .HasOne(e => e.TipoEvento)
                .WithMany()
                .HasForeignKey(h => h.CodigoTipoEvento);
            modelBuilder.Entity<Evento>()
                .HasMany(e => e.RequisitoEvento)
                .WithOne()
                .HasForeignKey(r => r.CodigoEvento);


            modelBuilder.Entity<HorarioEvento>()
                .ToTable("HorarioEvento")
                .HasKey(h => h.Codigo);


            modelBuilder.Entity<TipoEvento>()
                .ToTable("TipoEvento")
                .HasKey(t => t.Codigo);

            modelBuilder.Entity<Requisito>()
                .ToTable("Requisito")
                .HasKey(f => f.Codigo);

            modelBuilder.Entity<RequisitoEvento>()
                .ToTable("RequisitoEvento")
                .HasKey(r => new { r.CodigoEvento, r.CodigoRequisito });
            modelBuilder.Entity<RequisitoEvento>()
                .HasOne(r => r.Requisito)
                .WithMany()
                .HasForeignKey(r => r.CodigoRequisito);

            modelBuilder.Entity<Uf>()
                .ToTable("Uf")
                .HasKey(u => u.Codigo);


            modelBuilder.Entity<Cidade>()
                .ToTable("Cidade")
                .HasKey(c => c.Codigo);

            modelBuilder.Entity<Cidade>()
                .HasOne(c => c.Uf)
                .WithMany().HasForeignKey(c => c.CodigoUf);

            
            modelBuilder.Entity<Bairro>()
                .ToTable("Bairro")
                .HasKey(b => b.Codigo);

            modelBuilder.Entity<Bairro>()
                .HasOne(b => b.Cidade)
                .WithMany().HasForeignKey(b => b.CodigoCidade);

            
            modelBuilder.Entity<EnderecoLocal>()
                .ToTable("EnderecoLocal")
                .HasKey(e => e.Codigo);

            modelBuilder.Entity<EnderecoLocal>()
                .HasOne(e => e.Bairro)
                .WithMany().HasForeignKey(e => e.CodigoBairro);


            modelBuilder.Entity<Participante>()
                .ToTable("Participante")
                .HasKey(p => p.Codigo);


            base.OnModelCreating(modelBuilder);
        }
    }
}
