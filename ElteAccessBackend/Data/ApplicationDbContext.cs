using ElteAccessBackend.Dtos;
using ElteAccessBackend.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElteAccessBackend.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<User, IdentityRole<int>, int>(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<UsersSubject> UserSubjects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // This is REQUIRED for Identity!
        modelBuilder.Entity<UsersSubject>()
            .HasKey(us => new { us.UserId, us.SubjectCode }); // Composite Key
    }

}