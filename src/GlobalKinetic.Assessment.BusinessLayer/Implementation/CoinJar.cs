using System;
using System.Linq;
using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.BusinessLayer.Implementation
{
  public class CoinJar : ICoinJar
  {
    private readonly Coins[] coins = Enum.GetValues(typeof(CoinType)).Cast<CoinType>().Select(x => new Coins(x)).ToArray();
    public void AddCoin(ICoin coin)
    {
      throw new NotImplementedException();
    }

    public decimal GetTotalAmount()
    {
      throw new NotImplementedException();
    }

    public void Reset()
    {
      foreach (var c in coins)
      {
        c.Amount = 0;
      }
    }
  }
}
