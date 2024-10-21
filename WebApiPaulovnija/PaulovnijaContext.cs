using Microsoft.EntityFrameworkCore;
using WebApiPaulovnija.Models;

public class PaulovnijaContext : DbContext
{
    /// <summary>
    /// Inicijalizira novu instancu <see cref="PaulovnijaContext"/> klase.
    /// </summary>
    /// <param name="options">Opcije koje će koristiti <see cref="DbContext"/>.</param>
    public PaulovnijaContext(DbContextOptions<PaulovnijaContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    /// <summary>
    /// Dobiva ili postavlja kolekciju radnika (Radnici).
    /// </summary>
    public DbSet<Radnik> Radnici { get; set; }

    /// <summary>
    /// Dobiva ili postavlja kolekciju zadataka (Zadaci).
    /// </summary>
    public DbSet<Zadatak> Zadaci { get; set; }

    /// <summary>
    /// Dobiva ili postavlja kolekciju sadnica (Sadnice).
    /// </summary>
    public DbSet<Sadnica> Sadnice { get; set; }

    /// <summary>
    /// Dobiva ili postavlja kolekciju strojeva (Strojevi).
    /// </summary>
    public DbSet<Stroj> Strojevi { get; set; }

    /// <summary>
    /// Dobiva ili postavlja kolekciju rasadnika (Rasadnik).
    /// </summary>
    public DbSet<Rasadnik> Rasadnik { get; set; }

    /// <summary>
    /// Konfigurira model prilikom kreiranja konteksta.
    /// </summary>
    /// <param name="modelBuilder">Graditelj koji se koristi za konstruiranje modela za kontekst.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Konfiguracija primarnih ključeva za svaki entitet
        modelBuilder.Entity<Radnik>().HasKey(r => r.ID_Radnika);
        modelBuilder.Entity<Zadatak>().HasKey(z => z.ID_Zadatka);
        modelBuilder.Entity<Sadnica>().HasKey(s => s.ID_Sadnice);
        modelBuilder.Entity<Stroj>().HasKey(st => st.ID_Stroja);
        modelBuilder.Entity<Rasadnik>().HasKey(rs => rs.ID_Rasadnika);

        // Konfiguracija odnosa između entiteta

        // Sadnica ima jednog Rasadnika
        modelBuilder.Entity<Sadnica>()
            .HasOne(s => s.Rasadnik)
            .WithMany(r => r.Sadnice)
            .HasForeignKey(s => s.ID_Rasadnika);

        // Stroj ima jednog Radnika
        modelBuilder.Entity<Stroj>()
            .HasOne(st => st.Radnik)
            .WithMany(r => r.Strojevi)
            .HasForeignKey(st => st.ID_Radnika)
            .HasPrincipalKey(r => r.ID_Radnika);

        // Zadatak ima jednog Radnika
        modelBuilder.Entity<Zadatak>()
            .HasOne(z => z.Radnik)
            .WithMany(r => r.Zadaci)
            .HasForeignKey(z => z.ID_Radnika);
    }
}