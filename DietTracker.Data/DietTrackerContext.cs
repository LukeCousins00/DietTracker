using DietTracker.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DietTracker.Data;

public class DietTrackerContext : IdentityDbContext<ApplicationUser>
{
    public DietTrackerContext(DbContextOptions<DietTrackerContext> options)
        : base(options)
    {
    }

    public DbSet<Target> Targets { get; set; }

    public DbSet<Subsistence> Sustenance { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Target>()
            .HasMany(t => t.Sustenance)
            .WithMany(s => s.Targets)
            .UsingEntity<SubsistenceTarget>(
                j => j
                    .HasOne(st => st.Subsistence)
                    .WithMany(s => s.SubsistenceTargets)
                    .HasForeignKey(st => st.SubsistenceId),
                j => j
                    .HasOne(st => st.Target)
                    .WithMany(t => t.SubsistenceTargets)
                    .HasForeignKey(st => st.TargetId)
            );
        base.OnModelCreating(builder);
    }
}
