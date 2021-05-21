using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalKinetic.Assessment.DataAccessLayer.Models
{
  public class CoinModel
  {
    public int ID { get; set; }
    public int CoinType { get; set; }
    public decimal Amount { get; set; }
    public decimal Volume { get; set; }
  }
}
