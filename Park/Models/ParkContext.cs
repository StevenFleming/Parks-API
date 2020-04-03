using Microsoft.EntityFrameworkCore;

namespace Park.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options)
        : base(options)
    {
    }

    public DbSet<State> States { get; set; }

    public DbSet<National> Nationals { get; set; }
  }
}