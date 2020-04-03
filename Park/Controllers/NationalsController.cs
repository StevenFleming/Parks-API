using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Park.Models;

namespace Park.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NationalsController : ControllerBase
  {
    private ParkContext _db;

    public NationalsController(ParkContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<National>> Get()
    {
      return _db.Nationals.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<National> Get(int id)
    {
      return _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
    }

    [HttpPost]
    public void Post([FromBody] National national)
    {
      _db.Nationals.Add(national);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] National national)
    {
      national.NationalId = id;
      _db.Entry(national).State = EntityState.Modified;
      _db.SaveChanges();
    }

  }
}