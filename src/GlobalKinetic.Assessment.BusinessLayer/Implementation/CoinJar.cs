using System;
using System.Collections.Generic;
using System.Linq;
using GlobalKinetic.Assessment.BusinessLayer.Exceptions;
using GlobalKinetic.Assessment.BusinessLayer.Interfaces;
using GlobalKinetic.Assessment.DataAccessLayer;
using GlobalKinetic.Assessment.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace GlobalKinetic.Assessment.BusinessLayer.Implementation
{
  /// <summary>
  ///   public class for Coin Jar. 
  /// </summary>
  public class CoinJar : ICoinJar
  {
    //private readonly Coin[] coins = Enum.GetValues(typeof(Enums.CoinType)).Cast<Enums.CoinType>().Select(x => new Coin(x)).ToArray();

    public void AddCoin(ICoin coin)
    {
      try
      {
        var options = new DbContextOptionsBuilder<AssessmentDBContext>().UseInMemoryDatabase("KineticAssessment")
          .Options;

        using var context = new AssessmentDBContext(options);
        var model = new CoinModel
        {
          Amount = coin.Amount,
          Volume = coin.Volume,
          CoinType = 1
        };

        context.Coins.Add(model);
        context.SaveChanges();
      }
      catch (Exception)
      {
        throw new CoinOverFlowException();
      }
    }


    public decimal GetTotalAmount()
    {
      try
      {
        var options = new DbContextOptionsBuilder<AssessmentDBContext>().UseInMemoryDatabase("KineticAssessment")
          .Options;

        using var context = new AssessmentDBContext(options);

        var coins = context.Coins;
        return coins.Select(c => (decimal) c.Amount).Sum();
      }
      catch (Exception)
      {
        throw new CoinOverFlowException();
      }
    }

    public void Reset()
    {
      try
      {
        var options = new DbContextOptionsBuilder<AssessmentDBContext>().UseInMemoryDatabase("KineticAssessment")
          .Options;

        using var context = new AssessmentDBContext(options);
        context.Database.EnsureDeleted();
        context.SaveChanges();
      }
      catch (Exception)
      {
        throw new CoinOverFlowException();
      }
    }
  }
}
