using System;
using System.Collections.Generic;
using System.Text;
using GlobalKinetic.Question1.Common.Interfaces;

namespace GlobalKinetic.Question1.Common.Implementation
{
  public class FluidOunces : IVolume
  {
    public double Unit { get; private set; }
    public FluidOunces(double unit)
    {
      Unit = unit;
    }
  }
}
