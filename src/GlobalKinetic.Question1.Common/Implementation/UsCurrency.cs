using GlobalKinetic.Question1.Common.Interfaces;

namespace GlobalKinetic.Question1.Common.Implementation
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
