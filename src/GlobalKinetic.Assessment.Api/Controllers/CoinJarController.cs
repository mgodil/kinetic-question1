using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using GlobalKinetic.Assessment.BusinessLayer;
using GlobalKinetic.Assessment.BusinessLayer.Implementation;
using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.Api.Controllers
{

  /// <summary>
  ///  The Coin Jar API Controller
  /// </summary>
  [ApiController]
  [Route("api/v1")]
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
      try
      {
        decimal results = 0;
        if (_coinJar != null)
        {
          results = await Task.FromResult(_coinJar.GetTotalAmount());
        }
        return Ok(results);
      }
      catch (Exception e)
      {
        _logger.Log(LogLevel.Error, e, "An error was thrown");
        return BadRequest("Error Occurred");
      }
    }
    

    /// <summary>Posts the specified amount.</summary>
    /// <param name="amount">The amount.</param>
    /// <param name="volume">The volume.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    [HttpPost, Route("AddCoin")]
    public IActionResult Post(decimal amount, decimal volume )
    {
      try
      {
         _coinJar.AddCoin(new Coin(Enums.CoinType.Cent, amount, volume));
         return Ok();
      }
      catch (Exception e)
      {
        _logger.Log(LogLevel.Error, e, "An error was thrown");
        return BadRequest("Error Occurred");
      }
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
