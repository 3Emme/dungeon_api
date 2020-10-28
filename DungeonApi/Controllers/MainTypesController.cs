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
  public class MainTypesController : ControllerBase
  {
    private DungeonApiContext _db;

    public MainTypesController(DungeonApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<MainType>> Get(string mainTypeName)
    {
      var query = _db.MainTypes.AsQueryable();

      if (mainTypeName != null)
      {
        query = query.Where(entry => entry.MainTypeName == mainTypeName);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] MainType mainType)
    {
      _db.MainTypes.Add(mainType);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] MainType mainType)
    {
      mainType.MainTypeId = id;
      _db.Entry(mainType).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var mainTypeToDelete = _db.MainTypes.FirstOrDefault(entry => entry.MainTypeId == id);
      _db.MainTypes.Remove(mainTypeToDelete);
      _db.SaveChanges();
    }
  }
}