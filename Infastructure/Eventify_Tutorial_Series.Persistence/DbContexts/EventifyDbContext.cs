using Eventify_Tutorial_Series.Domain.Common;
using Eventify_Tutorial_Series.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventify_Tutorial_Series.Persistence.DbContexts;

public class EventifyDbContext:DbContext
{
    public DbSet<Event> Events { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>().OwnsOne(x => x.Location);
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("EventifyDb");
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var data = ChangeTracker.Entries<EntityBase<Guid>>();
        
        //Interception Mechanism
        foreach (var entry in data)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Id = Guid.NewGuid();
                entry.Entity.CreatedDate = DateTimeOffset.Now;
            }else if (entry.State == EntityState.Modified)
                entry.Entity.UpdatedDate = DateTimeOffset.Now;
            
               
        }
        
        return base.SaveChangesAsync(cancellationToken);
    }
}