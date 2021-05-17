using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.Api.Controllers
{

  /// <summary>
  ///  The Coinjar API Controller
  /// </summary>
  [ApiController]
  [Route("api/[controller]")]
  public class CoinJarController : ControllerBase
  {
    private readonly ILogger<CoinJarController> _logger;
    private readonly ICoinJar _coinJar;

    public CoinJarController(ILogger<CoinJarController> logger, ICoinJar coinJar)
    {
      _logger = logger;
      _coinJar = coinJar;
    }


    /// <summary>Gets this instance.</summary>
    /// <returns>
    ///   <br />
    /// </returns>
    [HttpGet, Route("GetTotalAmount")]
    public async Task<IActionResult> Get()
    {
      return null;
      //try
      //{

      //}
      // return new string[] { "value1", "value2" };
    }



    /// <summary>Posts the specified coin.</summary>
    /// <param name="coin">The coin.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    [HttpPost, Route("AddCoin")]
    public async Task<IActionResult> Post([FromBody] int coin)
    {
     // _logger.Log(LogLevel.Error, coin, );
      return Ok();
    }


    /// <summary>Resets the specified value.</summary>
    /// <param name="value">The value.</param>
    [HttpPost, Route("ResetCoin")]
    public void Reset()
    {
      _coinJar.Reset();
    }
  }
}
