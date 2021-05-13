using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Question1.Common.Interfaces
{
  public interface ICoin
  {
    decimal Amount { get; set; }
    decimal Volume { get; set; }
  }
}
