using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.BusinessLayer.Implementation
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
