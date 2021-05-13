using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Question1.Common.Interfaces
{
  public interface ICoinJar
  {
    void AddCoin(ICoin coin);
    decimal GetTotalAmount();
    void Reset();
  }
}
