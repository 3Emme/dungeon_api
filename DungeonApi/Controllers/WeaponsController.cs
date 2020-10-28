using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DungeonApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace DungeonApi.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class WeaponsController : ControllerBase
  {
    private DungeonApiContext _db;

    public WeaponsController(DungeonApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Weapon>> Get(string weaponName)
    {
      var query = _db.Weapons.AsQueryable();

      if (weaponName != null)
      {
        query = query.Where(entry => entry.WeaponName == weaponName);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Weapon weapon)
    {
      _db.Weapons.Add(weapon);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Weapon weapon)
    {
      weapon.WeaponId = id;
      _db.Entry(weapon).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var weaponToDelete = _db.Weapons.FirstOrDefault(entry => entry.WeaponId == id);
      _db.Weapons.Remove(weaponToDelete);
      _db.SaveChanges();
    }
  }
}