using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Park.Models;

namespace Park.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateController : ControllerBase
  {
    private ParkContext _db;

    public StateController(ParkContext db)
    {
      _db = db;
    }
    [HttpGet]

    public ActionResult<IEnumerable<State>> Get()
    {
      return _db.States.ToList();
    }

    [HttpPost]
    public void Post([FromBody] State state)
    {
      _db.States.Add(state);
      _db.SaveChanges();
    }

  }
}