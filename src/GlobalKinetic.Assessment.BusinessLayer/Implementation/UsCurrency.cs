using GlobalKinetic.Assessment.BusinessLayer.Interfaces;

namespace GlobalKinetic.Assessment.BusinessLayer.Implementation
{
  public class UsCurrency : ICurrency
  {
    public decimal UnitPrice { get; set; }
    public UsCurrency(decimal unitPrice)
    {
      UnitPrice = unitPrice;
    }
  }
}
