using System.ComponentModel.DataAnnotations;

namespace DungeonApi.Models
{
  public class Monster
  {
    public int MonsterId { get; set; }

    [Required]
    public string MonsterName { get; set; }

  }
}