using System.Collections.Generic;

namespace DungeonApi.Models
{
  public class Armor
  {
    public Armor()
    {
      this.Monsters = new HashSet<MonsterArmor>();
      this.ItemProperties = new HashSet<ItemPropertyJoin>();
    }


    public int ArmorId { get; set; }
    public string ArmorName { get; set; }
    public string ArmorDescription { get; set; }
    public string ArmorSlot { set; get; }
    public virtual ICollection<MonsterArmor> Monsters { get; set; }
    public virtual ICollection<ItemPropertyJoin> ItemProperties { get; set; }
  }
}