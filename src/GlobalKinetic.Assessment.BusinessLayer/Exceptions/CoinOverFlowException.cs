using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Assessment.BusinessLayer.Exceptions
{
  /// <summary>
  /// Class of Coin OverFlow Exception that inherits from Exception
  /// </summary>
  public class CoinOverFlowException : Exception
  {
    public CoinOverFlowException()
      : base("An error has occurred")
    {
    }
  }
}
