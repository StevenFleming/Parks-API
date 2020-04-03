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
    public ActionResult<IEnumerable<State>> Get()
    {
      return _db.States.ToList();
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