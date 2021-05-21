using System;
using System.Collections.Generic;
using System.Text;
using GlobalKinetic.Assessment.BusinessLayer.Exceptions;
using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.BusinessLayer.Implementation
{
  /// <summary>
  /// US Coin jar which implemented Coin Jar.
  /// </summary>
  public class Coin : ICoin
  {

    public readonly Enums.CoinType CoinType;
    public decimal Amount { get; set; }
    public decimal Volume { get; set; }

    public Coin(Enums.CoinType coinType, decimal amount, decimal volume)
    {
      CoinType = coinType;
      Amount = amount;
      Volume = volume;
    }
  }
}