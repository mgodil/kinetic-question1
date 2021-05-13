using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalKinetic.Question1.Api.Controllers
{
  [ApiController]
  [Route("api/controller")]
  public class CoinJarController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CoinJarController> _logger;

    public CoinJarController(ILogger<CoinJarController> logger)
    {
      _logger = logger;
    }

    //[HttpGet, Route("Get")]
    //public IEnumerable<string> Get()
    //{
    //  return new string[] {"value1", "value2"};
    //}

    //// GET: api/CoinJar/5  
    //[HttpGet]
    //public string Get(int id)
    //{
    //  return "value";
    //}

    // POST: api/CoinJar  
    //[HttpPost, Route("Post")]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT: api/CoinJar/5  
    //[HttpPut, Route("Put")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE: api/CoinJar/5  
    //[HttpDelete, Route("Delete")]
    //public void Delete(int id)
    //{
    //}
  }
}
