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
  public class MonsterMainTypesController : ControllerBase
  {
    private DungeonApiContext _db;

    public MonsterMainTypesController(DungeonApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<MonsterMainType>> Get(int monsterMainTypeId)
    {
      var query = _db.MonsterMainTypes.AsQueryable();
      // query = query.Where(entry => entry.MonsterMainTypeId == monsterMainTypeId);
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] MonsterMainType monsterMainType)
    {
      _db.MonsterMainTypes.Add(monsterMainType);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] MonsterMainType monsterMainType)
    {
      monsterMainType.MonsterMainTypeId = id;
      _db.Entry(monsterMainType).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var monsterMainTypeToDelete = _db.MonsterMainTypes.FirstOrDefault(entry => entry.MonsterMainTypeId == id);
      _db.MonsterMainTypes.Remove(monsterMainTypeToDelete);
      _db.SaveChanges();
    }
  }
}