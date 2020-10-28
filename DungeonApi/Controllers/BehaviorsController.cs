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
  public class BehaviorsController : ControllerBase
  {
    private DungeonApiContext _db;

    public BehaviorsController(DungeonApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Behavior>> Get(string behaviorName)
    {
      var query = _db.Behaviors.AsQueryable();

      if (behaviorName != null)
      {
        query = query.Where(entry => entry.BehaviorName == behaviorName);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Behavior behavior)
    {
      _db.Behaviors.Add(behavior);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Behavior behavior)
    {
      behavior.BehaviorId = id;
      _db.Entry(behavior).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var behaviorToDelete = _db.Behaviors.FirstOrDefault(entry => entry.BehaviorId == id);
      _db.Behaviors.Remove(behaviorToDelete);
      _db.SaveChanges();
    }
  }
}