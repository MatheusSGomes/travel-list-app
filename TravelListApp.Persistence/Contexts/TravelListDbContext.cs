using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TravelListApp.Domain.Entities;

namespace TravelListApp.Persistence.Contexts;

public class  TravelListDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Travel> Travels { get; set; }

    public TravelListDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }
}