using Microsoft.EntityFrameworkCore;

namespace DungeonApi.Models
{
  public class DungeonApiContext : DbContext
  {
    public DungeonApiContext(DbContextOptions<DungeonApiContext> options) : base(options)
    {
    }
    public DbSet<Monster> Monsters { get; set; }
    public DbSet<User> Users { get; set; }
  }

}