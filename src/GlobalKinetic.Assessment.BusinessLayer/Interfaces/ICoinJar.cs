using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.BusinessLayer.Interfaces
{
  public interface ICoinJar
  {
    void AddCoin(ICoin coin);
    decimal GetTotalAmount();
    void Reset();
  }
}
