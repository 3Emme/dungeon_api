using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DungeonApi.Models
{
  public class DungeonApiContext : IdentityDbContext<ApplicationUser>
  {
    public DungeonApiContext(DbContextOptions<DungeonApiContext> options) : base(options)
    {
    }
    public virtual DbSet<Monster> Monsters { get; set; }
    public virtual DbSet<Armor> Armors { get; set; }
    public virtual DbSet<Behavior> Behaviors { get; set; }
    public virtual DbSet<Weapon> Weapons { get; set; }
    public DbSet<ItemProperty> ItemProperties { get; set; }
    public DbSet<ItemPropertyJoin> ItemPropertyJoins { get; set; }
    public DbSet<MainType> MainTypes { get; set; }
    public DbSet<MonsterArmor> MonsterArmors { get; set; }
    public DbSet<MonsterBehavior> MonsterBehaviors { get; set; }
    public DbSet<MonsterMainType> MonsterMainTypes { get; set; }
    public DbSet<MonsterWeapon> MonsterWeapons { get; set; }

  }

}