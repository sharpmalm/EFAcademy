
using Microsoft.EntityFrameworkCore;
using EFAcademy.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFAcademy;

public class ApplicationDbContext : DbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Professor> Professors { get; set;}
    public DbSet<Class> Classs { get; set; }

    //in "options", you can put in connection string or sqlite file etc. not necessary to use the optionts
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //sqlite file
        optionsBuilder.UseSqlite("Filename=EFAcademy.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Primary keys
        modelBuilder.Entity<Address>().HasKey(e => e.Id);
        modelBuilder.Entity<Student>().HasKey(e => e.Id);
        modelBuilder.Entity<Professor>().HasKey(e => e.Id);
        modelBuilder.Entity<Class>().HasKey(e => e.Id);

        //relations
        modelBuilder.Entity<Student>().HasOne(e => e.Address);
        modelBuilder.Entity<Professor>().HasOne(e => e.Address);

        //possible to define two-way relations
        modelBuilder.Entity<Class>().HasMany(e => e.Students).WithMany(e => e.Classes);
        modelBuilder.Entity<Class>().HasOne(e => e.Professor).WithMany(e => e.Classes);



        base.OnModelCreating(modelBuilder);
    }
}
