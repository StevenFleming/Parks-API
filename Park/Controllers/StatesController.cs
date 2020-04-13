using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Park.Models;

namespace Park.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StatesController : ControllerBase
  {
    private ParkContext _db;

    public StatesController(ParkContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<State>> Get(string location, string name, int limit, int start)
    {
      var query = _db.States.AsQueryable();

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      //limits results
      const int maxLimit = 1000;

      int startVal = (start > 0) ? start : 1;
      int limitVal = 10;
      if (limit > 0)
      {
        limitVal = (limit > maxLimit) ? maxLimit : limit;
      }
      query = query.Skip(startVal - 1).Take(limitVal);


      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<State> Get(int id)
    {
      return _db.States.FirstOrDefault(entry => entry.StateId == id);
    }

    [HttpPost]
    public void Post([FromBody] State state)
    {
      _db.States.Add(state);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] State state)
    {
      state.StateId = id;
      _db.Entry(state).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateToDelete = _db.States.FirstOrDefault(entry => entry.StateId == id);
      _db.States.Remove(stateToDelete);
      _db.SaveChanges();
    }
  }
}