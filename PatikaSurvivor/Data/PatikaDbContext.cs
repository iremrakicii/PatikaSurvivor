using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PatikaSurvivor.Models;

namespace PatikaSurvivor.Data
{
    public class PatikaDbContext : DbContext
    {
        public PatikaDbContext(DbContextOptions<PatikaDbContext> options)
       : base(options)
        {
        }
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAKICI53;Database=PatikaCodeFirstDb3;Trusted_Connection=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competitor>()
                .HasOne(p => p.Category)
                .WithMany(u => u.Competitors)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Competitor>().HasData(
            new Competitor { Id = 1, IsDeleted = false, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1 },
            new Competitor { Id = 2, IsDeleted = false, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1 },
            new Competitor { Id = 3, IsDeleted = false, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1 },
            new Competitor { Id = 4, IsDeleted = false, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1 },
            new Competitor { Id = 5, IsDeleted = false, FirstName = "Özge", LastName = "Açık", CategoryId = 1 },
            new Competitor { Id = 6, IsDeleted = false, FirstName = "Kıvanç", LastName = "Tatlıtuğ", CategoryId = 2 },
            new Competitor { Id = 7, IsDeleted = false, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2 },
            new Competitor { Id = 8, IsDeleted = false, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2 },
            new Competitor { Id = 9, IsDeleted = false, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2 },
            new Competitor { Id = 10, IsDeleted = false, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2 }
                );
            modelBuilder.Entity<Category>().HasData(
             new Category { Id = 1, IsDeleted = false, Name = "Ünlüler" },
             new Category { Id = 2, IsDeleted = false, Name = "Gönüllüler" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
