using System.Collections.Generic;

namespace DungeonApi.Models
{
  public class ItemProperty
  {
    public ItemProperty()
    {
      // this.Armors = new HashSet<ItemPropertyJoin>();
      // this.Weapons = new HashSet<ItemPropertyJoin>();
      this.ItemPropertyJoins = new HashSet<ItemPropertyJoin>();
    }

    public int ItemPropertyId { get; set; }
    public string ItemPropertyName { get; set; }
    public string ItemPropertyDescription { get; set; }
    public string ItemPropertyFlags { set; get; }
    public virtual ICollection<ItemPropertyJoin> ItemPropertyJoins { get; set; }
    // public virtual ICollection<ItemPropertyJoin> Weapons { get; set; }
    
  }
}