using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

    [HttpPost]
    public void Post([FromBody] National national)
    {
      _db.Nationals.Add(national);
      _db.SaveChanges();
    }

  }
}