using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Assessment.BusinessLayer
{
  /// <summary>
  ///   <para>The Coin Class</para>
  /// </summary>
  public class Coins
  {
    public readonly CoinType CoinType;
    public int Amount { get; set; } = 0;

    public Coins(CoinType coinType)
    {
      CoinType = coinType;
    }
  }
}
