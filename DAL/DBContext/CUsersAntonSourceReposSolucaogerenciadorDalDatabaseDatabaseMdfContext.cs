using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MODEL;

namespace DAL.DBContext;

public partial class CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename =C:\\Users\\anton\\source\\repos\\SolucaoGerenciador\\DAL\\database\\Database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projetos__3214EC075D6934D4");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataDeInicio).HasColumnType("date");
            entity.Property(e => e.DataFinal).HasColumnType("date");
            entity.Property(e => e.Gerente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Resumo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
