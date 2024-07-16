using Microsoft.EntityFrameworkCore;
using TravelListApp.Domain.Entities;

namespace TravelListApp.Persistence.Contexts;

public class TravelListDbContext : DbContext
{
    public DbSet<Travel> Travels { get; set; }
    
    public TravelListDbContext(DbContextOptions<TravelListDbContext> options) : base(options) { }
}