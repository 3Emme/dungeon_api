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
  public class ArmorsController : ControllerBase
  {
    private DungeonApiContext _db;

    public ArmorsController(DungeonApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Armor>> Get(string armorName)
    {
      var query = _db.Armors.AsQueryable();

      if (armorName != null)
      {
        query = query.Where(entry => entry.ArmorName == armorName);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Armor armor)
    {
      _db.Armors.Add(armor);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Armor armor)
    {
      armor.ArmorId = id;
      _db.Entry(armor).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var armorToDelete = _db.Armors.FirstOrDefault(entry => entry.ArmorId == id);
      _db.Armors.Remove(armorToDelete);
      _db.SaveChanges();
    }
  }
}